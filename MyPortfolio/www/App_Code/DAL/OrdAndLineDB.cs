using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrdAndLineDB
/// </summary>
public class OrdAndLineDB : BaseDB
{
	public OrdAndLineDB()
	{
		
	}

    public void SaveOrdAndOrdL(ordAndLine ordAndOrdL)
    {
     

            dataContext.ordAndLines.InsertOnSubmit(ordAndOrdL);
            dataContext.SubmitChanges();
        
    }


    public List<ProductsWithQuant> GetOrderProducts(int orderId)
    {
        List<ProductsWithQuant> products = new List<ProductsWithQuant>();

        //var q = dataContext.ExecuteQuery<product>("SELECT product.name, product.id FROM product JOIN orderLine ON orderLine.prodId = product.id JOIN ordAndLine ON ordAndLine.orderLineId = orderLine.id JOIN orders ON ordAndLine.orderId = orders.id WHERE orderId=" + orderId);
        
        //var q1 = from c in dataContext.products join p in dataContext.orderLines on c.id equals p.prodId join l in dataContext.ordAndLines on p.id equals l.orderLineId join o in dataContext.orders on l.orderId where dataContext.orders equals orderId;
        //var query = dataContext.ExecuteQuery<ProductsWithQuant>("SELECT product.name, product.id, product.fat, product.protein, product.carbs, product.totalCalories, orderLine.quantity FROM product JOIN orderLine ON orderLine.prodId = product.id JOIN ordAndLine ON ordAndLine.orderLineId = orderLine.id JOIN orders ON ordAndLine.orderId = orders.id WHERE orderId=" + orderId);
        var query2 = from p in dataContext.products
                     join ol in dataContext.orderLines on p.id equals ol.prodId
                     join oal in dataContext.ordAndLines on ol.id equals oal.orderLineId
                     join or in dataContext.orders on oal.orderId equals orderId where or.id == orderId
                     select new { p.name, p.id, p.fat, p.protein, p.carbs, p.totalCalories, ol.quantity };

        foreach (var obj in query2)
        {
            
            ProductsWithQuant pwq1 = new ProductsWithQuant();
            pwq1.name = obj.name;
            pwq1.id = obj.id;
            pwq1.fat = Convert.ToDecimal(obj.fat);
            pwq1.protein = Convert.ToDecimal(obj.protein);
            pwq1.carbs = Convert.ToDecimal(obj.carbs);
            pwq1.totalCalories = Convert.ToDecimal(obj.totalCalories);
            pwq1.quantity = Convert.ToInt32(obj.quantity);
            products.Add(pwq1);
        }

        

        return products;


    }

   
    
}