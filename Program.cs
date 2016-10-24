using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HackerRankSolutions
{
    class Program
    {

        #region Day8Mapping

        //static void Main(string[] args)
        //{

        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    Dictionary<string, string> openWith =
        //       new Dictionary<string, string>();
        //    int n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < n; i++)
        //    {
        //        string[] tokens = Console.ReadLine().Split(' ');
        //        openWith.Add(tokens[0], tokens[1]);

        //    }
        //    string key = null;
        //    while (!string.IsNullOrEmpty(key = Console.ReadLine()))
        //    {
        //        //Console.ReadLine();
        //        if (openWith.ContainsKey(key))
        //        {
        //            Console.WriteLine(key + "=" + openWith[key]);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not Found");
        //        }
        //    }
        //}

        #endregion


        #region Day9Recursion

        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    int N = int.Parse(Console.ReadLine());
        //    int result = factorial(N);
        //    Console.WriteLine(result);
        //}

        //static int factorial(int n)
        //{
        //    if (n <= 20 && n >= 2)
        //        return (n * factorial(n - 1));
        //    else
        //        return n;

        //}

        #endregion


        #region Day10_Binarytodecimal

        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    DecToBinary(n);
        //}

        //static void DecToBinary(int n)
        //{
        //    int max = 0;

        //    string test = null;
        //    List<int> stack = new List<int>();
        //    while (n > 0)
        //    {
        //        int reminder = n % 2;
        //        n = n/2;
        //       stack.Add(reminder);

        //    }


        //    for (int i =0; i < stack.Count; i++)
        //    {
        //        test += stack[i].ToString();

        //        }
        //    char x = '0';
        //    string[] ones = test.Split(x);
        //    for (int j=0;j<ones.Length;j++)
        //    {
        //        if (ones[j].Length > max)
        //            max = ones[j].Length;
        //    }
        //    Console.WriteLine(max);
        //}


        #endregion


        #region Day11_2Darrays

        //static void Main(String[] args)
        //{
        //    int[][] arr = new int[6][];
        //    for (int arr_i = 0; arr_i < 6; arr_i++)
        //    {
        //        string[] arr_temp = Console.ReadLine().Split(' ');
        //        arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        //    }

        //    int[] sum = new int[16];
        //    int h = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            sum[h] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
        //                    + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1]
        //                    + arr[i + 2][j + 2];
        //            h++;
        //        }
        //    }
        //    Array.Sort(sum);
        //    Console.WriteLine(sum[15]);
        //}

        #endregion


        #region Day12_Inheritance

        //class Person
        //{
        //    protected string firstName;
        //    protected string lastName;
        //    protected int id;

        //    public Person() { }
        //    public Person(string firstName, string lastName, int identification)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //        this.id = identification;
        //    }
        //    public void printPerson()
        //    {
        //        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        //    }
        //}
        //class Student : Person
        //{
        //    private int[] testScores;



        //    public Student(string firstName, string lastName, int id,int[] scores)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //        this.id = id;
        //        this.testScores = scores;
        //    }

        //    public char calculate()
        //    {

        //        //int sum = testScores.Sum();
        //        int sum = 0;
        //        for (int i = 0; i < testScores.Length; i++)
        //        {
        //             sum += testScores[i];
        //        }
        //        int avg = sum/testScores.Length;
        //        if (avg <=100 && avg >= 90)
        //        {
        //            return 'O';
        //        }else if (avg <90 && avg >= 80)
        //        {
        //            return 'E';
        //        }
        //        else if (avg < 80 && avg >= 70)
        //        {
        //            return 'A';
        //        }
        //        else if (avg < 70 && avg >= 55)
        //        {
        //            return 'P';
        //        }
        //        else if (avg <55 && avg >=40)
        //        {
        //            return 'D';
        //        }
        //        else
        //        {
        //            return 'T';
        //        }
        //    }
        //}

        //static void Main()
        //{
        //    string[] inputs = Console.ReadLine().Split();
        //    string firstName = inputs[0];
        //    string lastName = inputs[1];
        //    int id = Convert.ToInt32(inputs[2]);
        //    int numScores = Convert.ToInt32(Console.ReadLine());
        //    inputs = Console.ReadLine().Split();
        //    int[] scores = new int[numScores];
        //    for (int i = 0; i < numScores; i++)
        //    {
        //        scores[i] = Convert.ToInt32(inputs[i]);
        //    }

        //    Student s = new Student(firstName, lastName, id, scores);
        //    s.printPerson();
        //    Console.WriteLine("Grade: " + s.calculate() + "\n");
        //}

        #endregion


        #region Day13_Abstract Classes

        //abstract class Book
        //{

        //    protected String title;
        //    protected String author;

        //    public Book(String t, String a)
        //    {
        //        title = t;
        //        author = a;
        //    }

        //    public abstract void display();

        //}

        //class MyBook : Book
        //{
        //    private int price;
        //    public MyBook(string t, string a,int p) : base(t, a)
        //    {
        //        this.title = t;
        //        this.author = a;
        //        this.price = p;

        //    }

        //    public override void display()
        //    {
        //        Console.WriteLine("Title: "+title+"\n"+ "Author: "+author+"\n"+"Price: "+price);
        //    }
        //}


        //static void Main(String[] args)
        //{
        //    String title = Console.ReadLine();
        //    String author = Console.ReadLine();
        //    int price = Int32.Parse(Console.ReadLine());
        //    Book new_novel = new MyBook(title, author, price);
        //    new_novel.display();
        //}

        #endregion


        #region Day14_Scope

        //class Difference
        //{
        //    private int[] elements;
        //    public int maximumDifference;

        //    public Difference(int[] elements)
        //    {
        //        this.elements = elements;

        //    }
        //    public void computeDifference()
        //    {
        //        Array.Sort(elements);
        //            if (maximumDifference < Math.Abs(elements[elements.Length-1] - elements[0] )) 
        //            {
        //                maximumDifference = Math.Abs(elements[elements.Length-1] - elements[0]);
        //            }


        //    }

        //}
        //static void Main(string[] args)
        //{
        //    Convert.ToInt32(Console.ReadLine());

        //    int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        //    Difference d = new Difference(a);

        //    d.computeDifference();

        //    Console.Write(d.maximumDifference);
        //}

        #endregion


        #region Day15_Linkedlist

        //internal class Node
        //{
        //    public int data;
        //    public Node next;
        //    public Node(int d)
        //    {
        //        data = d;
        //        next = null;
        //    }

        //}

        //public static Node insert(Node head, int data)
        //{
        //    //Complete this method
        //    Node temp = head;
        //    //Node current = head;
        //    if (head == null)
        //    {
        //        return new Node(data);
        //    }
        //    while (head.next != null)
        //    {
        //        head = head.next;
        //    }
        //    Node newNode = new Node(data);
        //    head.next = newNode;
        //    return temp;
        //}

        //    public static void display(Node head)
        //    {
        //        Node start = head;
        //        while (start != null)
        //        {
        //            Console.Write(start.data + " ");
        //            start = start.next;
        //        }
        //    }
        //    static void Main(String[] args)
        //    {

        //        Node head = null;
        //        int T = Int32.Parse(Console.ReadLine());
        //        while (T-- > 0)
        //        {
        //            int data = Int32.Parse(Console.ReadLine());
        //            head = insert(head, data);
        //        }
        //        display(head);
        //    }

        #endregion


        #region Day17_MoreExceptions

        // class Calculator
        //{
        //     public static int power(int n, int p)
        //    {
        //        int test = 0;

        //        if (n < 0 || p < 0)
        //            {
        //                throw new Exception("n and p should be non-negative");
        //            }
        //            else { test = (int)Math.Pow(n, p); }


        //         return test;
        //    }
        //}

        //static void Main(String[] args)
        //{
        //    Calculator myCalculator = new Calculator();
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        string[] num = Console.ReadLine().Split();
        //        int n = int.Parse(num[0]);
        //        int p = int.Parse(num[1]);
        //        try
        //        {
        //            int ans = Calculator.power(n, p);
        //            Console.WriteLine(ans);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);

        //        }
        //    }

        //}
        #endregion


        #region Day18_Queues_Stacks

        //    Queue<char> queue = new Queue<char>();
        //    Stack<char> stack = new Stack<char>();

        //void pushCharacter(char c)
        //{
        //    stack.Push(c);
        //}

        //void enqueueCharacter(char c)
        //{
        //    queue.Enqueue(c);
        //}

        //char popCharacter()
        //{
        //   return stack.Pop();
        //}

        //char dequeueCharacter()
        //{
        //    return queue.Dequeue();
        //}

        //static void Main(String[] args)
        //{
        //    // read the string s.
        //    string s = Console.ReadLine();

        //    // create the Solution class object p.
        //    Program obj = new Program();

        //    // push/enqueue all the characters of string s to stack.
        //    foreach (char c in s)
        //    {
        //        obj.pushCharacter(c);
        //        obj.enqueueCharacter(c);
        //    }

        //    bool isPalindrome = true;

        //    // pop the top character from stack.
        //    // dequeue the first character from queue.
        //    // compare both the characters.
        //    for (int i = 0; i < s.Length / 2; i++)
        //    {
        //        if (obj.popCharacter() != obj.dequeueCharacter())
        //        {
        //            isPalindrome = false;

        //            break;
        //        }
        //    }

        //    // finally print whether string s is palindrome or not.
        //    if (isPalindrome)
        //    {
        //        Console.Write("The word, {0}, is a palindrome.", s);
        //    }
        //    else
        //    {
        //        Console.Write("The word, {0}, is not a palindrome.", s);
        //    }
        //}

        #endregion


        #region Day19_Interfaces

        //public interface AdvancedArithmetic
        //{
        //    int divisorSum(int n);
        //}

        //class Calculator:AdvancedArithmetic
        //{
        //    public Calculator()
        //    {

        //    }

        //    public int divisorSum(int n)
        //    {
        //        int sum = 0;
        //        for (int i = 1; i <= n; i++)
        //        {
        //            if (n%i==0)
        //            {
        //                sum += i;
        //            }
        //        }
        //        return sum;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int n = Int32.Parse(Console.ReadLine());
        //    AdvancedArithmetic myCalculator = new Calculator();
        //    int sum = myCalculator.divisorSum(n);
        //    Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        //}

        #endregion


        #region Day20_Sorting



        //static void Main(String[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    string[] a_temp = Console.ReadLine().Split(' ');
        //    int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        //    int numberOfSwaps = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        // Track number of elements swapped during a single array traversal


        //        for (int j = 0; j < n - 1; j++)
        //        {
        //            // Swap adjacent elements if they are in decreasing order
        //            if (a[j] > a[j + 1])
        //            {
        //                //swap(a[j], a[j + 1]);
        //                int tmp = a[j];
        //                a[j] = a[j + 1];
        //                a[j + 1] = tmp;
        //                numberOfSwaps++;
        //            }
        //        }

        //        // If no elements were swapped during a traversal, array is sorted
        //        if (numberOfSwaps == 0)
        //        {
        //            break;
        //        }
        //    }

        //    Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
        //    Console.WriteLine("First Element: {0} ", a[0]);
        //    Console.WriteLine("Last Element: {0}", a[n-1]);

        //}

        #endregion


        #region Day21_Generics

        //static void printArray<T>(T[] a)
        //{
        //    foreach (T n in a)
        //    {
        //        Console.Write("{0} ", n);
        //    }
        //    Console.WriteLine();
        //}
        //static void Main(string[] args)
        //{
        //    int[] vInt = new int[] { 1, 2, 3 };
        //    string[] vString = new string[] { "Hello", "World" };

        //    printArray<int>(vInt);
        //    printArray<string>(vString);
        //}

        #endregion


        #region Day22_Binary_Search_Trees

        //class Node
        //{
        //    public Node left, right;
        //    public int data;
        //    public Node(int data)
        //    {
        //        this.data = data;
        //        left = right = null;
        //    }
        //}

        //static int getHeight(Node root)
        //{
        //    //Write your code here
        //    if (root==null)
        //    {
        //        return -1;
        //    }

        //    int leftDepth = getHeight(root.left);
        //    int rightDepth = getHeight(root.right);

        //    return (leftDepth > rightDepth ? leftDepth : rightDepth)+1;

        //}


        //static Node insert(Node root, int data)
        //{
        //    if (root == null)
        //    {
        //        return new Node(data);
        //    }
        //    else
        //    {
        //        Node cur;
        //        if (data <= root.data)
        //        {
        //            cur = insert(root.left, data);
        //            root.left = cur;
        //        }
        //        else
        //        {
        //            cur = insert(root.right, data);
        //            root.right = cur;
        //        }
        //        return root;
        //    }
        //}
        //static void Main(String[] args)
        //{
        //    Node root = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        int data = Int32.Parse(Console.ReadLine());
        //        root = insert(root, data);
        //    }
        //    int height = getHeight(root);
        //    Console.WriteLine(height);

        //}

        #endregion


        #region Day23_BST_Level-Order_Traversal

        //class Node
        //{
        //    public Node left, right;
        //    public int data;
        //    public Node(int data)
        //    {
        //        this.data = data;
        //        left = right = null;
        //    }
        //}
        //static void levelOrder(Node root)
        //{
        //    Queue Q = new Queue();
        //    Q.Enqueue(root);

        //    while (Q.Count > 0)
        //    {
        //        Node curNode = (Node)Q.Peek();
        //        if (curNode.left != null)
        //            Q.Enqueue(curNode.left);
        //        if (curNode.right != null)
        //            Q.Enqueue(curNode.right);
        //        Console.Write(curNode.data + " ");
        //        Q.Dequeue();
        //    }
        //}

        //static Node insert(Node root, int data)
        //{
        //    if (root == null)
        //    {
        //        return new Node(data);
        //    }
        //    else
        //    {
        //        Node cur;
        //        if (data <= root.data)
        //        {
        //            cur = insert(root.left, data);
        //            root.left = cur;
        //        }
        //        else
        //        {
        //            cur = insert(root.right, data);
        //            root.right = cur;
        //        }
        //        return root;
        //    }
        //}
        //static void Main(String[] args)
        //{
        //    Node root = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        int data = Int32.Parse(Console.ReadLine());
        //        root = insert(root, data);
        //    }
        //    levelOrder(root);

        //}


        #endregion


        #region Day24_More_LinkedLists
        //internal class Node
        //{
        //    public int data;
        //    public Node next;
        //    public Node(int d)
        //    {
        //        data = d;
        //        next = null;
        //    }

        //}
        //public static Node removeDuplicates(Node head)
        //{

        //if (head.next != null)
        //    {
        //        removeDuplicates(head.next);
        //        if (head.next.data == head.data)
        //        {
        //            head.next = head.next.next;
        //        }
        //    }


        //    return head;
        //}

        //public static Node insert(Node head, int data)
        //{
        //    Node p = new Node(data);


        //    if (head == null)
        //        head = p;
        //    else if (head.next == null)
        //        head.next = p;
        //    else
        //    {
        //        Node start = head;
        //        while (start.next != null)
        //            start = start.next;
        //        start.next = p;

        //    }
        //    return head;
        //}
        //public static void display(Node head)
        //{
        //    Node start = head;
        //    while (start != null)
        //    {
        //        Console.Write(start.data + " ");
        //        start = start.next;
        //    }
        //}
        //static void Main(String[] args)
        //{

        //    Node head = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        int data = Int32.Parse(Console.ReadLine());
        //        head = insert(head, data);
        //    }
        //    head = removeDuplicates(head);
        //    display(head);
        //}


        #endregion


        #region Day25_Running_Time_and_Complexity

        //static bool isPrime(int n)
        //{
        //    if (n <= 1)
        //        return false;
        //    else if (n <= 3)
        //        return true;
        //    else if (n % 2 == 0 || n % 3 == 0)
        //        return false;

        //    int i = 5;
        //    while (i * i <= n)
        //    {
        //        if (n % i == 0 || n % (i + 2) == 0)
        //            return false;
        //        i += 6;
        //    }

        //    return true;

        //}

        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //    int t = int.Parse(Console.ReadLine());
        //    int[] nums = new int[t];
        //    for (int i = 0; i < t; i++)
        //    {
        //        nums[i] = int.Parse(Console.ReadLine());
        //    }
        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        if (isPrime(nums[j]))
        //        {
        //            Console.WriteLine("Prime");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not prime");
        //        }
        //    }
        //}

        #endregion


        #region Day26_Nested_Logic

        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    string[] returnDate = Console.ReadLine().Split(' ');
        //    string[] expectedDate = Console.ReadLine().Split(' ');
        //    int fine = 0;

        //    if (int.Parse(returnDate[2]) > int.Parse(expectedDate[2]))
        //    {
        //        fine = 10000;
        //    }
        //    else if (int.Parse(returnDate[1]) > int.Parse(expectedDate[1]) && int.Parse(returnDate[2]) == int.Parse(expectedDate[2]))
        //    {
        //        fine = 500 * (int.Parse(returnDate[1]) - int.Parse(expectedDate[1]));
        //    }
        //    else if (int.Parse(returnDate[0]) > int.Parse(expectedDate[0]) && int.Parse(returnDate[1]) == int.Parse(expectedDate[1]) && int.Parse(returnDate[2]) == int.Parse(expectedDate[2]))
        //    {
        //        fine = 15 * (int.Parse(returnDate[0]) - int.Parse(expectedDate[0]));
        //    }

        //    Console.WriteLine(fine);

        //}

        #endregion
    }
}
/*
7
1 
1 
2 
2 
3 
3 
2
*/
