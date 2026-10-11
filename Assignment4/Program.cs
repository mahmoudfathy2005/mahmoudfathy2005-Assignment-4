
using BenchmarkDotNet.Running;
using System.Globalization;
using System.Text;

class Program
{
    static string[] sessionNames =
    {
        "C# Basics",
        "Arrays",
        "Functions",
        "Date and Time",
        "Exception Handling"
    };

    static DateTime[] sessionDates =
    {
        new DateTime(2026, 9, 10, 18, 0, 0),
        new DateTime(2026, 9, 13, 18, 0, 0),
        new DateTime(2026, 9, 17, 18, 0, 0),
        new DateTime(2026, 9, 20, 18, 0, 0),
        new DateTime(2026, 9, 24, 18, 0, 0)
    };

    static int[] sessionDurations = { 180, 240, 180, 240, 180 };

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Academy Schedule Analyzer =====");
            Console.WriteLine("1. Display Sessions");
            Console.WriteLine("2. Display Session Details");
            Console.WriteLine("3. Sort Durations");
            Console.WriteLine("4. Reverse Sessions");
            Console.WriteLine("5. Find Session Index");
            Console.WriteLine("6. Check Session Exists");
            Console.WriteLine("7. Calculate Total Duration");
            Console.WriteLine("8. Search Session");
            Console.WriteLine("9. Display Sessions After Today");
            Console.WriteLine("10. Show Next Session");
            Console.WriteLine("11. Difference Between Sessions");
            Console.WriteLine("12. Read Session Date");
            Console.WriteLine("13. Array Index Exception");
            Console.WriteLine("14. Validate Duration");
            Console.WriteLine("15. String Report");
            Console.WriteLine("16. StringBuilder Report");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    DisplaySessions(sessionNames, sessionDates, sessionDurations);
                    break;

                case 2:
                    Console.Write("Enter session name: ");
                    string? detailsName = Console.ReadLine();
                    DisplaySessionDetails(
                        detailsName,
                        sessionNames,
                        sessionDates,
                        sessionDurations);
                    break;

                case 3:
                    SortDuration(sessionDurations);
                    break;

                case 4:
                    Array.Reverse(sessionNames);
                    Array.Reverse(sessionDates);
                    Array.Reverse(sessionDurations);
                    Console.WriteLine("Arrays reversed.");
                    break;

                case 5:
                    Console.Write("Enter session name: ");
                    string? indexName = Console.ReadLine();

                    int index = Array.IndexOf(sessionNames, indexName);

                    if (index == -1)
                        Console.WriteLine("Not Found");
                    else
                        Console.WriteLine($"Index: {index}");

                    break;

                case 6:
                    Console.Write("Enter session name: ");
                    string? existsName = Console.ReadLine();

                    bool exists = Array.Exists(
                        sessionNames,
                        name => name == existsName);

                    Console.WriteLine($"Exists: {exists}");
                    break;

                case 7:
                    CalculateTotalDuration(
                        sessionDurations[0],
                        sessionDurations[1],
                        sessionDurations[2],
                        sessionDurations[3],
                        sessionDurations[4]);
                    break;

                case 8:
                    Console.Write("Enter session name: ");
                    string? searchName = Console.ReadLine();

                    SearchSessions(
                        searchName,
                        sessionNames,
                        sessionDates,
                        sessionDurations);
                    break;

                case 9:
                    DateTime now = DateTime.Now;

                    for (int i = 0; i < sessionDates.Length; i++)
                    {
                        if (sessionDates[i] > now)
                        {
                            Console.WriteLine(
                                $"{sessionNames[i]} - {sessionDates[i]:dd MMMM yyyy hh:mm tt}");
                        }
                    }

                    break;

                case 10:
                    NextSession(sessionNames, sessionDates);
                    break;

                case 11:
                    Console.Write("Enter first session name: ");
                    string? firstSession = Console.ReadLine();

                    Console.Write("Enter second session name: ");
                    string? secondSession = Console.ReadLine();

                    DiffrenceSession(
                        firstSession,
                        secondSession!,
                        sessionNames,
                        sessionDates);
                    break;

                case 12:
                    DateTime newDate = ReadSessionDate();
                    Console.WriteLine($"Valid Date: {newDate}");
                    break;

                case 13:
                    try
                    {
                        Console.Write("Enter index: ");
                        int selectedIndex = int.Parse(Console.ReadLine()!);

                        Console.WriteLine(
                            $"Session: {sessionNames[selectedIndex]}");
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index is out of range.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }

                    break;

                case 14:
                    try
                    {
                        Console.Write("Enter duration in minutes: ");
                        int duration = int.Parse(Console.ReadLine()!);

                        ValidateDuration(duration);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    finally
                    {
                        Console.WriteLine("Duration validation finished.");
                    }

                    break;

                case 15:
                    Console.WriteLine(
                        BuildReportUsingString(
                            sessionNames,
                            sessionDates,
                            sessionDurations));
                    break;

                case 16:
                    Console.WriteLine(
                        BuildReportUsingStringBuilder(
                            sessionNames,
                            sessionDates,
                            sessionDurations));
                    break;

                case 0:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);

        // BenchmarkRunner.Run<StringBenchmark>();
    }


    static void DisplaySessions(
        string[] names,
        DateTime[] dates,
        int[] durations)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {names[i]}");
            Console.WriteLine($"Date:       {dates[i]:dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {dates[i]:hh:mm tt}");
            Console.WriteLine($"Duration:   {durations[i]} minutes");
        }
    }


    static void SearchSessions(
        string? name,
        string[] names,
        DateTime[] dates,
        int[] durations)
    {
        int index = Array.IndexOf(names, name);

        if (index == -1)
        {
            Console.WriteLine("Session Not Found");
            return;
        }

        Console.WriteLine($"Date : {dates[index]:dd MMMM yyyy}");
        Console.WriteLine($"Day  : {dates[index].DayOfWeek}");
        Console.WriteLine($"Year : {dates[index].Year}");
        Console.WriteLine($"Month : {dates[index].Month}");
        Console.WriteLine($"Day Number : {dates[index]:dd}");
        Console.WriteLine($"Start Time : {dates[index]:hh:mm tt}");
        Console.WriteLine($"Duration : {durations[index]} minutes");
        Console.WriteLine(
            $"End Time : {dates[index].AddMinutes(durations[index]):hh:mm tt}");
    }


    static void DisplaySessionDetails(
        string? name,
        string[] names,
        DateTime[] dates,
        int[] durations)
    {
        int inx = Array.IndexOf(names, name);

        if (inx == -1)
        {
            Console.WriteLine("Not Found");
        }
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
        double avg;

        int shortest = durations[0];
        int longest = durations[0];

        for (int i = 0; i < durations.Length; i++)
        {
            sum += durations[i];

            if (durations[i] < shortest)
            {
                shortest = durations[i];
            }

            if (durations[i] > longest)
            {
                longest = durations[i];
            }
        }

        avg = (double)sum / durations.Length;

        Console.WriteLine($"Total Duration: {sum} minutes");
        Console.WriteLine($"Average Duration: {avg} minutes");
        Console.WriteLine($"Shortest Duration: {shortest} minutes");
        Console.WriteLine($"Longest Duration:  {longest} minutes");
    }


    static void SortDuration(int[] durations)
    {
        var sortArray = new int[durations.Length];

        Array.Copy(
            durations,
            sortArray,
            durations.Length);

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


    static (int index, int duration) OutDisplay(
        string? name,
        string[] names,
        int[] durations,
        out int index,
        out int duration)
    {
        index = Array.IndexOf(names, name);

        if (index == -1)
        {
            duration = 0;
            return (index, duration);
        }

        duration = durations[index];

        return (index, duration);
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


    static void DiffrenceSession(
        string? S1,
        string S2,
        string[] names,
        DateTime[] dates)
    {
        int inx1 = Array.IndexOf(names, S1);
        int inx2 = Array.IndexOf(names, S2);

        if (inx1 == -1 || inx2 == -1)
        {
            Console.WriteLine("One or both sessions were not found.");
            return;
        }

        TimeSpan diff = dates[inx2] - dates[inx1];

        Console.WriteLine("Difference:");
        Console.WriteLine($"{diff.TotalDays} days");
        Console.WriteLine($"{diff.TotalHours} hours");
    }


    static void NextSession(
        string[] names,
        DateTime[] dates)
    {
        DateTime now = DateTime.Now;
        DateTime nearstDate = DateTime.MaxValue;
        int nearstIndex = -1;

        for (int i = 0; i < dates.Length; i++)
        {
            if (dates[i] > now && dates[i] < nearstDate)
            {
                nearstIndex = i;
                nearstDate = dates[i];
            }
        }

        if (nearstIndex == -1)
        {
            Console.WriteLine("No upcoming sessions.");
            return;
        }

        TimeSpan remaining = nearstDate - now;

        Console.WriteLine("Next Session:");
        Console.WriteLine($"{names[nearstIndex]}:");
        Console.WriteLine($"{nearstDate:dd MMMM yyyy}");
        Console.WriteLine($"{nearstDate:hh:mm tt}");
        Console.WriteLine("Time Remaining:");
        Console.WriteLine($"{remaining.Days} days");
        Console.WriteLine($"{remaining.Hours} hours");
    }


    static DateTime ReadSessionDate()
    {
        const string format = "yyyy-MM-dd HH:mm";

        while (true)
        {
            Console.Write($"Enter date ({format}): ");

            string input = Console.ReadLine() ?? "";

            if (DateTime.TryParseExact(
                input,
                format,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime result))
            {
                return result;
            }

            Console.WriteLine("Invalid date.");
        }
    }


    static void ValidateDuration(int duration)
    {
        if (duration <= 0)
        {
            throw new ArgumentException(
                "Duration must be greater than zero.");
        }

        Console.WriteLine("Duration accepted.");
    }


    static string BuildReportUsingString(
        string[] names,
        DateTime[] dates,
        int[] durations)
    {
        string result = "";

        for (int i = 0; i < names.Length; i++)
        {
            result +=
                $"{i + 1}. {names[i]} - " +
                $"{dates[i]:dd MMMM yyyy hh:mm tt} - " +
                $"{durations[i]} minutes\n";
        }

        return result;
    }


    static string BuildReportUsingStringBuilder(
        string[] names,
        DateTime[] dates,
        int[] durations)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < names.Length; i++)
        {
            result.Append(
                $"{i + 1}. {names[i]} - " +
                $"{dates[i]:dd MMMM yyyy hh:mm tt} - " +
                $"{durations[i]} minutes\n");
        }

        return result.ToString();
    }
}

