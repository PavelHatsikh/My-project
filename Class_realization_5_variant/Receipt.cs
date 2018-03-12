using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_realization_5_variant
{
    class Receipt
    {
        private string product_naming;
        private string cipher;
        private int count_of_receipts;


        public string Product_naming { get; set; }
        public string Cipher { get; set; }
        public int Count_of_receipts { get; set; }
        public Receipt()
        {
            Product_naming = null;
            Cipher = null;
            Count_of_receipts = 0;
        }

        public Receipt(string product_naming, string cipher, int count_of_receipts)
        {
            Product_naming = product_naming;
            Cipher = cipher;
            Count_of_receipts = count_of_receipts;
        }

        public virtual void Input()
        {
            Console.WriteLine("(- - - - - - - - - - Input description of class- - - -  - - - - -)");
            Console.WriteLine();
            Console.WriteLine("Название продукта: ");
            Product_naming = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Шифр продукта: ");
            Cipher = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Количество едениц изделия: ");
            Count_of_receipts = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("(- - - - - - - - - - - - - Output class - - - - - - - - - - -)");
            Console.WriteLine("Название продукта: " + Product_naming);
            Console.WriteLine();
            Console.WriteLine("Шифр продукта: " + Cipher);
            Console.WriteLine();
            Console.WriteLine("Количество едениц изделия: " + Count_of_receipts);
            Console.WriteLine();
        }
    }
}