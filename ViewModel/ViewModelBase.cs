using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HCTheme
{
    /// <summary>
    /// Class làm view model cho window
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected ViewModelPropertyChange SetPropertyValue<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            property = value;
            OnPropertyChanged(propertyName);

            return new ViewModelPropertyChange(this);
        }
        protected ViewModelPropertyChange RaisePropertyValue([CallerMemberName] string propertyName = null)
        {

            OnPropertyChanged(propertyName);

            return new ViewModelPropertyChange(this);
        }

    }

    /// <summary>
    /// Tạo trung gian raise property
    /// </summary>
    public class ViewModelPropertyChange
    {
        private readonly ViewModelBase _viewModel;

        public ViewModelPropertyChange(ViewModelBase viewModel)
        {
            _viewModel = viewModel;
        }

        public ViewModelPropertyChange WithDependent(string name)
        {
            _viewModel.OnPropertyChanged(name);

            return this;
        }
    }


}
