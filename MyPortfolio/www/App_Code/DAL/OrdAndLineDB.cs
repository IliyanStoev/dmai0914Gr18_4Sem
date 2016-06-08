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
        var query = dataContext.ExecuteQuery<ProductsWithQuant>("SELECT product.name, product.id, product.fat, product.protein, product.carbs, product.totalCalories, orderLine.quantity FROM product JOIN orderLine ON orderLine.prodId = product.id JOIN ordAndLine ON ordAndLine.orderLineId = orderLine.id JOIN orders ON ordAndLine.orderId = orders.id WHERE orderId=" + orderId);


        foreach (ProductsWithQuant pwq in query)


        {
            
            products.Add(pwq);
        }

        return products;


    }

   
    
}