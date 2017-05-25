using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalLinguisticsTask3
{
    public class Position : NotifyPropertyChangedBase
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                SetField(ref _value, value);
            }
        }
    }
}
