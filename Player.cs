using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pac_man
{
    enum Directions { UP, DOWN, LEFT, RIGHT }
    internal class Player
    {
        public Directions CurrentDirection { get; set; }
    }
}
