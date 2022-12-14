namespace WebAddressbookTests
{
    /// <summary>
    ///  Класс для работы с данными на странице авторизации
    /// </summary>
    /// 
    public class AccountData
    {
        private string username;
        private string password;

        public AccountData(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }

        }
        public string Password
        {
            get { return password; }
            set { password = value; }

        }
    }
}
