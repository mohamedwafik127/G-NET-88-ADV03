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

        #region Exercise 3

        //Dictionary<string, string> contacts = new Dictionary<string, string>
        //{
        //    { "Medo", "01005403213" },
        //    { "Sara", "01353343257" },
        //    { "Ali", "01000000000" },
        //    { "Mona", "01000000001" }
        //};

        //contacts["Hassan"] = "01000000002";

        //Console.WriteLine("---------------------------------------");

        //try
        //{
        //    contacts.Add("Medo", "01005403213");
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine($"Error: {ex.Message}");
        //}

        //Console.WriteLine("---------------------------------------");

        //bool added = contacts.TryAdd("Sara", "01000000003");
        //Console.WriteLine($"TryAdd succeeded: {added}");

        //Console.WriteLine("---------------------------------------");

        //if (contacts.TryGetValue("Omar", out string omarNumber))
        //{
        //    Console.WriteLine($"Omar's number: {omarNumber}");
        //}
        //else
        //{
        //    Console.WriteLine("Omar not found in contacts.");
        //}

        //Console.WriteLine("---------------------------------------");

        //string number = contacts.GetValueOrDefault("Omar", "Not Found");
        //Console.WriteLine($"Omar's number (with fallback): {number}");

        //Console.WriteLine("---------------------------------------");

        //Console.WriteLine(string.Join(", ", contacts.Keys));
        //Console.WriteLine(string.Join(", ", contacts.Values));

        #endregion

        #region Exercise 4

        //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        //emails.Add("ahmed@test.com");
        //emails.Add("AHMED@test.com");
        //emails.Add("sara@test.com");
        //emails.Add("Sara@Test.Com");

        //Console.WriteLine("---------------------------------------");

        //Console.WriteLine($"Count: {emails.Count}");
        ////Only 2 are stored because the comparer is case insensitive, so "ahmed@test.com" and "AHMED@test.com" are treated as the same value, and same for the two Sara entries.

        //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

        //Console.WriteLine("---------------------------------------");

        //HashSet<int> unionResult = new HashSet<int>(setA);
        //unionResult.UnionWith(setB);
        //Console.WriteLine("Union: " + string.Join(", ", unionResult));

        //Console.WriteLine("---------------------------------------");

        //HashSet<int> intersectResult = new HashSet<int>(setA);
        //intersectResult.IntersectWith(setB);
        //Console.WriteLine("Intersect: " + string.Join(", ", intersectResult));

        //Console.WriteLine("---------------------------------------");

        //HashSet<int> exceptResult = new HashSet<int>(setA);
        //exceptResult.ExceptWith(setB);
        //Console.WriteLine("Except: " + string.Join(", ", exceptResult));

        //Console.WriteLine("---------------------------------------");

        //HashSet<int> subsetCheck = new HashSet<int> { 1, 2 };
        //bool isSubset = subsetCheck.IsSubsetOf(setA);
        //Console.WriteLine($"{{1,2}} is subset of Set A: {isSubset}");

        #endregion
    }
}