namespace WebApi.Models;

    public class Categories
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public IList<Products>? Products { get; set; }

    }
