using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClearGlade.Model;
using ClearGlade.Utilities;

namespace ClearGlade.View
{
    /// <summary>
    /// Логика взаимодействия для NumberOfTicketsPage.xaml
    /// </summary>
    public partial class NumberOfTicketsPage : Page
    {
        public NumberOfTicketsPage()
        {
            InitializeComponent();
        }

        private SumNumberModel _sumNumberModel;

        public SumNumberModel SumNumberModel
        {
            get => _sumNumberModel ?? (_sumNumberModel = new SumNumberModel());
            set => _sumNumberModel = value;
        }

        private ICommand _nextPaymentMethodPageCommand;

        public ICommand NextPaymentMethodPageCommand => _nextPaymentMethodPageCommand ??
                                                        (_nextPaymentMethodPageCommand = new RelayCommand(
                                                            a =>
                                                            {
                                                                App.CurrentApp.NavigationService.Navigate(
                                                                    new PaymentMethodPage(SumNumberModel));
                                                            }));

        private void ButtonPlus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { 

        }
    }
}
