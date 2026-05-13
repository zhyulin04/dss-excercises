using System;

int people = int.Parse(Console.ReadLine());
string group = Console.ReadLine();
string day = Console.ReadLine();

double pricePerPerson = 0;

if (group == "Students")
{
    if (day == "Friday")
    {
        pricePerPerson = 8.45;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 9.80;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 10.46;
    }
}
else if (group == "Business")
{
    if (day == "Friday")
    {
        pricePerPerson = 10.90;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 15.60;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 16;
    }

    if (people >= 100)
    {
        people -= 10;
    }
}
else if (group == "Regular")
{
    if (day == "Friday")
    {
        pricePerPerson = 15;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 20;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 22.50;
    }
}

double totalPrice = people * pricePerPerson;

if (group == "Students" && people >= 30)
{
    totalPrice *= 0.85;
}

if (group == "Regular" && people >= 10 && people <= 20)
{
    totalPrice *= 0.95;
}

Console.WriteLine($"Total price: {totalPrice:F2}");