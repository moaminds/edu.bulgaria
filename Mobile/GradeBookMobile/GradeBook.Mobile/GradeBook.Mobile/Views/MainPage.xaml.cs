using GradeBook.Mobile.ViewModels;
using GradeBook.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GradeBook.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginPageExec()
        {
            this.Navigation.PushAsync(new LoginPage());
        }

        public void AddTeacher()
        {
            this.Navigation.PushAsync(new AddTeacherPage());
        }
    }
}
