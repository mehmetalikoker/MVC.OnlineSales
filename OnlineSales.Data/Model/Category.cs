using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSales.Data.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="{0} boş geçilmemelidir")]
        [DisplayName("Kategori Adı")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
