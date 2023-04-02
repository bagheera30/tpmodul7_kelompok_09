using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static tpmodul7_kelompok_09.KuliahMahasiswa_1302210112;

namespace tpmodul7_kelompok_09
{
    internal class KuliahMahasiswa_1302210112
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CoursesList
        {
            public List<Course> courses { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "C:\\Users\\asus\\Documents\\latihan\\tpkpl\\tpmodul7_kelompok_09\\tpmodul7_kelompok_09\\tp7_2_1302210112.json";
            string jsonString = File.ReadAllText(filePath);
            CoursesList coursesList = JsonSerializer.Deserialize<CoursesList>(jsonString);

            Console.WriteLine("Daftar Mata Kuliah yang diambil:");
            int i = 1;
            foreach (Course course in coursesList.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }

    }
}
