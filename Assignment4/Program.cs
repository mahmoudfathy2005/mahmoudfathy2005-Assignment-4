namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] sessionNames =
            {
                    "C# Basics",
                    "Arrays",
                    "Functions",
                    "Date and Time",
                    "Exception Handling"
            };


            DateTime[] sessionDates =
            {
                new DateTime(2026, 9, 10, 18, 0, 0),
                new DateTime(2026, 9, 13, 18, 0, 0),
                new DateTime(2026, 9, 17, 18, 0, 0),
                new DateTime(2026, 9, 20, 18, 0, 0),
                new DateTime(2026, 9, 24, 18, 0, 0)
            };

            int[] sessionDurations =
            {
                    180,
                    240,
                    180,
                    240,
                    180
            };

            #region  Display All Sessions
            // Part2
            DisplaySessions(sessionNames, sessionDates, sessionDurations);
            Console.WriteLine("-----------------------------------------");

            //// Part3
            //DisplaySessionDetails("Functions", sessionNames, sessionDates, sessionDurations);
            //DisplaySessionDetails("Mahmoud", sessionNames, sessionDates, sessionDurations);
            #endregion

            #region part 4 => sort And reverse


            //var copy = new string[sessionNames.Length];
            //Array.Copy(sessionNames, copy, sessionNames.Length);
            //Array.Sort(copy);
            //foreach(var session in copy)
            //{
            //    Console.WriteLine(session);
            //}
            //Console.WriteLine("--------------------------------------");

            //// reverse
            //Array.Reverse(copy);

            //foreach (var session in copy)
            //{
            //    Console.WriteLine(session);
            //}
            #endregion

            #region Find Session Index &  Check if a Session Exists

            //Console.WriteLine("Enter session name ");
            //var session = Console.ReadLine();

            //int index = Array.IndexOf(sessionNames, session);
            //if (index == -1)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    Console.WriteLine($"Index of session {index}");

            //}

            // Exit

            //var exit = Array.Exists(sessionNames,x => x == session);
            //if (exit)
            //{
            //    Console.WriteLine("Session exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Session does not exist");
            //}



            #endregion

            #region 4.7 Copy an Array

            //var copyArray = new string[sessionNames.Length];
            //Array.Copy(sessionNames,copyArray, sessionNames.Length);
            //copyArray[0] = "Mahmoud";

            //Console.WriteLine("Original Array ");
            //Console.WriteLine($" {sessionNames[0]}");

            //Console.WriteLine("Copy Array ");
            //Console.WriteLine($" {copyArray[0]}");


            #endregion

            #region Part 5 — Duration Analysis
            // OperationOfDuration(sessionDurations);

            //SortDuration(sessionDurations);

            #endregion









        }

        static void DisplaySessions(string[] names, DateTime[] dates, int[] durations)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
                Console.WriteLine($"Date:       {dates[i]:dd MMMM yyyy}");
                Console.WriteLine($"Start Time: {dates[i]:hh:mm tt}");
                Console.WriteLine($"Duration:   {durations[i]} minutes");
            }
        }

        static void DisplaySessionDetails(string name , string[] names, DateTime[] dates, int[] durations)
        {
            int inx = Array.IndexOf(names, name);
            if( inx == -1 )
                Console.WriteLine("Not Found");
            else
            {
                Console.WriteLine($"{inx + 1}. {names[inx]}");
                Console.WriteLine($"Date:       {dates[inx]:dd MMMM yyyy}");
                Console.WriteLine($"Start Time: {dates[inx]:hh:mm tt}");
                Console.WriteLine($"Duration:   {durations[inx]} minutes");

            }


            

        }

        static void OperationOfDuration(int[] durations)
        {
            int sum = 0;
            Double avg;
            int shortest = durations[0];
            int longest = durations[0];

            for (int i = 0; i < durations.Length; i++)
            {
                sum = sum + durations[i];
                if (durations[i] > shortest)
                {
                    shortest = durations[i];
                }
                if (durations[i] < shortest)
                {
                    shortest = durations[i];
                }
            }
            avg = sum / durations.Length;

            Console.WriteLine($"Total Duration: {sum} minutes");
            Console.WriteLine($"Average Duration: {avg} minutes");
            Console.WriteLine($"Shortest Duration: {shortest} minutes");
            Console.WriteLine($"Longest Duration:  {longest} minutes");
        }

        static void SortDuration(int[] durations) { 
            var sortArray= new int[durations.Length];
            Array.Copy(durations, sortArray, durations.Length);

            Array.Sort(sortArray);

            foreach(var  duration in sortArray)
            {
                Console.WriteLine(duration);
            }
        
        
        }

    }
}
