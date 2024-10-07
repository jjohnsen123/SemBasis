using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lek12MauiApp1
{
    public class Car : INotifyPropertyChanged
    {
        public string Model { get; set; }
        public int Horsepower { get; set; }
        private bool isElectric;


        public bool IsElectric
        {
            get
            {
                return isElectric;
            }
            set
            {
                if (isElectric != value)
                {
                    isElectric = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(isElectric)));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

    }
}
