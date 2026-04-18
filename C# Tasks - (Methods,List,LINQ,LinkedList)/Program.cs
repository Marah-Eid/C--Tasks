//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 50, 60, 70 };

//        // Task 1: Even Numbers
//        var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
//        Console.WriteLine("Even Numbers:");
//        PrintList(evenNumbers);

//        // Task 2: Remove Duplicates
//        List<int> duplicates = new List<int> { 1, 2, 2, 3, 3, 4 };
//        var unique = duplicates.Distinct().ToList();
//        Console.WriteLine("Unique Numbers:");
//        PrintList(unique);

//        // Task 3: Max Number
//        int max = numbers.Max();
//        Console.WriteLine("Max = " + max);

//        // Task 4: Reverse List
//        numbers.Reverse();
//        Console.WriteLine("Reversed:");
//        PrintList(numbers);

//        // Task 5: Count > 50
//        int count = numbers.Count(x => x > 50);
//        Console.WriteLine("Count > 50 = " + count);

//        Console.ReadKey();
//    }

//    static void PrintList(List<int> list)
//    {
//        foreach (var item in list)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }

//    // ================= Section 2: Dictionary =================

//    Dictionary<string, int> students = new Dictionary<string, int>()
//        {
//            {"Ali", 90},
//            {"Sara", 75},
//            {"Lana", 45},
//            {"Omar", 88},
//            {"Rami", 30}
//        }

//    // Task 6: print scores > 80
//    Console.WriteLine("Task 6:");
//        foreach (var student in students)
//        {
//            if (student.Value > 80)
//            {
//                Console.WriteLine(student.Key + " : " + student.Value);
//            }
//        }

//        // Task 7: search by key
//        Console.WriteLine("\nTask 7:");
//string searchName = "Sara";
//if (students.ContainsKey(searchName))
//{
//    Console.WriteLine(searchName + " score is " + students[searchName]);
//}
//else
//{
//    Console.WriteLine("Not found");
//}

//// Task 8: sum of values
//Console.WriteLine("\nTask 8:");
//int total = students.Values.Sum();
//Console.WriteLine("Total scores = " + total);

//// Task 9: remove scores < 50
//Console.WriteLine("\nTask 9:");
//List<string> removeList = new List<string>();

//foreach (var student in students)
//{
//    if (student.Value < 50)
//    {
//        removeList.Add(student.Key);
//    }
//}

//foreach (var name in removeList)
//{
//    students.Remove(name);
//}

//foreach (var student in students)
//{
//    Console.WriteLine(student.Key + " : " + student.Value);
//}

//// Task 10: highest score
//Console.WriteLine("\nTask 10:");
//string topStudent = "";
//int highest = 0;

//foreach (var student in students)
//{
//    if (student.Value > highest)
//    {
//        highest = student.Value;
//        topStudent = student.Key;
//    }
//}

//Console.WriteLine("Highest score: " + topStudent + " : " + highest);

//// ================= Section 3: LinkedList =================

//LinkedList<string> pages = new LinkedList<string>();

//// Task 11: add first / last
//Console.WriteLine("\nTask 11:");
//pages.AddFirst("Home");
//pages.AddLast("About");
//pages.AddLast("Contact");
//PrintLinkedList(pages);

//// Task 12: remove middle element
//Console.WriteLine("\nTask 12:");
//pages.Remove("About");
//PrintLinkedList(pages);

//// Task 13: add before / after
//Console.WriteLine("\nTask 13:");
//LinkedListNode<string> homeNode = pages.Find("Home");
//pages.AddAfter(homeNode, "Services");
//pages.AddLast("Blog");
//LinkedListNode<string> blogNode = pages.Find("Blog");
//pages.AddBefore(blogNode, "Gallery");
//PrintLinkedList(pages);

//// Task 14: traverse linked list
//Console.WriteLine("\nTask 14:");
//foreach (string page in pages)
//{
//    Console.WriteLine(page);
//}

//// Task 15: first and last
//Console.WriteLine("\nTask 15:");
//Console.WriteLine("First: " + pages.First.Value);
//Console.WriteLine("Last: " + pages.Last.Value);

//Console.ReadKey();
    

//    static void PrintLinkedList(LinkedList<string> list)
//{
//    foreach (string item in list)
//    {
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//}

//// ================= Section 4: LINQ =================

//List<int> numbers = new List<int> { 10, 15, 22, 35, 44, 101, 150, 7 };

//// Task 16: odd numbers
//Console.WriteLine("Task 16:");
//var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
//PrintList(oddNumbers);

//// Task 17: multiply all by 2
//Console.WriteLine("\nTask 17:");
//var multiplied = numbers.Select(x => x * 2).ToList();
//PrintList(multiplied);

//// Task 18: sort descending
//Console.WriteLine("\nTask 18:");
//var sortedDesc = numbers.OrderByDescending(x => x).ToList();
//PrintList(sortedDesc);

//// Task 19: first number greater than 100
//Console.WriteLine("\nTask 19:");
//int firstGreaterThan100 = numbers.FirstOrDefault(x => x > 100);
//Console.WriteLine(firstGreaterThan100);

//// Task 20: average
//Console.WriteLine("\nTask 20:");
//double avg = numbers.Average();
//Console.WriteLine("Average = " + avg);

//// ================= Section 5: Mixed =================

//List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
//List<int> list2 = new List<int> { 4, 5, 6, 7, 8 };

//// Task 21: common numbers
//Console.WriteLine("\nTask 21:");
//var common = list1.Intersect(list2).ToList();
//PrintList(common);

//// Task 22: merge two lists
//Console.WriteLine("\nTask 22:");
//var merged = list1.Concat(list2).ToList();
//PrintList(merged);

//// Task 23: unique values only
//Console.WriteLine("\nTask 23:");
//var unique = merged.Distinct().ToList();
//PrintList(unique);

//// Task 24: dictionary to list
//Console.WriteLine("\nTask 24:");
//Dictionary<string, int> scores = new Dictionary<string, int>()
//        {
//            {"Ali", 90},
//            {"Sara", 120},
//            {"Lana", 70},
//            {"Omar", 150}
//        };

//List<int> valuesList = scores.Values.ToList();
//PrintList(valuesList);

//// Task 25: filter dictionary value > 100
//Console.WriteLine("\nTask 25:");
//var filtered = scores.Where(x => x.Value > 100);

//foreach (var item in filtered)
//{
//    Console.WriteLine(item.Key + " : " + item.Value);
//}

//Console.ReadKey();
//    }
//  List<int> numbers = new List<int> { 10, 25, 30, 40, 55, 60, 25 };

//// Task 26: Manual Search
//Console.WriteLine("Task 26:");
//int target = 40;
//bool found = false;

//foreach (int num in numbers)
//{
//    if (num == target)
//    {
//        found = true;
//        break;
//    }
//}

//Console.WriteLine(found ? "Found" : "Not Found");

//// Task 27: Count Even Without LINQ
//Console.WriteLine("\nTask 27:");
//int evenCount = 0;

//foreach (int num in numbers)
//{
//    if (num % 2 == 0)
//    {
//        evenCount++;
//    }
//}

//Console.WriteLine("Even count = " + evenCount);

//// Task 28: Remove While Looping
//Console.WriteLine("\nTask 28:");
//List<int> nums2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

//for (int i = nums2.Count - 1; i >= 0; i--)
//{
//    if (nums2[i] % 2 == 0)
//    {
//        nums2.RemoveAt(i);
//    }
//}

//PrintList(nums2);

//// Task 29: Find Second Largest Number
//Console.WriteLine("\nTask 29:");
//List<int> nums3 = new List<int> { 10, 50, 30, 80, 60 };

//int largest = int.MinValue;
//int secondLargest = int.MinValue;

//foreach (int num in nums3)
//{
//    if (num > largest)
//    {
//        secondLargest = largest;
//        largest = num;
//    }
//    else if (num > secondLargest && num != largest)
//    {
//        secondLargest = num;
//    }
//}

//Console.WriteLine("Second Largest = " + secondLargest);

//Console.ReadKey();
//    }

// // Task 1: Most frequent number
//        int[] arr1 = { 1, 2, 2, 3, 3, 3, 4 };
//int maxCount = 0, most = arr1[0];

//for (int i = 0; i < arr1.Length; i++)
//{
//    int count = 0;
//    for (int j = 0; j < arr1.Length; j++)
//    {
//        if (arr1[i] == arr1[j])
//            count++;
//    }
//    if (count > maxCount)
//    {
//        maxCount = count;
//        most = arr1[i];
//    }
//}
//Console.WriteLine("Most frequent: " + most);

//// Task 2: Rotate array right
//int[] arr2 = { 1, 2, 3, 4, 5 };
//int n = 2;

//for (int i = 0; i < n; i++)
//{
//    int last = arr2[arr2.Length - 1];
//    for (int j = arr2.Length - 1; j > 0; j--)
//    {
//        arr2[j] = arr2[j - 1];
//    }
//    arr2[0] = last;
//}
//PrintArray(arr2);

//// Task 3: Palindrome
//int[] arr3 = { 1, 2, 3, 2, 1 };
//bool isPal = true;

//for (int i = 0; i < arr3.Length / 2; i++)
//{
//    if (arr3[i] != arr3[arr3.Length - 1 - i])
//    {
//        isPal = false;
//        break;
//    }
//}
//Console.WriteLine("Palindrome: " + isPal);

//// Task 4: Missing number
//int[] arr4 = { 1, 2, 4, 5 };
//int sum = 0;
//for (int i = 0; i < arr4.Length; i++)
//    sum += arr4[i];

//int n4 = arr4.Length + 1;
//int total = n4 * (n4 + 1) / 2;

//Console.WriteLine("Missing: " + (total - sum));

//// Task 6: Longest increasing sequence
//int[] arr6 = { 1, 2, 2, 3, 4, 1, 2, 3 };
//int maxLen = 1, curr = 1;

//for (int i = 1; i < arr6.Length; i++)
//{
//    if (arr6[i] > arr6[i - 1])
//    {
//        curr++;
//        if (curr > maxLen)
//            maxLen = curr;
//    }
//    else
//        curr = 1;
//}
//Console.WriteLine("Longest increasing length: " + maxLen);

//// Task 7: Shortest duplicate distance
//int[] arr7 = { 1, 2, 3, 1, 4, 2, 1 };
//int minDist = int.MaxValue;

//for (int i = 0; i < arr7.Length; i++)
//{
//    for (int j = i + 1; j < arr7.Length; j++)
//    {
//        if (arr7[i] == arr7[j])
//        {
//            int dist = j - i;
//            if (dist < minDist)
//                minDist = dist;
//        }
//    }
//}
//Console.WriteLine("Min distance: " + minDist);

//// Task 8: Even then odd (stable)
//int[] arr8 = { 1, 2, 3, 4, 5, 6 };
//List<int> result = new List<int>();

//foreach (int x in arr8)
//    if (x % 2 == 0) result.Add(x);

//foreach (int x in arr8)
//    if (x % 2 != 0) result.Add(x);

//PrintList(result);

//// Task 9: Peaks
//int[] arr9 = { 1, 3, 2, 4, 1 };
//for (int i = 1; i < arr9.Length - 1; i++)
//{
//    if (arr9[i] > arr9[i - 1] && arr9[i] > arr9[i + 1])
//        Console.WriteLine("Peak: " + arr9[i]);
//}

//// Task 10: Two sum
//int[] arr10 = { 2, 7, 11, 15 };
//int target = 9;

//Dictionary<int, int> map = new Dictionary<int, int>();

//for (int i = 0; i < arr10.Length; i++)
//{
//    int need = target - arr10[i];
//    if (map.ContainsKey(need))
//    {
//        Console.WriteLine("Found: " + need + " + " + arr10[i]);
//        break;
//    }
//    map[arr10[i]] = i;
//}

//// Task 11: Shift zeros
//int[] arr11 = { 0, 1, 0, 3, 12 };
//List<int> temp = new List<int>();

//foreach (int x in arr11)
//    if (x != 0) temp.Add(x);

//while (temp.Count < arr11.Length)
//    temp.Add(0);

//PrintList(temp);

//// Task 12: Alternating merge
//int[] a1 = { 1, 2, 3 };
//int[] a2 = { 4, 5, 6 };

//List<int> merged = new List<int>();

//for (int i = 0; i < a1.Length; i++)
//{
//    merged.Add(a1[i]);
//    merged.Add(a2[i]);
//}
//PrintList(merged);

//// Task 14: Second max
//int[] arr14 = { 10, 50, 30, 80, 60 };
//int max1 = int.MinValue, max2 = int.MinValue;

//foreach (int x in arr14)
//{
//    if (x > max1)
//    {
//        max2 = max1;
//        max1 = x;
//    }
//    else if (x > max2 && x != max1)
//    {
//        max2 = x;
//    }
//}
//Console.WriteLine("Second max: " + max2);

//// Task 15: Subarray sum
//int[] arr15 = { 1, 2, 3, 7, 5 };
//int targetSum = 12;

//for (int i = 0; i < arr15.Length; i++)
//{
//    int s = 0;
//    for (int j = i; j < arr15.Length; j++)
//    {
//        s += arr15[j];
//        if (s == targetSum)
//        {
//            Console.WriteLine("Subarray found");
//            break;
//        }
//    }
//}

//// Task 20: Remove number manually
//int[] arr20 = { 1, 2, 3, 2, 4, 2, 5 };
//int remove = 2;

//List<int> newList = new List<int>();

//foreach (int x in arr20)
//{
//    if (x != remove)
//        newList.Add(x);
//}

//PrintList(newList);

//Console.ReadKey();
//    }

//    static void PrintArray(int[] arr)
//{
//    foreach (int x in arr)
//        Console.Write(x + " ");
//    Console.WriteLine();
//}

//static void PrintList(List<int> list)
//{
//    foreach (int x in list)
//        Console.Write(x + " ");
//    Console.WriteLine();
//}
//}