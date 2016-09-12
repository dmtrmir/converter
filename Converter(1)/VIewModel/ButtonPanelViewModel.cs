using System.Windows.Input;
using Converter_1_.Infrastructure;
using Converter_1_.Model;

namespace Converter_1_.VIewModel
{
    public class ButtonPanelVieModel:ViewModelBase
    {
        private ConvertMangerViewModel _convertMangerViewModel = new ConvertMangerViewModel();

        public string NumberToShwow
        {
            get
            {   
                return ConvertManagerViewModel.ConvertManager.CurrentNumber.ValueToConvert;
            }
            set
            {
                _convertMangerViewModel.ConvertManager.CurrentNumber.ValueToConvert = value;
                OnPropertyChanged("NumberToShwow");
            }
              
        }
        private RelayCommand _addSymbol_0Command;
        private RelayCommand _add1Command;
        private RelayCommand _add2Command;
        private RelayCommand _add3Command;
        private RelayCommand _add4Command;
        private RelayCommand _add5Command;
        private RelayCommand _add6Command;
        private RelayCommand _add7Command;
        private RelayCommand _add8Command;
        private RelayCommand _add9Command;
        private RelayCommand _add_A_Command;
        private RelayCommand _add_B_Command;
        private RelayCommand _add_C_Command;
        private RelayCommand _add_D_Command;
        private RelayCommand _add_E_Command;
        private RelayCommand _add_F_Command;
        private RelayCommand _calculateCommand;
        private RelayCommand _backspaceCommand;
        private RelayCommand _clearCommand;
        
        public ConvertMangerViewModel ConvertManagerViewModel
        {
            get { return _convertMangerViewModel; }
        }

        #region ICommands

        public ICommand AddSymbol0
        {
            get { return _addSymbol_0Command ?? new RelayCommand(ExecuteAddSymbol0, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol1
        {
            get { return _add1Command ?? new RelayCommand(ExecuteAddSymbol1, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol2
        {
            get { return _add2Command ?? new RelayCommand(ExecuteAddSymbol2, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol3
        {
            get { return _add3Command ?? new RelayCommand(ExecuteAddSymbol3, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol4
        {
            get { return _add4Command ?? new RelayCommand(ExecuteAddSymbol4, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol5
        {
            get { return _add5Command ?? new RelayCommand(ExecuteAddSymbol5, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol6
        {
            get { return _add6Command ?? new RelayCommand(ExecuteAddSymbol6, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol7
        {
            get { return _add7Command ?? new RelayCommand(ExecuteAddSymbol7, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol8
        {
            get { return _add8Command ?? new RelayCommand(ExecuteAddSymbol8, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddSymbol9
        {
            get { return _add9Command ?? new RelayCommand(ExecuteAddSymbol9, CanExecuteAddSymbolCommand); }
        }

        public ICommand AddLetterA
        {
            get { return _add_A_Command ?? new RelayCommand(ExecuteAddLetterA, CanExecuteAddLettersCommand); }
        }
        public ICommand AddLetterB
        {
            get { return _add_B_Command ?? new RelayCommand(ExecuteAddLetterB, CanExecuteAddLettersCommand); }
        }
        public ICommand AddLetterC
        {
            get { return _add_C_Command ?? new RelayCommand(ExecuteAddLetterC, CanExecuteAddLettersCommand); }
        }
        public ICommand AddLetterD
        {
            get { return _add_D_Command ?? new RelayCommand(ExecuteAddLetterD, CanExecuteAddLettersCommand); }
        }
        public ICommand AddLetterE
        {
            get { return _add_E_Command ?? new RelayCommand(ExecuteAddLetterE, CanExecuteAddLettersCommand); }
        }
        public ICommand AddLetterF
        {
            get { return _add_F_Command ?? new RelayCommand(ExecuteAddLetterF, CanExecuteAddLettersCommand); }
        }
        public ICommand CalculateCommand
        {
            get { return _calculateCommand ?? new RelayCommand(ExecuteCalculate, CanExecuteCalculate); }
        }

        public ICommand BackspaceCommand
        {
            get { return _backspaceCommand ?? new RelayCommand(ExecuteBackspace, CanExecuteBackspace); }
        }

        public ICommand ClearCommand
        {
            get { return _clearCommand ?? new RelayCommand(ExecuteClear, CanExecuteClear); }
        }

       
        #endregion

        #region CanExecute

        public bool CanExecuteAddSymbolCommand(object parametr)
        {
            return _convertMangerViewModel.ConvertManager.CurrentNumber.ValueToConvert.Length <= 8;
        }

        public bool CanExecuteAddLettersCommand(object parametr)
        {
            return _convertMangerViewModel.ConvertManager.CurrentNumber.InputConvertMode == ConvertMode.Hex;
        }
        public bool CanExecuteCalculate(object parametr)
        {
            return _convertMangerViewModel.ConvertManager.CurrentNumber.ValueToConvert.Length > 0;
        }

        public bool CanExecuteBackspace(object parametr)
        {
            return _convertMangerViewModel.ConvertManager.CurrentNumber.ValueToConvert.Length > 0;
        }

        public bool CanExecuteClear(object parametr)
        {
            return _convertMangerViewModel.ConvertManager.CurrentNumber.ValueToConvert.Length > 0;
        }

        #endregion

        #region ExecuteSymbols

        public void ExecuteAddSymbol0(object parametr)
        {
            AddSymbol_0();
        }

        public void ExecuteAddSymbol1(object parametr)
        {
            AddSymbol_1();
        }

        public void ExecuteAddSymbol2(object parametr)
        {
            AddSymbol_2();
        }

        public void ExecuteAddSymbol3(object parametr)
        {
            AddSymbol_3();
        }

        public void ExecuteAddSymbol4(object parametr)
        {
            AddSymbol_4();
        }

        public void ExecuteAddSymbol5(object parametr)
        {
            AddSymbol_5();
        }

        public void ExecuteAddSymbol6(object parametr)
        {
            AddSymbol_6();
        }

        public void ExecuteAddSymbol7(object parametr)
        {
            AddSymbol_7();
        }

        public void ExecuteAddSymbol8(object parametr)
        {
            AddSymbol_8();
        }

        public void ExecuteAddSymbol9(object parametr)
        {
            AddSymbol_9();
        }

        public void ExecuteAddLetterA(object parametr)
        {
            AddLetter_A();
        }
        public void ExecuteAddLetterB(object parametr)
        {
            AddLetter_B();
        }
        public void ExecuteAddLetterC(object parametr)
        {
            AddLetter_C();
        }
        public void ExecuteAddLetterD(object parametr)
        {
            AddLetter_D();
        }
        public void ExecuteAddLetterE(object parametr)
        {
            AddLetter_E();
        }
        public void ExecuteAddLetterF(object parametr)
        {
            AddLetter_F();
        }

        #endregion

        #region Execute Operations

        public void ExecuteCalculate(object parametr)
        {
            Calculate();
        }

        public void ExecuteBackspace(object parametr)
        {
            Backspace();
        }

        public void ExecuteClear(object parametr)
        {
            Clear();
        }

        
        #endregion

        #region AddSymbolsMethods

        public void AddSymbolToCnvertManager(string symbol)
        {
            NumberToShwow += symbol;
        }
        public void AddSymbol_1()
        {
            AddSymbolToCnvertManager("1");
        }

        public void AddSymbol_0()
        {
            AddSymbolToCnvertManager("0");
        }

        public void AddSymbol_2()
        {
            AddSymbolToCnvertManager("2");
        }

        public void AddSymbol_3()
        {
            AddSymbolToCnvertManager("3");
        }

        public void AddSymbol_4()
        {
            AddSymbolToCnvertManager("4");
        }

        public void AddSymbol_5()
        {
            AddSymbolToCnvertManager("5");
        }

        public void AddSymbol_6()
        {
            AddSymbolToCnvertManager("6");
        }

        public void AddSymbol_7()
        {
            AddSymbolToCnvertManager("7");
        }

        public void AddSymbol_8()
        {
            AddSymbolToCnvertManager("8");
        }

        public void AddSymbol_9()
        {
            AddSymbolToCnvertManager("9");
        }
        public void AddLetter_A()
        {
            AddSymbolToCnvertManager("A");
        }
        public void AddLetter_B()
        {
            AddSymbolToCnvertManager("B");
        }
        public void AddLetter_C()
        {
            AddSymbolToCnvertManager("C");
        }
        public void AddLetter_D()
        {
            AddSymbolToCnvertManager("D");
        }
        public void AddLetter_E()
        {
            AddSymbolToCnvertManager("E");
        }
        public void AddLetter_F()
        {
            AddSymbolToCnvertManager("F");
        }
        
        #endregion

        #region Process Methods

        public void Clear()
        {
            ConvertManagerViewModel.ClearValueToConvert();
        }

        public void Backspace()
        {
            ConvertManagerViewModel.RemoveLastSymbol();
        }

        public void Calculate()
        {
            ConvertManagerViewModel.GetConvertationResult();
        }

        #endregion

    }
}