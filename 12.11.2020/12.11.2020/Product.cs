using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2020
{
    class Product
    {
        private double _price;
        private int _count;
        private static  double _totalAmount;
        public string Name { get; set; }
        public double Price { get=>_price;}
        private static List<Sale> SaledProducts { get; set; } = new List<Sale>();
        public int Count { get=>_count; }
        public static  double TotalAmount { get=>_totalAmount;}
        public Product(string name,int count,double price)
        {
            this.Name = name;
            this._count = count;
            this._price = price;
        }

        public void AddCount(int count)
        {
            this._count += count;
        }
        public void SaleProduct(int count)
        {
            if (count>0 && count<this._count)
            {
                this._count -= count;
                _totalAmount += _count * _price;
                Sale sale = new Sale(this.Name, DateTime.Now);
                SaledProducts.Add(sale);
                Console.WriteLine($"Satish ugurla heyata kechdi.Qalan mehsul sayi:{this._count}");
            }
            else
            {
                Console.WriteLine("Sizin satmaq istediyiniz qeder mehsulumuz yoxdur.");
            }
            

        }
        public static void ShowSaledProduct()
        {
            foreach (Sale product in SaledProducts)
            {
                Console.WriteLine($"Satilmish malin adi:{product.Name}.Satish tarixi:{product.Date}");
            }
        }



    }
}
