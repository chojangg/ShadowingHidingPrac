using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowingHidingPrac
{
    internal static class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void Method2()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
            public override void Method2()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        public static int number = 10;
        static void Main(String[] args)
        {
            int number = 20;
            Console.WriteLine(number);
            Child child = new Child();
            Console.WriteLine(child.variable);
            Parent p = child;
            Console.WriteLine(p.variable);

            child.Method();
            p.Method();

            child.Method2();
            p.Method2();
        }
    }
}
