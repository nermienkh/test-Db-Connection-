using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDbCon
{
    class Program
    {
        static void Main(string[] args)
        {

            using ( testEntities1  context = new testEntities1()) {
                context.Projects.Add(new Project {  ID="15", Project_Name="Project15" });
                context.Employees_.Add(new Employees_ {  ID="1111", Name="NNN",  ProjectID= "15"});
                context.SaveChanges();
            
            }

        }
    }
}
