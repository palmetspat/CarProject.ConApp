using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    public interface IDice
    {
        public int Dots { get; }
        public void Roll();
    }
}
