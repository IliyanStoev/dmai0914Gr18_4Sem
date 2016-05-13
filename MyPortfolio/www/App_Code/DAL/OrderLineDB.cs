using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



public class OrderLineDB : BaseDB
{
   
	public OrderLineDB()
	{
		
	}

    public orderLine SaveOrderLine(orderLine ordL)
    {
        

            dataContext.orderLines.InsertOnSubmit(ordL);
            

            return dataContext.orderLines.Where(x => x.id == ordL.id).FirstOrDefault();
        
    }

   

    public void SaveOrderLine2(orderLine ordL)
    {
        
            

            dataContext.orderLines.InsertOnSubmit(ordL);

            dataContext.SubmitChanges();
        
    }

    public int GetMaxOrderLineId()
    {
             List<orderLine> list = new List<orderLine>();

            list = dataContext.orderLines.ToList();



            if (list.Count == 0)
            {

                return 0;
            }
            else
            {
                return dataContext.orderLines.Max(x => x.id);
            }
        
        
    }


   
   
}