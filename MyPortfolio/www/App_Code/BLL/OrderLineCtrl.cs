using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderLineCtrl
/// </summary>
public class OrderLineCtrl
{
    protected OrderLineDB ordLDb = null;
	public OrderLineCtrl()
	{
        ordLDb = new OrderLineDB();
	}

    public orderLine SaveOrderLine(orderLine ordLine)
    {

        //ordLDb = new OrderLineDB();
        return ordLDb.SaveOrderLine(ordLine);
    }

    

    public void SaveOrderLine2(orderLine ordLine)
    {

        
        ordLDb.SaveOrderLine2(ordLine);
    }

    public int GetMaxOrderLineId()
    {
       // ordLDb = new OrderLineDB();

        return ordLDb.GetMaxOrderLineId();
    }

    
}