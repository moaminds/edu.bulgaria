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

            this.Bind(ViewModel, vm => vm.UserName, v => v.ViewModel.UserName);
            this.Bind(ViewModel, vm => vm.Password, v => v.ViewModel.Password);
            this.BindCommand(ViewModel, vm => vm.SaveCommand, v => v.ViewModel.SaveCommand);

            this.WhenAnyValue(x => x.ViewModel.is)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(busy =>
                {
                   
                });
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