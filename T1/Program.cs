using System;

var film = new string[5];
film[0] = "Inception";
film[1] = "Dark Knight";
film[2] = "Top Gun 2";
film[3] = "Don't Look Up";
film[4] = "Top Gun";

Console.WriteLine("O'sish bo'yicha");
string tempA = "";
for(int indexA = 0; indexA < 4; indexA++)
{
    for(int indexB = indexA + 1; indexB < 5; indexB++)
    {
        if (film[indexA].CompareTo(film[indexB]) > 0)
        {
            tempA = film[indexA];
            film[indexA] = film[indexB];
            film[indexB] = tempA;
        }
    }
}

foreach(var item in film)
{
    Console.WriteLine(item);
}

Console.WriteLine("kamayish bo'yicha");
string tempB = "";
for (int indexA = 0; indexA < 4; indexA++)
{
    for (int indexB = indexA + 1; indexB < 5; indexB++)
    {
        if (film[indexB].CompareTo(film[indexA]) > 0)
        {
            tempB = film[indexA];
            film[indexA] = film[indexB];
            film[indexB] = tempB;
        }
    }
}

foreach (var item in film)
{
    Console.WriteLine(item);
}