using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1proga
{
    class Exam
    {
        string name; //9
        public int rating; //9
        DateTime dateExam; //9
        public Exam(string name, int rating, DateTime dateExam) //Конструктор  с  параметрами  типа  string,  int  и  DateTime  для  инициализации  всех свойств класса
        {
            this.name = name;
            this.rating = rating;
            this.dateExam = dateExam;
        }
        public Exam() //Конструктор без параметров, инициализирующий все свойства класса некоторыми значениями по умолчанию
        {
            name = "Математика";
            rating = 5;
            dateExam = new DateTime(2015, 3, 5);
        }
        public override string ToString() //Перегруженная версия  виртуального  метода  string  ToString()  для формирования строки со значениями всех свойств класса;  
        {
            return string.Format("По предмету: {0}, получена оценка: {1}, экзамен проведен: {2}", name, rating, dateExam);
        }
        public object DeepCopy() //Реализовать интерфейс IDateAndCopy
        {
            Exam exam = new Exam(this.name, this.rating, this.dateExam);
            return exam;
        }
    }
}
