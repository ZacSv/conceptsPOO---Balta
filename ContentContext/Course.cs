using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPOO.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }
        public string TagCourse { get; set; }
        public IList<Module> Modules{ get; set; }

        public class Module
        {
            public Module()
            {
                Lectures = new List<Lecture>();
            }
            public int Order { get; set; }
            public string Tittle { get; set; }
            IList<Lecture> Lectures { get; set; }
        }

        public class Lecture
        {
            public int Order { get; set; }
            public string Tittle { get; set; }
        }
    }
    }
