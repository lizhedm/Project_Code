using System;
using System.Windows.Input;

namespace LinkSettingDemo
{
    #region DelegateCommand
    internal class DelegateCommand : ICommand
    {
        private readonly Func<Object, Boolean> _canExecute;
        private readonly Action<Object> _execute;

        #region Constructors
        public DelegateCommand(Action<Object> execute) : this(execute, null)
        {

        }

        public DelegateCommand(Action<Object> execute, Func<Object, Boolean> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException("execute");
            _canExecute = canExecute;
        }
        #endregion

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            _execute(parameter);
        }
    }
    #endregion

    #region DelegateCommand<T>
    internal class DelegateCommand<T> : ICommand
    {
        private readonly Func<Object, Boolean> _canExecute;
        private readonly Action<Object> _execute;

        #region Constructors
        public DelegateCommand(Action<Object> execute) : this(execute, null)
        {

        }

        public DelegateCommand(Action<Object> execute, Func<Object, Boolean> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException("execute");
            _canExecute = canExecute;
        }
        #endregion

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            _execute(parameter);
        }
    }
    #endregion
}