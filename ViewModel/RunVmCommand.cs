using System;
using System.Windows.Input;

namespace HCTheme
{
    /// <summary>
    /// Run view model command
    /// </summary>
    public class RunVmCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        private Action<object> _execute;



        public RunVmCommand(Action<object> execute) => _execute = execute;



        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => _execute.Invoke(parameter);
    }



    [System.Diagnostics.DebuggerStepThrough]
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);

        public void Execute(object parameter) => _execute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }


}
