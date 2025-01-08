using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern;

// interface that just includes a Quack() method that needs to be implemented
public interface IQuackBehavior {
    public void Quack();
}
