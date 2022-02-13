using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAccessModifiresTask
{
    class Product
    {
        private string _name;
        public double Price;
        public int Count;
        public double TotalIncome=0;

        public Product(string name)
        {
            Name = name;
        }
        public Product(string name, double price, int count) : this(name)
        {
            _name = name;
            Price = price;
            Count = count;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                while(true)
                {
                    if (value.Length == 0)
                    {
                        Console.WriteLine("Mehsul daxil edin: ");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _name = value;
                        break;
                    }
                }
            }
        }
        public void Sell()
        {
            if (Count > 0)
            {
                TotalIncome +=Price;
                Count--;
                Console.WriteLine($"{Name} mehsulundan bir eded satildi.");
            }
            else
            {
                Console.WriteLine($"sizin stokda {Name} mehsulundan yoxdur");
            }
        }
        public string Info()
        {
            return $"{Name} mehsulunun qiymeti {Price} qederdir. stokda {Count } Eded var. satilmasindan elde olunan gelir {TotalIncome}-dir";
        }
    }
}
