using System;

namespace BootcampCurriculum
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitgithub = new Topic();
            gitgithub.Name = "Git/GitHub";
            gitgithub.Category = "SCM"; // source control management
            gitgithub.Difficulty = 3;
            gitgithub.Print();

            var sql = new Topic();
            sql.Name = "SQL";
            sql.Category = "Database Management";
            sql.Difficulty = 2;
            sql.Print();

            var csharp = new Topic();
            csharp.Name = "C#";
            csharp.Category = "General Purpose Language";
            csharp.Difficulty = 1;
            csharp.Print();

            //another way to initialize properties without using constructor
            var java = new Topic //() optional here
            {
                Name = "Java",
                Category = "General Purpose Language",
                Difficulty = 1

            };
            java.Print();
        }
    }
}
