using Lesson9_train.Class_lesson9;
using System;

namespace Lesson9_train
{
    class Program
    {
        static void Main(string[] args)
        {
            Preke Product = new Preke("Product1", 12.45, 5);
            Product.AddNewProduct();
            Product.ChangeProductPrice();

        }
    }
}
