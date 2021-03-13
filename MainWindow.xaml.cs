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

namespace WPFGentryFinal
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

        public void GoForm3_Click(Object sender, EventArgs e)
        {
            this.Hide();
            HelloWorld form3 = new HelloWorld();
            form3.Show();
        }

        public void GoForm2_Click(Object sender, EventArgs e)
        {
            this.Hide();
            Gravity form2 = new Gravity();
            form2.Show();
        }

        private void CloseAll_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
