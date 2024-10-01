public class Challenge_one
{
     // Todo: Print out the numbers 1 - 10
     public void PrintNumbers()
     {
          for (int i = 1; i <= 10; i++)
          {
               Console.WriteLine(i);

          }
     }
     /* Todo: Print out each string that is passed to the array as an argument*/
     public void PrintStrings(string[] arr)
     {
          string[] array1 = ["en", "to", "tre"];
          foreach (String str in array1)
          {

               Console.WriteLine(str);
          }

          {

          }
     }
     /*
          Todo: Check if a number is positive, negative or zero.
          */
     public void CheckIfNumberIsPositiveOrNegative(int number)
     {
          int a = Convert.ToInt32(Console.ReadLine());
          if (a > 0)
          {
               Console.WriteLine("positive");
          }
          if (a < 0)
          {
               Console.WriteLine("negative");
          }
          if (a == 0)
          {
               Console.WriteLine("zero");
          }
     }

}


