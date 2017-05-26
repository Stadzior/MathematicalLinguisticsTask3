using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalLinguisticsTask3
{
    public class Tape : NotifyPropertyChangedBase
    {
        public readonly int VisibleSize = 10;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return Position1;
                    case 2:
                        return Position2;
                    case 3:
                        return Position3;
                    case 4:
                        return Position4;
                    case 5:
                        return Position5;
                    case 6:
                        return Position6;
                    case 7:
                        return Position7;
                    case 8:
                        return Position8;
                    case 9:
                        return Position9;
                    case 10:
                        return Position10;
                    default:
                        return -1;
                }
            }

            set
            {
                switch (index)
                {
                    case 1:
                        Position1 = value;
                        break;
                    case 2:
                        Position2 = value;
                        break;
                    case 3:
                        Position3 = value;
                        break;
                    case 4:
                        Position4 = value;
                        break;
                    case 5:
                        Position5 = value;
                        break;
                    case 6:
                        Position6 = value;
                        break;
                    case 7:
                        Position7 = value;
                        break;
                    case 8:
                        Position8 = value;
                        break;
                    case 9:
                        Position9 = value;
                        break;
                    case 10:
                        Position10 = value;
                        break;
                    default:
                        break;
                }
            }
        }

        private int _position1;
        public int Position1
        {
            get { return _position1; }
            set
            {
                SetField(ref _position1, value);
            }
        }

        private int _position2;
        public int Position2
        {
            get { return _position2; }
            set
            {
                SetField(ref _position2, value);
            }
        }


        private int _position3;
        public int Position3
        {
            get { return _position3; }
            set
            {
                SetField(ref _position3, value);
            }
        }

        private int _position4;
        public int Position4
        {
            get { return _position4; }
            set
            {
                SetField(ref _position4, value);
            }
        }

        private int _position5;
        public int Position5
        {
            get { return _position5; }
            set
            {
                SetField(ref _position5, value);
            }
        }

        private int _position6;
        public int Position6
        {
            get { return _position6; }
            set
            {
                SetField(ref _position6, value);
            }
        }

        private int _position7;
        public int Position7
        {
            get { return _position7; }
            set
            {
                SetField(ref _position7, value);
            }
        }

        private int _position8;
        public int Position8
        {
            get { return _position8; }
            set
            {
                SetField(ref _position8, value);
            }
        }

        private int _position9;
        public int Position9
        {
            get { return _position9; }
            set
            {
                SetField(ref _position9, value);
            }
        }

        private int _position10;
        public int Position10
        {
            get { return _position10; }
            set
            {
                SetField(ref _position10, value);
            }
        }

        public Tape()
        {
            Position1 = 0;
            Position2 = 0;
            Position3 = 0;
            Position4 = 0;
            Position5 = 0;
            Position6 = 0;
            Position7 = 0;
            Position8 = 0;
            Position9 = 0;
            Position10 = 0;
        }
    }
}
