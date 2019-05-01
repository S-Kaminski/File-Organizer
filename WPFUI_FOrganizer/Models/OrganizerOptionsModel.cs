using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WPFUI_FOrganizer.Models
{
    public class OrganizerOptionsModel : PropertyChangedBase
    {
        private string _organizeEverything;
        private string _organizeType;

        public string OrganizeEverything
        {
            get { return _organizeEverything; }
            set
            {
                _organizeEverything = value;
                NotifyOfPropertyChange(() => OrganizeEverything);
            }
        }


        public string OrganizeType
        {
            get { return _organizeType; }
            set
            {
                _organizeType = value;
                NotifyOfPropertyChange(() => OrganizeType);
            }
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        }

        public ObservableCollection<ExtensionsModel> Extensions { get; set; }

    }
}
