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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
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

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Login_txtPass.Password) && Login_txtPass.Password.Length > 0)
            {
                Login_txtbPass.Visibility = Visibility.Collapsed;
            }
            else
            {
                Login_txtbPass.Visibility = Visibility.Visible;
            }
        }

        private void txtbPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login_txtPass.Password = "";
            Login_txtPass.Focus();
        }

        private void rbtn_Admin_Click(object sender, RoutedEventArgs e)
        {

            //// New Images ////////
            Images.Navigate(new System.Uri("pages/Admin.xaml", UriKind.RelativeOrAbsolute));


            ////เครียร์ Textbox //////
            Login_txtUser.Text = "";
            Login_txtPass.Password = "";

            Login_txtUser.Focus();
        }

        private void rbtn_User_Click(object sender, RoutedEventArgs e)
        {

            //// New Images ////////
            Images.Navigate(new System.Uri("pages/User.xaml", UriKind.RelativeOrAbsolute));


            ////เครียร์ Textbox //////
            Login_txtUser.Text = "";
            Login_txtPass.Password = "";

            Login_txtUser.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Images.Navigate(new System.Uri("pages/Admin.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Register_txtbPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Register_txtPass.Password = "";
            Register_txtPass.Focus();
        }

        private void Register_txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Register_txtPass.Password) && Register_txtPass.Password.Length > 0)
            {
                Register_txtbPass.Visibility = Visibility.Collapsed;
            }
            else
            {
                Register_txtbPass.Visibility = Visibility.Visible;
            }
        }

        private void btn_Sign_Up_Click(object sender, RoutedEventArgs e)
        {

            var WidthAnimationOpen = new DoubleAnimation() { To = 340, Duration = TimeSpan.FromSeconds(0.6) };
            var WidthAnimationOff = new DoubleAnimation() { To = 0, Duration = TimeSpan.FromSeconds(0.5) };

            FromRegister.BeginAnimation(Border.WidthProperty, WidthAnimationOpen);
            FromLogin.BeginAnimation(Border.WidthProperty, WidthAnimationOff);
            NavBar.BeginAnimation(Border.WidthProperty, WidthAnimationOff);


            /////Open From/////
            Images.Navigate(new System.Uri("pages/Register.xaml", UriKind.RelativeOrAbsolute));


            ////เครียร์ Textbox //////
            Login_txtUser.Text = "";
            Login_txtPass.Password = "";

            Login_txtUser.Focus();

        }

        private void btn_Sign_In_Click(object sender, RoutedEventArgs e)
        {
            var WidthAnimationOpen = new DoubleAnimation() { To = 340, Duration = TimeSpan.FromSeconds(0.6) };
            var WidthAnimationOpenNavBar = new DoubleAnimation() { To = 80, Duration = TimeSpan.FromSeconds(1) };
            var WidthAnimationOff = new DoubleAnimation() { To = 0, Duration = TimeSpan.FromSeconds(0.5) };

            FromLogin.BeginAnimation(Border.WidthProperty, WidthAnimationOpen);
            FromRegister.BeginAnimation(Border.WidthProperty, WidthAnimationOff);
            NavBar.BeginAnimation(Border.WidthProperty, WidthAnimationOpenNavBar);

            /////Open From/////
            Images.Navigate(new System.Uri("pages/Admin.xaml", UriKind.RelativeOrAbsolute));

            ////เครียร์ Textbox //////
            Register_txtEmail.Text = "";
            Register_txtUser.Text = "";
            Register_txtPass.Password = "";

            Register_txtUser.Focus();
        }
    }
}
