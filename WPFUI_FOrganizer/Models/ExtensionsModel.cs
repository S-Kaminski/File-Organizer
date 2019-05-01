using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WPFUI_FOrganizer.Models
{
    public class ExtensionsModel : PropertyChangedBase
    {
        private string _extension;
        private bool _isSelected;

        public string Extension
        {
            get { return _extension; }
            set
            {
                _extension = value;
                NotifyOfPropertyChange(() => Extension);
            }
        }



        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        }


    }
}
