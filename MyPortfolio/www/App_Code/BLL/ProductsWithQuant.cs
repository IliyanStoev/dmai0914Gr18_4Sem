using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductsWithQuant
/// </summary>
public class ProductsWithQuant
{
    public string name {get; set;}
    public int id { get; set; }
    public decimal fat { get; set; }
    public decimal protein { get; set; }
    public decimal carbs { get; set; }

    public decimal totalCalories { get; set; }
    public int quantity { get; set; }
	public ProductsWithQuant()
	{
		
	}
}