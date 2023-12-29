namespace week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PlusMinus();
            // MiniMaxSum();
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
    }
}