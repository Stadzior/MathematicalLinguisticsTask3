using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathematicalLinguisticsTask3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TuringMachine TuringMachine
        {
            get { return (DataContext as TuringMachine); }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnStep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInsertValue_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(txtValue.Text, out value) && (value < 1024 || value > -1))
                InputValue(value);
            else
                MessageBox.Show("Inputted text should be an integer between 0 - 1023.", "Nope");
        }

        private void InputValue(int value)
        {
            List<int> result = new List<int>();

            while (value > 0)
            {
                result.Add(value % 2);
                value = (int)Math.Floor((decimal)value / 2);
            }

            while (result.Count < 10)
                result.Add(0);

            int j = 0;
            for (int i = TuringMachine.Tape.VisibleSize; i > TuringMachine.Tape.VisibleSize + 1 - result.Count; i--)
            {
                TuringMachine.Tape[i] = result[j];
                j++;
            }
        }
    }
}
