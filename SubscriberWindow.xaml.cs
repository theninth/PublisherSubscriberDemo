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
using System.Windows.Shapes;

namespace PublisherSubscriberDemo
{
    /// <summary>
    /// Interaction logic for SubscriberWindow.xaml
    /// </summary>
    public partial class SubscriberWindow : Window
    {
        public SubscriberWindow()
        {
            InitializeComponent();
        }

        public void OnClick(object source, EventArgs e)
        {
            TextLabel.Content = Int32.Parse(TextLabel.Content.ToString()) + 1;
        }
    }
}
