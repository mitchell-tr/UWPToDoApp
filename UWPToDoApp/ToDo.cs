using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPToDoApp
{
    public class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Pritority { get; set; }
        public DateTime createDate { get; set; }
        public DateTime completeDate { get; set; }

        public ToDo(string name, string description, Priority priority, DateTime complete)
        {
            Name = name;
            Description = description;
            createDate = DateTime.Now;
            this.Pritority = priority;
            completeDate = complete;
        }
    }
}
