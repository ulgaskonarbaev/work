using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleApp1
{
    internal class Project
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime CompletionData { get; set; }

        public string Status { get; set; }

        public int Priority { get; set; }

        public List<Task> Tasks { get; set; }



    }
}
