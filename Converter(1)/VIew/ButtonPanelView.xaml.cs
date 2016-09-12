using System.Windows;
using System.Windows.Controls;
using Converter_1_.VIewModel;

namespace Converter_1_.VIew
{
    /// <summary>
    /// Interaction logic for ButtonPanel.xaml
    /// </summary>
    public partial class ButtonPanelView : UserControl
    {
        readonly ButtonPanelVieModel _buttonPanelVieModel = new ButtonPanelVieModel();
        public ButtonPanelView()
        {
            InitializeComponent();
        }
        
    }
}
