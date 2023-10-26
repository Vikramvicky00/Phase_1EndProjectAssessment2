using System;
using System.Collections.Generic;
using System.IO;

namespace Phase1EndProject2
{
    public class TeacherManagement
    {

        private const string FilePath = @"D:\Practice Exercises\.Net\Phase-1 Agile, Git, and Basics of C# Programming\Phase1EndProject2\System_For_Storing_and_Updating_Teacher_Records\Phase1EndProject2\TeacherData.txt";

        public static void SaveTeacherData(List<Teacher> teachers)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Teacher teacher in teachers)
                {
                    writer.WriteLine($"{teacher.ID},{teacher.Name},{teacher.Class},{teacher.Section}");
                }
            }
        }

        public static List<Teacher> LoadTeacherData()
        {
            List<Teacher> teachers = new List<Teacher>();

            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string teacherClass = parts[2];
                            string section = parts[3];

                            teachers.Add(new Teacher
                            {
                                ID = id,
                                Name = name,
                                Class = teacherClass,
                                Section = section
                            });
                        }
                    }
                }
            }

            return teachers;
        }


        public static void UpdateTeacherData(List<Teacher> teachers)
        {
            Console.Write("\nEnter Teacher ID to update: ");
            int idToUpdate = int.Parse(Console.ReadLine());

            Teacher teacherToUpdate = teachers.Find(t => t.ID == idToUpdate);
            if (teacherToUpdate == null)
            {
                Console.WriteLine("Teacher with specified ID not found.");
                return;
            }

            Console.Write("Enter updated Teacher Name: ");
            teacherToUpdate.Name = Console.ReadLine();

            Console.Write("Enter updated Class: ");
            teacherToUpdate.Class = Console.ReadLine();

            Console.Write("Enter updated Section: ");
            teacherToUpdate.Section = Console.ReadLine();

            Console.WriteLine("Teacher data updated successfully!");
        }


       public static void DisplayAllTeachers(List<Teacher> teachers)
        {
            Console.WriteLine("\nAll Teachers:");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.ID}, Name: {teacher.Name}, Class: {teacher.Class}, Section: {teacher.Section}");
            }
        }

       public static void AddNewTeacher(List<Teacher> teachers)
        {
            Console.Write("\nEnter Teacher ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Teacher Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Class: ");
            string teacherClass = Console.ReadLine();

            Console.Write("Enter Section: ");
            string section = Console.ReadLine();

            teachers.Add(new Teacher
            {
                ID = id,
                Name = name,
                Class = teacherClass,
                Section = section
            });

            Console.WriteLine("Teacher data added successfully!");
        }

    }
}
