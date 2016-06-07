using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class ResCtrl
{
    protected RestaurantDB resDb = null;
	public ResCtrl()
	{
        resDb = new RestaurantDB();
	}

    public List<restaurant> GetAllRes()
    {
        return resDb.GetAllRes();
    }

    public List<product> GetProductByResId(int restId, string fGrId)
    {
        return resDb.GetProductByResId(restId, fGrId);
    }

    public product GetProductByProdId(int productId)
    {
        return resDb.GetProductByProdId(productId);
    }

    public product GetMostOrdProd()
    {
        return resDb.GetMostOrdProd();
    }
    public void UpdateProduct(product prod)
    {
        
       // prod.ordered = ordered;

        resDb.UpdateProduct(prod);


    }

    public void UpdateProduct2(int prodId, int quantity)
    {
         resDb.UpdateProduct2(prodId, quantity);
    }

    public bool CheckStock(int prodId, int quantity)
    {
        return resDb.CheckStock(prodId, quantity);
    }


}