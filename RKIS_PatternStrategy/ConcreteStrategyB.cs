using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_PatternStrategy
{
    public class ConcreteStrategyB : AbstractStrategy
    {
        public override void DoSomething()
        {
            Console.WriteLine("Алгоритм B");
        }
    }
}
