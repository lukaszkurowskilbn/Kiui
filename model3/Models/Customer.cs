
namespace model3.Models
{
    using System;
    using System.ComponentModel;
    class Customer : INotifyPropertyChanged
    {
        public Customer(String customerName)
        {
          

        }
        private string _Name;
        public String Name
        {
            get
            {
                return _Name;

            }
            set
            {
                _Name = value;
                OnPropertyChenged("Name");
            }

        }

    }
}
