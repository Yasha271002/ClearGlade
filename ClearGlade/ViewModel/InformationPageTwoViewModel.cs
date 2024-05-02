using System.Windows.Input;
using ClearGlade.Utilities;
using ClearGlade.View;

namespace ClearGlade.ViewModel
{
    public class InformationPageTwoViewModel
    {
        private ICommand _nextNumberOfTicketsPageCommand;

        public ICommand NextNumberOfTicketsPageCommand => _nextNumberOfTicketsPageCommand ??
                                                          (_nextNumberOfTicketsPageCommand = new RelayCommand(
                                                              a =>
                                                              {
                                                                  App.CurrentApp.NavigationService.Navigate(
                                                                      new NumberOfTicketsPage());
                                                              }));
    }
}
