using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

public class BaseDB : DbContext
{
    protected UserDBDataContext dataContext = null;
    
	public BaseDB()
	{
      
            dataContext = new UserDBDataContext();
        
     
       
        
        
	}

    

  

    
}