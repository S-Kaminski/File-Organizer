using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WPFUI_FOrganizer.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public string ShellName { get; } = "File Organizer";

        public ShellViewModel() => ActivateItem(new FileOrganizerViewModel());
    }
}
