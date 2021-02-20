﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_1.Linq_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Запрос 1:--");
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                select student;
            //var studentQueryW = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80);

            foreach (Student student in studentQuery)
            {
                Console.WriteLine($"{student.Last}, {student.First}");
            }

            Console.WriteLine("\n--Запрос 2:--");
            int studentCount = (
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                select student).Count();

            var studentCountW = students.Where(st => st.Scores[0] > 90 && st.Scores[3] < 80).Count();

            Console.WriteLine($"Количество студентов: {studentCount}, {studentCountW}");

            Console.WriteLine("\n--Запрос 3:--");
            var studentList = (
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.Scores[0] descending
                select student).ToList();

            foreach (Student student in studentList)
            {
                Console.WriteLine($"{student.Last}, {student.First}, {student.Scores[0]}");
            }

            Console.WriteLine("\n--Запрос 4:--");
            var studentQuery2 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine($"{student.Last}, {student.First}");
                }
            }

            Console.WriteLine("\n--Запрос 5:--");
            var studentQuery3 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery3)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine($"{student.Last}, {student.First}");
                }
            }

            Console.WriteLine("\n--Запрос 6:--");
            var studentQuery4 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            foreach (var studentGroup in studentQuery4)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine($"{student.Last}, {student.First}");
                }
            }

            Console.WriteLine("\n--Запрос 7:--");
            var studentQuery5 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;

            foreach (string student in studentQuery5)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n--Запрос 8:--");
            var studentQuery6 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select totalScore;

            double averageScore = studentQuery6.Average();
            Console.WriteLine($"Class average score = {averageScore}");

            Console.WriteLine("\n--Запрос 9:--");
            IEnumerable<string> studentQuery7 =
                from student in students
                where student.Last == "Garcia"
                select student.First;

            Console.WriteLine("The Garcias in the class are:");
            foreach (string student in studentQuery7)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n--Запрос 10:--");
            var studentQuery8 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where totalScore > averageScore
                select new { id = student.ID, score = totalScore };

            foreach (var student in studentQuery8)
            {
                Console.WriteLine($"Student ID: {student.id}, Score: {student.score}");
            }
        }

        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores = new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores = new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores = new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores = new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores = new List<int> {35, 72, 91, 70}},
            new Student {First="Martin", Last="Brown", ID=116, Scores = new List<int> {98, 66, 67, 77}},
        };
    }
}
