using GradeBook.Mobile.Interfaces;
using GradeBook.Mobile.Models;
using ReactiveUI;

namespace GradeBook.Mobile.ViewModels
{
    public class AddTeacherPageViewModel
    {
        public AddTeacherPageViewModel()
        {
            this.Teacher = new Teacher();
        }
        

        public IPerson Teacher { get; set; }

    }
}