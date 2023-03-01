namespace WebApi.ViewModels.CategoriesViewModels
{
    public class CategoriesOutput
    {
        public CategoriesOutput(int id, string title) 
        {
            this.Id = id;
            this.Title  = title;
   
        }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}