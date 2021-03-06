﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSales.Data.Model
{
    public class ProductFeature
    {
        [Key]
        public int ProductFeatureId { get; set; }

        [DisplayName("Özellik Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        public string FeatureName { get; set; }

        [Required]
        public string FeatureValue { get; set; }

        [Required]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
