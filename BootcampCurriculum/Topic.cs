using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCurriculum
{
    class Topic
    {
      private static int NextId { get; set; } = 1;
      public int Id { get; private set; } //can change visibility/access on reading AND editing data
      public string Name { get; set; }
      public string Category { get; set; }
      public int Difficulty { get; set; }
   
      public void Print()
    {
        Console.WriteLine($"{Id} | {Name} | {Category} | {Difficulty}");
    }

        public Topic()
        {
            this.Id = NextId++;
           // NextId = NextId++;  did this first, but when incrementing, just need the line above, other increments add this
        }  

    }

}
