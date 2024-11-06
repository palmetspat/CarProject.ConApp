using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    internal class DefaultDice : IDice
    {
        private Random _random = new Random();
        public int Dots { get; private set; }

        public void Roll()
        {

            Dots = _random.Next(1, 7);
        }
    }
}
