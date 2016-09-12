using System.ComponentModel;
using System;

namespace Converter_1_.Model
{
    public  class ConvertManager: INotifyPropertyChanged
    {
        private InputNumber _currentNumber;
        private string _result;
        public InputNumber CurrentNumber
        {
            get { return _currentNumber ?? (_currentNumber = new InputNumber()); }
            set
            {
                _currentNumber = value;
                OnPropertyChanged("CurrentNumber");
            }
        }

        public string Result
        {
            get
            {
                if (_result == null)
                {_result = "";}
                ConvertNumberToTargetSystem();
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }
        
        public void ConvertNumberToTargetSystem()//Convert number to target notation
        {
            ConvertNumberToDecimal();
            switch (CurrentNumber.OutputConvertMode)
            {
                case ConvertMode.Dec:
                    Result = CurrentNumber.ValueToConvert;
                    break;
                case ConvertMode.Bin:
                    Result = Convert.ToString(Convert.ToInt32(CurrentNumber.ValueToConvert, 10),2);
                    break;
                case ConvertMode.Oct:
                    Result = Convert.ToString(Convert.ToInt32(CurrentNumber.ValueToConvert, 10), 8);
                    break;
                case ConvertMode.Hex:
                    Result = Convert.ToString(Convert.ToInt32(CurrentNumber.ValueToConvert, 10), 16);
                    break;
            }
        }
        private void ConvertNumberToDecimal()//Convert current value to decimal
        {
            switch (CurrentNumber.InputConvertMode)
            {
                case ConvertMode.Dec:
                    break;
                case ConvertMode.Bin:
                    CurrentNumber.ValueToConvert = Convert.ToString(Convert.ToInt32(CurrentNumber.ValueToConvert, 2));
                    break;
                case ConvertMode.Oct:
                    CurrentNumber.ValueToConvert = Convert.ToString(Convert.ToInt32(CurrentNumber.ValueToConvert, 8));
                    break;
                case ConvertMode.Hex:
                    CurrentNumber.ValueToConvert = Convert.ToString(Convert.ToInt32(CurrentNumber.ValueToConvert, 16));
                    break;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}