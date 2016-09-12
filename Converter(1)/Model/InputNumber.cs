using System;
using System.ComponentModel;

namespace Converter_1_.Model
{
    public class InputNumber: INotifyPropertyChanged
    {
        private string _valueToConvert;
        public string ValueToConvert 
        {
            get { return _valueToConvert ?? (_valueToConvert = ""); }

            set
            {
                _valueToConvert = value;
                OnPropertyChanged("ValueToConvert");
            } 
        }
        public ConvertMode InputConvertMode { get; set; }
        public ConvertMode OutputConvertMode { get; set; }

        public InputNumber(string valueToConvert = "", ConvertMode inputConvertMode = ConvertMode.Dec, ConvertMode outputConvertMode = ConvertMode.Dec)
        {
            ValueToConvert = valueToConvert;
            this.InputConvertMode = inputConvertMode;
            this.OutputConvertMode = outputConvertMode;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}