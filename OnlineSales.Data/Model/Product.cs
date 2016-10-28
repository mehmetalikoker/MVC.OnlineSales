using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSales.Data.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }


        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }


    }
}
