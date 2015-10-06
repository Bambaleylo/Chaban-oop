using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1proga
{
    class Person
    {
        protected internal string name; //1
        protected internal string surname; //1
        protected DateTime date; //1
        public Person(string name, string surname, DateTime date) //2,1 Конструктор  c тремя параметрами типа string, string, DateTime для инициализации всех полей класса
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
        }
        public Person()  //2,2 Конструктор  без  параметров,  инициализирующий  все  поля  класса  некоторыми значениями по умолчанию
        {
            name = "Юрий";
            surname = "Чабан";
            date = new DateTime(1995, 8, 18);
        }
        public string PUBname  //3
        {
            get { return name; }
            set { name = value; }
        }
        public string PUBsurname  //3
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime PUBdate  //3
        {
            get { return date; }
            set { date = value; }
        }
        public int PUByear  //3
        {
            get { return Convert.ToInt32(date); }
            set { date = Convert.ToDateTime(value); }
        }
        public override string ToString() //4
        {
            return string.Format("{1} {0} родился: {2}", name, surname, date);
        }
        public virtual string ToShortString() //4
        {
            return string.Format("{1} {0}", name, surname);
        }
        public override bool Equals(Object obj) //5,1 и 7 Переопределяем метод virtial bool Equals (object obj) и определяем операции == и != так,  чтобы  равенство  объектов  типа  Person  трактовалось  как  совпадение  всех данных объектов, а не ссылок на объекты Person  
        {
            Person person = (Person)obj;
            bool value = false;
            if (obj != null)
                if (name.Equals(person.name))
                    if (surname.Equals(person.surname))
                        if (date.Equals(person.date))
                            value = true;
            return value;
        }
        public static bool operator ==(Person p1, Person p2) //5,2 и 7
        {
            bool result = false;

            if (p1.name.Equals(p2.name))
                if (p1.surname.Equals(p2.surname))
                    if (p1.date.Equals(p2.date))
                        result = true;
            return result;

        }
        public static bool operator !=(Person p1, Person p2) //5,2 и 7
        {
            bool result = true;
            if (p1.name.Equals(p2.name))
                if (p1.surname.Equals(p2.surname))
                    if (p1.date.Equals(p2.date))
                        result = false;
            return result;
        }
        public override int GetHashCode() //5,3 и 7
        {
            return name.Length + surname.Length + date.Day + date.Month + date.Year;
        }
        public object DeepCopy() //Реализовать интерфейс IDateAndCopy
        {
            Person person = new Person(name, surname, date);
            return person;
        }
    }
}
