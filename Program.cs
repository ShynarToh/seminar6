// : Задайте двумерный массив символов (тип char 
//[,]). Создать строку из символов этого массива. a b c => “abcdef” d e f 

namespace String_2 {
    class Program {
        static void Main (string [] arg){
            char [,] chars = new char [,] {{'2', '2','f', 'n'},
           {'1', '2', 'f', 'v'} };
            System.Console.WriteLine(CreateString(chars));

        }
        static string CreateString(char [,] array)  {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string result = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array[i,j];
                }
                
            }
            return result;
        }
    }
 }
