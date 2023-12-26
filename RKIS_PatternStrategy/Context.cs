using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_PatternStrategy
{
    public class Context
    {
        private AbstractStrategy _strategy;

        public Context(AbstractStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomething()
        {
            _strategy.DoSomething();
        }
    }
}
