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

namespace ReservationDesktopUI
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            //chkbox30.IsChecked = false;
        }

        private void OptOK_Click(object sender, RoutedEventArgs e)
        {
            string ItemValue = "";

            foreach (CheckBox item in Options.Items)
            {
                if (item.IsChecked == true)
                {
                    if (ItemValue != "") { ItemValue = ItemValue + ", "; }

                    ItemValue = ItemValue + item.Content.ToString();
                }
            }

            MessageBox.Show((ItemValue + " is checked."));
        }



    }
}
