using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_OPERATION
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Where
            //     string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
            //"Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //     IEnumerable<string> sequence = cars.Where(p => p.StartsWith("F"));
            //   //  IEnumerable<string> sequence = cars.Where((p, i) => (i & 1) == 1);
            //     foreach (string s in sequence)
            //         Console.WriteLine(s);

            #endregion

            #region Select
            //string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
            //                "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<int> sequence = cars.Select(p => p.Length);
            ////  var carObj = cars.Select(p => new { LastName = p, Length = p.Length });
            //foreach (int i in sequence)
            //    Console.Write(i + " ");
            #endregion

            #region SelectMany
            //Employee[] employees = Employee.GetEmployeesArray();
            //EmployeeOptionEntry[] empOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();

            //var employeeOptions = employees
            //  .SelectMany(e => empOptions
            //                     .Where(eo => eo.id == e.id)
            //                     .Select(eo => new
            //                     {
            //                         id = eo.id,
            //                         optionsCount = eo.optionsCount
            //                     }));

            //foreach (var item in employeeOptions)
            //    Console.WriteLine(item);
            #endregion

            #region Take
            //    string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
            //"Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //    IEnumerable<string> auto = cars.Take(5);

            //    foreach (string str in auto)
            //        Console.WriteLine(str);
            #endregion

            #region TakeWhile
            //string[] cars = { "Nissan", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW", "Aston Martin",
            //                "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<string> auto = cars.TakeWhile(s => s.Length < 12);
            ////IEnumerable<string> auto = cars.TakeWhile((s, i) => s.Length < 12 && i < 5);

            //foreach (string str in auto)
            //    Console.WriteLine(str);
            #endregion

            #region Skip
            //string[] cars = { "Nissan", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW", "Aston Martin",
            //                "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<string> auto = cars.Skip(5);

            //foreach (string str in auto)
            //    Console.WriteLine(str);
            #endregion

            #region SkipWhile
            //string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<string> auto = cars.SkipWhile(s => s.StartsWith("A"));
            ////IEnumerable<string> auto = cars.SkipWhile((s, i) => s.StartsWith("A") && i < 10);

            //foreach (string str in auto)
            //    Console.WriteLine(str);
            #endregion

            #region Concat
            //       string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //"Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //       IEnumerable<string> auto = cars.Take(5).Concat(cars.Skip(5));

            #region AlternativeConcat
            //      // IEnumerable<string> auto = new[] {
            //      //cars.Take(5),
            //      //cars.Skip(5)}
            //      //.SelectMany(s => s);
            #endregion

            //       foreach (string str in auto)
            //           Console.WriteLine(str);
            #endregion

            #region OrderBy
            //string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<string> auto = cars.OrderBy(s => s.Length);

            //foreach (string str in auto)
            //    Console.WriteLine(str);
            #region AlternativeOrderBy
            //MyVowelToConsonantRatioComparer myComp = new MyVowelToConsonantRatioComparer();
            //IEnumerable<string> auto = cars.OrderBy((s => s), myComp);

            //foreach (string str in auto)
            //{
            //    int vCount = 0;
            //    int cCount = 0;
            //    myComp.GetVowelConsonantCount(str, ref vCount, ref cCount);
            //    double dRatio = Math.Round(((double)vCount / (double)cCount), 3);
            //    Console.WriteLine(str + " - " + dRatio + " - " + vCount + ":" + cCount);
            //}
            #endregion

            #endregion

            #region OrderByDescending
            //string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<string> auto = cars.OrderByDescending(s => s);

            //foreach (string str in auto)
            //    Console.WriteLine(str);
            #endregion

            #region ThenBy
            //string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //IEnumerable<string> auto = cars.OrderBy(s => s.Length).ThenBy(s => s);

            //foreach (string str in auto)
            //    Console.WriteLine(str);
            #region ThenByAlternative
            //MyVowelToConsonantRatioComparer myComp = new MyVowelToConsonantRatioComparer();
            //IEnumerable<string> auto = cars
            //    .OrderBy(s => s.Length)
            //    .ThenBy((s => s), myComp);

            //foreach (string str in auto)
            //{
            //    int vCount = 0;
            //    int cCount = 0;
            //    myComp.GetVowelConsonantCount(str, ref vCount, ref cCount);
            //    double dRatio = Math.Round(((double)vCount / (double)cCount), 3);
            //    Console.WriteLine(str + " - " + dRatio + " - " + vCount + ":" + cCount);
            //}
            #endregion

            #endregion

            #region ThenByDescending
            //     string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //"Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //     IEnumerable<string> auto = cars.OrderBy(s => s.Length).ThenByDescending(s => s);

            //     foreach (string str in auto)
            //         Console.WriteLine(str);
            #endregion

            #region Join
            //  Employee[] employees = Employee.GetEmployeesArray();
            //  EmployeeOptionEntry[] empOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();

            //  var employeeOptions = employees
            //    .Join(
            //      empOptions,       //  inner sequence
            //      e => e.id,        //  outerKeySelector
            //      o => o.id,        //  innerKeySelector
            //      (e, o) => new       //  resultSelector
            //{
            //          id = e.id,
            //          name = string.Format("{0} {1}", e.firstName, e.lastName),
            //          options = o.optionsCount
            //      });

            //  foreach (var item in employeeOptions)
            //      Console.WriteLine(item);
            #endregion

            #region GroupJoin
            //Employee[] employees = Employee.GetEmployeesArray();
            //EmployeeOptionEntry[] empOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();

            //var employeeOptions = employees
            //  .GroupJoin(
            //    empOptions,
            //    e => e.id,
            //    o => o.id,
            //    (e, os) => new
            //    {
            //        id = e.id,
            //        name = string.Format("{0} {1}", e.firstName, e.lastName),
            //        options = os.Sum(o => o.optionsCount)
            //    });

            //foreach (var item in employeeOptions)
            //    Console.WriteLine(item);
            #endregion

            #region GroupBy
            //EmployeeOptionEntry[] empOptions = EmployeeOptionEntry.GetEmployeeOptionEntries();
            //IEnumerable<IGrouping<int, EmployeeOptionEntry>> outerSequence =
            //  empOptions.GroupBy(o => o.id);

            ////  Сначала перечисление по внешней последовательности IGrouping
            //foreach (IGrouping<int, EmployeeOptionEntry> keyGroupSequence in outerSequence)
            //{
            //    Console.WriteLine("Записи опционов для сотрудника: " + keyGroupSequence.Key);

            //    // Теперь перечисление по сгруппированной последовательности элементов EmployeeOptionEntry.
            //    foreach (EmployeeOptionEntry element in keyGroupSequence)
            //        Console.WriteLine("id={0} : optionsCount={1} : dateAwarded={2:d}",
            //          element.id, element.optionsCount, element.dateAwarded);
            //}
            #endregion

            #region Distinct
            //int[] arr = { 1, 10, 5, 8, 5, 1, 12, 5, 9, 9, 2 };
            //Console.WriteLine("Массив: ");
            //foreach (int i in arr)
            //    Console.Write(i + " ");

            //IEnumerable<int> nums = arr.Distinct();

            //Console.WriteLine("\n\nУдалены повторяющиеся элементы: ");
            //foreach (int i in nums)
            //    Console.Write(i + " ");
            #endregion

            #region Union
            //            string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                            "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //            IEnumerable<string> first = cars.Take(5);
            //            IEnumerable<string> second = cars.Skip(4);

            //            // Поскольку пропущены 4 элемента, пятый элемент 
            //            // должен присутствовать в обеих последовательностях
            //            IEnumerable<string> concat = first.Concat<string>(second);
            //            IEnumerable<string> union = first.Union<string>(second);

            //            Console.WriteLine(@"Cars: {0} элементов
            //first: {1} элементов
            //second: {2} элементов
            //concat: {3} элементов
            //union: {4} элементов", cars.Count(), first.Count(), second.Count(), concat.Count(), union.Count());
            #endregion

            #region Intersect
            //string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
            //                "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            //// 5 элемент присутствует в обоих коллекциях
            //IEnumerable<string> first = cars.Take(5);
            //IEnumerable<string> second = cars.Skip(4);

            //IEnumerable<string> auto = first.Intersect(second);

            //foreach (string s in auto)
            //    Console.WriteLine(s);
            #endregion

            #region Except
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr2 = { 6, 7, 8, 9 };

            //IEnumerable<int> nums = arr1.Except<int>(arr2);

            //foreach (int i in nums)
            //    Console.WriteLine(i);
            #endregion

        }
    }
}
