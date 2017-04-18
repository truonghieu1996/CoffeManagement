using System.Data;

namespace DTO
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }

        public Food(string name, int categoryID, int price)
        {
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(int id, string name, int categoryID, int price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.CategoryID = (int)row["CategoryID"];
            this.Price = (int)row["Price"];
        }
    }
}