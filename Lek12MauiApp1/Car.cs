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
        private string model;
        private int horsepower;
        private bool isElectric;

        public Car(string model, int horsePower, bool isElectric)
        {
            Model = model;
            HorsePower = horsePower;
            IsElectric = isElectric;
        }

        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Model)));

            }
        }

        public int HorsePower
        {
            get { return horsepower; }
            set
            {
                horsepower = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(HorsePower)));
            }
        }

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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsElectric)));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

    }
}
