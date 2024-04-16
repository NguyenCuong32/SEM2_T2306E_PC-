using MauiApp3Student.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiApp3Student.Secvices
{
    internal class StudentSecvice
    {
        public StudentSecvice() 
        {
        }
        public List<Student> GetStudents() 
        {
            string path = "Resources\Styles\product.json";
            var demo = File.ReadAllText(path);
            List<Student> students = 
                JsonSerializer.Deserialize<List<Student>>(demo);
            return students;
        }
    }
}
