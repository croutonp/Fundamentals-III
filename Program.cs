﻿// static void PrintList(List<string> MyList)
// {
//     for (int i =0; i<MyList.Count; i++)
//     {
//         Console.WriteLine(MyList[i]);

//     }
// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);



// static void SumOfNumbers(List<int> IntList)
// {
//     int final = 0;
//     foreach (var item in IntList)
//     {
//         final +=item ;
//     }
//     Console.WriteLine(final);

// }
// List<int> TestIntList = new List<int>() {2,7,12,9,3};

// SumOfNumbers(TestIntList);



// static int FindMax(List<int> IntList)
// {
//     int result = 0;
//     for (int i = 0; i<IntList.Count; i++)
//     {
//         if (result < IntList[i])
//         {
//             result = IntList[i];
//         }

//     }

//     return result;
// }
// List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};

// Console.WriteLine(FindMax(TestIntList2));




// TODO:

// using System.Diagnostics.Metrics;

// static List<int> SquareValues(List<int> IntList)
// {
    
//     for (int i = 0; i <IntList.Count; i++) 
//     {
//         IntList[i] = IntList[i]*IntList[i];
//         Console.WriteLine(IntList[i]);
//     }
//     return IntList;
// }
// List<int> TestIntList3 = new List<int>() {1,2,3,4,5};

// SquareValues(TestIntList3);


// static int[] NonNegatives(int[] IntArray)
// {
//     for (int i = 0; i<IntArray.Length; i++)
//     {
//         if (IntArray[i] < 0)
//         {
//             IntArray[i] = 0;
//         }
//     Console.WriteLine(IntArray[i]);
    
//     }

// return IntArray;
// }
// int[] TestIntArray = new int[] {-1,2,3,-4,5};
// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);


// static void PrintDictionary(Dictionary<string,string> MyDictionary)
// {
//     foreach(KeyValuePair<string, string> Superhero in MyDictionary)
//     {
//         Console.WriteLine($"{Superhero.Key} : {Superhero.Value}");
        
//     }
// }
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
// PrintDictionary(TestDict);

// static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// {
//      foreach (string key in MyDictionary.Keys)
//     {
//         if (SearchTerm == key)
//         {
//             return true;
//         }
//     }
//     return false;
// }
// // Use the TestDict from the earlier example or make your own
// // This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// // This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));



// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here

