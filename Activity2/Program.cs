Console.Write("Enter length(in centimeters)>>> ");
int cm = Convert.ToInt32(Console.ReadLine());
int yards, foot, inches;
yards = (int)(cm / 91.44);
foot = (int)((cm % 91.44) / 30.48);
inches = (int)((cm % 91.44) % 30.48 / 2.54);
Console.WriteLine(yards + " yards, " + foot + " feet (foot), " + inches + " inches");