using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace ClassLibrary
{
    public class IpAddressDetail: INotifyPropertyChanged
    {
        public IpAddressDetail()
        {

        }
        public IpAddressDetail(string ipAddress, string name)
        {
            IpAddress = ipAddress;
            Name = name;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private bool isActive;
        public bool IsActive {
            get { return isActive;  }
            set {
                Debug.WriteLine(value);
                isActive = value;
                OnPropertyChanged("IsActive");
            } 
        }


        private string ipAddress;
        public string IpAddress {
            get { return ipAddress; }
            set {
                ipAddress = value;
                OnPropertyChanged("IpAddress");
            } 
        }

        private string name;

        public string Name { 
            get { return name; }
            set {
                name = value;
                OnPropertyChanged("Name");
            } }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
