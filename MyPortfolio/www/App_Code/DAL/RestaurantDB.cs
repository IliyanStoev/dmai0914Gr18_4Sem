using System;
using System.Collections.Generic;
using System.Linq;
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
}