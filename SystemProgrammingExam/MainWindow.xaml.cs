using System;
using System.Collections.Generic;
using System.Linq;
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
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SystemProgrammingExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SendSMS(object sender, RoutedEventArgs e)
        {
            string accountSid = Environment.GetEnvironmentVariable("AC6a3f8378d7611c91aeb27c4c1f0a144a");
            string authToken = Environment.GetEnvironmentVariable("b17eb3fadab80eb203036f68b2b62859");

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
            body: "Hello",
            from: new Twilio.Types.PhoneNumber("+12055767674"),
            to: new Twilio.Types.PhoneNumber("+77754570190")
        );

        }
    }
}
