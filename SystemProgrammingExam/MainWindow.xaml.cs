using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

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
            //ButtonPressDelay();
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(30) };
            timer.Start();
            //bool result = Regex.Match(phoneTextBox.Text, @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})").Success;
            //MessageBox.Show(result.ToString());
            string phoneNumber = $"+7{phoneTextBox.Text}";
            if (Regex.Match(phoneTextBox.Text, @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})").Success)
            {
                string accountSid = Environment.GetEnvironmentVariable("AC15a9364b89062d729d06c9977c0d1e6c");
                string authToken = Environment.GetEnvironmentVariable("7d1c9721d9cc263875d3e00a70f70d8c");

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                body: smsTextBox.Text,
                from: new Twilio.Types.PhoneNumber("+12058947575"),
                to: new Twilio.Types.PhoneNumber(phoneTextBox.Text)
            );
                MessageBox.Show("Text");

            }
            else
            {
                MessageBox.Show("Неправильно введен номер телефона");
            }

        }

        public async void ButtonPressDelay()
        {
            await Task.Delay(30000);
        }
    }
}
