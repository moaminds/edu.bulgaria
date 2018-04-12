using GradeBook.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GradeBook.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTeacherPage : ContentPage
	{
        private readonly AddTeacherPageViewModel viewModel;

		public AddTeacherPage ()
		{
			InitializeComponent ();

            this.viewModel = new AddTeacherPageViewModel();

            BindingContext = viewModel;
		}

        public void AddTeacherExec()
        {

        }

        public void Reset()
        {

        }
    }
}