using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1proga
{
    class Student:Person
    {
        private Education education; //13
        private int numberGroup; //13
        private ArrayList listTests; //13
        private Exam[] exams; //13
        public Student(Person person, Education education, int numberGroup) //Конструктор  c  параметрами    типа  Person,  Education,  int  для  инициализации соответствующих полей класса
        {
            Person = person;
            this.education = education;
            this.numberGroup = numberGroup;
            exams = new Exam[0];
            listTests = new ArrayList();
        }
        public Student() //Конструктор без параметров для инициализации по умолчанию
        {
            Person = new Person();
            education = Education.Bachelor;
            numberGroup = 1;
            exams = new Exam[0];
            listTests = new ArrayList();
        }
        public Person Person //Cвойство типа Person; метод  get свойства возвращает объект типа Person,  данные которого совпадают с данными подобъекта базового класса, метод set присваивает значения полям из подобъекта базового класса
        {
            get { return (Person)this; }
            set
            {
                name = this.name;
                surname = this.surname;
                date = this.date;
            }
        }
        public ArrayList ListTests //Cвойство типа System.Collections.ArrayList  с методами get и set для доступа к полю со списком зачетов
        {
            get { return listTests; }
            set { listTests = value; }
        }
        public Exam[] Exams //Cвойство типа Exam[] для доступа к полю со списком экзаменов
        {
            get { return exams; }
            set { exams = value; }
        }
        public double AverageRating //Cвойство типа double (только с методом get), в котором вычисляется средний балл как среднее значение оценок в списке сданных экзаменов;  метод  void  AddExams  (  params  Exam[]  )    для  добавления  элементов  в  список экзаменов;  
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < exams.Length; i++)
                {
                    sum += exams[i].rating;
                }
                if (exams.Length != 0)
                    return sum / exams.Length;
                else
                    return 0;
            }
        }
        public void AddExam(params Exam[] examAdd) //Mетод void AddTests ( params Test[] )  для добавления элементов в список тестов
        {
            int Length = exams.Length;
            Array.Resize<Exam>(ref exams, Length + examAdd.Length);
            examAdd.CopyTo(exams, Length);

        }
        public override string ToString() //Перегруженная  версия  виртуального  метода  string  ToString()  для  формирования строки со значениями всех полей класса, включая список зачетов и экзаменов
        {
            string result = base.ToString() + "; Тип образования: " + education.ToString() + "; Номер группы" + numberGroup.ToString() +"; ";
            foreach (Exam e in exams)
            {
                result += e.ToString() + "; ";
            }
            foreach (Test t in listTests)
            {
                result += t.ToString();
            }
            return result;
        }
        new public string ToShortString() //Виртуальный  метод  string  ToShortString(),  который  формирует  строку  со значениями  всех  полей  класса  без  списка  зачетов  и  экзаменов,  но  со  значением среднего балла
        {
            return string.Format(base.ToString() + "Тип образования: {0}; №Группы: {1}; Средний балл: {2}", education, numberGroup, AverageRating);
        }
        new public object DeepCopy() //Определить перегруженную версию виртуального метода object DeepCopy()
        {
            Student student = new Student((Person)this, education, numberGroup);
            for (int i = 0; i < exams.Length; i++)
            {
                student.exams[i] = (Exam)exams[i].DeepCopy();
            }
            for (int i = 0; i < listTests.Count; i++)
            {
                student.listTests[i] = (Test)listTests[i];
            }
            return student;
        }
        public int NumberGroup //Определить свойство типа int с  методами  get  и  set для доступа  к полю с номером группы
        {
            get { return numberGroup; }
            set
            {

                if (value <= 100 || value > 599)
                {
                    throw new Exception("Обазначение групп должны включать в себя значения от 101 до 599 включительно!");
                }
            }
        }
    }
}
