namespace LugXGaming.Models
{
    public class Gamecu:Base
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public double Price { get; set; }
        public double Discounnt { get; set; }
        public string Imageurl { get; set; }

        public Gamecu(string title, string summary, double price, double discounnt,string imageurl)
        {   
            Title = title;
            Summary = summary;
            Price = price;
            Discounnt = discounnt;
            Imageurl = imageurl;
        }
    }


}
