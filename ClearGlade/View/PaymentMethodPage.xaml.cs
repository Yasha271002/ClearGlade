using System.Windows.Controls;
using System.Windows.Input;
using ClearGlade.Model;
using ClearGlade.Utilities;



namespace ClearGlade.View
{
    /// <summary>
    /// Логика взаимодействия для PaymentMethodPage.xaml
    /// </summary>
    public partial class PaymentMethodPage : Page
    {
        public PaymentMethodPage(SumNumberModel model)
        {
            InitializeComponent();
        }

        private SumNumberModel _model;


        public SumNumberModel SumNumberModel
        {
            get => _model ?? (_model = new SumNumberModel());
            set => _model = value;
            }

            private ICommand _nextPayForTheTicketPageCommand;

            public ICommand NextPayForTheTicketPageCommand => _nextPayForTheTicketPageCommand ??
                                                              (_nextPayForTheTicketPageCommand = new RelayCommand(
                                                                  a =>
                                                                  {
                                                                      App.CurrentApp.NavigationService.Navigate(
                                                                          new PayForTheTicketPage(SumNumberModel));
                                                                  }));
    }
}

