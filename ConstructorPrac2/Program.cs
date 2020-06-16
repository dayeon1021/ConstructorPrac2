using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPrac2
{
    class Program
    {
        class Parent{
            public Parent()
            {
                Console.WriteLine("부모 생성자 호출~!");
            }
        }
        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식 생성자 호출~~!");
            }
        }
        static void Main(string[] args)
        {
            Child c = new Child();
        }
    }
}
