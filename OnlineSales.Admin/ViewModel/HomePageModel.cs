using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineSales.Admin.ViewModel
{
    /// <summary>
    /// View Model içinde sayfalara özgü class lar bulunacak. 
    /// Bu class içinde ana sayfaya özgü değişl-kenler bulunacak.
    /// </summary>
    public class HomePageModel
    {
        public int CategoryCount { get; set; }
        public int ProductCount { get; set; }
        public int ProductImageCount { get; set; }
        public int ProductFeatureCount { get; set; }
    }
}