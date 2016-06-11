using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Transactions;
using System.Web;

public class RestaurantDB : BaseDB
{
	public RestaurantDB()
	{
	}

    public List<restaurant> GetAllRes()
    {
      
            return dataContext.restaurants.ToList();
        
    }

    public List<product> GetProductByResId(int resId, string fGrId)
    {
        
            return dataContext.products.Where(x => x.resId == resId && x.fGroup == fGrId).ToList();
        
    }

    public product GetProductByProdId(int prodId)
    {
       

            return dataContext.products.Where(x => x.id == prodId).FirstOrDefault();
        
    }

    public product GetMostOrdProd()
    {
       
            return dataContext.products.OrderByDescending(x => x.ordered.Value).FirstOrDefault();
        
    }

    public void UpdateProduct(product prod)
    {
        
            dataContext.SubmitChanges();
        
    }


    public void UpdateProduct2(int prodId, int quantity)
    {
        TransactionOptions options = new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead };

        using (System.Transactions.TransactionScope trans = new System.Transactions.TransactionScope(TransactionScopeOption.Required, options))
        {
            product prod = GetProductByProdId(prodId);
            try
            {
               
                    int newStockValue = Convert.ToInt32(prod.stock - quantity);
                    int newOrderedValue = Convert.ToInt32(prod.ordered + quantity);

                    prod.stock = newStockValue;
                    prod.ordered = newOrderedValue;

                    dataContext.SubmitChanges();
                    trans.Complete();
                   
                
            }
            catch(Exception ex)
            {
                throw ex;
            }

          

            
        }
        
    }

    public product CheckStock(int prodId, int quantity)
    {

        TransactionOptions options = new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead };

        using (System.Transactions.TransactionScope trans2 = new System.Transactions.TransactionScope(TransactionScopeOption.Required, options))
        {
            product prod = GetProductByProdId(prodId);

            if (prod.stock >= quantity)
            {
                trans2.Complete();
                return null;
                
            }
            else
            {
                trans2.Complete();
                return prod;
            }
        }
    }

   
}