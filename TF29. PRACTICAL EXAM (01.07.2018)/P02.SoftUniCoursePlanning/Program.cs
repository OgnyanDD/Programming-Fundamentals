using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SoftUniCoursePlanning
{
    class Program
    {
        static List<string> course = new List<string>();

        static void Main(string[] args)
        {
            course = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "course start") { break; }

                string[] tokens = input.Split(':');
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        Add(tokens[1]);
                        break;
                    case "Insert":
                        Insert(tokens[1], int.Parse(tokens[2]));
                        break;
                    case "Remove":
                        Remove(tokens[1]);
                        break;
                    case "Swap":
                        Swap(tokens[1], tokens[2]);
                        break;
                    case "Exercise":
                        Exercise(tokens[1]);
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, course[i]);
            }
        }

        static void Add(string lessonTitle)
        {
            if (course.Contains(lessonTitle) == false)
            {
                course.Add(lessonTitle);
            }
        }

        static void Insert(string lessonTitle, int index)
        {
            bool existsLesson = course.Contains(lessonTitle);
            bool isValidIndex = index >= 0 && index <= course.Count;
            if (existsLesson == false && isValidIndex)
            {
                course.Insert(index, lessonTitle);
            }
        }

        static void Remove(string lessonTitle)
        {
            int lessonIndex = course.IndexOf(lessonTitle);
            if (course.Contains(lessonTitle))
            {
                course.RemoveAt(lessonIndex);
                // Check if has exercise
                if (FollowsExercise(lessonTitle, lessonIndex + 1))
                {
                    // If yes - remove exercise as well
                    course.RemoveAt(lessonIndex + 1);
                }
            }
        }

        static void Swap(string firstLesson, string secondLesson)
        {
            string firstExercise = $"{firstLesson}-Exercise";
            string secondExercise = $"{secondLesson}-Exercise";

            if (course.Contains(firstLesson) && course.Contains(secondLesson))
            {
                // First swap lessons
                int firstIndex = course.IndexOf(firstLesson);
                int secondIndex = course.IndexOf(secondLesson);

                string tempLesson = course[firstIndex];
                course[firstIndex] = course[secondIndex];
                course[secondIndex] = tempLesson;

                // Swap exercises, if any
                if (course.Contains(firstExercise))
                {
                    course.Remove(firstExercise);
                    firstIndex = course.IndexOf(firstLesson);
                    course.Insert(firstIndex + 1, firstExercise);
                }
                if (course.Contains(secondExercise))
                {
                    course.Remove(secondExercise);
                    secondIndex = course.IndexOf(secondLesson);
                    course.Insert(firstIndex + 1, secondExercise);
                }
            }

        }

        static void Exercise(string lessonTitle)
        {
            // Add exercise to existing lesson
            int lessonIndex = course.IndexOf(lessonTitle);
            if (lessonIndex >= 0)
            {
                string exerciseTitle = $"{lessonTitle}-Exercise";
                // Check if exercise already exists
                if (FollowsExercise(lessonTitle, lessonIndex + 1) == false)
                {
                    course.Insert(lessonIndex + 1, exerciseTitle);
                }
            }
            // Non-existing lesson - add both lesson and exercise
            else
            {
                string exerciseTitle = $"{lessonTitle}-Exercise";
                course.Add(lessonTitle);
                course.Add(exerciseTitle);
            }
        }

        static bool FollowsExercise(string lessonTitle, int candidateIndex)
        {
            bool result = false;
            // Check if index is within
            if (candidateIndex < course.Count)
            {
                // Extract next title to check if same lesson
                string exerciseTitle = course[candidateIndex].Split('-')[0];
                if (exerciseTitle == lessonTitle)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}