namespace Event_MS.Classes
{
    public class User
    {
        // Private fields to store user name and password
        private string name;
        private string password;

        // Public property for accessing and modifying the name
        public string Name
        {
            get => name; // Using expression-bodied member for getter
            set => name = value; // Using expression-bodied member for setter
        }

        // Public property for accessing and modifying the password
        public string Password
        {
            get => password; // Using expression-bodied member for getter
            set => password = value; // Using expression-bodied member for setter
        }

        // Constructor to initialize the User object with name and password
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        // Virtual method to get the role of the user, can be overridden in derived classes
        public virtual string GetRole()
        {
            return "User";
        }
    }
}
