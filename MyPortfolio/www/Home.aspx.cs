using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    private product mostOrdProd;
    private RestaurantDB resDb;
    protected void Page_Load(object sender, EventArgs e)
    {
        

        SecurityHelper sch = new SecurityHelper();
        sch.CheckSecurity();

        Master.PageID = "Home";
        fill();

       
        
    }


    public void fill()
    {
        resDb = new RestaurantDB();

        mostOrdProd = resDb.GetMostOrdProd();

        lblMostName.Text = mostOrdProd.name;
        lblMostOrd.Text = "Ordered :" + " " + mostOrdProd.ordered.ToString() + " " + "times";

        byte[] b = mostOrdProd.photo.ToArray();

        string strBase64 = Convert.ToBase64String(b);

        prodImage.ImageUrl = "data:Image/png;base64," + strBase64;

        lblRest.Text = "Offered by :" + " " + mostOrdProd.restaurant.name;
    }


    
}