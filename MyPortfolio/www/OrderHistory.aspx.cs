using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderHistory : System.Web.UI.Page
{
    private List<order> orders;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        FillGrid();
    }


   
        
    

    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ViewDetails")
        {
            int rowId = Convert.ToInt32(e.CommandArgument);
            int ordId = Convert.ToInt32(GridView1.DataKeys[rowId].Values[0]);
            //int ordId = Convert.ToInt32(GridView1.Rows[rowId].Cells[0].Text);

            OrderCtrl ordCtrl = new OrderCtrl();
            order ordr = ordCtrl.GetOrderById(ordId);
            OrdAndLineCtrl ordAndLineCtrl = new OrdAndLineCtrl();
            List<product> products = new List<product>();

            products = ordAndLineCtrl.GetProductsByOrderId(ordId);

            GridView2.DataSource = products;
            GridView2.DataBind();

        }

    }

    private void FillGrid()
    {
        orders = new List<order>();

        OrderCtrl ordCtrl = new OrderCtrl();

        orders = ordCtrl.GetOrderByUserId(Convert.ToInt32(Session["id"]));

        GridView1.DataSource = orders;
        GridView1.DataBind();
    }
}