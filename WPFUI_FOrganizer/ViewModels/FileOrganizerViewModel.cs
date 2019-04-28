using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

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

    }
}
