using OnlineSales.Data.Data_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSales.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var onlineSalesContext = new OnlineSalesContext();

            var productList = onlineSalesContext.Product.ToList();
        }
    }
}
