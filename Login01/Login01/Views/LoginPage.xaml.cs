using Login01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        void Login(object sender, EventArgs e)
        {
            Users user = new Users(Entry_Username.Text = "", Entry_Password.Text = "");

            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login Not Currect", "OK");
            }
        }
    }
}