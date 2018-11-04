using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien_HuaWang_Lab_1B_Ex03
{
    class Test
    {
        static void Main(string[] args)
        {
            LinkedList<Student> linkedLstStudent = new LinkedList<Student>();
            Student student1 = new Student(1, "Hua", "Wang");
            AddLinkedListItem(linkedLstStudent, student1);
            Student student2 = new Student(2, "Hank", "Liang");
            AddLinkedListItem(linkedLstStudent, student2);
            Student student3 = new Student(3, "Edward", "Lin");
            AddLinkedListItem(linkedLstStudent, student3);
            Student student4 = new Student(4, "Willaim", "Lin");
            AddLinkedListItem(linkedLstStudent, student4);
            Student student5 = new Student(5, "Andy", "Chen");

            AddLinkedListItem(linkedLstStudent, student5);
            Console.WriteLine($"There are currently {linkedLstStudent.Count} students:\n");
            PrintLinkedList(linkedLstStudent);
            RemoveLinkedListItem(linkedLstStudent, student3);
            Console.WriteLine($"Removing the student with id {student3.StudentId}:\n");
            PrintLinkedList(linkedLstStudent);
            Console.WriteLine("Searching for Student No 2:\n");
            Console.Write($"{ student2}Is in position: ");
            Console.WriteLine(SearchLinkedListItem(linkedLstStudent, student2));
            Console.WriteLine($"\n\nRemoving ALL students:");
            RemoveAllLinkedListItems(linkedLstStudent);
            PrintLinkedList(linkedLstStudent);
            Console.WriteLine($"The linkedlist is empty...\n");
        }

        private static void AddLinkedListItem<T>(LinkedList<T> list, T student)
        {
            list.AddLast(student);
        }

        private static void RemoveLinkedListItem<T>(LinkedList<T> list, T student)
        {
            list.Remove(student);
        }

        private static void PrintLinkedList<T>(LinkedList<T> list)
        {
            int count = 1;

            foreach (var item in list)
            {
                Console.WriteLine($"{item}\n");
                count++;
            }
        }

        private static int SearchLinkedListItem<T>(LinkedList<T> list, T student)
        {
            LinkedListNode<T> currentNode = list.Find(student);

            var count = 0;
            for (var node = list.First; node != null; node = node.Next, count++)
            {
                if (student.Equals(node.Value))
                    return count + 1;
            }
            return -1;
        }

        private static void RemoveAllLinkedListItems<T>(LinkedList<T> list)
        {
            list.Clear();
        }
    }
}
