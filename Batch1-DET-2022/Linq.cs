//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{

//    internal class linq
//    {
//        public static void Main()
//        {
//            //List<int> numbers = new List<int>();
//            //numbers.Add(100);
//            //numbers.Add(200);
//            //numbers.Add(300);
//            //numbers.Add(400);

//            ////var numQueary = from num in numbers select num;

//            ////var numQueary = (from num in numbers
//            ////                 where num>102
//            ////                 select num).ToList();

//            //var numQueary = numbers.Where(x => x > 102);
//            //foreach (int num in numQueary)
//            //{
//            //    Console.WriteLine("{0}", num);
//            //}
//            // Console.ReadLine();


//            // SKIP
//            //string[] words = { "one", "two", "three", "four", "five", "six" };

//            //var result = words.Skip(4);

//            //Debug.WriteLine("Skips the first 4 words:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);


//            ////SKIPWHILE
//            //string[] states = { "goa", "karnataka", "maharashtra", "kerala", "panjab", "gujarat","goa" };

//            //var Result = states.SkipWhile(w => w.Length== 3);

//            //Debug.WriteLine("Skips words while the condition is met:");
//            //foreach (string state in Result)
//            //    Console.WriteLine(state);

//            //

//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            //var result = numbers.Take(5);

//            //Console.WriteLine("Takes the first 5 numbers only:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            //

//            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 3, 2, 1 , 9, 10 };

//            //var result = numbers.TakeWhile(n => n < 5);

//            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            ////-------aggregate simple
//            //var numbers = new int[] { 1, 2, 3, 4, 5 };

//            //var result = numbers.Aggregate((a, b) => a * b);

//            //Console.WriteLine("Aggregated numbers by multiplication:");
//            //Console.WriteLine(result);

//            ////-----average
//            //int[] numbers = { 10, 10, 11, 11 };

//            //var result = numbers.Average();

//            //Console.WriteLine("Average is:");
//            //Console.WriteLine(result);

//            ////----count
//            //string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

//            //var result = names.Count();

//            //Console.WriteLine("Counting names gives:");
//            //Console.WriteLine(result);

//            ////------max
//            //int[] numbers = { 2, 8, 5, 6, 1 };

//            //var result = numbers.Max();

//            //Console.WriteLine("Highest number is:");
//            //Console.WriteLine(result);



//            ////-----min
//            //int[] numbers = { 6, 9, 3, 7, 5 };

//            //var result = numbers.Min();

//            //Console.WriteLine("Lowest number is:");
//            //Console.WriteLine(result);



//            ////------sum
//            //int[] numbers = { 2, 5, 10 };

//            //var result = numbers.Sum();

//            //Console.WriteLine("Summing the numbers yields:");
//            //Console.WriteLine(result);



//            ////---------------element-----
//            ////----elementat
//            //string[] words = { "One", "Two", "Three" };

//            //var result = words.ElementAt(1);

//            //Console.WriteLine("Element at index 1 in the array is:");
//            //Console.WriteLine(result);



//            ////---------element at or default
//            //string[] colors = { "Red", "Green", "Blue" };

//            //var resultIndex1 = colors.ElementAtOrDefault(1);

//            //var resultIndex10 = colors.ElementAtOrDefault(10);

//            //Console.WriteLine("Element at index 1 in the array contains:");
//            //Console.WriteLine(resultIndex1);

//            //Console.WriteLine("Element at index 10 in the array does not exist:");
//            //Console.WriteLine(resultIndex10 == null);



//            ////-------first(simple)
//            //string[] fruits = { "Banana", "Apple", "Orange" };

//            //var result = fruits.First();

//            //Console.WriteLine("First element in the array is:");
//            //Console.WriteLine(result);



//            ////----first(conditional)
//            //string[] countries = { "Denmark", "Sweden", "Norway" };

//            //var result = countries.First(c => c.Length == 6);

//            //Console.WriteLine("First element with a length of 6 characters:");
//            //Console.WriteLine(result);



//            ////----firstOrDefault
//            //string[] countries = { "Denmark", "Sweden", "Norway" };
//            //string[] empty = { };

//            //var result = countries.FirstOrDefault();

//            //var resultEmpty = empty.FirstOrDefault();

//            //Console.WriteLine("First element in the countries array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("First element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);



//            //----last
//            //int[] numbers = { 7, 3, 5 };

//            //var result = numbers.Last();

//            //Console.WriteLine("Last number in array is:");
//            //Console.WriteLine(result);



//            ////----lastOrDefault
//            //string[] words = { "one", "two", "three" };
//            //string[] empty = { };

//            //var result = words.LastOrDefault();

//            //var resultEmpty = empty.LastOrDefault();

//            //Console.WriteLine("Last element in the words array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);



//            ////----lastOrDefault(conditional)
//            //string[] words = { "one", "two", "three" };

//            //var result = words.LastOrDefault(w => w.Length == 3);

//            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

//            //Console.WriteLine("Last element in the words array having a length of 3:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
//            //Console.WriteLine(resultNoMatch == null);



//            ////----single
//            //string[] names1 = { "Peter" };
//            //string[] names3 = { "Peter", "Joe", "Wilma" };
//            //string[] empty = { };

//            //var result1 = names1.Single();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //try
//            //{
//            //    // This will throw an exception because array contains no elements
//            //    var resultEmpty = empty.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}

//            //try
//            //{
//            //    // This will throw an exception as well because array contains more than one element
//            //    var result3 = names3.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Debug.WriteLine(e.Message);
//            //}



//            ////----singleOrDefault
//            //string[] names1 = { "Peter" };
//            //string[] names3 = { "Peter", "Joe", "Wilma" };
//            //string[] empty = { };

//            //var result1 = names1.SingleOrDefault();

//            //var resultEmpty = empty.SingleOrDefault();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
//            //Console.WriteLine(resultEmpty == null);

//            //try
//            //{
//            //    // This will throw an exception as well because array contains more than one element
//            //    var result3 = names3.SingleOrDefault();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}




//            ////----------------------set------------------------
//            ////--------distrinct-------
//            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

//            //var result = numbers.Distinct();

//            //Console.WriteLine("Distinct removes duplicate elements:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);



//            ////-----except------
//            //int[] numbers1 = { 1, 2, 3 };
//            //int[] numbers2 = { 3, 4, 5 };

//            //var result = numbers1.Except(numbers2);

//            //Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);



//            //-----intersect-----
//            //int[] numbers1 = { 1, 2, 3 };
//            //int[] numbers2 = { 3, 4, 5 };

//            //var result = numbers1.Intersect(numbers2);

//            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);



//            //-----union-----
//            //int[] numbers1 = { 1, 2, 3 };
//            //int[] numbers2 = { 3, 4, 5 };

//            //var result = numbers1.Union(numbers2);

//            //Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);



//            ////----Quantifiers----
//            ////----all---
//            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

//            //var result = names.All(n => n.StartsWith("B"));

//            //Console.WriteLine("Does all of the names start with the letter 'B':");
//            //Console.WriteLine(result);



//            ////----any----
//            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

//            //var result = names.Any(n => n.StartsWith("B"));

//            //Console.WriteLine("Does any of the names start with the letter 'B':");
//            //Console.WriteLine(result);



//            ////----contains----
//            //int[] numbers = { 1, 3, 5, 7, 9 };

//            //var result = numbers.Contains(5);

//            //Console.WriteLine("sequence contains the value 5:");
//            //Console.WriteLine(result);


//            ////-------assignment------
//            ////-----max lenght----
//            //string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

//            //var result = names.Length();

//            ////Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);

//            ////----name contains o
//            //string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

//            //var result = from name in names
//            //             where name.Contains("o")
//            //             select name;
//            //foreach (var name in result)
//            //    Console.WriteLine(name);
//            //



//            ////----elements with length
//            //string[] words1 = { "believe", "relief", "receipt", "field" };

//            //var result = from word in words1
//            //             select word;


//            //foreach (var word in result)
//            //    Console.WriteLine($"{word}--{word.Length}");



//            ////----reverse of string
//            //string[] words = { "blueberry", "blackberry", "abacus" };

//            //var result = from word in words

//            //             select word.Reverse();

//            //foreach (var word in result)
//            //     Console.WriteLine(word);


//            ////----elements by index--
//            //Int[] numbers = { 1, 3, 2, 0 };
//            //string[]={"C#", "SQL", "linq", ‘Java’};




//            String_Groupby();
//        }

//        public static void String_Groupby()
//        {
//            List<string> words = new List<string> { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

//            var wordGroups = words.GroupBy(x => x.Length).Select
//                (y => new { FirstLetter = y.Key, Words = y });

//            foreach (var item in wordGroups)
//            {
//                Console.WriteLine("words that start with the" + "letter '{0}':", item.FirstLetter);

//                foreach (var w in item.Words)
//                {
//                    Console.WriteLine(w);
//                }
//            }
//        }

//    }
//}
