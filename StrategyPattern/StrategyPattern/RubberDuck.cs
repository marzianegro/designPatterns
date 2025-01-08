﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

public class RubberDuck : Duck {
    public RubberDuck() { }

    public override void Display() {
        Console.WriteLine("I'm a rubber duck");
    }
}
