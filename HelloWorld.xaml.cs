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

namespace WPFGentryFinal
{
    /// <summary>
    /// Interaction logic for HelloWorld.xaml
    /// </summary>
    public partial class HelloWorld : Window
    {
        public HelloWorld()
        {
            InitializeComponent();
        }
        public void GoForm1_Click(Object sender, EventArgs e)
        {
            this.Hide();
            MainWindow form1 = new MainWindow();
            form1.Show();
        }
        public void Button_Click(Object sender, EventArgs e)
        {
            this.Hide();
            Gravity form2 = new Gravity();
            form2.Show();
        }

        private void EndApp_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
