using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_Interface
{
    public class Smartphone : ICallable, IWebBrowsable
    {
        private List<string> phoneNumbers;
        public List<string> PhoneNumbers
        {
            get { return this.phoneNumbers; }
            private set
            {
                this.phoneNumbers = value;
            }
        }

        public void Call()
        {
            foreach (var number in this.PhoneNumbers)
            {
                bool containsOnlyNumbers = true;
                for (int i = 0; i < number.Length; i++)
                {
                    if (!char.IsDigit(number[i]))
                    {
                        containsOnlyNumbers = false;
                        break;
                    }
                }
                if (containsOnlyNumbers)
                {
                    Console.WriteLine("Calling {0}", number);
                }
            }
        }
        public Smartphone(List<string> phoneNumbers, List<string> webSites)
        {
            this.PhoneNumbers = phoneNumbers;
            this.WebSites = webSites;
        }

        private List<string> webSites;
        public List<string> WebSites
        {
            get { return this.webSites; }
            private set
            {
                this.webSites = value;
            }
        }

        public void Browse()
        {
            foreach (var site in this.WebSites)
            {
                bool containsOnlyLetters = true;
                for (int i = 0; i < site.Length; i++)
                {
                    if (char.IsDigit(site[i]))
                    {
                        containsOnlyLetters = false;
                        Console.WriteLine("Invalid URL");
                        break;
                    }
                }
                if (containsOnlyLetters)
                {
                    Console.WriteLine("Browsing {0}", site);
                }
            }
        }

    }
}
