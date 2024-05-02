using System.Windows;
using System.Windows.Input;
using ClearGlade.Utilities;
using ClearGlade.View;

namespace ClearGlade.ViewModel
{
    public class ConfirmViewModel
    {
        private ICommand _onMainPageCommand;

        public ICommand OnMainPageCommand => _onMainPageCommand ?? (_onMainPageCommand = new RelayCommand(a =>
        {
            App.CurrentApp.NavigationService.Navigate(new FirstPage());
            MainWindow mw = (MainWindow)App.Current.MainWindow;
            mw.MainPageImage.Visibility = Visibility.Visible;
            mw.BackgroundPageImage.Visibility = Visibility.Hidden;
            mw.BackgroundRotatePageImage.Visibility = Visibility.Hidden;
            mw.ButtonBack.Visibility = Visibility.Hidden;
        }));
    }
}
