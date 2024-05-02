using ClearGlade.Utilities;
using ClearGlade.View;
using System.Windows;
using System.Windows.Input;

namespace ClearGlade.ViewModel
{
    public class FirstPageViewModel
    {
        private ICommand _nextPageInformationCommand;

        public ICommand NextPageInformationCommand => _nextPageInformationCommand ?? (_nextPageInformationCommand = new RelayCommand(a =>
        {
            App.CurrentApp.NavigationService.Navigate(new InformationPage());
            MainWindow mw = (MainWindow)App.Current.MainWindow;
            mw.MainPageImage.Visibility = Visibility.Hidden;
            mw.BackgroundPageImage.Visibility = Visibility.Visible;
            mw.BackgroundRotatePageImage.Visibility = Visibility.Visible;
            mw.ButtonBack.Visibility = Visibility.Visible;

        }));

        private ICommand _nextPageInformationTwoCommand;

        public ICommand NextPageInformationTwoCommand => _nextPageInformationTwoCommand ?? (_nextPageInformationTwoCommand = new RelayCommand(a =>
        {
            App.CurrentApp.NavigationService.Navigate(new InformationPageTwo());
            MainWindow mw = (MainWindow)App.Current.MainWindow;
            mw.MainPageImage.Visibility = Visibility.Hidden;
            mw.BackgroundPageImage.Visibility = Visibility.Visible;
            mw.BackgroundRotatePageImage.Visibility = Visibility.Visible;
            mw.ButtonBack.Visibility = Visibility.Visible;
        }));
    }
}
