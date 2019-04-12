using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using SplitStrings.Decorator;

namespace SplitStrings
{
    class Program
    {
        public static object SentenceString { get; private set; }

        static void Main(string[] args)
        {
            /*string aString = "ABCDE99F-J74-12-89A";

            IEnumerable<char> stringQuery =
                from ch in aString
                where char.IsDigit(ch)
                select ch;

            foreach (var c in stringQuery)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Count: {0}",stringQuery.Count());

            IEnumerable<char> stringQuery2 = aString.TakeWhile(c => c != '-');
            foreach (var c in stringQuery2)
            {
                Console.WriteLine(c);
            }*/

            /*List<string> list = new List<string>();

            list.Add("Dubai");
            list.Add("Oradea");
            list.Add("London");
            list.Add("Dubai");
            list.Add("Bucharest");
            list.Add("Malaga");
            list.Add("Malaga");
            list.Add("Dubai");

            int most = list.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Count()).First();

            IEnumerable<string> mostVal = list.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                .Where(grp => grp.Count() == most).Select(grp => grp.Key);

            Console.WriteLine(most);
            foreach (var m in mostVal)
            {
                Console.WriteLine(m);
            }*/

            /*Singleton singleton = Singleton.GetInstance();

            Margherita pizza = new Margherita();
            Console.WriteLine("Plain Margherita: " + pizza.GetPrice());

            ExtraCheeseTopping moreCheese = new ExtraCheeseTopping(pizza);
            ExtraCheeseTopping someMoreCheese = new ExtraCheeseTopping(moreCheese);
            Console.WriteLine("Plain Margherita with double extra cheese: " + someMoreCheese.GetPrice());

            MushroomTopping moreMushroom = new MushroomTopping(someMoreCheese);
            Console.WriteLine("Plain Margherita with double extra cheese with mushroom: " + moreMushroom.GetPrice());

            JalapenoTopping moreJalapeno = new JalapenoTopping(moreMushroom);
            Console.WriteLine("Plain Margherita with double extra cheese with mushroom with Jalapeno: " + moreJalapeno.GetPrice());

            Console.ReadLine();*/
            //split/Diff DateTime

            /*string line = "14:22:57 12:47:11";

            string[] time = line.Split(' ');
            DateTime endTime = DateTime.Parse(time[0]);
            DateTime startTime = DateTime.Parse(time[1]);

            TimeSpan timeDiff = endTime - startTime;

            Console.WriteLine(timeDiff.Duration());
            Console.Read();*/

            //remove string spaces

            /*string str = "This is a test";
            str = str.Replace(" ", String.Empty);
            Console.WriteLine(str);
            Console.Read();*/

            //Count the lowest 2 numbers from an array

            /*var numbers = new[] {5, 12, 33, 6};

            Console.WriteLine(numbers.OrderBy(i => i).Take(2).Sum());
            Console.Read();*/

            //return the smallest work lenght 

            /*Console.WriteLine("Enter a sentence: ");
            var input = Console.ReadLine();

            string[] input1 = input.Split(' ');
            var longestWord = input1.OrderByDescending(n => n.Length).Last().Length;

            Console.WriteLine("Longest word is: " + longestWord);
            Console.Read();*/

            //return min and max from array

            int[] numbers = {2, -2, 2, 2, -6, 3, 3, 3, 3};
            int[] num = {1,2,4,3,7,88,0,-22,192,74};
            //ArrayDiff(numbers, num);
            //MinMinMax(num);
            object[] a = new object[] {(int) 1, (int) 2, "3", 1, "2"};
            //Enough(100, 50, 60);
            //GetUnique(numbers);
            //GetSum(0, -22);

            //Longest(ss, sss);

            //SplitCamelCase("camelCase");
            //CamelCase("hello case");

            //SplitStringCamelCase("HelloHelloHello");
            //SumMix(a);

            //ToBinary(3);

            //Solution("ceva", "va");

            /*int[] array = new[] {numbers.Min(), numbers.Max()};
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/

            //minMax(numbers);
            //InvertValues(numbers);
            //
            //Console.WriteLine("min: {0} max: {1}", minNum, maxNum);
            //CreatePhoneNumber(numbers);
            //CamelCase1st("ceva nou");
            //SetPhoneNumberWithDashes("1123456789");
            //ReverseSeq(12);
            //is_uppercase("GEORG");
            //ReverseLetterString("ceva231");
            //Square(2);
            //Switch("abc");
            //CountBy(1, 10);
            //ReverseWords("ceva absolut nou");
            
            //FormatMoney(39);
            //ArrayPlusArray(num, numbers);
            //AbbrevName("George Serban");
            /*var res = arr1.Union(arr2).Except(arr1.Intersect(arr2));
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }*/
            //CatMouse("C...m");
            //BubbleSort(num);
            //SortArray(num);
            //DescendingOrder(3421312);
            SquareDigits(8);
            //Bublesort();
            //Dictionary<string, int> dictionary = new Dictionary<string, int>
                //{{"Hindi", 60}, {"Greek", 71}, {"Dutch", 93}};
            //MyLanguages(dictionary);
            Console.Read();
        }

        //return new array consist of min and max numbers from provided array;
        public static int[] minMax(int[] lst)
        {
            return new int[] {lst.Min(), lst.Max()};
        }


        //Function to return middle letter or letters of a string
        public static string GetMiddleString(string original)
        {
            //Find the middle point
            var mid = original.Length / 2.0;

            //If it's odd, we take 1 letter, if it's even, we take 2
            var numToTake = (mid == (int) mid) ? 2 : 1;

            //Round up from the middle, and subtract one (as Substring is 0-indexed)
            var startIndex = (int) Math.Ceiling(mid) - 1;

            Console.WriteLine(original.Substring((int) Math.Ceiling(mid) - 1, numToTake));
            return original.Substring((int) Math.Ceiling(mid) - 1, numToTake);
        }

        public static string GetMiddle(string s) => s.Substring((s.Length - 1) / 2, (s.Length - 1) % 2 + 1);


        //Seats in Theater
        public static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nRows - row) * (nCols - col + 1);
        }

        //rps
        public static string Rps(string p1, string p2)
        {
            if (p1 == "rock" && p2 == "scissors")
            {
                return "Player 1 won!";
            }

            if (p1 == "paper" && p2 == "rock")
            {
                return "Player 1 won!";
            }

            if (p1 == "scissors" && p2 == "paper")
            {
                return "Player 1 won!";
            }

            if (p2 == "rock" && p1 == "scissors")
            {
                return "Player 2 won!";
            }

            if (p2 == "paper" && p1 == "rock")
            {
                return "Player 2 won!";
            }

            if (p2 == "scissors" && p1 == "paper")
            {
                return "Player 2 won!";
            }

            return "Draw!";
        }

        public static List<int> CreateList(int number)
        {
            return Enumerable.Range(1, number).ToList();
        }

        public static int binToDec(string s)
        {
            return Convert.ToInt32(s, 2);
        }


        public static string InputName(string name)
        {
            if (name.StartsWith("R") || (name.StartsWith("r")))
            {
                Console.WriteLine(name + " plays banjo");
                return name + " plays banjo";
            }

            Console.WriteLine(name + " does not play banjo");
            return name + " does not play banjo";
        }

        public static List<int> ReverseList(List<int> list)
        {
            list.Reverse();
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }

            return list;
        }

        public static int GetAge(string inputString)
        {
            char[] age = inputString.ToCharArray(0, inputString.Length);
            Console.WriteLine(age[0]);
            return age[0];
        }

        public static int Litres(double time)
        {
            if (time > 2)
            {
                Console.WriteLine(Convert.ToInt32((time - 1) / 2));
                return Convert.ToInt32((time - 1) / 2);
            }
            else if (time == 2)
            {
                Console.WriteLine(Convert.ToInt32(time / 2));
                return Convert.ToInt32(time / 2);
            }

            return 0;
        }

        //remove second element from an array
        public static object[] RemoveEveryOther(object[] arr)
        {
            var result = arr.Where((i, index) => (index & 1) == 0)
                .ToArray();
            return result;

        }

        public static bool Hero(int bullets, int dragons)
        {
            if (bullets >= (dragons * 2))
            {
                return true;
            }

            return false;
        }

        public static string Remove_char(string s)
        {
            s = s.Substring(1);
            s = s.Remove(s.Length - 1);
            Console.WriteLine(s);
            return s;
        }

        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '-':
                    return value1 - value2;
                case '+':
                    return value1 + value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;


            }

            return value1 / value1;
        }

        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int twice = dadYears - (2 * sonYears);
            return twice;
        }

        //remove duplicates from string
        public static string RemoveDuplicateWords(string s)
        {
            Console.WriteLine(string.Join(" ", s.Split(' ').Distinct()));
            return string.Join(" ", s.Split(' ').Distinct());

        }

        //sort numbers
        public static int[] SortNumbers(int[] nums)
        {
            return nums == null || !nums.Any() ? new int[] { } : nums.OrderBy(n => n).ToArray();
        }

        //check uppercase
        public static bool IsAllUpper(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLower(value[i]))
                {
                    Console.WriteLine(false);
                    return false;
                }
            }

            Console.WriteLine(true);
            return true;
        }

        //sum array
        public static double SumArray(double[] array)
        {
            Console.WriteLine(array.Sum());
            return array.Sum();
        }

        //order array by string length
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(x => x.Length).ToArray();
        }

        //return array (count positive num and sum of negative numbers)
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            var pos = input.Where(x => x > 0).ToList();
            var neg = input.Where(x => x < 0).ToList();



            int[] arrayInts = new[] {pos.Count, neg.Sum()};
            foreach (var a in arrayInts)
            {
                Console.WriteLine(a);
            }

            return arrayInts;
        }

        //invert array values 
        public static int[] InvertValues(int[] input)
        {
            int[] array = input;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(-array[i]);
            }

            return array;
        }

        //cast object array to int array
        public static int SumMix(object[] x)
        {
            return x.Sum(i => Convert.ToInt32(i));
        }

        //convert to binary
        public static int ToBinary(int n)
        {
            Console.WriteLine(Convert.ToInt32(Convert.ToString(n, 2)));
            return Convert.ToInt32(Convert.ToString(n, 2));
        }

        //EndWith string method
        public static bool Solution(string str, string ending)
        {
            Console.WriteLine(str.EndsWith(ending));

            return str.EndsWith(ending);
        }

        //return max and min from a string 
        public static string HighAndLow(string numbers)
        {
            var numb = numbers.Split(' ').Select(Int32.Parse).ToList();

            return numb.Max() + " " + numb.Min();
        }

        //Break camelCase
        public static string SplitCamelCase(string input)
        {
            return Regex.Replace(input, "(?<=[a-z])([A-Z])", " $1", RegexOptions.Compiled);
        }

        //convert string to CamelCase
        public static string CamelCase(string s)
        {
            var x = s.Replace("_", "");
            if (x.Length == 0) return "Null";
            x = Regex.Replace(x, "([A-Z])([A-Z]+)($|[A-Z])",
                m => m.Groups[1].Value + m.Groups[2].Value.ToLower() + m.Groups[3].Value);
            Console.WriteLine(char.ToUpper(x[0]) + x.Substring(1));
            return char.ToUpper(x[0]) + x.Substring(1);
        }

        //split string camel case "HelloHelloHello" -> "Hello Hello Hello"
        public static string SplitStringCamelCase(string camelCaseString)
        {
            Console.WriteLine(Regex.Replace(camelCaseString, "([A-Z])", " $1", RegexOptions.Compiled).Trim());
            return Regex.Replace(camelCaseString, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }

        //remove duplicated from list 
        public static List<int> Unique(List<int> integers)
        {
            return integers.Distinct().ToList();
        }

        //return longest sorted string
        public static string Longest(string s1, string s2)
        {
            var a = s1.ToList();
            a.Sort();
            var b = s2.ToList();
            b.Sort();


            if (a.Count > b.Count)
            {
                Console.WriteLine(string.Join("", a));
                return string.Join("", a);
            }

            Console.WriteLine(string.Join("", b));
            return string.Join("", b);
        }

        //sum of range int // if equals return do not sum
        public static int GetSum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            if (a < b)
            {
                var c = Enumerable.Range(a, b - a + 1).ToList();
                return c.Sum();
            }

            var e = Enumerable.Range(b, a - b + 1).ToList();
            return e.Sum();
        }

        //create phone number
        public static string CreatePhoneNumber(int[] numbers)
        {
            string phoneNumber = string.Join("", numbers);

            return string.Format("{0:(###) ###-####}", double.Parse(phoneNumber));
        }

        //change to uppercase first letter of string 
        public static string CamelCase1st(string str)
        {
            string capsMe = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return capsMe.Replace(" ", "");
        }


        //return unique number from array
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }


        //subtracts one list from another and returns the result
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }

        // returns an array of the repeated characters (letters, numbers, whitespace) in the string.
        public static List<char> Remember(string str)
        {
            var query = str.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            return query.ToList();
        }

        //return max number
        public static int MaxNumber(int n)
        {
            //Console.WriteLine(int.Parse(string.Concat(n.ToString().ToArray().OrderByDescending(a => a))));
            return int.Parse(string.Concat(n.ToString().ToArray().OrderByDescending(a => a)));
        }

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            var a = a1.Where(s => s.Length == a1.Max(m => m.Length)).First();


            var b = a2.Where(s => s.Length == a2.Max(m => m.Length)).First();
            Console.WriteLine(a.Length + b.Length);
            return a.Length + b.Length;
        }


        public static string ExpandedForm(long num)
        {
            /*var result = num.ToString();

            return result.Substring(1,result.Length-1).Replace(", 0", "").Replace(",", " +");*/

            

            return num.ToString();

        }

        //string replace
        public static string Correct(string text)
        {
            string result = text.Replace('5', 'S').Replace('0', 'O').Replace('1', 'I');
            return result;
        }

        public static string bonus_time(int salary, bool bonus)
        {
            if (bonus == true)
            {
                return (salary * 10).ToString("$0",CultureInfo.CurrentCulture);

            }

            return salary.ToString("$0",CultureInfo.CurrentCulture);
        }

       public static int Square (int num)
       {
           Console.WriteLine(num*num);
           return num * num;
       }

       public static string Greet(string name, string owner)
       {
           if (name == owner)
           {
               return "Hello boss";
           }

           return "Hello guest";
       }

       public static int FinalGrade(int exam, int projects)
       {
           //Console.WriteLine(exam > 90 || projects > 10 ? 100 : exam > 75 && projects >= 5 ? 90 : exam > 50 && projects >= 2 ? 75 : 0);
           return exam > 90 || projects > 10 ? 100 : exam > 75 && projects >= 5 ? 90 : exam > 50 && projects >= 2 ? 75 : 0;
       }

        // generate array from 1 to n and reverse it 
       public static int[] ReverseSeq(int n)
       {
           return Enumerable.Range(1, n).Reverse().ToArray();
       }

       //multiply all array values
       public static int Grow(int[] x)
       {
           return x.Aggregate((a, b) => a * b);
       }

       private static int getDiagonalSumFromTop(int[][] matrix)
       {
           int sum = 0;
           for (int i = 0; i < matrix.Length; i++)
           {
               sum += matrix[i][i];
           }
           return sum;
       }

       public static string[] StringToArray(string str)
       {
           string[] s = str.Split(' ');
           return s;
       }

       public static bool Check(object[] a, object x)
       {
           return a.Contains(x);
       }


       //return card issuer
       public static string getIssuer(long number)
       {
           var card = number.ToString();

           if (card.StartsWith("34") || card.StartsWith("37") && card.Length == 15)
           {
               return "AMEX";
           }
           if (card.StartsWith("6011") && card.Length == 16)
           {
               return "Discover";
           }
           if (card.StartsWith("51") || card.StartsWith("52") || card.StartsWith("53") || card.StartsWith("54") || card.StartsWith("55") && card.Length == 16)
           {
               return "Mastercard";
           }
           if (card.StartsWith("4") && card.Length == 16 || card.Length == 13)
           {
               return "VISA";
           }

           return "Unknown";

       }

       //check if divisible
       public static bool isDivisible(long n, long x, long y)
       {
            return n % x == 0 && n % y == 0;
       }

       //return negative number
       public static int MakeNegative(int number)
       {
           return -Math.Abs(number);
       }

       //range list numbers from 1 to num and return sum()
       public static int Summation(int num)
       {
           return Enumerable.Range(1, num).ToList().Sum();
       }

       public static string Problem(string a)
       {
           return double.TryParse(a, out double r) ? (r * 50 + 6).ToString() : "Error";
       }

       //get character from ASCII value
       public static char GetChar(int charcode)
       {
           return (char)charcode;
       }

       //remove all "!" from string
       public static string RemoveExclamationMarks(string s)
       {
           return s.Replace("!", "");
       }

       public static int ExpressionsMatter(int a, int b, int c)
       {
           int val1 = a * (b + c);
           int val2 = a * b * c;
           int val3 = a + b * c;
           int val4 = (a + b) * c; 

           int result1 = Math.Max(val1, val2);
           int result2 = Math.Max(val3, val4);

           return Math.Max(result1,result2);
       }

       public static bool IsDigit(string s)
       {
           return double.TryParse(s, out double result);
       }

       //convert name to initials
       public static string AbbrevName(string name)
       {
           Console.WriteLine(string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper());
           return string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
       }

        //count a,e,i,o and u
        public static int GetVowelCount(string str)
        {
            string sentence = "The quick brown fox jumps over the lazy dog.";
            int vowelCount = sentence.Count(c => "aeiou".Contains(Char.ToLower(c)));

            return vowelCount;
        }

        //rental car
        public static int RentalCarCost(int d)
        {
            return d * 40 - ((d > 6) ? 50 : ((d > 2) ? 20 : 0));
        }

        //check if string uppercase (return true or false)
        public static bool is_uppercase (string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLower(value[i]))
                {
                    Console.WriteLine(false);
                    return false;
                }
            }

            Console.WriteLine(true);
            return true;
        }

        //return value from (largest-smallest) array
        public static int BetweenExtremes(int[] numbers)
        {
            return numbers.Max() - numbers.Min();
        }


        //reverse string and remove non-alphabetic characters
        public static string ReverseLetterString(string str)
        {
            return new string(str.Where(Char.IsLetter).Reverse().ToArray());
        }

        //return "automorphic if (num * num) ends with initial num
        public static string Automorphic(int n)
        {
            int square = n * n;
            if (square.ToString().EndsWith(n.ToString())) 
            {
                return "Automorphic";
            }

            return "Not";
        }

        //predict your age 
        public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            int[] ages = new int[] {age1 * age1, age2 * age2, age3 * age3, age4 * age4, age5 * age5, age6 * age6, age7 * age7, age8 * age8};
            

            var sumAges = ages.Sum();
            var sqrt = Math.Sqrt(sumAges);

            return (int)sqrt / 2;

        }

        public static string Switch(string x)
        {
            
            var result = x.Select(s => s == 'a' ? 'b' : (s == 'b' ? 'a' : s)).ToArray();
            Console.WriteLine(new string(result));
            string nou = new string(result);
            return nou;
        }

        public static int[] CountBy(int x, int n)
        {
            //List<int> list = new List<int>(n);
            int[] z = new int[n];
            /*z[0] = x;
            z[1] = z[0] + x;
            z[2] = z[1] + x;
            z[3] = z[2] + x;
            z[4] = z[3] + x;*/

            for (int i = x; i < z.Length+1; i+=x)
            {
                //list.Add(i);
                Console.WriteLine(i);
            }

            //foreach (var l in list)
            //{
            //    Console.WriteLine(l);
            //}


            return z;
        }

        //reverse words in a string
        public static string ReverseWords(string str)
        {
            Console.WriteLine(string.Join(" ", str.Split(' ').Reverse()));
            return string.Join(" ", str.Split(' ').Reverse());
        }

        //currency format($)
        public static string FormatMoney(double amount)
        {
            Console.WriteLine(string.Format("{0:C}", amount));
            return string.Format("{0:C}", amount);
        }

        //sum 2 arrays
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            Console.WriteLine(arr1.Sum() + arr2.Sum());
            return arr1.Sum() + arr2.Sum();
        }

        //return array with divisible numbers by given number
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            var l = numbers.ToList();
            var result = l.Where(i => i % divisor == 0).ToArray();
            return result;
        }

        //sum positive numbers
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(i => i > 0).Sum();
        }

        //return [smallest, minimumAbsent(between smallest and largest), largest]
        public static int[] MinMinMax(int[] array)
        {
            int smallest = array.Min();
            Console.WriteLine(smallest);
            int largest = array.Max();
            Console.WriteLine(largest);
            var list = Enumerable.Range(smallest, largest).ToList();
            int minimumAbsent = list.ElementAt(1);
            Console.WriteLine(minimumAbsent);

            return new[] {smallest, minimumAbsent, largest};
        }

        public static int Enough(int cap, int on, int wait)
        {
            Console.WriteLine(Math.Max(0, on + wait - cap));
            return Math.Max(0, on + wait - cap);
        }

        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }

        public static double Calculator(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;

            }

            throw new ArgumentException("op");
        }

        public static string RemoveUrlAnchor(string url)
        {
            return url.Split('#')[0];
        }

        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            //var result = results.Where(kvp => kvp.Value >= 60).FirstOrDefault();

            IEnumerable<string> result = from r in results
                where r.Value >= 60
                orderby r.Key descending 
                select r.Key;


            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            return result;

        }

        //validate ip address 
        public static bool is_valid_IP(string ipAddres)
        {
            IPAddress result = null;
            return
                !String.IsNullOrEmpty(ipAddres) &&
                IPAddress.TryParse(ipAddres, out result);

        }

        //count score of games 
        public static int TotalPoints(string[] games)
        {
            var list = games.Select(i => Int32.Parse(i));

            foreach (var g in list)
            {
                Console.WriteLine(g);
            }

            return 0;
        }

        public static int MaxMultiply(int divisor, int bound)
        {
            int remaider = bound % divisor;

            return bound - remaider;
        }

        public static int GetVowelCountC(string str)
        {
            return str.Count(x => "aeiou".IndexOf(x) != -1);
        }

        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

        //insert several characters by given int
        public static string repeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }

        public static int Divisors(int n)
        {
            var searched = Enumerable.Range(1, n)
                .Where((x) => n % x == 0)
                .Select(x => n / x);

            return searched.Count();

        }

        public static int Multiply(int x)
        {
            if (x % 2 == 0)
            {
                return x * 8;
            }

            return x * 9;
        }

        public static int[] MonkeyCount(int n)
        {
            int[] arr = Enumerable.Range(1, n).ToArray();
            return arr;
        }

        public static int[] BubbleSort(int[] array)
        {
            Console.WriteLine("Original array: ");
            foreach (var a in array)
            {
                Console.WriteLine(a + " ");
            }
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: ");

            foreach (var a in array)
            {
                Console.Write(a + " ");
            }

            return array;
        }

        public static void Bublesort()
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            int first = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        first = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = first;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }

        public static int[] SortArray(int[] array)
        {
            int length = array.Length;
            int first = 0;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        first = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = first;
                    }
                }
            }

            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
            
            return array;
        }


        //return list of int from list of objects
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }

        //check if string is isogram
        public static bool IsIsogram(string str)
        {
            return str.ToUpper().Distinct().Count() == str.Length;
        }

        //square each element and sum array
        public static int SquareSum(int[] n)
        {
            return n.Select(i => i * i).Sum();
        }

        //return descending order of int
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }

        //return true if 3 given int(sides) define a triangle
        public static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c && b + c > a && a + c > b);
        }

        //remove vowels from string
        public static string Disemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            return new string(str.Where(c => !vowels.Contains(c)).ToArray());
            //return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
        }

        //reverse each word in a string
        public static string ReverseEachWords(string str)
        {
            return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
        }

        public static int SquareDigits(int n)
        {
            var num = n.ToString().ToCharArray();
            var squaredArray = num.Select(x => x * x).ToArray();

            return Convert.ToInt32(squaredArray.ToString());
        }

        public static double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "divide":
                    return a / b;
                case "multiply":
                    return a * b;
            }

            return 0;
        }

    }

       
}

