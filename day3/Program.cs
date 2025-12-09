// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, day3!");
int x;
x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine($"{x} can not  divided by 2");
}
else
{
    Console.WriteLine($"{x} be divided by by 2")
}
*/
//quadratic equation
/*

double a, b, c, term;
a= Convert.ToDouble(Console.ReadLine());
b= Convert.ToDouble(Console.ReadLine());
c= Convert.ToDouble(Console.ReadLine());
term = Math.Sqrt(b*b-4 - a * c);
if (term>0)
{
    Console.WriteLine($"x1 = {(-b + term) / (2 * a):F2} and x2 = {(-b - term) / (2 * a):F2}");
}
else
{
    Console.WriteLine("can not be all real solutions");
*/
// arithmetic sequence
/*
 int a, b, c, d,diff;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
diff = b - a;
if (diff == c - b)
{
        int a0;
        a0 = a - diff;
        Console.WriteLine($"{d}th sequence is {a0 + d * diff}");
}
else
    {
        Console.WriteLine($"{a},{b}and{c} are not arithmetic sequence");
    }
*/
// handout : number to word


int x;
Console.Write("type a nunber[0-999]: ");
x = Convert.ToInt32(Console.ReadLine());
if ((x >= 0) && (x <= 10))
{
    if (x == 0)
    {
        Console.WriteLine("Zero");
    }
    else if (x == 1)
    {
        Console.WriteLine("One");
    }
    else if (x == 2)
    {
        Console.WriteLine("Two");
    }
    else if (x == 3)
    {
        Console.WriteLine("Three");
    }
    else if (x == 4)
    {
        Console.WriteLine("Four");
    }
    else if (x == 5)
    {
        Console.WriteLine("Five");
    }
    else if (x == 6)
    {
        Console.WriteLine("Six");
    }
    else if (x == 7)
    {
        Console.WriteLine("Seven");
    }
    else if (x == 8)
    {
        Console.WriteLine("Eight");
    }
    else if (x == 9)
    {
        Console.WriteLine("Nine");
    }
    else if (x == 10)
    {
        Console.WriteLine("Ten");
    }
}
else if ((x > 10) && (x <= 99))
{
    if (x == 11)
    {
        Console.WriteLine("Eleven");
    }
    else if (x == 12)
    {
        Console.WriteLine("Twelve");
    }
    else if (x == 13)
    {
        Console.WriteLine("Thirteen");
    }
    else if (x == 14)
    {
        Console.WriteLine("Fourteen");
    }
    else if (x == 15)
    {
        Console.WriteLine("Fifteen");
    }
    else if (x == 16)
    {
        Console.WriteLine("Sixteen");
    }
    else if (x == 17)
    {
        Console.WriteLine("Seventeen");
    }
    else if (x == 18)
    {
        Console.WriteLine("Eighteen");
    }
    else if (x == 19)
    {
        Console.WriteLine("Nineteen");
    }
    else if (x == 20)
    {
        Console.WriteLine("Twenty");
    }
    else
    {
        int a, b;
        string res, res1;
        res = "";
        res1 = "";
        a = x % 10;
        b = (x - a) / 10;
        Console.WriteLine($"{b * 10}+{a}");
        if (b == 2)
        {
            res = "Twenty";
        }
        else if (b == 3)
        {
            res = "Thirty";
        }
        else if (b == 4)
        {
            res = "Fourty";
        }
        else if (b == 5)
        {
            res = "Fifty";
        }
        else if (b == 6)
        {
            res = "Sixty";
        }
        else if (b == 7)
        {
            res = "Seventy";
        }
        else if (b == 8)
        {
            res = "Eighty";
        }
        else if (b == 9)
        {
            res = "Ninety";
        }
        if (a == 1)
        {
            res1 = "One";
        }
        else if (a == 2)
        {
            res1 = "Two";
        }
        else if (a == 3)
        {
            res1 = "Three";
        }
        else if (a == 4)
        {
            res1 = "Four";
        }
        else if (a == 5)
        {
            res1 = "Five";
        }
        else if (a == 6)
        {
            res1 = "Six";
        }
        else if (a == 7)
        {
            res1 = "Seven";
        }
        else if (a == 8)
        {
            res1 = "Eight";
        }
        else if (a == 9)
        {
            res1 = "Nine";
        }
        Console.WriteLine($"{res} and {res1}");
    }
}
else if (x >= 100)
{
    int a, b, c;
    a = x % 10;
    b = ((x - a) / 10) % 10;
    c = (x - b * 10 - a) / 100;
    Console.WriteLine($"{c * 100}+{b * 10}+{a}");
}



