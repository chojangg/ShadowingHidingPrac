﻿using System;
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
        }

        class Child : Parent
        {
            public string variable = "shadowing";
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
        }
    }
}
