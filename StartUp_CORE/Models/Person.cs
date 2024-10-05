namespace StartUp_CORE.Models
{
    public class Person
    {
        // Auto-implemented properties for simplicity
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        // Private field and property for phone numbers
        private List<string> phoneNumbers = new List<string>();
        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
            set { phoneNumbers = value; }
        }

        // Property for birthday
        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                // Validate birthday to ensure age is between 0 and 120
                int age = CalculateAge(value);
                if (age < 0 || age > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthday = value;
                }
            }
        }

        // Read-only property for age
        public int Age
        {
            get { return CalculateAge(birthday); }
        }

        // Constructor
        public Person(string firstName, string lastName, string address, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
        }

        // Method to add phone number
        public void AddPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        // Method to calculate age
        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }
    }
}
