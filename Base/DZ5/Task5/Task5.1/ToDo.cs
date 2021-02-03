using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class ToDo
    {
        public int number;

        public string Title{ get; set; }
        public bool IsDone { get; set; }
        public int Number { get; set; }

        public ToDo(string title, bool isDone, int number)
        {

             Title = title;
             IsDone = isDone;
             Number = number;


        }

        public ToDo()
        {

        }
}
}
