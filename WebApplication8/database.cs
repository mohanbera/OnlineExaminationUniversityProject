using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8
{
    public class database
    {
        static string[,] students =new string[2 ,3] { {"11612306", "123", "Mohan Bera"}, {"11612307", "123", "Chandan Patel"} };
        static string[,] faculty = new string [2 ,3]{ { "123456", "123", "faculty1" }, {"1234567" , "123", "faculty2"} };
        static string currentUserName = "";
        static string currentId = "";
        static string[] availableTests = new string[50];
        static int totalTests = 0;
        static string currentTest = "";
        static int correctAnswers = 0;
        static int inCorrectAnswers = 0;
        static int totalScore = 0;
        static string[,] results = new string[100, 10];
        static int totalResult = 0;


        static String[,,] questions = new string[100,5,6];

        public database()
        {

            System.Diagnostics.Debug.WriteLine("CALLED DATABASE " + questions[0, 0, 0]);
            if(totalTests == 0)
            {

                System.Diagnostics.Debug.WriteLine("CALLED DATABASE INSIDE " + questions[0, 0, 0]);
                totalTests = 1;
                availableTests[0] = "CSE304";

                

                // 5 questions for cse 304
                questions[0, 0, 0] = "Which of the following points is/are true about Linked List data structure when it is compared with array";
                questions[0, 1, 0] = "Which of the following sorting algorithms can be used to sort a random linked list with minimum time complexity?";
                questions[0, 2, 0] = "In the worst case, the number of comparisons needed to search a singly linked list of length n for a given element is";
                questions[0, 3, 0] = "Suppose each set is represented as a linked list with elements in arbitrary order. Which of the operations among union, intersection, membership, cardinality will be the slowest?";
                questions[0, 4, 0] = "What is the time complexity of inserting at the end in dynamic arrays?";

                // their options
                questions[0, 0, 1] = "Arrays have better cache locality that can make them better in terms of performance.";
                questions[0, 0, 2] = "It is easy to insert and delete elements in Linked List";
                questions[0, 0, 3] = "Random access is not allowed in a typical implementation of Linked Lists";
                questions[0, 0, 4] = "All Of the above";

                questions[0, 0, 5] = "All Of the above";


                questions[0, 1, 1] = "Insertion sort"; questions[0, 1, 2] = "Quick sort"; questions[0, 1, 3] = "Heap sort"; questions[0, 1, 4] = "Merge sort";
                questions[0, 1, 5] = "Merge sort";

                questions[0, 2, 1] = "log2n"; questions[0, 2, 2] = "n//2"; questions[0, 2, 3] = "lo2n - 1"; questions[0, 2, 4] = "n";
                questions[0, 2, 5] = "n";

                questions[0, 3, 1] = "union only"; questions[0, 3, 2] = "intersection, membership"; questions[0, 3, 3] = "membership, cardinality"; questions[0, 3, 4] = "union, intersection";
                questions[0, 3, 5] = "union, intersection";

                questions[0, 4, 1] = "O(1)"; questions[0, 4, 2] = "O(n)"; questions[0, 4, 3] = "O(logn)"; questions[0, 4, 4] = "Either O(1) or O(n)";
                questions[0, 4, 5] = "Either O(1) or O(n)";

                System.Diagnostics.Debug.WriteLine("FIRST "+questions[0, 0, 0]);


            }
        }
        public string check(string regNo, string password)
        {
            for (int i = 0; i < 2; i++)
            {
                if (regNo == students[i, 0] && password == students[i, 1])
                {
                    currentUserName = students[i, 2];
                    currentId = students[i, 0];
                    return "student";
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (regNo == faculty[i, 0] && password == faculty[i, 1])
                {
                    currentUserName = faculty[i, 2];
                    return "faculty";
                }
            }

            return "NA";
        }

        public void setCurrentTest(string test)
        {
            currentTest = test;
        }

        public string getCurrentUsername()
        {
            return currentUserName;
        }

        public string[] getAvailableTests()
        {
            return availableTests;
        }

        public void increaseTotalTest()
        {
            totalTests = totalTests + 1;
        }


        public Boolean validTest(string test)
        {
            if (availableTests.Contains(test) || availableTests.Contains(test.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public int getCurrentTestIndex()
        {
            for (int i = 0; i < availableTests.Length; i++)
            {
                if (currentTest == availableTests[i] || currentTest.ToUpper() == availableTests[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public string[,,] getQuestion(int index)
        {
            return questions;
        }

        public string getText(int a, int b, int c)
        {
            return questions[a, b, c];
        }

        public void setText(int a, int b, int c, string text)
        {
            questions[a, b, c] = text;
        }

        public void setResult(int a, int b, int c)
        {
            correctAnswers = a;
            inCorrectAnswers = b;
            totalScore = c;

            results[totalResult, 0] = "Name: "+currentUserName;
            results[totalResult, 1] = "Reg No: " + currentId;
            results[totalResult, 2] = "Subject: " + currentTest;
            results[totalResult, 3] = "score: " + c;
            results[totalResult, 4] = "Correct: " + a;
            results[totalResult, 5] = "Incorrect: " + b;

            totalResult = totalResult + 1;
        }

        public int getCorrect()
        {
            return correctAnswers;
        }

        public int getInCorrect()
        {
            return inCorrectAnswers;
        }

        public int getResult()
        {
            return totalScore;
        }

        public int getTotalTest()
        {
            return totalTests;
        }

        public void insertCourse(string course)
        {
            availableTests[totalTests] = course;
        }

        public string[,] getResultStatus()
        {
            return results;
        }

        public int getTotalResult()
        {
            return totalResult;
        }
    }
}