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
        private readonly ReactiveCommand<Unit, Unit> resetCommand;

        public LoginPageViewModel()
        {
            var canLogin = this.WhenAnyValue(
                 x => x.UserName,
                 x => x.Password,
                (userName, password) => !String.IsNullOrWhiteSpace(userName) && !String.IsNullOrWhiteSpace(password)
            && userName.Length >= 3 && password.Length >= 8);

            // check if the user exist and navigate 
            loginCommand = ReactiveCommand.CreateFromTask(async (arg) =>
            {
                await Task.Delay(4000).ConfigureAwait(false);
            }, canLogin);

            loginCommand.IsExecuting.ToProperty(this, x => x.IsLoading, out _isLoading);

            this.resetCommand = ReactiveCommand.Create(() =>
                {
                    this.UserName = null;
                    this.Password = null;
                });
            
        }

        readonly ObservableAsPropertyHelper<bool> _isLoading;
        public bool IsLoading
        {
            get { return _isLoading.Value; }
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

        private bool areCredentialsInvalid;
        public bool AreCredentialsInvalid
        {
            get { return areCredentialsInvalid; }
            set { this.RaiseAndSetIfChanged(ref areCredentialsInvalid, value); }
        }

    }
}