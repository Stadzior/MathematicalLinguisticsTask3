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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TuringMachine).Tapes.Add(
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
                });
        }
    }
}
