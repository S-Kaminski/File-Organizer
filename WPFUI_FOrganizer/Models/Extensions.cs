using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_FOrganizer.Models
{
    public class Extensions
    {
        private string _extension;
        private bool _isSelected;

        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }


    }
}
