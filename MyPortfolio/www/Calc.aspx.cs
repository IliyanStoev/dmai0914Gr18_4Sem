using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calc : System.Web.UI.Page
{
    private SecurityHelper sch = new SecurityHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblgain1.Visible = false;
        lblgain2.Visible = false;
        lbllose1.Visible = false;
        lbllose2.Visible = false;

        Master.PageID = "Calculators";

        sch.CheckSecurity();
        if (sch.IsLoggedIn)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        
    }
    protected void btnCalculateClick(object sender, EventArgs e)
    {
        

        int bmrW = Convert.ToInt32(BMRweight.Value)*10;
        double bmrH = Convert.ToInt32(BMRheight.Value)*6.25;
        int bmrA = Convert.ToInt32(BMRage.Value)*5;

        if (BMRradioM.Checked)
        {
            double bmrM = (bmrW + bmrH - bmrA) + 5;

            BMR.Value = Convert.ToString(bmrM);

          //  ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + bmrM + "');", true);
                
        }
        else if(BMRradioF.Checked) 
        {
            double bmrF = (bmrW + bmrH - bmrA) - 161;

            BMR.Value = Convert.ToString(bmrF);

           // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + bmrF + "');", true);
        }

    }


    protected void btnCalculateDailyClick(object sender, EventArgs e)
    {
        double bmr = Convert.ToDouble(BMR.Value);

        if (little.Selected)
        {
            dailyCals.Value = Convert.ToString(bmr * 1.2);
        }
        if (light.Selected)
        {
            dailyCals.Value = Convert.ToString(bmr * 1.375);
        }
        if (moderate.Selected)
        {
            dailyCals.Value = Convert.ToString(bmr * 1.55);
        }
        if (hard.Selected)
        {
            dailyCals.Value = Convert.ToString(bmr * 1.725);
        }
        if (veryHard.Selected)
        {
            dailyCals.Value = Convert.ToString(bmr * 1.9);
        }

        fillCal();
    }

    private void fillCal()
    {
        double divGain1d = Convert.ToDouble(dailyCals.Value) + 500;
        int divGain1i = Convert.ToInt32(Math.Round((divGain1d/100), MidpointRounding.AwayFromZero));

        
        gain1.Text = divGain1d.ToString();

        divGain1.Style["width"] = divGain1i.ToString() + "%";

        double divGain2d = Convert.ToDouble(dailyCals.Value) + 1000;
        int divGain2i = Convert.ToInt32(Math.Round((divGain2d / 100), MidpointRounding.AwayFromZero));

        gain2.Text = divGain2d.ToString();

        divGain2.Style["width"] = divGain2i.ToString() + "%";

        
        double divLose1d = Convert.ToDouble(dailyCals.Value) - 500;
        int divLose1i = Convert.ToInt32(Math.Round((divLose1d / 100), MidpointRounding.AwayFromZero));

        lose1.Text = divLose1d.ToString();

        divLose1.Style["width"] = divLose1i.ToString() + "%";

        double divLose2d = Convert.ToDouble(dailyCals.Value) - 1000;
        int divLose2i = Convert.ToInt32(Math.Round((divLose2d / 100), MidpointRounding.AwayFromZero));

        lose2.Text = divLose2d.ToString();

        divLose2.Style["width"] = divLose2i.ToString() + "%";


        lblgain1.Visible = true;
        lblgain2.Visible = true;
        lbllose1.Visible = true;
        lbllose2.Visible = true;

       
    }

   
}