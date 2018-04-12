using GradeBook.Mobile.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GradeBook.Mobile.ViewModels
{
    public class LoginPageViewModel : ReactiveObject
    {

        private readonly ReactiveCommand<Unit, Unit> loginCommand;
        private ReactiveCommand<Unit, Unit> resetCommand;

        public LoginPageViewModel()
        {

            this.WhenAnyValue(
                 x => x.UserName,
                 x => x.Password,
                (userName, password) => !string.IsNullOrEmpty(userName) && password.Length > 5)
                .ToProperty(this, v => v.IsValid, out isValid);


            var canExecuteLogin = this.WhenAnyValue(x => x.IsLoading, x => x.IsValid,
                (isLoading, IsValid) => !isLoading && IsValid);

            // check if the user exist and navigate 
            loginCommand = ReactiveCommand.CreateFromTask(async (arg) =>
            {
                await Task.Delay(1000);
            }, canExecuteLogin);

            loginCommand.IsExecuting.ToProperty(this, x => x.IsLoading, out isLoading);

            this.resetCommand = ReactiveCommand.Create(() =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    this.UserName = null;
                    this.Password = null;
                });
            });

            this.WhenAnyObservable(x => x.loginCommand.IsExecuting)
                .StartWith(false)
                .ToProperty(this, x => x.IsLoading, out isLoading);
        }

        readonly ObservableAsPropertyHelper<bool> isLoading;
        public bool IsLoading
        {
            get { return isLoading?.Value ?? false; }
        }

        readonly ObservableAsPropertyHelper<bool> isValid;
        public bool IsValid
        {
            get { return isValid?.Value ?? false; }
        }


        public ReactiveCommand<Unit, Unit> SaveCommand => loginCommand;
        public ReactiveCommand<Unit, Unit> ResetCommand => resetCommand;

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { this.RaiseAndSetIfChanged(ref userName, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { this.RaiseAndSetIfChanged(ref password, value); }
        }
    }
}
