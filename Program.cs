namespace Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = { { 1, 2 }, { 3, 4 } };
            int[,] secondMatrix = { { 5,6 }, { 7, 8 } };

            int[,] addMaxtrix = new int[2, 2];
            int firstMatrixColumn = 0;
            int secondMatrixColumn = 0;
            for (int i =0; i <firstMatrix.GetLength(0); i++) 
            {
                addMaxtrix[firstMatrixColumn,i] = firstMatrix[firstMatrixColumn,i] + secondMatrix[secondMatrixColumn,i];   
            }
            firstMatrixColumn = 1;
            secondMatrixColumn = 1;

            for (int i = 0; i < firstMatrix.GetLength(0); i++) 
            {
                addMaxtrix[firstMatrixColumn, i] = firstMatrix[firstMatrixColumn, i] + secondMatrix[secondMatrixColumn, i];
            }
           
            foreach (int i in addMaxtrix) 
            {
                Console.WriteLine(i);   
            }
        }
    }
}
