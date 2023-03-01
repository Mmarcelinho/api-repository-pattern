namespace WebApi.ViewModels.CategoriesViewModels
{
    public class CategoriesInput
    {   
        [Key]
         public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio")]
        [MinLength(5, ErrorMessage = "No minimo 5 caracteres")]
        public string Title { get; set; }
    }
}