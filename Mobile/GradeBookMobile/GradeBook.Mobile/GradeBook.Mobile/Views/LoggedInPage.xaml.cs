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
    public partial class LoggedInPage : TabbedPage
    {
        public LoggedInPage ()
        {
            var teachersPage = new NavigationPage(new AddTeacherPage());
            teachersPage.Title = "Add Teacher";

            var studentsPage = new NavigationPage(new AddStudentsPage());
            studentsPage.Title = "Add Student";


            this.Children.Add(teachersPage);
            this.Children.Add(studentsPage);

            InitializeComponent();
        }
    }
}