using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Newtonsoft.Json;

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
            
                        Reservations dt = new Reservations();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44350/");
            client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = client.GetAsync("api/values").Result;
            if (response.IsSuccessStatusCode)
            {
                //var reservation = await response.Content.ReadAsStringAsync();
                var reservation = response.Content.ReadAsStringAsync().Result;
                var EmpInfo = JsonConvert.DeserializeObject<IEnumerable<Reservations>>(reservation);
                foreach (var entry in EmpInfo)
                {
                    //nefunguje - mělo být vypíná switchů
                    foreach (CheckBox item in Options.Items)
                    {
                        if (entry.Id == Convert.ToInt32(item.Content)) {
                            item.IsEnabled = false;
                            item.Background = Brushes.DarkGray;
                        }
                    }
                    
                }
            }
        }


        private void OptOK_Click(object sender, RoutedEventArgs e)
        {
            string ItemValue = "";
            bool check = false;

            foreach (CheckBox item in Options.Items)
            {
                if (item.IsChecked == true)
                {

                    Reservations newReservation = new Reservations
                    {
                        Id = Convert.ToInt32(item.Content),
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Email = txtEmail.Text,
                        MobileNumber = txtMobileNumber.Text,

                    };
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:44350/");
                    HttpResponseMessage response =
                    client.PostAsJsonAsync("api/values", newReservation).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(("Rezervace nebyla provedena."));
                    }
                    else
                    {
                        if (ItemValue != "") { ItemValue = ItemValue + ", "; }

                        ItemValue = ItemValue + item.Content.ToString();
                        item.IsChecked = false;
                        item.IsEnabled = false;
                        item.Background = Brushes.DarkGray;
                        check = true;
                    }
                }
            }
            if(check)
            MessageBox.Show(("Sedadla: "+ItemValue + " byla rezervována pro osobu: \nJméno: "+txtName.Text+" " +
                "\nPříjmení: "+txtSurname.Text+" \nEmail: "+txtEmail.Text+" \nTelefon: "+txtMobileNumber.Text+""));
        }



        //Watermark Name
        private void txtName_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Jméno")
            {
                txtName.Clear();
                txtName.Foreground = Brushes.Black;
            }
        }

        private void txtName_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "") 
            { 
            txtName.Text = "Jméno";
            txtName.Foreground = Brushes.DarkGray;
            }

        }

        private void txtName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (txtName.Text == "Jméno")
            {
                txtName.Clear();
                txtName.Foreground = Brushes.Black;
            }
        }


        private void txtName_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Jméno";
                txtName.Foreground = Brushes.DarkGray;
            }
        }

        //Watermark Surname

        private void txtSurname_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtSurname.Text == "Příjmení")
            {
                txtSurname.Clear();
                txtSurname.Foreground = Brushes.Black;
            }
        }

        private void txtSurname_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Příjmení";
                txtSurname.Foreground = Brushes.DarkGray;
            }
        }


        private void txtSurname_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (txtSurname.Text == "Příjmení")
            {
                txtSurname.Clear();
                txtSurname.Foreground = Brushes.Black;
            }
        }

        private void txtSurname_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Příjmení";
                txtSurname.Foreground = Brushes.DarkGray;
            }
        }

        //Watermark email

        private void txtEmail_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
                txtEmail.Foreground = Brushes.Black;
            }
        }

        private void txtEmail_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.Foreground = Brushes.DarkGray;
            }
        }

        private void txtEmail_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
                txtEmail.Foreground = Brushes.Black;
            }
        }

        private void txtEmail_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.Foreground = Brushes.DarkGray;
            }
        }

        //Watermark MobileNumber

        private void txtMobileNumber_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtMobileNumber.Text == "Telefonní číslo")
            {
                txtMobileNumber.Clear();
                txtMobileNumber.Foreground = Brushes.Black;
            }
        }

        private void txtMobileNumber_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtMobileNumber.Text == "")
            {
                txtMobileNumber.Text = "Telefonní číslo";
                txtMobileNumber.Foreground = Brushes.DarkGray;
            }
        }

        private void txtMobileNumber_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (txtMobileNumber.Text == "Telefonní číslo")
            {
                txtMobileNumber.Clear();
                txtMobileNumber.Foreground = Brushes.Black;
            }
        }

        private void txtMobileNumber_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtMobileNumber.Text == "")
            {
                txtMobileNumber.Text = "Telefonní číslo";
                txtMobileNumber.Foreground = Brushes.DarkGray;
            }
        }

    }
}
