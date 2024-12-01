namespace Advent_of_Code_2024
{
    public class Day1
    {
        public int TotalDistance()
        {
            (List<int> list1, List<int> list2) = GetData();
            int totalDiff = 0;

            list1.Sort();
            list2.Sort();

            list1.ForEach(x =>
            {
                totalDiff += Math.Abs(x - list2.First());

                list2.RemoveAt(0);
            });

            return totalDiff;
        }

        public int SimilarityScore()
        {
            (List<int> list1, List<int> list2) = GetData();
            int score = 0;

            list1.ForEach(x =>
            {
                score += list2.Count(y => y == x) * x;
            });

            return score;
        }

        private (List<int>, List<int>) GetData()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            using (StreamReader reader = new StreamReader("Data/day1.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> content = line.Split("   ").ToList();
                    list1.Add(int.Parse(content.First()));
                    list2.Add(int.Parse(content.Last()));
                }
            }

            return (list1,  list2);
        }
    }
}
