using System;
using System.Collections.Generic;
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
using Converter_1_.VIewModel;

namespace Converter_1_.VIew
{
    /// <summary>
    /// Interaction logic for OutputControlModeSwitcher.xaml
    /// </summary>
    public partial class OutputControlModeSwitcher : UserControl
    {
        private OutputConvertModeSwitcherViewModel _outputConvertModeSwitcherViewModel;

        public OutputConvertModeSwitcherViewModel OutputConvertModeSwitcherViewModel
        {
            get {
                return _outputConvertModeSwitcherViewModel ??
                       (_outputConvertModeSwitcherViewModel = new OutputConvertModeSwitcherViewModel());
            }
        }

        public OutputControlModeSwitcher()
        {
            InitializeComponent();
        }

        private void RadioHexOutput_Checked(object sender, RoutedEventArgs e)
        {
            OutputConvertModeSwitcherViewModel.ChangeOutputModeToHex();
        }

        private void RadioOctalOutput_Checked(object sender, RoutedEventArgs e)
        {
            OutputConvertModeSwitcherViewModel.ChahgeOutputModeToOctal();
        }

        private void RadioBinaryOutput_Checked(object sender, RoutedEventArgs e)
        {
            OutputConvertModeSwitcherViewModel.ChahgeOutputModeToBinary();
        }

        private void RadioDecimalOutput_Checked(object sender, RoutedEventArgs e)
        {
            OutputConvertModeSwitcherViewModel.ChangeOutputModeToDecimal();
        }

        
    }
}
