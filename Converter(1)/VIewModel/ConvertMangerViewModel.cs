using System.Security.Authentication.ExtendedProtection;
using Converter_1_.Model;

namespace Converter_1_.VIewModel
{
    public class ConvertMangerViewModel : ViewModelBase
    {
        private ConvertManager _convertManager;
        public ConvertManager ConvertManager
        {
            get { return _convertManager ?? (_convertManager = new ConvertManager()); }
        }

       
        public void AddSymbolValueToConvert(string input)//Add new symbol to input area
        {
            ConvertManager.CurrentNumber.ValueToConvert += input;
        }

        public void ChangeInputMode(ConvertMode mode)
        {
            ConvertManager.CurrentNumber.InputConvertMode = mode;
        }

        public void ChangeOutputMode(ConvertMode mode)
        {
            ConvertManager.CurrentNumber.OutputConvertMode = mode;
        }

        public void ClearValueToConvert()//clear input area and set convert in/out Mode to default 
        {
            ConvertManager.CurrentNumber.ValueToConvert = "";
            ConvertManager.CurrentNumber.InputConvertMode = ConvertMode.Dec;
            ConvertManager.CurrentNumber.OutputConvertMode = ConvertMode.Dec;
        }

        public void RemoveLastSymbol()//remove last symbol from input area
        {
            string valueToTrim = ConvertManager.CurrentNumber.ValueToConvert;
            while (valueToTrim.Length < 0)
            {
                if (valueToTrim.Length == 1)
                {
                   ClearValueToConvert();
                }
                else
                {
                    valueToTrim = valueToTrim.Remove(valueToTrim.Length);
                    ConvertManager.CurrentNumber.ValueToConvert = valueToTrim;
                }
            }
        }

        public string GetConvertationResult()
        {
            ConvertManager.ConvertNumberToTargetSystem();
            return ConvertManager.Result;
        }

        
    }
}