using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAccessModifiresTask
{
    class Milk  : Product
    {
        public double Volume;
        public double FatRate;
        public Milk(string name,double price,int count,double volume,double fatrate): base(name,price,count)
        {
            Volume = volume;
            FatRate = fatrate;
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"{Name} mehsulunun qiymeti {Price}-dir.stokda {Count}eded var. satilmasindan elde olunan gelir {TotalIncome} . Hecmi-{Volume} ve yagliliq derecesi {FatRate}% dir");
        }
    }
}
