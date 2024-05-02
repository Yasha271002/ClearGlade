using ClearGlade.Model;
using ClearGlade.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClearGlade.View
{
    /// <summary>
    /// Логика взаимодействия для PayForTheTicketPage.xaml
    /// </summary>
    public partial class PayForTheTicketPage : Page
    {
        public PayForTheTicketPage(SumNumberModel model)
        {
            InitializeComponent();
        }

        private SumNumberModel _model;


        public SumNumberModel SumNumberModel
        {
            get => _model ?? (_model = new SumNumberModel());
            set => _model = value;
        }

        private ICommand _nextConfirmPageCommand;

        public ICommand NextConfirmPageCommand => _nextConfirmPageCommand ?? (_nextConfirmPageCommand =
            new RelayCommand(
                a =>
                {
                    App.CurrentApp.NavigationService.Navigate(new ConfirmPage());

                }));
    }
}
