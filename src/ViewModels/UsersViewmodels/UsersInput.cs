namespace WebApi.ViewModels.UsersViewmodels;

    public class UsersInput
    {    
        [Key]
         public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "No minimo 5 caracteres")]
        public string Name { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "No minimo 5 caracteres")]
        public string Office { get; set; }

        
    }
