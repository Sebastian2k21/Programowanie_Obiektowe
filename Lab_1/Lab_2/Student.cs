using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Student:Person
    {
        protected string group;
        protected List<Task> tasks;
        public string Group { get => group; set => group = value ; }


        public Student (string PersonName,int PersonAge , string PersonGroup): base( PersonName, PersonAge)
        {
            group = PersonGroup;
        }

        public Student(string PersonName, int PersonAge, string PersonGroup, List<Task> tasks1 ) : base(PersonName, PersonAge)
        {
            tasks = tasks1;
        }

        public void AddTask (string taskName, TaskStat taskStatus)
        {
            var task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }

        public void  RemoveTask(int index) => tasks.RemoveAt(index);

        public void UpdateTask(int index , TaskStat taskStatus)
        

        
    }
}
