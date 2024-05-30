using SoUs.Entities;
using SoUs.services;
using System.Collections.ObjectModel;

namespace SoUs.CareApp.viewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {

        private readonly ISoUsService soUsService;


        public ObservableCollection<Assignment> TodaysAssignments { get; } = new();
        public  MainPageViewModel(ISoUsService soUsService)
        {
            Title = "FORSIDEN";
            this.soUsService = soUsService;
            UpdateAssignments();

        }

        private async Task UpdateAssignments()
        {
            TodaysAssignments.Clear();
            var assignments = await soUsService.GetAssignmentsForAsync(DateTime.Now, null);
            foreach (var assignment in assignments)
            {
                TodaysAssignments.Add(assignment);
            }
        }


    }
}
