/* first **********************************************/
/*Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter your surName: ");
string surName = Console.ReadLine();
Console.WriteLine("Enter your year of birth: ");
int birthYear = int.Parse(Console.ReadLine());
int yearNow = DateTime.Now.Year;

Console.WriteLine($"Aš {name} {surName}. Man yra {yearNow - birthYear} metai(ų).");*/

/* second ********************************************/
/*Random rnd = new Random();
double a = rnd.Next(1, 5);
double b = rnd.Next(1, 5);
Console.WriteLine(a + " " + b);

if (a > b)
{
    Console.WriteLine("result : "  + Math.Round(a /b, 2));
}
else if (b > a)
{
    Console.WriteLine("result : " + Math.Round(b /a, 2));
} else
{
    Console.WriteLine("Something went wrong");
}*/

/* third ********************************************/
/*Random rnd = new Random();
int a = rnd.Next(0, 25);
int b = rnd.Next(0, 25);
int c = rnd.Next(0, 25);
Console.WriteLine(a + " " + b + " " + c);
if ((a > c || a > b) && (a < c || a < b))
{
    Console.WriteLine(a + " A yra tarp B ir C");
} else if ((b > c || b > a) && (b < c || b < a))
{
    Console.WriteLine(b + " B yra tarp A ir C");
} else if ((c > a || c > b) && (c < b || c < a))
{
    Console.WriteLine(c + " C yra tarp A ir B");
}
else
{
    Console.WriteLine("something went wrong, check the random numbers");
    Console.WriteLine("maybe some of them are equal to other");
}*/

/* fourth ********************************************/
/*Random rnd = new Random();
int a = rnd.Next(1, 10);
int b = rnd.Next(1, 10);
int c = rnd.Next(1, 10);
Console.WriteLine(a + " " + b + " " + c);
if ((a+b > c) && (a+c > b) && (b+c > a))
{
    Console.WriteLine("galima sudaryti trikampį");
}
else
{
    Console.WriteLine("negalima sudaryti trikampio");
}*/

/* fifth ********************************************/
/*Random rnd = new Random();
int a = rnd.Next(0, 3);
int b = rnd.Next(0, 3);
int c = rnd.Next(0, 3);
int d = rnd.Next(0, 3);
int zeros=0;
int ones = 0;
int twos = 0;
Console.WriteLine(a + " " + b + " " + c + " " + d);

if (a == 0)
{
    zeros++;
} else if (a == 1)
{
    ones++;
} else if(a == 2)
{
    twos++;
}

if (b == 0)
{
    zeros++;
}
else if (b == 1)
{
    ones++;
}
else if (b == 2)
{
    twos++;
}

if (c == 0)
{
    zeros++;
}
else if (c == 1)
{
    ones++;
}
else if (c == 2)
{
    twos++;
}

if (d == 0)
{
    zeros++;
}
else if (d == 1)
{
    ones++;
}
else if (d == 2)
{
    twos++;
}

Console.WriteLine("number of zeros : " + zeros);
Console.WriteLine("number of ones : " + ones);
Console.WriteLine("number of twos : " + twos);*/

/* sixth ********************************************/
/*Random rnd = new Random();
int a = rnd.Next(-10, 10);
int b = rnd.Next(-10, 10);
int c = rnd.Next(-10, 10);
Console.WriteLine(a + " " + b + " " + c);

if (a > 0)
{
    Console.WriteLine("(" + a + ")");
} else if (a < 0)
{
    Console.WriteLine("[" + a + "]");
}

if (b > 0)
{
    Console.WriteLine("(" + b + ")");
}
else if (b < 0)
{
    Console.WriteLine("[" + b + "]");
}

if (c > 0)
{
    Console.WriteLine("(" + c + ")");
}
else if (c < 0)
{
    Console.WriteLine("[" + c + "]");
}*/

/* seventh ********************************************/
/*Random rnd = new Random();
int candles = rnd.Next(5, 3000);
double priceDiscount;
double price = 1;
Console.WriteLine("Number of candles ordered " + candles);

if (candles > 1000 && candles <= 2000)
{
    priceDiscount = 0.03;
} else if (candles > 2000)
{
    priceDiscount = 0.04;
} else
{
    priceDiscount = 0;
}

price = price - priceDiscount;

Console.WriteLine("As you buy " + candles + ", your discount is " + priceDiscount * 100 + " %");
Console.WriteLine("So the price for " + candles + " is " + candles*price + "Eur");*/

/* eighth ********************************************/
/*Random rnd = new Random();
int a = rnd.Next(0, 100);
int b = rnd.Next(0, 100);
int c = rnd.Next(0, 100);
int firstAverage = 0;
int secondAverage = 0;
int dividedBy = 0;
Console.WriteLine(a + " " + b + " " + c);

firstAverage = (a + b + c) * 3;
Console.WriteLine("pirmasis aritmetinis vidurkis " + firstAverage);

if(a < 90 && a > 10)
{
    secondAverage = secondAverage + a;
    dividedBy++;
}

if (b < 90 && b > 10)
{
    secondAverage = secondAverage + b;
    dividedBy++;
}

if (c < 90 && c > 10)
{
    secondAverage = secondAverage + c;
    dividedBy++;
}

secondAverage = secondAverage/ dividedBy;

Console.WriteLine("divided by " + dividedBy);
Console.WriteLine("antrasis aritmetinis vidurkis " + secondAverage);*/

/*extra 1 *****************************************/
/*string name = "Edgar";
Console.WriteLine("Labas " + name + "!");*/


/*extra 2 ***************************************/
/*int a = 5;
int b = 2;
Console.WriteLine("result : " + (a+b));*/

/*extra 3 ***************************************/
/*int age = 28;
Console.WriteLine("your age today is " + age);
Console.WriteLine("your age after 5 years is " + (age+5));*/

/*extra 4 ***************************************/
/*double a = 10;
double b = 12;
Console.WriteLine("plotas : " + (a*b));*/

/*extra 5 ***************************************/
/*int num = int.Parse(Console.ReadLine());
num = num % 2;
if (num == 0)
{
    Console.WriteLine("Lyginis");
} else
{
    Console.WriteLine("Nelyginis");
}*/

/*extra 6 ***************************************/
/*string character = Console.ReadLine();
if (character == "a" ||  character == "e" || character == "i" || character == "u" || character == "o")
{
    Console.WriteLine("balsė");
} else
{
    Console.WriteLine("priebalsė");
}*/

/*extra 7 ***************************************/
/*Console.WriteLine("Enter temperature of monday");
double t1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter temperature of tuesday");
double t2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter temperature of wednesday");
double t3 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter temperature of thursday");
double t4 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter temperature of friday");
double t5 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter temperature of saturday");
double t6 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter temperature of sunday");
double t7 = double.Parse(Console.ReadLine());

double result = (t1 + t2 + t3 + t4 + t5 + t6 + t7) / 7;
Console.WriteLine("On average temperature was " + Math.Round(result, 1) + "C this week");*/

/*extra 8 ***************************************/
/*Console.WriteLine("Please, enter the price");
double initialPrice = double.Parse(Console.ReadLine());
Console.WriteLine("VAT %");
double vatPercentage = double.Parse(Console.ReadLine());
double finalPrice = initialPrice + (initialPrice * (vatPercentage/100));

Console.WriteLine("final price with VAT is " + Math.Round(finalPrice, 2));*/

/*extra 9 ***************************************/
/*Console.WriteLine("KMI");
Console.WriteLine("Please enter your weight");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter your height");
double height = double.Parse(Console.ReadLine());
double kmi = weight / (Math.Pow(height, 2)/100);
Console.WriteLine("KMI is " + Math.Round((kmi * 100),1));*/