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

namespace Flags
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

        private void BabianKnapp_Click(object sender, RoutedEventArgs e)
        {
            if (BabianText.Text == "Babian")

            {
                BabianText.Text = "HOHA";
                BabianKnapp.Content = "Babian";

            }
            else if(BabianText.Text == "HOHA")
            {
                var newButton = new Button();
                newButton.Content = "Peekaboo";
                newButton.Height = 40;
                newButton.Width = 80;
                MainGrid.Children.Add(newButton);
            }
            else
            {
                BabianText.Text = "Babian";
                BabianKnapp.Content = "HOHA";
            }
        }

    }

}
