using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using WPFUI_FOrganizer.Models;

namespace WPFUI_FOrganizer.ViewModels
{
    
    public class FileOrganizerViewModel : Screen
    {
        public string OrganizeEverything { get; } = "Organize everything";
        public string OrganizeDocuments { get; } = "Documents";
        public string OrganizePictures { get; } = "Pictures";
        public string OrganizeMusic { get; } = "Music";
        public string OrganizeVideos { get; } = "Videos";
        public string OrganizeExesAndShortcuts { get; } = "Executables and Shortcuts";
        public string OrganizeOther { get; } = "Other";
        public string OrganizeFolders { get; } = "Folders";
        public static IEnumerable<String> SelectedData { get; set; }

        public ObservableCollection<OrganizerOptionsModel> Organizer { get; set; }

        public FileOrganizerViewModel()
        {
            Organizer = new ObservableCollection<OrganizerOptionsModel>();
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeDocuments, IsSelected = true}); //true to see if working
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizePictures });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeMusic });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeVideos });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeExesAndShortcuts });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeOther});
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeFolders });
        }
    }
}
