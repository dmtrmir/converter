using System.ComponentModel;
using System.Windows.Media.Animation;
using Converter_1_.Model;

namespace Converter_1_.VIewModel
{
    public class InOutPanelViewModel : ViewModelBase
    {
        private ConvertMangerViewModel _convertMangerViewModel;

        public ConvertMangerViewModel ConvertManagerViewModel
        {
            get { return _convertMangerViewModel ?? new ConvertMangerViewModel(); }
        }

       
    }
}