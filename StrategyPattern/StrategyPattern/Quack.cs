﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

public class RealQuack : IQuackBehavior {
    public void Quack() {
        // implements duck quacking
        Console.WriteLine("Quack");
    }
}
