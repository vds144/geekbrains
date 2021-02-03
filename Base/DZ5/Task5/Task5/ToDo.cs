using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class ToDo
    {
        public string Title { get; set; }
        public int IsDone { get; set; }

        public ToDo(string title, int isDone)
        {

            Title = title;
            IsDone = isDone;
        }
    }
}
