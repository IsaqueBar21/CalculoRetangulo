using System.Globalization;

double b, a;

b = double.Parse(Console.ReadLine());
a = double.Parse(Console.ReadLine());

double area = b * a;
double perimetro = (2 * b) + (2 * a);
double diagonal = Math.Sqrt(Math.Pow(b,2) + Math.Pow(a,2));

Console.WriteLine("Area = " + area.ToString("f4", CultureInfo.InvariantCulture));
Console.WriteLine("Perímetro = " + perimetro.ToString("f4", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal = " + diagonal.ToString("f4", CultureInfo.InvariantCulture));




