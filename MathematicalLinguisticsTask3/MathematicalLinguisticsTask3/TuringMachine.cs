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
        public Tape Tape { get; }
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

        public TuringMachine()
        {
            Tape = new Tape();
            Tapes = new ObservableCollection<Tape>() { Tape };

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
