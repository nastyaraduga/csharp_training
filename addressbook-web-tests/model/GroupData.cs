using System;

namespace WebAddressbookTests
{
    /// <summary>
    ///  Класс для работы с данными на странице создания группы
    /// </summary>
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {

        //Конструктор присваивания 
        public GroupData(string name)
        {
            Name = name;
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
        public string Name { get; set; }
      
        public string Header { get; set; }
      
        public string Footer { get; set; }

        public string Id { get; set; }

    }

}