using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApplication.Models
{
    public class Driver : INotifyPropertyChanged
    {
        #region Properties
        public long Id { get; set; }
        public string EGN { get; set; }
        public string Name { get; set; }
        #endregion

        public virtual ICollection<Car> Cars { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
