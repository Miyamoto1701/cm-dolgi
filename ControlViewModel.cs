using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PractWork2.ViewModels
{
    public partial class ControlViewModel : ViewModelBase
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Age))]
        private DateTime selectedDate;

        public int Age => DateTime.Now.Month >= selectedDate.Month && DateTime.Now.Day >= selectedDate.Day ?
            DateTime.Now.Year - selectedDate.Year :
            DateTime.Now.Year - selectedDate.Year- 1;
    }
}
