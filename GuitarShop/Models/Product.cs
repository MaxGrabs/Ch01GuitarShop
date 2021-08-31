namespace GuitarShop.Models
{
    //its the product class getters and setters.
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //replaces any space in the url with a - 
        public string Slug => Name.Replace(' ', '-');
    }
}