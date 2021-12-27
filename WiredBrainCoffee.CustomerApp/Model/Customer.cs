using System.ComponentModel;
using Windows.Foundation.Metadata;
using WiredBrainCoffee.CustomerApp.Base;

namespace WiredBrainCoffee.CustomerApp.Model
{
    [CreateFromString(MethodName = "WiredBrainCoffee.CustomerApp.Model.CustomerConverter.CreateCustomerFromString")]
    public class Customer : Observable
    {
        private string _firstName;
        private string lastName;
        private bool isDeveloper;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }
        public bool IsDeveloper
        {
            get => isDeveloper; set
            {
                isDeveloper = value;
                OnPropertyChanged();
            }
        }
    }
}
