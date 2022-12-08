
using System;
using System.Linq;

string str = "йцукенгшщзхъфывапролджэячсмитьбю ";
bool isLetter = false;
for (int i = 0; i < str.Length; i++)
{
    if ((str.ToLower()[i] < 'а' || str.ToLower()[i] > 'я') && str[i] != ' ')
    {
        isLetter = true;
        break;
    }
}

if (isLetter)
{
    Console.WriteLine("данный текст содержит символы, отличные от букв и пробела");
}
else
{
    Console.WriteLine("данный текст не содержит символы, отличные от букв и пробела");
}