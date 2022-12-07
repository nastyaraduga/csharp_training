namespace WebAddressbookTests
{
    /// <summary>
    /// Добавление данных на странице создания контакта
    /// </summary>
    public class ContactData
    {

        private string firstname;
        private string lastname;

        public ContactData(string firstname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

    }
}