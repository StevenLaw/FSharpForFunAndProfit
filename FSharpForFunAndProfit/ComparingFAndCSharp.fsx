// define the square function
let square x = x * x

// define the sumOfSquare function
let sumOfSquares n = 
    [1..n] |> List.map square |> List.sum

// try it
sumOfSquares 100

//public static class SumOfSquaresHelper
//{
//   public static int Square(int i)
//   {
//      return i * i;
//   }

//   public static int SumOfSquares(int n)
//   {
//      int sum = 0;
//      for (int i = 1; i <= n; i++)
//      {
//         sum += Square(i);
//      }
//      return sum;
//   }
//}

// Shorter version
let sumOfSquares2 n = 
    [1..n]
    |> List.map square
    |> List.sum

// define the square function
let squareF x = x * x

// define the sumOfSquares function
let sumOfSquaresF n = 
   [1.0 .. n] |> List.map squareF |> List.sum  // "1.0" is a float

sumOfSquaresF 100.0

// test
let s2 = square 2
let s3 = square 3
let s4 = square 4

//public static class FunctionalSumOfSquaresHelper
//{
//   public static int SumOfSquares(int n)
//   {
//      return Enumerable.Range(1, n)
//         .Select(i => i * i)
//         .Sum();
//   }
//}