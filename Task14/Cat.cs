﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Cat : Animal
    {
        public string name;
        public override string Name
        {
            get => name;
            set => name=value;
        }
        public Cat(string name)
            :base(name)
        {
           
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
