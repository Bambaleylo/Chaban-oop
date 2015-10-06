using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1proga
{
    class Test
    {
        string name; //11
        bool resultTest; //11
        string rt= "Незачет"; //Для того чтобы в конце не выводилось true\false, а зачет\незачет
        public Test(string name, bool resultTest) //Конструктор c параметрами типа string и bool для инициализации свойств класса
        {
            this.name = name;
            this.resultTest = resultTest;
            if (resultTest == true)
            {
                rt = "Зачет";
            }
        }
        public Test() //Конструктор  без параметров, инициализирующий все свойства класса некоторыми значениями по умолчанию
        {
            name = "ООП";
            resultTest = true;
            rt = "Зачет";
        }
        public override string ToString() //Перегруженная  версия  виртуального  метода  string  ToString()  для формирования строки со значениями всех свойств класса
        {
            return string.Format("По предмету: {0} - {1}", name, rt);
        }
        public object DeepCopy() //Реализовать интерфейс IDateAndCopy
        {
            Test test = new Test(name, resultTest);
            return test;
        }
    }
}
