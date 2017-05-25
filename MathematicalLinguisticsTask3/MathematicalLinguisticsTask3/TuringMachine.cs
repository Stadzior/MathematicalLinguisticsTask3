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
        public ObservableCollection<State> States { get; set; }
        private State _currentState;
        public State CurrentState
        {
            get { return _currentState; }
            set
            {
                SetField(ref _currentState, value);
            }
        }

        private int _headPosition = 10; //Max position
        public int HeadPosition
        {
            get { return _headPosition; }
            set
            {
                SetField(ref _headPosition, value);
            }
        }

        public int CurrentPositionValue
        {
            get
            {
                switch (_headPosition)
                {
                    case 1:
                        return Tapes[0].Position1;
                    case 2:
                        return Tapes[0].Position2;
                    case 3:
                        return Tapes[0].Position3;
                    case 4:
                        return Tapes[0].Position4;
                    case 5:
                        return Tapes[0].Position5;
                    case 6:
                        return Tapes[0].Position6;
                    case 7:
                        return Tapes[0].Position7;
                    case 8:
                        return Tapes[0].Position8;
                    case 9:
                        return Tapes[0].Position9;
                    case 10:
                        return Tapes[0].Position10;
                    default:
                        return -1;
                }
            }

            set
            {
                switch (_headPosition)
                {
                    case 1:
                        Tapes[0].Position1 = value;
                        break;
                    case 2:
                        Tapes[0].Position2 = value;
                        break;
                    case 3:
                        Tapes[0].Position3 = value;
                        break;
                    case 4:
                        Tapes[0].Position4 = value;
                        break;
                    case 5:
                        Tapes[0].Position5 = value;
                        break;
                    case 6:
                        Tapes[0].Position6 = value;
                        break;
                    case 7:
                        Tapes[0].Position7 = value;
                        break;
                    case 8:
                        Tapes[0].Position8 = value;
                        break;
                    case 9:
                        Tapes[0].Position9 = value;
                        break;
                    case 10:
                        Tapes[0].Position10 = value;
                        break;
                }
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

            States = new ObservableCollection<State>()
            {
                new State() { Name = "Q0"},
                new State() { Name = "Q1"},
                new State() { Name = "Q2"},
                new State() { Name = "Q3"}
            };

            InitializeStatesNextSteps();
        }

        private void InitializeStatesNextSteps()
        {
            var q0 = States.Single(s => s.Name.Equals("Q0"));
            var q1 = States.Single(s => s.Name.Equals("Q1"));
            var q2 = States.Single(s => s.Name.Equals("Q2"));
            var q3 = States.Single(s => s.Name.Equals("Q3"));

            q0.StepInfoForOne = new StepInfo()
            {
                Direction = Direction.Left,
                State = q1,
                ValueToSave = 0
            };
            q0.StepInfoForZero = new StepInfo()
            {
                Direction = Direction.Left,
                State = q2,
                ValueToSave = 1
            };

            q1.StepInfoForOne = new StepInfo()
            {
                Direction = Direction.Left,
                State = q2,
                ValueToSave = 1
            };
            q1.StepInfoForZero = new StepInfo()
            {
                Direction = Direction.Left,
                State = q2,
                ValueToSave = 0
            };

            q2.StepInfoForOne = new StepInfo()
            {
                Direction = Direction.Left,
                State = q2,
                ValueToSave = 0
            };
            q2.StepInfoForZero = new StepInfo()
            {
                Direction = Direction.Left,
                State = q3,
                ValueToSave = 1
            };

            q3.StepInfoForOne = new StepInfo()
            {
                Direction = Direction.Left,
                State = q3,
                ValueToSave = 1
            };
            q3.StepInfoForZero = new StepInfo()
            {
                Direction = Direction.Left,
                State = q3,
                ValueToSave = 0
            };
        }

        public void MoveHead(StepInfo stepInfo)
        {
            if (stepInfo.Direction == Direction.Left)
                _headPosition--;
            else
                _headPosition++;

            CurrentState = stepInfo.State;
        }
    }
}
