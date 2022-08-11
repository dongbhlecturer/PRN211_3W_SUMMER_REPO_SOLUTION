using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP.OOP;
//POJO: la mot lop thuan khiet (khong ke thua, khong phu thuoc vao class khac)
public class Product
{
    /*1. fields/properties/attributes/data*/
    //fields (data)
    private int? productId;
    private string? productName;
    //properties (APIs)
    public double ListPrice { get; set; } = 0;
    public int? ProductId { 
        get { return productId; } 
        set { productId = value; }
    }
    public string ProductName { get => productName; set => productName = value; } //expression bodies
    public string? Desc { get; set; }
    //read-only auto properties
    public int CategoryID { get; }

    //2. constructor (ham khoi tao ra doi tuong)
    public Product()
    {
        CategoryID = 1;
    }
    public Product(int? productId, string? productName, double listPrice, string? desc,
        int categoryId)
    {
        this.productId = productId;
        this.productName = productName;
        CategoryID = categoryId;
        ListPrice = listPrice;
        Desc = desc;
    }

    public override string? ToString()
    {
        return DisplayInfo();
    }

    private string DisplayInfo()
    {
        return $"[Product ID: {this.productId}, Product Name: {ProductName}, " +
            $"List Price: {ListPrice}], Desc: {Desc}";
    }
    //manual methods
    public void IncreasePrice(int percent)
    {
        this.ListPrice += (this.ListPrice * percent) / 100;

    }
}
