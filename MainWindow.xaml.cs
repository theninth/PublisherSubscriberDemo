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

namespace PublisherSubscriberDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<PublisherWindow> publisherWindows = new List<PublisherWindow>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenPublisher_Click(object sender, RoutedEventArgs e)
        {
            PublisherWindow frm = new PublisherWindow();
            frm.Show();
            publisherWindows.Add(frm);
        }

        private void OpenSubscriber_Click(object sender, RoutedEventArgs e)
        {
            SubscriberWindow frm = new();
            foreach (var publisherWindow in publisherWindows)
            {
                if (publisherWindow != null)
                {
                    publisherWindow.Click += frm.OnClick;
                }
            }
            frm.Show();
        }
    }
}
