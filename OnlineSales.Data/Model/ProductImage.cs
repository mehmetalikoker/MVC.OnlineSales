using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSales.Data.Model
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }

        [Required]
        public string ImageName { get; set; }

        [Required]
        public string ContentType { get; set; }

        [Required]
        public byte[] Content { get; set; }

        public virtual Product Product { get; set; }
    }
}
