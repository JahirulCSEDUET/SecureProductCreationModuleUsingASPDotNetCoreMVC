using System.ComponentModel.DataAnnotations;

namespace SecureProductCreationModuleUsingASPDotNetCoreMVC.Domain.Entities
{
    public class Product
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength =3,ErrorMessage = "Product Name must be between 3 and 50 character!")]
        [Display(Name="Product Name")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Description must be upto 50 character!")]
        public string Description { get; set; }

        [Range(1, double.MaxValue, ErrorMessage ="Price must be greater than zero!")]
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; } 
    }
}
