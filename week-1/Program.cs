using System.Globalization;

namespace week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PlusMinus();
            // MiniMaxSum();
            //TimeConversion();
            //BreakingTheRecords();
        }

        static void PlusMinus()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            decimal zero = 0;
            decimal positive = 0;
            decimal negative = 0;

            foreach (var item in arr)
            {
                if (item == 0)
                {
                    zero++;
                }
                else if (item > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            Console.WriteLine(positive / arr.Count);
            Console.WriteLine(negative / arr.Count);
            Console.WriteLine(zero/arr.Count);
        }
        static void MiniMaxSum()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int max = arr.First();
            int min = arr.First();
            long sum = 0;

            foreach (var item in arr) {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
                sum += item;
            }
            
            Console.Write((sum - max) + " " + (sum - min));            
        }
        static void TimeConversion()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            var dt = DateTime.ParseExact(
              s, "hh:mm:sstt", CultureInfo.InvariantCulture
            );

            string result = $"{dt:HH:mm:ss}";

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }        
        static void BreakingTheRecords()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            int max = 0;
            int min = 0;
            int minValue = scores[0];
            int maxValue = scores[0];
            foreach (var item in scores)
            {
                if (item > maxValue)
                {
                    max++;
                    maxValue = item;
                }
                else if (item < minValue)
                {
                    min++;
                    minValue = item;
                }
            }

            List<int> result = new List<int> { max, min };

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
        static void CamelCase()
        {
            var text = Console.ReadLine();
            var textArr = text.Split(";");
            var convertedText = textArr[2];

            if (textArr[0] == "S")
            {
                if (textArr[1] == "M")
                {
                    foreach (var item in convertedText)
                    {
                        if (char.IsUpper(item))
                        {

                        }
                    }
                }
            }
            else if (textArr[0] == "C")
            {

            }
        }
    }
}