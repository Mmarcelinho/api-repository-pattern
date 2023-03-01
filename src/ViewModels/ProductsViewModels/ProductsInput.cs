namespace WebApi.ViewModels.ProductsViewModels;

    public class ProductsInput
    {   
        [Key]
         public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio")]
        [MinLength(5, ErrorMessage = "No minimo 5 caracteres")]
        public string Title { get;  set; }

        [Required(ErrorMessage = "Campo obrigátorio")]
        [Range(0, double.MaxValue,ErrorMessage = "Só permitido valores maiores que 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Campo obrigátorio")]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "Campo obrigátorio")]
        public int UserId { get; set; }

        
    }
