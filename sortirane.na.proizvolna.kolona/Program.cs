namespace sortirane.na.proizvolna.kolona
{
    internal class Program
    {
        static void Main()
        {
            
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int sortColumn = int.Parse(input[2]);

            int[][] table = new int[rows][]; 

            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = Console.ReadLine().Split(' ');
                table[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    table[i][j] = int.Parse(rowValues[j]);
                }
            }

            
            Array.Sort(table, (a, b) => a[sortColumn].CompareTo(b[sortColumn]));

           
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", table[i]));
            }
        }
    }
}