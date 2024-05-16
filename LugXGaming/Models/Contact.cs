namespace LugXGaming.Models
{
    public class Contact
    {
        public string Title  { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public Contact(string title,string text,string description,string adress,string email)
        {
            Title = title;
            Text = text;
            Description = description;
            Adress = adress;
            Email = email;

        }
    }
}
