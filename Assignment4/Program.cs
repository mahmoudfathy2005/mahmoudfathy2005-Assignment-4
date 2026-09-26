using BenchmarkDotNet.Running;
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Text;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Part 7 — ref, out, and Reference-Type Parameters
            // 7.1 ref

            //int number = 20;
            //Console.WriteLine(number);
            //ChangValue(ref number);
            //Console.WriteLine(number);

            // 7.2 out

            //Console.WriteLine("Enter session:");
            //string? name = Console.ReadLine();

            //int index;
            //int duration;

            //OutDisplay(name,sessionNames,sessionDurations, out index, out duration);

            //if (index == -1) {
            //    Console.WriteLine("Not found ");
            //}
            //else
            //{
            //    Console.WriteLine($" Index: {index}");
            //    Console.WriteLine($" Duration: {duration} minutes");
            //}


            //  7.3 Reference Type Without ref


            //int[] Arr = { 10, 20, 30 };
            //Console.WriteLine($"Berfor : {Arr[0]} ");

            //ChangRefrenceValue(Arr);
            //Console.WriteLine($"After : {Arr[0]} ");





            #endregion

            #region Part 8 — params Keyword
            //CalculateTotalDuration(10, 20, 500);
            //CalculateTotalDuration(10, 200, 100);


            #endregion

            #region Part 9 — Session Date Details

            //Console.WriteLine("Enter session ");
            //string? name = Console.ReadLine();

            //SearchSessions(name,sessionNames,sessionDates, sessionDurations);


            #endregion

            #region Part 10 — Date Difference

            //Console.WriteLine("Enter session 1: ");
            //string? S1 = Console.ReadLine();
            //Console.WriteLine("Enter session 2: ");
            //string? S2 = Console.ReadLine();

            //DiffrenceSession(S1,S2,sessionNames, sessionDates);



            #endregion

            #region Part 11 — Past and Upcoming Sessions

            //DateTime dateTime = DateTime.Now;
            //for (int i = 0; i < sessionDates.Length; i++) {
            //    string status = sessionDates[i] < dateTime ? "Past" : "Upcoming";
            //    Console.WriteLine($"{sessionNames[i] } : {status}");
            //}

            #endregion

            #region Part 12 — Find the Next Session
            //NextSession(sessionNames, sessionDates);
            #endregion

            #region Part 13 — Date Formatting

            //Console.WriteLine($"session : {sessionNames[2]} ");
            //Console.WriteLine($"{sessionDates[2]:yyyy-MM-dd}  ");
            //Console.WriteLine($"{sessionDates[2]:dd/MM/yyyy} ");
            //Console.WriteLine($"{sessionDates[2]:dd MMMM yyyy}  ");
            //Console.WriteLine($"{sessionDates[2]:dddd,dd MMMM yyyy}  ");
            //Console.WriteLine($"{sessionDates[2]:hh:mm tt} ");


            #endregion

            #region Part 14 — Read and Validate a Date

            //  DateTime dateTime = ReadSessionDate();

            #endregion

            #region Part 15 — Exception Handling: Menu Input
            //while (true) {
            //    try
            //    {
            //        Console.WriteLine("enter number 1 to 10 ");
            //        int num=int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch(FormatException) 
            //    {
            //        Console.WriteLine("Enter valied number ");
            //    }


            //}


            #endregion

            #region Part 16 — Exception Handling: Invalid Array Index
            //try
            //{
            //    Console.WriteLine("Enter session index:");
            //    int index = int.Parse(Console.ReadLine());
            //    var session = sessionNames[index];
            //    Console.WriteLine(session);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("The selected session index is out of range.");
            //}

            #endregion

            #region Part 17 — Throw an Exception
            //Console.WriteLine("Enter duration:");
            //int duration = int.Parse(Console.ReadLine() ?? "") ;
            //try
            //{
            //    vailDuration(duration);
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Duration must be greater than zero.");
            //}


            #endregion

            #region Part 18 — finally
            //Console.WriteLine("Enter duration:");
            //int duration = int.Parse(Console.ReadLine() ?? "");
            //try
            //{
            //    vailDuration(duration);
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Duration must be greater than zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Input operation finished.");
            //}

            #endregion

            #region Part 19 — Build a Schedule Report Using string
            //BuildReportUsingString(sessionNames,sessionDates ,sessionDurations);


            #endregion

            #region Part 20 — Build the Same Report Using StringBuilder
            //BuildReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations);

            #endregion


            #region  art 21 — BenchmarkDotNet
            BenchmarkRunner.Run<StringBenchmark>();


            #endregion

            #region 


            #endregion

            #region 


            #endregion

            #region 


            #endregion

            #region 


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

        static void SearchSessions(string? name, string[] names, DateTime[] dates, int[] durations)
        {
            int index = Array.IndexOf(names, name);
            Console.WriteLine($"Date : {dates[index]:dd MMMM yyyy}");
            Console.WriteLine($"Day  : {dates[index].DayOfWeek}");
            Console.WriteLine($"Year  : {dates[index].Year}");
            Console.WriteLine($"Month : {dates[index].Month}");
            Console.WriteLine($"DayNumber  : {dates[index]:dd}");
            Console.WriteLine($"StatTime  : {dates[index]:hh :mm tt}");
            Console.WriteLine($"Duration : {durations[index]}");
            Console.WriteLine($"Duration : {dates[index].AddMinutes(durations[index]):hh:mm tt}");





        }

        static void DisplaySessionDetails(string name, string[] names, DateTime[] dates, int[] durations)
        {
            int inx = Array.IndexOf(names, name);
            if (inx == -1)
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

        static void SortDuration(int[] durations)
        {
            var sortArray = new int[durations.Length];
            Array.Copy(durations, sortArray, durations.Length);

            Array.Sort(sortArray);

            foreach (var duration in sortArray)
            {
                Console.WriteLine(duration);
            }


        }

        static void ChangValue(ref int number)
        {
            number *= 10;


        }

        static (int index, int duration) OutDisplay(string? name, string[] names, int[] durations, out int index, out int duration)
        {
            index = Array.IndexOf(names, name);
            if (index == -1)
            {
                return (index, duration = 0);
            }

            return (index, duration = durations[index]);


        }

        static void ChangRefrenceValue(int[] arr)
        {
            arr[0] = 1000;


        }

        static void CalculateTotalDuration(params int[] Duration)
        {
            int sum = 0;
            foreach (var duration in Duration)
            {

                sum += duration;
            }

            Console.WriteLine($"TotalDuration : {sum}");

        }

        static void DiffrenceSession(string? S1, string S2, string[] names, DateTime[] dates)
        {
            int inx1=Array.IndexOf(names, S1);
            int inx2=Array.IndexOf(names, S2);

            TimeSpan diff = dates[inx2] - dates[inx1];
            Console.WriteLine("Difference: ");
            Console.WriteLine($"{diff.Days} days");
            Console.WriteLine($"{diff.Hours} hours");
        }

        static void NextSession(string[] names, DateTime[] dates)
        {
            DateTime now = DateTime.Now;
            DateTime nearstDate = DateTime.MaxValue;
            int nearstIndex = -1;
            for (int i = 0; i < dates.Length; i++)
            {
                if ( dates[i]  >now & dates[i] < nearstDate)
                {
                    nearstIndex = i;
                    nearstDate = dates[i];

                }
               
            }
            TimeSpan remaining = nearstDate - now;
            Console.WriteLine("Next Session:");
            Console.WriteLine($"{names[nearstIndex]} :");
            Console.WriteLine($"{nearstDate:dd MMMM yyyy}");
            Console.WriteLine($"{nearstDate:hh :mm tt}");
            Console.WriteLine($"Time Remaining:");
            Console.WriteLine($"{remaining.Days} days");
            Console.WriteLine($"{remaining.Hours} hours");
            



        }

        static DateTime ReadSessionDate()
        {
            const string format = "yyyy-MM-dd HH:mm";

            while (true)
            {
                Console.Write(
                    $"Enter date ({format}): ");

                string input =
                    Console.ReadLine() ?? "";

                if (DateTime.TryParseExact(
                    input,
                    format,
                    null,
                    DateTimeStyles.None,
                    out DateTime result))
                {
                    return result;
                }

                Console.WriteLine(
                    "Invalid date.");
            }
        }

        static void vailDuration(int duration) { 
            if (duration < 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine("Duration accepted.");
        
        
        }

        static string BuildReportUsingString(string[] names,DateTime[] dates, int[] durations)
        {
            string result = "";

            for (int i = 0; i < names.Length; i++)
            {
                result +=
                    $"{names[i]} - " +
                    $"{dates[i]:dd/MM/yyyy hh:mm tt} - " +
                    $"{durations[i]} minutes";

                if (i < names.Length - 1)
                {
                    result += Environment.NewLine;
                }
            }

            return result;
        }

        static string BuildReportUsingStringBuilder(string[] names, DateTime[] dates,int[] durations)
        {
            StringBuilder result =
                new StringBuilder();

            for (int i = 0; i < names.Length; i++)
            {
                result.Append(
                    $"{names[i]} - " +
                    $"{dates[i]:dd/MM/yyyy hh:mm tt} - " +
                    $"{durations[i]} minutes");

                if (i < names.Length - 1)
                {
                    result.AppendLine();
                }
            }

            return result.ToString();
        }

    }
}





//#region  sol

//28.Menu + FormatException

//المطلوب هنا تحديدًا استخدام:

//int.Parse()

//داخل try/catch، وليس TryParse.

//try
//{
//    return int.Parse(
//        Console.ReadLine() ?? "");
//}
//catch (FormatException)
//{
//    Console.WriteLine(
//        "Invalid menu option. Enter a number.");
//}

//وبنفضل في loop.

//29. IndexOutOfRangeException

//المطلوب المستخدم يدخل index، ولو index غير صحيح نمسك:

//IndexOutOfRangeException

//مثلاً:

//int index =
//    int.Parse(Console.ReadLine() ?? "");

//Console.WriteLine(names[index]);

//لو المستخدم كتب:

//100

//هيحصل exception.

//فنستخدم:

//catch (IndexOutOfRangeException)
//{
//    Console.WriteLine(
//        "The selected session index is out of range.");
//}
//30. throw +ArgumentException

//المطلوب لو duration أقل من أو تساوي صفر نعمل throw.

//static void ValidateSessionDuration(
//    int duration)
//{
//    if (duration <= 0)
//    {
//        throw new ArgumentException(
//            "Duration must be greater than zero.");
//    }
//}

//وبعدين:

//try
//{
//    ValidateSessionDuration(duration);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//31. finally

//المطلوب إن finally يشتغل سواء العملية نجحت أو حصل exception.

//finally
//{
//    Console.WriteLine(
//        "Input operation finished.");
//}

//يعني سواء:

//Duration accepted.

//أو:

//Duration must be greater than zero.

//في الآخر:

//Input operation finished.
//32. String Concatenation Report

//المطلوب report باستخدام string concatenation.

//static string BuildReportUsingString(
//    string[] names,
//    DateTime[] dates,
//    int[] durations)
//{
//    string result = "";

//    for (int i = 0; i < names.Length; i++)
//    {
//        result +=
//            $"{names[i]} - " +
//            $"{dates[i]:dd/MM/yyyy hh:mm tt} - " +
//            $"{durations[i]} minutes";

//        if (i < names.Length - 1)
//        {
//            result += Environment.NewLine;
//        }
//    }

//    return result;
//}

//المهم هنا إننا داخل loop بنعمل +=.

//33. StringBuilder Report

//نفس النتيجة لكن باستخدام:

//StringBuilder

//static string BuildReportUsingStringBuilder(
//    string[] names,
//    DateTime[] dates,
//    int[] durations)
//{
//    StringBuilder result =
//        new StringBuilder();

//    for (int i = 0; i < names.Length; i++)
//    {
//        result.Append(
//            $"{names[i]} - " +
//            $"{dates[i]:dd/MM/yyyy hh:mm tt} - " +
//            $"{durations[i]} minutes");

//        if (i < names.Length - 1)
//        {
//            result.AppendLine();
//        }
//    }

//    return result.ToString();
//}

//الـ output لازم يكون equivalent للـ string version.

//34. الـ Menu

//الـ assignment محدد menu من 1 إلى 16 بالإضافة لـ 0 للخروج، والـ menu لازم يفضل شغال في loop ويستخدم switch.

//الفكرة:

//while (true)
//{
//    DisplayMenu();

//    int option = ReadMenuOption();

//    switch (option)
//    {
//        case 1:
//            ...
//            break;

//        case 2:
//            ...
//            break;

//        // ...

//        case 0:
//            return;

//        default:
//            Console.WriteLine("Unknown option.");
//            break;
//    }
//}

//وده بيحقق كمان requirement:

//while
//switch
//if
//functions
//user input.
//35.BenchmarkDotNet

//الجزء ده منفصل عن التطبيق الأساسي. الـ assignment يطلب BenchmarkDotNet، وMemoryDiagnoser، وiterations:

//100
//1000
//10000
//100000

//مع مقارنة:

//String concatenation
//StringBuilder

//الكود الموجود:

//[MemoryDiagnoser]
//public class StringBenchmark
//{
//    [Params(100, 1000, 10000, 100000)]
//    public int Iterations;

//    [Benchmark]
//    public string StringConcatenation()
//    {
//        string result = "";

//        for (int i = 0; i < Iterations; i++)
//        {
//            result +=
//                "Academy Schedule Analyzer";
//        }

//        return result;
//    }

//    [Benchmark]
//    public string StringBuilderConcatenation()
//    {
//        StringBuilder result =
//            new StringBuilder();

//        for (int i = 0; i < Iterations; i++)
//        {
//            result.Append(
//                "Academy Schedule Analyzer");
//        }

//        return result.ToString();
//    }
//}

//مهم: متحطش Console.WriteLine داخل الـ benchmark loop، ومتستخدمش Stopwatch؛ الassignment مانع الاثنين.

//36. BENCHMARK.md

//هنا في حاجة مينفعش نختلقها.

//الassignment بيطلب نتائج Benchmark على جهازك الحقيقي، وبعدين تجاوب:

//مين أسرع عند 100؟
//مين أسرع عند 100000؟
//مين بيعمل allocations أكتر؟
//ماذا يحدث عندما يزيد عدد الـ iterations؟
//لماذا concatenation بيعمل allocations؟
//لماذا StringBuilder غالبًا أفضل في التكرار الكبير؟
//هل StringBuilder دائمًا أفضل؟

//لذلك الملف المرفق فيه مكان لهذه الإجابات، لكن الأرقام لازم تطلع من تشغيل benchmark على جهازك. مينفعش أحط أرقام وهمية وأقول إنها نتائج جهازك.

//والاستنتاج المفاهيمي المطلوب:

//string في C# immutable، وبالتالي عمليات concatenation المتكررة يمكن أن تنتج strings جديدة.

//StringBuilder مصمم لتجميع النصوص المتعددة التعديلات بكفاءة أكبر.

//لكن مش معنى كده إن StringBuilder دائمًا أسرع؛ الassignment نفسه يطلب منك مناقشة ذلك بناءً على benchmark الفعلي.

//37. LeetCode — Valid Anagram

//المطلوب حل accepted وفهم:

//length difference
//frequency counting
//time complexity
//space complexity

//الحل الموجود في المشروع:

//public bool IsAnagram(string s, string t)
//{
//    if (s.Length != t.Length)
//        return false;

//    int[] count = new int[26];

//    for (int i = 0; i < s.Length; i++)
//    {
//        count[s[i] - 'a']++;
//        count[t[i] - 'a']--;
//    }

//    for (int i = 0; i < count.Length; i++)
//    {
//        if (count[i] != 0)
//            return false;
//    }

//    return true;
//}
//الفكرة

//لو:

//s = "anagram"
//t = "nagaram"

//كل character له frequency.

//نزود من الأولى:

//count[s[i] - 'a']++;

//وننقص من الثانية:

//count[t[i] - 'a']--;

//لو كل القيم رجعت صفر، يبقى نفس الحروف بنفس الـ frequencies.

//التعقيد:

//Time: O(n)
//Space: O(1)

//لأن array حجمها ثابت 26 في حدود المسألة.

//38. LeetCode — GCD of Strings

//المطلوب فهم:

//repeated pattern
//no common divisor
//greatest pattern
//time/space complexity

//الحل:

//public string GcdOfStrings(
//    string str1,
//    string str2)
//{
//    if (str1 + str2 != str2 + str1)
//        return "";

//    int gcdLength =
//        Gcd(str1.Length, str2.Length);

//    return str1.Substring(0, gcdLength);
//}

//ودالة GCD:

//private int Gcd(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }

//    return a;
//}

//الفكرة الأساسية:

//لو:

//str1 + str2

//مش مساوية لـ:

//str2 + str1

//يبقى مفيش common repeating pattern.

//لو متساويين، نجيب:

//GCD(length1, length2)

//وبناخد prefix بالحجم ده.

//39. LeetCode README + Screenshots

//الـ assignment طالب:

//profile URL
//problem URLs
//accepted screenshots
//screenshots داخل:
//LeetCode / images /

//وبأسماء محددة.

//الجزء ده لا يمكن أعمله بدالك لأن الـ screenshot لازم يكون من حساب LeetCode بتاعك ويظهر Accepted.

//يعني تعمل:

//افتح Valid Anagram.
//Submit الحل.
//لما يظهر Accepted خُد screenshot.
//احفظه باسم:
//valid - anagram - accepted.png
//نفس الكلام لـ GCD of Strings:
//gcd - of - strings - accepted.png
//حط screenshots في:
//LeetCode / images /
//40.LinkedIn — 4 Posts

//المطلوب 4 technical posts من كتابتك أنت، وكل واحد فيه:

//شرح واضح
//C# example صغير
//practical scenario
//URL بعد النشر

//والموضوعات هي:

//Post 1
//ref vs out

//تشرح الفرق بين الاثنين مع مثال.

//Post 2
//ref with Reference Types

//وتشرح ليه array ممكن تتغير من function بدون ref.

//Post 3
//params

//وتشرح:

//params int[] values
//Post 4
//string vs StringBuilder

//وتستخدم observations من benchmark بتاعك.

//مهم جدًا: ما تكتبش:

//StringBuilder is always faster.

//لأن الassignment نفسه بيطلب منك عدم الادعاء بكده.

//أنا حاطط drafts جاهزة في:

//LinkedIn / POST_DRAFTS.md

//لكن النشر والـ URLs لازم يكونوا من حسابك أنت.

//41. README

//الـ root README مطلوب يحتوي على بيانات المشروع وطريقة التشغيل والروابط الخاصة بالأجزاء المختلفة.

//في المشروع:

//README.md

//وفيه أماكن لـ:

//Student Name
//Cohort
//Assignment

//تقدر تعدلهم ببياناتك.

//42. Structure النهائي

//الـ assignment محدد structure معين تقريبًا:

//AcademyScheduleAnalyzer_Submission /
//│
//├── AcademyScheduleAnalyzer /
//│   ├── AcademyScheduleAnalyzer.csproj
//│   └── Program.cs
//│
//├── Benchmarks /
//│   ├── StringBenchmark.cs
//│   └── ...
//│
//├── LeetCode /
//│   ├── README.md
//│   ├── ValidAnagram.cs
//│   ├── GcdOfStrings.cs
//│   └── images /
//│
//├── LinkedIn /
//│   ├── README.md
//│   └── POST_DRAFTS.md
//│
//├── BENCHMARK.md
//├── README.md
//└── .gitignore
//43. تشغيل المشروع

//بعد فك الـ ZIP:

//cd AcademyScheduleAnalyzer
//dotnet restore
//dotnet run

//المفروض يظهر:

//===================================
//Academy Schedule Analyzer
//===================================
//1. Display all sessions
//2. Search for a session
//3. Sort session names
//...
//16. Generate report using StringBuilder
//0. Exit
//44. إيه اللي خلص فعليًا وإيه اللي عليك؟

//حسب checklist الassignment، المطلوب النهائي يشمل التطبيق والـ arrays/functions/Array methods وDateTime/TimeSpan وref/out/params وexceptions وstring/StringBuilder والـ benchmark وLeetCode وLinkedIn والـ repository structure.

//جاهز في المشروع

//✅ Console application
//✅ Arrays
//✅ Functions
//✅ Array.Copy
//✅ Array.Sort
//✅ Array.Reverse
//✅ Array.IndexOf
//✅ Array.Exists
//✅ Array.Find
//✅ Array.FindIndex
//✅ Duration calculations
//✅ ref
//✅ out
//✅ Reference type example
//✅ params
//✅ DateTime
//✅ TimeSpan
//✅ DateTime.Now
//✅ AddMinutes
//✅ TryParseExact
//✅ Date formatting
//✅ FormatException
//✅ IndexOutOfRangeException
//✅ ArgumentException
//✅ throw
//✅ finally
//✅ String report
//✅ StringBuilder report
//✅ Menu + switch
//✅ BenchmarkDotNet setup
//✅ Valid Anagram solution
//✅ GCD of Strings solution
//✅ LinkedIn drafts
//✅ README files

//حاجات لازم تعملها بحساباتك

//⚠️ Benchmark results: شغّل BenchmarkDotNet على جهازك واكتب النتائج الحقيقية في BENCHMARK.md.

//⚠️ LeetCode screenshots: لازم screenshots من حسابك وتظهر Accepted.

//⚠️ LeetCode profile URL: حط رابط بروفايلك.

//⚠️ LinkedIn: انشر الـ 4 posts، وبعدها حط الـ 4 URLs.

//⚠️ Student Name / Cohort: عدلهم في README.

//ده لأن الassignment نفسه بيطلب بيانات وحالات مرتبطة بحساباتك الفعلية، ومينفعش أختلقها وأقدمها على إنها حصلت.

//ابدأ بالـ ZIP اللي فوق، وبعد فك الضغط افتح Program.cs أولًا؛ هو الجزء الأساسي، وباقي الملفات معمولة بحيث كل requirement يكون منفصل وواضح.
//#endregion