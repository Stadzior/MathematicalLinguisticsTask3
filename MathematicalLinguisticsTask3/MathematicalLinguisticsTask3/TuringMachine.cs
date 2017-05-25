using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalLinguisticsTask3
{
    public class TuringMachine : NotifyPropertyChangedBase
    {
        private Tape _tape;
        public Tape Tape
        {
            get { return _tape; }
            set
            {
                SetField(ref _tape, value);
            }
        }

    }
}
