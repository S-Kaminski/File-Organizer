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
        private string _path;
        private string _selectedTypes;

        public string OrganizeEverything { get; } = "Organize everything";
        public string OrganizeDocuments { get; } = "Documents";
        public string OrganizePictures { get; } = "Pictures";
        public string OrganizeMusic { get; } = "Music";
        public string OrganizeVideos { get; } = "Videos";
        public string OrganizeExesAndShortcuts { get; } = "Executables and Shortcuts";
        public string OrganizeOther { get; } = "Other";
        public string OrganizeFolders { get; } = "Folders";



        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                NotifyOfPropertyChange(() => Path);
            }
        }
        public string SelectedTypes
        {
            get { return _selectedTypes; }
            set
            {
                _selectedTypes = value;
                NotifyOfPropertyChange(() => SelectedTypes);
            }
        }


        public ObservableCollection<OrganizerOptionsModel> Organizer { get; set; } = new ObservableCollection<OrganizerOptionsModel>();

        public FileOrganizerViewModel()
        {
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeDocuments, IsSelected = true}); //true to see if working
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizePictures });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeMusic });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeVideos });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeExesAndShortcuts });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeOther});
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeFolders });
        }

        private IEnumerable<string> SelectedTypesEnumerable()
        {
            return Organizer.Where(d => d.IsSelected).Select(d => d.OrganizeType);
        }

        public void Organize(string path)
        {
            path = Path;
            string types = "";
            IEnumerable<string> result = SelectedTypesEnumerable();
            foreach (var res in result)
            {
                types += $"{ res } {Environment.NewLine}";
            }
            SelectedTypes = types;
        }

        public bool CanOrganize(string path)
        {
            path = Path;
            return !String.IsNullOrWhiteSpace(path);
        }
    }
}
