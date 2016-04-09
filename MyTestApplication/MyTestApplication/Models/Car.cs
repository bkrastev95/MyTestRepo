using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyTestApplication.Models
{
    public class Car : INotifyPropertyChanged
    {
        public long Id { get; set; }
        public string RegNumber { get; set; }
        public int ColorId { get; set; }
        public int CarTypeId { get; set; }
        public int BrandId { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
