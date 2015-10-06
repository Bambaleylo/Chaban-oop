using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1proga
{
    interface IDateAndCopy //6
    {
        object DeepCopy();
        DateTime Date { get; set; }
    }
    enum Education //8
    {
        Specialist, Bachelor, SecondEducation
    }

}
