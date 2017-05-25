using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalLinguisticsTask3
{
    public struct StepInfo
    {
        public Direction Direction { get; set; }
        public State State { get; set; }
        public int ValueToSave { get; set; }
    }
}
