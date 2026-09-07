using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {

        #region Exercise 1

        //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

        //Console.WriteLine($"Total grades: {grades.Count}");
        //Console.WriteLine($"First grade: {grades.First()}");
        //Console.WriteLine($"Last grade: {grades.Last()}");
        //grades.Sort();

        //Console.WriteLine("---------------------------------------");

        //Console.WriteLine("Sorted the grades ascending: ");
        //foreach (var grade in grades)
        //{
        //    Console.Write($"{grade} ");
        //}

        //Console.WriteLine();
        //Console.WriteLine("---------------------------------------");

        //int foundGrade = grades.Find(g => g > 90);
        //Console.WriteLine($"first grade above 90:\n{foundGrade}");

        //Console.WriteLine("---------------------------------------");

        //Console.WriteLine("all grades below 75 (failing grades): ");
        //var lowGrades = grades.FindAll(g => g < 75);
        //foreach (var item in lowGrades)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("---------------------------------------");

        //grades.RemoveAll(g => g < 75);
        //Console.WriteLine("All failing grades removed.");

        //Console.WriteLine("---------------------------------------");

        //if (grades.Exists(g => g == 100))
        //{
        //    Console.WriteLine("There is a perfect score of 100 in the list.");
        //}
        //else
        //{
        //    Console.WriteLine("There is no perfect score of 100 in the list.");
        //}

        //Console.WriteLine("---------------------------------------");

        //List<string> StringGrades = new List<string>();

        //for (int i = 0; i < grades.Count; i++)
        //{
        //    StringGrades.Add($"Grade: {grades[i]}");
        //}

        #endregion

        #region Exercise 2

        //Dictionary<int, string> leaderboard = new Dictionary<int, string>
        //{
        //    { 200, "Sara" },
        //    { 350, "Mona" },
        //    { 500, "Ahmed" },
        //    { 800, "Ali" }
        //};

        //foreach (var entry in leaderboard)
        //{
        //    Console.WriteLine($"Score: {entry.Key} || Player: {entry.Value}");
        //}

        //Console.WriteLine("---------------------------------------");

        //var firstEntry = leaderboard.First();
        //Console.WriteLine($"First entry:\nScore: {firstEntry.Key} || Player: {firstEntry.Value}");

        //Console.WriteLine("---------------------------------------");

        //if (leaderboard.ContainsKey(500))
        //{
        //    Console.WriteLine("Score 500 exists!");
        //}
        //else
        //    Console.WriteLine("Score 500 does not exist.");

        //Console.WriteLine("---------------------------------------");

        //if (leaderboard.ContainsKey(999))
        //{
        //    Console.WriteLine(leaderboard[999]);
        //}
        //else
        //    Console.WriteLine("Score 999 does not exist.");

        //Console.WriteLine("---------------------------------------");

        //Console.WriteLine("The updated list without the removed entry:");
        //leaderboard.Remove(200);
        //foreach (var entry in leaderboard)
        //{
        //    Console.WriteLine($"Score: {entry.Key} || Player: {entry.Value}");
        //}

        #endregion

    }
}