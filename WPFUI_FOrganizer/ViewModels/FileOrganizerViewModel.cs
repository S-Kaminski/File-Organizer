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
        public string OrganizeExesAndShortcuts { get; } = "Executables";
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
        public ObservableCollection<ExtensionsModel> DocumentsExt { get; set; } = new ObservableCollection<ExtensionsModel>();
        public ObservableCollection<ExtensionsModel> PicturesExt { get; set; } = new ObservableCollection<ExtensionsModel>();

        public ObservableCollection<ExtensionsModel> MusicExt { get; set; } = new ObservableCollection<ExtensionsModel>();
        public ObservableCollection<ExtensionsModel> VideosExt { get; set; } = new ObservableCollection<ExtensionsModel>();
        public ObservableCollection<ExtensionsModel> ExecutablesExt { get; set; } = new ObservableCollection<ExtensionsModel>();

        public FileOrganizerViewModel()
        {
            InitExtensionsLists();
            InitOrganizeOptions();
            
        }

        public void InitExtensionsLists()
        {
            InitDocumentsExtensions();
            InitPicturesExtensions();
            InitMusicExtensions();
            InitVideosExtensions();
            InitExesExtensions();
        }

        public void InitDocumentsExtensions()
        {
            DocumentsExt.Add(new ExtensionsModel() { Extension = ".docx", IsSelected = true });
            DocumentsExt.Add(new ExtensionsModel() { Extension = ".pdf", IsSelected = true });
        }

        public void InitPicturesExtensions()
        {

             PicturesExt.Add(new ExtensionsModel() { Extension = ".png", IsSelected = true });
             PicturesExt.Add(new ExtensionsModel() { Extension = ".jpg", IsSelected = true });
             PicturesExt.Add(new ExtensionsModel() { Extension = ".jpeg", IsSelected = true });
        }

        public void InitMusicExtensions()
        {
            MusicExt.Add(new ExtensionsModel() { Extension = ".mp3", IsSelected = true });
        }

        public void InitVideosExtensions()
        {
            VideosExt.Add(new ExtensionsModel() { Extension = ".mp4", IsSelected = true });
            VideosExt.Add(new ExtensionsModel() { Extension = ".mov", IsSelected = true });
        }

        public void InitExesExtensions()
        {
            ExecutablesExt.Add(new ExtensionsModel() { Extension = ".exe", IsSelected = true });
        }

        public void InitOrganizeOptions()
        {
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeDocuments, IsSelected = true, Extensions = DocumentsExt }); //true to see if working
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizePictures, Extensions = PicturesExt });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeMusic, Extensions = MusicExt });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeVideos, Extensions = VideosExt });
            Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeExesAndShortcuts, Extensions = ExecutablesExt });
           // Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeOther, Extensions = PicturesExt });
            //Organizer.Add(new OrganizerOptionsModel() { OrganizeEverything = this.OrganizeEverything, OrganizeType = this.OrganizeFolders, Extensions = PicturesExt });
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
