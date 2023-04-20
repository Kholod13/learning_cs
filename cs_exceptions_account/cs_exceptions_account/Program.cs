
namespace _cs_exceptions_account
{
    internal class Account
    {
        private string email;
        private string password;
        public string Email {
            get {
                return email;
            } 
            set {
                bool error = true;
                while (error != false) {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Email is empty!");
                        error= false;
                    }
                    else
                    {
                        error= true;
                    }
                    if (!IsValidEmail(value))
                    {
                        throw new ArgumentException("Incorrect email data!");
                        error = false;
                    }
                    else
                    {
                        error= true;
                    }
                }
                email = value;
            } 
        }
        public string Password {
            get { return password;}
            set {
                bool error = true;
                while (error != false)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Password is Empty!");
                        error= false;
                    }
                    else
                    {
                        error= true;
                    }
                    if (value.Length < 6)
                    {
                        throw new ArgumentException("Password will be have min 6 symbols!");
                        error = false;
                    }
                    else
                    {
                        error= true;
                    }
                    if (!IsValidPassword(value))
                    {
                        throw new ArgumentException("Password will be have min 1 number!");
                        error = false;
                    }
                    else
                    {
                        error= true;
                    }
                }
                password = value;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            if (email.Length < 4 || email.Length > 50)
                return false;

            if (!email.Contains("@"))
                return false;

            foreach (char a in email)
            {
                if (!char.IsLetterOrDigit(a) && a != '_')
                    return false;
            }

            return true;
        }

        private bool IsValidPassword(string password)
        {
            bool letter = false;
            bool number = false;

            foreach (char a in password)
            {
                if (char.IsLetter(a))
                    letter = true;

                if (char.IsDigit(a))
                    number = true;

                if (letter && number)
                    return true;
            }

            return false;
        }
    }
}
internal class Program
    {
        private void Main(string[] args)
        {

        }
    }
