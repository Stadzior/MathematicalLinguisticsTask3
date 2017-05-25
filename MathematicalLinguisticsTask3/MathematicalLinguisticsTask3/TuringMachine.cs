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
        public ObservableCollection<Tape> Tapes { get; set; }

        private State _currentState;
        public State CurrentState
        {
            get { return _currentState; }
            set
            {
                SetField(ref _currentState, value);
            }
        }

        public TuringMachine()
        {
            Tapes = new ObservableCollection<Tape>()
            {
                new Tape()
                {
                    Position1 = 0,
                    Position2 = 0,
                    Position3 = 0,
                    Position4 = 0,
                    Position5 = 0,
                    Position6 = 0,
                    Position7 = 0,
                    Position8 = 0,
                    Position9 = 0,
                    Position10 = 0
                }
            };


        }

        public void MoveHead(StepInfo stepInfo)
    }
}
