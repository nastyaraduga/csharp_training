using System;

namespace WebAddressbookTests
{
    /// <summary>
    ///  Класс для работы с данными на странице создания группы
    /// </summary>
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData(string name)
        {
            this.name = name;
        }

        // определение функции реализующее сравнение групп
        public bool Equals (GroupData other )
        {
            if (object.ReferenceEquals ( other, null ) )
            {
                return false;
            }
            if (object.ReferenceEquals ( this, other ) )
            {
                return true;
            }
            return Name == other.Name;
        }
        //Возвращение хещ-кода для свойств имени группы
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        //Возвращение строкового представления объектов GroupData
        public override string ToString()
        {
            return "name=" + Name;
        }
        //Метод для функции сравнения объектов name
        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals ( other, null ) )
            {
                return 1; 
            }
            return Name.CompareTo( other.Name );

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
        public string Footer
        {
            get
            {
                return footer;
            }
            set
            {
                footer = value;
            }

        }
    }

}