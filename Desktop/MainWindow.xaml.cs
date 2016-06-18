using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Desktop.ViewModels;
using Domain;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _vm;
        public MainWindow()
        {
            InitializeComponent();
        }

    
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Call newCall = new Call()
            {

                Anumber = "777",
                Bnumber = "2222",
                Created = DateTime.Now,
                UserId = "0eb2699e-3746-410d-98e8-d61a1ccfcbc6",
                Dir = "1",
                ServiceId = 1,
                Duration = "23"

            };

            Task<HttpResponseMessage>  message =_vm.addCall(newCall);
            listBox.Items.Add(message.Result);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this._vm = new MainWindowVM();
        }
    }
}
