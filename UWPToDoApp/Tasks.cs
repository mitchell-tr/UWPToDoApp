using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPToDoApp
{
    public class Tasks
    {
        public Dictionary<string, ToDo> TaskList = new Dictionary<string, ToDo>();

        public List<ToDo> ToList()
        {
            return TaskList.Values.ToList();
        }
    }
}
