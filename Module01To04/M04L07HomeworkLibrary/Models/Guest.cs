namespace M04L07HomeworkLibrary.Models
{
    public class Guest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageToHost { get; set; }
        private int _age { get; set; }
        public int Age
        {
            get
            {
               return _age;
            }
            set
            {
                if (value >= 0 && value < 120)
                {
                    _age = value;
                }
                else
                {
                    throw new System.ArgumentException(value.ToString(), "The age is invalid.");
                }
            }
        }
        public string GuestInfo
        {
            get
            {
                return $"{FirstName} {LastName}: {MessageToHost}";
            }
        }
    }

}