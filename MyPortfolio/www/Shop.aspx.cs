using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Shop : System.Web.UI.Page
{
    private SecurityHelper sch = new SecurityHelper();
    private List<String> resList = new List<string>();
    private List<product> prodList = new List<product>();
    private List<orderLine> ordLines;
    private order ord;
    private List<ordAndLine> ordAndLines;
    //private List<product> newProdList;

    private List<double> doubles = new List<double>();
    private double realDouble;
    protected void Page_Load(object sender, EventArgs e)
    {


        Master.PageID = "Shop";


        sch.CheckSecurity();

        if (sch.IsLoggedIn)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {


            ordLines = new List<orderLine>();

            Session["myList"] = ordLines;

            ordAndLines = new List<ordAndLine>();
            Session["myList2"] = ordAndLines;


            fillDrop();
            createOrderBtn.Enabled = false;


        }
        else
        {


            ordLines = (List<orderLine>)Session["myList"];
            ord = (order)Session["order"];
            ordAndLines = (List<ordAndLine>)Session["myList2"];

            //foodGroupDd.Enabled = true;
            if (ordLines.Count != 0)
            {
                createOrderBtn.Enabled = true;
            }


            //newProdList = (List<product>)Session["myList2"];
        }

    }










    private void fillDrop()
    {


        ResCtrl resCtrl = new ResCtrl();
        foreach (restaurant res in resCtrl.GetAllRes())
        {

            resList.Add(res.id + "." + res.name);
        }
        resDrop.DataSource = resList;
        resDrop.DataBind();

    }

    /* private void fillDropProd()
     {
     
         int restaurantId = Convert.ToInt32(resDrop.SelectedValue.Substring(0,1));
     
         ResCtrl resCtrl = new ResCtrl();
         foreach (product prod in resCtrl.GetProductByResId(restaurantId))
         {
             prodList.Add(prod.content);
         }
        
       
         prodDrop.DataSource = prodList;
         prodDrop.DataBind();
        


        
     }
     */
    protected void resDrop_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (resDrop.SelectedValue == "Please Select Restaurant")
        {
            foodGroupDd.Enabled = false;
            GridView1.DataSource = null;
            GridView1.DataBind();
        }
        else
        {
            foodGroupDd.Enabled = true;
            int restaurantId = Convert.ToInt32(resDrop.SelectedValue.Substring(0, 1));
            string selectedG = foodGroupDd.SelectedItem.Value;

            ResCtrl resCtrl = new ResCtrl();

            foreach (product prod in resCtrl.GetProductByResId(restaurantId, selectedG))
            {
                prodList.Add(prod);
            }

            GridView1.Columns[0].Visible = true;
            GridView1.DataSource = prodList;

            GridView1.DataBind();
            GridView1.Columns[0].Visible = false;

        }
    }



    protected void foodGroupDd_SelectedIndexChanged(object sender, EventArgs e)
    {


        int restaurantId = Convert.ToInt32(resDrop.SelectedValue.Substring(0, 1));
        string selectedG = foodGroupDd.SelectedItem.Value;

        ResCtrl resCtrl = new ResCtrl();

        foreach (product prod in resCtrl.GetProductByResId(restaurantId, selectedG))
        {
            prodList.Add(prod);
        }

        GridView1.Columns[0].Visible = true;
        GridView1.DataSource = prodList;

        GridView1.DataBind();
        GridView1.Columns[0].Visible = false;
    }






    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Add To Cart")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int userId = Convert.ToInt32(HttpContext.Current.Session["id"]);

            int productId = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

            DropDownList quantDd = (DropDownList)GridView1.Rows[index].FindControl("quantDd");

            int selectedQuantity = Convert.ToInt32(quantDd.SelectedItem.Value); 
           
            
            ResCtrl resCtrl = new ResCtrl();

            OrderLineCtrl ordLctrl = new OrderLineCtrl();


            OrderCtrl ordCtrl = new OrderCtrl();

            if (ord == null)
            {
                ord = new order();

                ord.id = ordCtrl.GetMaxOrderId() + 1;

                Session["order"] = ord;

                orderLine ordL = new orderLine();

                if (ordLines.Count == 0)
                {
                    ordL.id = ordLctrl.GetMaxOrderLineId() + 1;
                    ordL.prodId = productId;
                    
                    ordL.quantity = selectedQuantity;
                    
                    ordLines.Add(ordL);
                }

                else
                {
                    int oldId = ordLines.Max(obj => obj.id);
                    ordL.prodId = productId;
                    ordL.id = oldId + 1;
                    ordL.quantity = selectedQuantity;
                    ordLines.Add(ordL);
                }



            }
            else
            {
                ord = (order)Session["order"];

                orderLine ordL = new orderLine();

                if (ordLines.Count == 0)
                {
                    ordL.id = ordLctrl.GetMaxOrderLineId() + 1;
                    ordL.prodId = productId;
                    ordL.quantity = selectedQuantity;
                    ordLines.Add(ordL);
                }

                else
                {
                    int oldId = ordLines.Max(obj => obj.id);
                    ordL.prodId = productId;
                    ordL.quantity = selectedQuantity;
                    ordL.id = oldId + 1;


                    ordLines.Add(ordL);
                }


            }



            

            GridView2.DataSource = ordLines;

            GridView2.DataBind();


            foreach (GridViewRow gvR in GridView2.Rows)
            {
                int prodId = Convert.ToInt32(GridView2.DataKeys[gvR.RowIndex].Values[1]);
                
                product prod = resCtrl.GetProductByProdId(prodId);

                gvR.Cells[2].Text = prod.name;

                decimal protein = Convert.ToInt32(gvR.Cells[8].Text) * Convert.ToDecimal(prod.protein);

                gvR.Cells[3].Text = protein.ToString();

                decimal carbs = Convert.ToInt32(gvR.Cells[8].Text) * Convert.ToDecimal(prod.carbs);

                gvR.Cells[4].Text = carbs.ToString();

                decimal fat = Convert.ToInt32(gvR.Cells[8].Text) * Convert.ToDecimal(prod.fat);

                gvR.Cells[5].Text = fat.ToString();

                decimal totalCalories = Convert.ToInt32(gvR.Cells[8].Text) * Convert.ToDecimal(prod.totalCalories);

                gvR.Cells[6].Text = totalCalories.ToString();

                decimal sum = Convert.ToInt32(gvR.Cells[8].Text) * Convert.ToDecimal(prod.price);

                gvR.Cells[7].Text = sum.ToString();
                
            }
            

            GridView2CalculateFooter();

            resDrop.Enabled = false;
            createOrderBtn.Enabled = true;



        }
    }



    protected void createOrderBtn_Click(object sender, EventArgs e)
    {
        List<product> productsWoS = new List<product>();
        //bool isInStock = false;
        product productWs = null;

        OrderCtrl ordCtrl = new OrderCtrl();
        ResCtrl resCtrl = new ResCtrl();
        int id = Convert.ToInt32(HttpContext.Current.Session["id"]);
        string adr = ordAddress.Value;
        realDouble = Convert.ToDouble(GridView2.FooterRow.Cells[7].Text);
        double totalCals = Convert.ToDouble(GridView2.FooterRow.Cells[6].Text);

        

        foreach (orderLine ordL in ordLines)
        {

            productWs = resCtrl.CheckStock(Convert.ToInt32(ordL.prodId), Convert.ToInt32(ordL.quantity));

            //if (resCtrl.CheckStock(Convert.ToInt32(ordL.prodId), Convert.ToInt32(ordL.quantity)) == null)
            if(productWs == null)
            {
                //isInStock = true;
            }
            else 

            {
                //isInStock = false;
                productsWoS.Add(productWs);
                //break;
            }

            
        }
        if (productsWoS.Count == 0)
        {
            int rows = ordCtrl.createOrder(ord.id, DateTime.Now, realDouble, id, adr, totalCals);
        
        

        foreach (orderLine ordL in ordLines)
        {

           
            ordAndLine ordAndLineObject = new ordAndLine();

            ordAndLineObject.orderLineId = ordL.id;
            ordAndLineObject.orderId = ord.id;

            OrderLineCtrl ordLineCtrl = new OrderLineCtrl();
            OrdAndLineCtrl ordAndLctrl = new OrdAndLineCtrl();

            ordLineCtrl.SaveOrderLine2(ordL);
            ordAndLctrl.SaveOrderAndLine(ordAndLineObject);

            resCtrl.UpdateProduct2(Convert.ToInt32(ordL.prodId), Convert.ToInt32(ordL.quantity));
            
                
               
          }

        if (rows > 0)
        {
            ordLines = null;
            ord = null;
            Session["order"] = null;
            
            GridView2.DataSource = ordLines;
            GridView2.DataBind();
            Response.Redirect("OrderSucess.aspx");
        }

        else
        {
            string msg = "Something went wrong, please try again";
            Response.Write("<script>alert('" + msg + "')</script>");
        }
     
            
        }

        else
        {
          
            foreach (product noStockProd in productsWoS)
            {
                int productId = noStockProd.id;

                foreach (GridViewRow gVr in GridView2.Rows)
                {
                    //int prodId = Convert.ToInt32(GridView2.DataKeys[gvR.RowIndex].Values[1]);
                    if (Convert.ToInt32(GridView2.DataKeys[gVr.RowIndex].Values[1]) == productId)
                    {
                        gVr.BackColor = System.Drawing.Color.FromArgb(255, 77, 77);
                      
                    }
                    else
                    {

                    }
                }
            }
            /*string message = "The Stock of the product" + productWs.name + "is not enough" + "/N2" + "Available Stock :" + productWs.stock + "";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);*/
        }
        
  

    }



    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
        ResCtrl resCtrl = new ResCtrl();

        if (e.CommandName == "Remove")
        {
            int index = Convert.ToInt32(e.CommandArgument);
           
           int orderLineId = Convert.ToInt32(GridView2.DataKeys[index].Values[0]);
           

            foreach (orderLine ordL in ordLines.ToList())
            {
                if (ordL.id == orderLineId)
                {
                    ordLines.Remove(ordL);
                }
            }
            GridView2.DataSource = ordLines;
            GridView2.DataBind();

            foreach (GridViewRow gvR in GridView2.Rows)
            {

                int prodId = Convert.ToInt32(GridView2.DataKeys[gvR.RowIndex].Values[1]);
                product prod = resCtrl.GetProductByProdId(prodId);
                gvR.Cells[2].Text = prod.name;
                gvR.Cells[3].Text = prod.protein.ToString();
                gvR.Cells[4].Text = prod.carbs.ToString();
                gvR.Cells[5].Text = prod.fat.ToString();
                gvR.Cells[6].Text = prod.totalCalories.ToString();
                gvR.Cells[7].Text = prod.price.ToString();
            }


            GridView2CalculateFooter();
           

            if (ordLines.Count == 0)
            {
                resDrop.Enabled = true;
                createOrderBtn.Enabled = false;
                ord = null;
            }


        }
    }

    private void GridView2CalculateFooter()
    {


        GridView2.FooterRow.Cells[2].Text = "Order Total : ";

        decimal totalPr = 0;
        decimal totalCarbs = 0;
        decimal totalFat = 0;
        decimal totalCalories = 0;
        decimal total = 0;
        foreach (GridViewRow gvR in GridView2.Rows)
        {
            totalPr += Convert.ToDecimal(gvR.Cells[3].Text);

            totalCarbs += Convert.ToDecimal(gvR.Cells[4].Text);

            totalFat += Convert.ToDecimal(gvR.Cells[5].Text);

            totalCalories += Convert.ToDecimal(gvR.Cells[6].Text);

            total += Convert.ToDecimal(gvR.Cells[7].Text);
        }
        GridView2.FooterRow.Cells[3].Text = totalPr.ToString("N2");


        GridView2.FooterRow.Cells[4].Text = totalCarbs.ToString("N2");


        GridView2.FooterRow.Cells[5].Text = totalFat.ToString("N2");


        GridView2.FooterRow.Cells[6].Text = totalCalories.ToString("N2");


        GridView2.FooterRow.Cells[7].Text = total.ToString("N2");

    }






    protected void ordAddressCheck_CheckedChanged(object sender, EventArgs e)
    {
        if (ordAddressCheck.Checked)
        {
            int userId = Convert.ToInt32(Session["id"]);
            UserCtrl userCtrl = new UserCtrl();
            ordAddress.Value = userCtrl.GetUserById(userId)._Address;

            ordAddress.Disabled = true;

        }
        else
        {
            ordAddress.Disabled = false;
            ordAddress.Value = "";
        }
    }


    
}