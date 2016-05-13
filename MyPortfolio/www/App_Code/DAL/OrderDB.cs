using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDB
/// </summary>
public class OrderDB : BaseDB
{
	public OrderDB()
	{
		
	}

    public int saveOrder(order order)
    {
      
            dataContext.orders.InsertOnSubmit(order);
            int rows = dataContext.GetChangeSet().Inserts.Count;
            dataContext.SubmitChanges();

            return rows;
        
    }


    public order createOrder(order order)
    {
      
            dataContext.orders.InsertOnSubmit(order);
            dataContext.SubmitChanges();

            return dataContext.orders.Where(x => x.id == order.id).FirstOrDefault();
        
    }

    public int GetMaxOrderId()
    {
      

            //int i = dataContext.orders.Max(x => x.id);
            List<order> list = new List<order>();

            list = dataContext.orders.ToList();



            if (list.Count == 0)
            {

                return 0;
            }
            else
            {
                return dataContext.orders.Max(x => x.id);
            }
        
        //return i;
    }

    public List<order> getOrdersByUserId(int userId)
    {
       
            return dataContext.orders.Where(x => x.userId == userId).ToList();
        
        
    }

    public order GetOrderById(int orderId)
    {
        return dataContext.orders.Where(x => x.id == orderId).FirstOrDefault();
    }

    
}