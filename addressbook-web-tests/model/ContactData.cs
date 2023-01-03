using System;
using System.Xml.Linq;

namespace WebAddressbookTests
{
    /// <summary>
    /// Добавление данных на странице создания контакта
    /// </summary>
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public string allPhones;
        public string allEmails;
        public ContactData(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string AllPhones
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone)).Trim();
                }
            }
            set
            {
                  allPhones = value;
            }
        }

        private static string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }
            return phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "\r\n";
        }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string AllEmails
        {
            get
            {
                if (AllEmails != null)
                {
                    return allEmails;
                }
                else
                {
                    return (OneEmail + TwoEmail + ThreeEmail).Trim();
                }

            }
            set
            {
                allEmails = value;
            }
        }
        public string OneEmail { get; set; }
        public string TwoEmail { get; set; }
        public string ThreeEmail { get; set; }

        public bool Equals(ContactData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return FirstName == other.FirstName
            && LastName == other.LastName;
        }
        //Возвращение хещ-кода для свойств имени группы
        public override int GetHashCode()
        {
            return (FirstName + "" + LastName).GetHashCode();
        }
        //Возвращение строкового представления объектов ContactData
        public override string ToString()
        {
            return FirstName + "" + LastName;
        } 
        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            int result = LastName.CompareTo(other.LastName);
            if (result != 0) 
            {
                return result;
            }
            else
            {
                return FirstName.CompareTo(other.FirstName);
            }
        }
    }
}