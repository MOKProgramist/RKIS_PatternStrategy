using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_PatternStrategy
{
    public class ConcreteStrategyA : AbstractStrategy
    {
        public override void DoSomething()
        {
            Console.WriteLine("Алгоритм A");
        }
    }
}
