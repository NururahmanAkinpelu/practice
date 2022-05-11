using System;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ReturnLongestWord();
            //string[] attendance = { "P", "P", "A", "L", "L", "L" };
            //AttendanceAward(attendance);
            int[] statues = { 0, 3};
            Solution(statues);
          
        }
        static int Solution(int[] statues)
        {
            Array.Sort(statues);
            int result = 0;
            for (int i = 1; i < statues.Length; i++)
            {
                result += (statues[i] - statues[i - 1] - 1);
            }

            return result;

        }


        ////1
        //static void AttendanceAward(string[] attendance)
        //{
        //    bool eligible = false;
        //    int countA = 0;
        //    int countL = 0;

        //    for (int i = 0; i < attendance.Length; i++)
        //    {
        //        if (attendance[i] == "A") countA++;
        //        if (attendance[i] == attendance[i + 1] && attendance[i] == attendance[i+2]) countL++;
        //    }
        //    if (countA < 2 && countL < 3) eligible = true;
        //    else eligible = false;

        //    Console.WriteLine(eligible);
        //}

        ////2
        //static void RemoveCharacter(string firststring, string x)
        //{
        //    Console.WriteLine(firststring.Replace(x, ""));
        //}

        //3
        //static void ReturnLongestWord()
        //{
        //    string words;
        //    string[] arrayofwords;
        //    int count = 0;
        //    int length;
        //    int longest = 0;
        //    string longestword;

        //    Console.Write("Enter words: ");
        //    words = Console.ReadLine();
        //    arrayofwords = words.Split();
        //    longestword = arrayofwords[0];
        //    length = arrayofwords.Length;

        //    for (int i = 0; i < length; i++)
        //    {
        //        if(arrayofwords[i].Length> longest)
        //        {
        //            longest = arrayofwords[i].Length;
        //            longestword = arrayofwords[i];
        //            count = i;
        //        }
        //    }
        //    Console.WriteLine("The longest word is '{0}'",longestword);
        //}
    }
}
