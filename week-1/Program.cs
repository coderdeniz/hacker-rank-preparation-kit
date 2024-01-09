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
            //CamelCase();
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
            try
            {
                while (true)
                {
                    var text = Console.ReadLine();
                    var textArr = text.Split(";");
                    var convertedText = textArr[2];

                    if (textArr[0] == "S")
                    {
                        string splitedText = string.Empty;

                        if (textArr[1] == "M")
                        {
                            foreach (var item in convertedText)
                            {
                                if (item == '(')
                                {
                                    break;
                                }
                                if (char.IsUpper(item))
                                {
                                    splitedText = splitedText + " ";
                                    splitedText = splitedText + char.ToLower(item).ToString();
                                }
                                else
                                {
                                    splitedText += item.ToString();
                                }
                            }
                        }
                        if (textArr[1] == "C" || textArr[1] == "V")
                        {
                            for (int i = 0; i < convertedText.Length; i++)
                            {
                                if (char.IsUpper(convertedText[i]))
                                {
                                    if (i == 0)
                                    {
                                        splitedText += " ";
                                    }
                                    splitedText += char.ToLower(convertedText[i]).ToString();
                                }
                                else
                                {
                                    splitedText += convertedText[i].ToString();
                                }
                            }
                        }
                        Console.WriteLine(splitedText);
                    }
                    else if (textArr[0] == "C")
                    {
                        string splitedText = string.Empty;

                        if (textArr[1] == "M")
                        {
                            for (int i = 0; i < convertedText.Length; i++)
                            {
                                if (convertedText[i] == ' ')
                                {
                                    splitedText = splitedText + "";
                                    splitedText = splitedText + char.ToUpper(convertedText[i + 1]).ToString();
                                    i = i + 1;
                                }
                                else
                                {
                                    splitedText += convertedText[i].ToString();
                                }
                                if (i == convertedText.Length - 1)
                                {
                                    splitedText += "()";
                                }
                            }
                        }
                        if (textArr[1] == "C")
                        {
                            for (int i = 0; i < convertedText.Length; i++)
                            {
                                if (i == 0)
                                {
                                    splitedText += char.ToUpper(convertedText[i]).ToString();
                                }
                                else
                                {
                                    if (convertedText[i] == ' ')
                                    {
                                        splitedText = splitedText + "";
                                        splitedText = splitedText + char.ToUpper(convertedText[i + 1]).ToString();
                                        i = i + 1;
                                    }
                                    else
                                    {
                                        splitedText += convertedText[i].ToString();
                                    }
                                }
                            }
                        }
                        if (textArr[1] == "V")
                        {
                            for (int i = 0; i < convertedText.Length; i++)
                            {
                                if (i == 0)
                                {
                                    splitedText += convertedText[i].ToString();
                                }
                                else
                                {
                                    if (convertedText[i] == ' ')
                                    {
                                        splitedText = splitedText + "";
                                        splitedText = splitedText + char.ToUpper(convertedText[i + 1]).ToString();
                                        i = i + 1;
                                    }
                                    else
                                    {
                                        splitedText += convertedText[i].ToString();
                                    }
                                }
                            }
                        }
                        Console.WriteLine(splitedText);
                    }
                }
            }
            catch (Exception)
            {               
            }
        }        
        static void DivisibleSumPairs()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int count = 0;
            for (int i = 0; i < ar.Count(); i++)
            {
                for (int j = i + 1; j < ar.Count(); j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            textWriter.WriteLine(count);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}