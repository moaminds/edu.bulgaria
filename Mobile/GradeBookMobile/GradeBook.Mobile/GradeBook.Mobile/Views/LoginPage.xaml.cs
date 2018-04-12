using GradeBook.Mobile.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GradeBook.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage, IViewFor<LoginPageViewModel>
    {

        public LoginPage()
        {
            InitializeComponent();

            ViewModel = new LoginPageViewModel();
        }

        protected override void OnAppearing()
        {
            this.Bind(ViewModel, vm => vm.UserName, v => v.userName.Text);
            this.Bind(ViewModel, vm => vm.Password, v => v.password.Text);
            this.Bind(ViewModel, vm => vm.IsLoading, v => v.loading.IsVisible);
            this.BindCommand(ViewModel, vm => vm.SaveCommand, v => v.saveCommand);
            this.BindCommand(ViewModel, vm => vm.ResetCommand, v => v.resetCommand);
        }


        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (LoginPageViewModel)value; }
        }

        public static readonly BindableProperty ViewModelProperty =
             BindableProperty.Create(nameof(ViewModel), typeof(LoginPageViewModel), typeof(LoginPage), null, BindingMode.OneWay);

        public LoginPageViewModel ViewModel
        {
            get { return (LoginPageViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
    }
}