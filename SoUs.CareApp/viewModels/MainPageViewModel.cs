using SoUs.Entities;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.viewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {

        public MainPageViewModel()
        {
            Title = "FORSIDEN";

            var a = new Assignment
            {
                Resident = new()
                {
                    Name = "Ibn Halfdan"
                },
                TimeStart = new(2024, 01, 01, 12, 00, 00),
                TimeEnd = new(2024, 01, 01, 12, 30, 00)
            };
            var b = new Assignment
            {
                Resident = new()
                {
                    Name = "Ib Bifrost"
                },
                TimeStart = new(2024, 01, 01, 15, 30, 00),
                TimeEnd = new(2024, 01, 01, 16, 30, 00)
            };

            TodaysAssignments.Add(a);
            TodaysAssignments.Add(b);
        }


        public ObservableCollection<Assignment> TodaysAssignments { get; } = new();

    }
}
