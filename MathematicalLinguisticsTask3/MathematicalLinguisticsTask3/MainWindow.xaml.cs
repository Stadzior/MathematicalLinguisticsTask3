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
            TuringMachine.
        }

        private void btnInsertValue_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(txtValue.Text, out value) && value < 1024 || value > -1)
            {
                MessageBox.Show("Inputted text should be an integer between 0 - 1023.", "Nope");
            }
\
        }
    }
}
