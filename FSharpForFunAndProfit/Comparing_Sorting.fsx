// https://fsharpforfunandprofit.com/posts/fvsc-quicksort/
let rec quicksort list =
    match list with
    | [] ->                         // If the list is empty
        []                          // return an empty list
    | firstElem::otherElements ->   // If the list is not empty
        let smallerElements =       // extract the smaller ones 
            otherElements
            |> List.filter (fun e -> e < firstElem)
            |> quicksort            // and sort them
        let largerElemnts =         // extract the large ones
            otherElements
            |> List.filter (fun e -> e >= firstElem)
            |> quicksort            // and sort them
        // Combine the 3 parts into a new list and return it
        List.concat [smallerElements; [firstElem]; largerElemnts]

//test
printfn "%A" (quicksort [1;5;23;18;9;1;3])

let rec quicksort2 = function
    | [] -> []
    | first::rest ->
        let smaller, larger = List.partition ((>=) first) rest
        List.concat [quicksort2 smaller; [first]; quicksort2 larger]

//test 2
printfn "%A" (quicksort2 [1;5;23;18;9;1;3])

//public class QuickSortHelper
//{
//   public static List<T> QuickSort<T>(List<T> values) 
//      where T : IComparable
//   {
//      if (values.Count == 0)
//      {
//         return new List<T>();
//      }

//      //get the first element       T firstElement = values[0];

//      //get the smaller and larger elements       var smallerElements = new List<T>();
//      var largerElements = new List<T>();
//      for (int i = 1; i < values.Count; i++)  // i starts at 1       {                                       // not 0!          var elem = values[i];
//         if (elem.CompareTo(firstElement) < 0)
//         {
//            smallerElements.Add(elem);
//         }
//         else
//         {
//            largerElements.Add(elem);
//         }
//      }

//      //return the result       var result = new List<T>();
//      result.AddRange(QuickSort(smallerElements.ToList()));
//      result.Add(firstElement);
//      result.AddRange(QuickSort(largerElements.ToList()));
//      return result;
//   }
//}