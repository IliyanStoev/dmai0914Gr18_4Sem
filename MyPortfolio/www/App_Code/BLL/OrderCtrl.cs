using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class OrderCtrl
{
   
    
    protected OrderDB ordDB = null;
	public OrderCtrl()
	{

        ordDB = new OrderDB(); 
	}

    public int createOrder(int id, DateTime date, double total, int userId, string address, double totalCals)
    {
        order order = new order();

        order.id = id;
        order.orderDate = date;
        order.total = Convert.ToDecimal(total);
        order.userId = userId;
        order._address = address;
        order.totalCals = Convert.ToDecimal(totalCals);
        order.ordStatus = false;
 
        return ordDB.saveOrder(order);

    }

    public order SaveOrder(order ord)
    {
        //ordDB = new OrderDB();
        return ordDB.createOrder(ord);
    }

    public int GetMaxOrderId()
    {
        //ordDB = new OrderDB();

        return ordDB.GetMaxOrderId();
    }

    public List<order> GetOrderByUserId(int userId)
    {
        return ordDB.getOrdersByUserId(userId);
    }

    public order GetOrderById(int ordrId)
    {
        return ordDB.GetOrderById(ordrId);
    }

  
}