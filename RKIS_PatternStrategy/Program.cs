using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKIS_PatternStrategy
{
    // Strategy - это паттерн проектирования,
    // который позволяет вам определять семейство алгоритмов,
    // инкапсулировать каждый из них и сделать их взаимозаменяемыми.
    // Это позволяет вам изменять алгоритмы независимо от клиентов, которые их используют.
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStrategyA());
            context.DoSomething();

            // Вывод: Алгоритм A

            context = new Context(new ConcreteStrategyB());
            context.DoSomething();

            // Вывод: Алгоритм B

            Console.ReadLine();
        }
    }
}
