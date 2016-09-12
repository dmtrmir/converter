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
    /// Interaction logic for ConvertModeSwitcher.xaml
    /// </summary>
    public partial class ConvertModeSwitcher : UserControl
    {
        
        public ConvertModeSwitcher()
        {
            InitializeComponent();
        }

        private void RadioHexInput_Checked(object sender, RoutedEventArgs e)
        {
            InputConvertModeSwitcherViewModel.ChangeInputModeToHex();
        }

        private void RadioOctalInput_Checked(object sender, RoutedEventArgs e)
        {
            InputConvertModeSwitcherViewModel.ChangeInputModeToOctal();
        }

        private void RadioBinaryInput_Checked(object sender, RoutedEventArgs e)
        {
            InputConvertModeSwitcherViewModel.ChangeInputModeToBinary();
        }

        private void RadioDecimalInput_Checked(object sender, RoutedEventArgs e)
        {
            InputConvertModeSwitcherViewModel.ChangeInputModeToDecimal();
        }
    }
}
