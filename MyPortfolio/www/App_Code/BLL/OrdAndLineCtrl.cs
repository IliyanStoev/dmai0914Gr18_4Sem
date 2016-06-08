using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrdAndLineCtrl
/// </summary>
public class OrdAndLineCtrl
{
    protected OrdAndLineDB ordAndLineDb;
	public OrdAndLineCtrl()
	{
        ordAndLineDb = new OrdAndLineDB();
	}

    public void SaveOrderAndLine(ordAndLine ordAndLine)
    {

        //ordLDb = new OrderLineDB();
        ordAndLineDb.SaveOrdAndOrdL(ordAndLine);
    }

    public List<ProductsWithQuant> GetProductsByOrderId(int orderId)
    {
        return ordAndLineDb.GetOrderProducts(orderId);
    }
}