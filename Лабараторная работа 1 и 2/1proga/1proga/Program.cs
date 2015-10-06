using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1proga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Один  объект  типа  Student,  преобразовать  данные  в  текстовый вид с помощью метода ToShortString() и вывести данные"); //18.1
            Console.WriteLine();
            Student student = new Student();
            Console.WriteLine(student.ToShortString());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Присвоить    значения    всем    определенным    в    типе    Student    свойствам, преобразовать    данные   в   текстовый   вид    с    помощью   метода    ToString()    и вывести данные; C  помощью  метода  AddExams(params  Exam[])   добавить  элементы  в список  экзаменов  и  вывести  данные  объекта  Student,  используя  метод ToString()");//18.2.3
            Console.WriteLine();
            student.AddExam(new Exam());
            student.NumberGroup = 230;
            student.surname = "Чабан";
            student.name = "Юрий";
            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.ReadLine();
            
            Console.WriteLine("Создать  два  объекта  типа    Person    с  совпадающими  данными  и  проверить,  что ссылки на объекты не равны, а объекты равны, вывести значения хэш-кодов для объектов. "); //18,4
            Console.WriteLine();
            Person a = new Person();
            Person b = new Person();
            Console.WriteLine(a.GetHashCode() + " " + b.GetHashCode());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Создать   объект    типа    Student,    добавить    элементы    в    список    экзаменов  и зачетов. Вывести значение свойства типа Person для объекта типа Student"); //18,5,6
            Console.WriteLine();
            Student student2 = new Student();
            student.AddExam(new Exam("Физика", 3, new DateTime(2015, 01, 15)));
            student.AddExam(new Exam("История", 4, new DateTime(2015, 01, 10)));
            student.AddExam(new Exam("Философия", 4, new DateTime(2015, 01, 5)));
            Console.WriteLine(student2.ToString());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("С   помощью    метода   DeepCopy()    создать    полную    копию    объекта    Student. Изменить  данные  в  исходном  объекте  Student  и  вывести  копию  и исходный объект, полная копия исходного объекта должна остаться без изменений");//18,7
            Console.WriteLine();
            Student student3 = (Student)student2.DeepCopy();
            student2.name = "Мустафа";
            Console.WriteLine(student2.ToString()); //Измененная
            Console.WriteLine(student3.ToString()); //Полная копия
            Console.WriteLine();
            Console.ReadLine();
            
            Console.WriteLine("В блоке    try/catch    присвоить    свойству    с    номером    группы    некорректное значение,  в  обработчике   исключения   вывести   сообщение,  переданное через объект-исключение");//18,8
            Console.WriteLine();
            try
            {
                student.NumberGroup = 1;
                Console.WriteLine("Введено: " + student.NumberGroup);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.ReadLine();
            
            Console.WriteLine("С  помощью  оператора  foreach  вывести список всех зачетов и экзаменов"); //18,9
            Console.WriteLine();
            foreach (Exam e in student.Exams)
            {
                Console.WriteLine(e.ToString());
            }
            foreach (Test t in student.ListTests)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("С  помощью  оператора  foreach  для  итератора  с  параметром вывести  список  всех  экзаменов  с оценкой выше 3");//18,10
            Console.WriteLine();
            for (int i = 0; i < student.Exams.Length; i++)
            {
                if (student.Exams[i].rating > 3)
                    Console.WriteLine(student.Exams[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
