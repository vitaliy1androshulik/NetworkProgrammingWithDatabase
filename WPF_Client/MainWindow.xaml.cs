using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.IO;
using System.Configuration;

namespace WPF_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPEndPoint serverPoint;
        TcpClient client;
        ObservableCollection<MessageInfo> messages;
        NetworkStream ns = null;
        StreamReader sr = null;
        StreamWriter sw = null;
        public MainWindow()
        {
            InitializeComponent();
            client = new TcpClient();
            string address = ConfigurationManager.AppSettings["ServerAddress"]!;
            short port = short.Parse(ConfigurationManager.AppSettings["ServerPort"]!);
            serverPoint = new IPEndPoint(IPAddress.Parse(address), port);//точка нашого сервера
            messages = new ObservableCollection<MessageInfo>();
            this.DataContext = messages;
            Connect();
        }

        private void BtnSrchByRegion_Click(object sender, RoutedEventArgs e)
        {
            TextResult.Text = null;
            string message = TextBoxInformation.Text;
            if (message.Count() > 2)
            {
                sw.WriteLine(message);
                sw.Flush();
            }
            else if (message.Count() == 2)
            {
                MessageBox.Show("This is not region name!! Enter correct region name", "Information!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnSrchByCode_Click(object sender, RoutedEventArgs e)
        {
            TextResult.Text = null;
            string message = TextBoxInformation.Text;
            if(message.Count()==2)
            {
                sw.WriteLine(message);
                sw.Flush();
            }
            else if(message.Count() > 2)
            {
                MessageBox.Show("This is not region CODE!! Enter correct region CODE", "Information!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private async void Listen()
        {
            while (true)
            {
                string? message = await sr.ReadLineAsync();
                TextResult.Text=message;
            }
        }
        private void Connect()
        {
            try
            {
                client.Connect(serverPoint);
                ns = client.GetStream();

                sw = new StreamWriter(ns);
                sr = new StreamReader(ns);
                Listen();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }        
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            sr.Close();
            sw.Close();
            client.Close();
        }
    }
    public class MessageInfo
    {
        public string Text { get; set; }

        public MessageInfo(string text)
        {
            this.Text = text ?? "";
        }
        public override string ToString()
        {
            return $"{Text}";
        }
    }
}