using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine(MinutesToSeconds(5)); 
        Console.WriteLine(Increment(7)); 

        int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
        PrintArray(EvenNumberEvenIndex(nums));

        string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
        PrintArray(EvenIndexOddLength(strings));

        int[] nums2 = { 44, 5, 4, 3, 2, 10 };
        PrintArray(PowerElementIndex(nums2));

        Console.WriteLine(Multiplication2(5, 4)); 
        Console.WriteLine(Muti2(3, 6));

        int[] nums3 = { 1, 2, 3, 8, 9 };
        Console.WriteLine(AveArray(nums3)); 

        Console.ReadKey();
    }



    //**************************  Function(1) *************************

    // 1
    static int MinutesToSeconds(int minutes)
    {
        return minutes * 60;
    }

    // 2
    static int Increment(int num)
    {
        return num + 1;
    }

    // 3
    static int FirstElement(int[] arr)
    {
        return arr[0];
    }

    // 4
    static double TriangleArea(double b, double h)
    {
        return 0.5 * b * h;
    }

    // 5
    static int[] EvenNumberEvenIndex(int[] nums)
    {
        int[] temp = new int[nums.Length];
        int count = 0;

        for (int i = 0; i < nums.Length; i += 2)
        {
            if (nums[i] % 2 == 0)
            {
                temp[count++] = nums[i];
            }
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
            result[i] = temp[i];

        return result;
    }

    // 6
    static string[] EvenIndexOddLength(string[] arr)
    {
        string[] temp = new string[arr.Length];
        int count = 0;

        for (int i = 0; i < arr.Length; i += 2)
        {
            if (arr[i].Length % 2 != 0)
            {
                temp[count++] = arr[i];
            }
        }

        string[] result = new string[count];
        for (int i = 0; i < count; i++)
            result[i] = temp[i];

        return result;
    }

    // 7
    static int[] PowerElementIndex(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = (int)Math.Pow(nums[i], i);
        }

        return result;
    }

    // 8 
    static int Multiplication2(int a, int b)
    {
        int result = 0;
        for (int i = 0; i < b; i++)
        {
            result += a;
        }
        return result;
    }

    // 9
    static int Muti2(int a, int b)
    {
        int result = 1;
        for (int i = a; i <= b; i++)
        {
            result *= i;
        }
        return result;
    }

    // 10
    static double AveArray(int[] arr)
    {
        double sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;
    }

    // Helper (to print arrays)
    static void PrintArray<T>(T[] arr)
    {
        Console.Write("[ ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("]");
    }
}

//******************  Function(2) *****************************

// 1
static int GetDays(DateTime firstDate, DateTime secondDate)
{
    TimeSpan diff = secondDate - firstDate;
    return Math.Abs(diff.Days);
}

// 2
static string[] NumInStr(string[] arr)
{
    List<string> result = new List<string>();

    foreach (string item in arr)
    {
        bool hasNumber = false;

        foreach (char ch in item)
        {
            if (char.IsDigit(ch))
            {
                hasNumber = true;
                break;
            }
        }

        if (hasNumber)
        {
            result.Add(item);
        }
    }

    return result.ToArray();
}

// 3
static string ReverseOdd(string sentence)
{
    string[] words = sentence.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 != 0)
        {
            words[i] = ReverseWord(words[i]);
        }
    }

    return string.Join(" ", words);
}

static string ReverseWord(string word)
{
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

// 4
static bool IsPandigital(long num)
{
    string str = num.ToString();

    for (char digit = '0'; digit <= '9'; digit++)
    {
        if (!str.Contains(digit))
        {
            return false;
        }
    }

    return true;
}


//************************ Function(3) ************************

// 1) Add(n)(x)
static Func<int, int> Add(int n)
{
    return x => n + x;
}

// 2) remove leading and trailing zeros
static string RemoveLeadingTrailing(string n)
{
    double num = double.Parse(n);
    return num.ToString("0.############################");
}

// 3) second largest
static int SecondLargest(int[] arr)
{
    Array.Sort(arr);
    return arr[arr.Length - 2];
}

// 4) repdigit
static bool IsRepdigit(int num)
{
    if (num < 0)
        return false;

    string str = num.ToString();

    for (int i = 1; i < str.Length; i++)
    {
        if (str[i] != str[0])
            return false;
    }

    return true;
}

// 5) reverse words order
static string ReverseWords(string str)
{
    string[] words = str.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Array.Reverse(words);
    return string.Join(" ", words);
}

// 6) seven boom
static string SevenBoom(int[] arr)
{
    foreach (int num in arr)
    {
        if (num.ToString().Contains('7'))
            return "Boom!";
    }

    return "there is no 7 in the array";
}

// 7) insert whitespace
static string InsertWhitespace(string str)
{
    string result = "";

    for (int i = 0; i < str.Length; i++)
    {
        if (i > 0 && char.IsLower(str[i - 1]) && char.IsUpper(str[i]))
            result += " ";

        result += str[i];
    }

    return result;
}

// 8) count true
static int CountTrue(bool[] arr)
{
    int count = 0;

    foreach (bool item in arr)
    {
        if (item)
            count++;
    }

    return count;
}

// 9) capitals to front
static string CapToFront(string str)
{
    string upper = "";
    string lower = "";

    foreach (char ch in str)
    {
        if (char.IsUpper(ch))
            upper += ch;
        else
            lower += ch;
    }

    return upper + lower;
}

// 10) match last item
static bool MatchLastItem(object[] arr)
{
    string all = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        all += arr[i].ToString();
    }

    return all == arr[arr.Length - 1].ToString();
}

// 11) find NaN
static int FindNaN(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (double.IsNaN(arr[i]))
            return i;
    }

    return -1;
}

// 12) remove duplicates
static T[] RemoveDups<T>(T[] arr)
{
    List<T> result = new List<T>();

    foreach (T item in arr)
    {
        if (!result.Contains(item))
            result.Add(item);
    }

    return result.ToArray();
}

// 13) convert time to 24-hour format
static string ConvertTime(string time)
{
    DateTime dt = DateTime.ParseExact(time, "hh:mm:sstt", null);
    return dt.ToString("HH:mm:ss");
}

// 14) remove last vowel in each word
static string RemoveLastVowel(string sentence)
{
    string[] words = sentence.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        words[i] = RemoveLastVowelFromWord(words[i]);
    }

    return string.Join(" ", words);
}

static string RemoveLastVowelFromWord(string word)
{
    string vowels = "aeiouAEIOU";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        if (vowels.Contains(word[i]))
        {
            return word.Remove(i, 1);
        }
    }

    return word;
}

// 15) sum of cubes
static int SumOfCubes(int[] arr)
{
    int sum = 0;

    foreach (int num in arr)
    {
        sum += num * num * num;
    }

    return sum;
}

