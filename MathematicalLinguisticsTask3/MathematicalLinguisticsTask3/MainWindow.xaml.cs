using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

        private bool _started;
        private CancellationTokenSource _tokenSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnStartStop_Click(object sender, RoutedEventArgs e)
        {
            _started = !_started;

            if (_started)
            {
                btnStartStop.Content = "Stop";
                _tokenSource = new CancellationTokenSource();

                await Task.Factory.StartNew(() =>
                {
                    var _headPosition = Dispatcher.Invoke(() => TuringMachine.HeadPosition);
                    while (_headPosition > 0 && !_tokenSource.IsCancellationRequested)
                    {
                        Dispatcher.Invoke(() => TuringMachine.PerformStep());
                        Thread.Sleep(2000);
                        _headPosition = Dispatcher.Invoke(() => TuringMachine.HeadPosition);
                    }
                    Dispatcher.Invoke(() => false);
                },_tokenSource.Token);
            }
            else
            {
                btnStartStop.Content = "Start";
                _tokenSource.Cancel();
            }
        }

        private void BtnStep_Click(object sender, RoutedEventArgs e)
        {
            TuringMachine.PerformStep();
            btnStep.IsEnabled = TuringMachine.HeadPosition > 0;
        }

        private void BtnInsertValue_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value) && (value < 1021 && value > -1))
            {
                InputValue(value);
                TuringMachine.Reset();
                btnStep.IsEnabled = true;
            }
            else
                MessageBox.Show("Inputted text should be an integer between 0 - 1020.", "Nope");
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
            for (int i = TuringMachine.Tape.VisibleSize; i > TuringMachine.Tape.VisibleSize - result.Count; i--)
            {
                TuringMachine.Tape[i] = result[j];
                j++;
            }
        }
    }
}
