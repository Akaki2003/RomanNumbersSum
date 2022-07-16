using System;
using System.Collections.Generic;


public class prog
{
    public static void Main()
    {
        string RomanSum = Console.ReadLine();
        string [] Numlist = RomanSum.Split('+');
        string FirstNum = Numlist[0];
        string SecondNum = Numlist[1];
        int sum = 0;
        int counter = 0;
        int i = 0;
        while (true)
        {
            if (counter == 2)
            {
                break;
            }
            if (i == FirstNum.Length)
            {
                counter++;
                i = 0;
                FirstNum = SecondNum;
                continue;
            }
            char nextLetter = '.';
            char prevLetter = '.';
            char letter = FirstNum[i];
            if (i > 0)
            {
                prevLetter = FirstNum[i - 1];
            }
            if ((i == 0 || i<FirstNum.Length-1) && FirstNum.Length != 1)
            {
                nextLetter = FirstNum[i + 1];
            }
            if (i == FirstNum.Length - 1)
            {
                nextLetter = '.';
            }
            if (letter == 'I' && nextLetter == 'V')
            {
                sum += 4;
                i++;
                continue;
            }
            else if (letter == 'I' && nextLetter != 'V' && nextLetter != 'X')
            {
                sum++;
                i++;
                continue;
            }
            else if (letter == 'V' && prevLetter != 'I')
            {
                sum += 5;
                i++;
                continue;
            }
            else if (letter == 'I' && nextLetter == 'X')
            {
                sum += 9;
                i++;
                continue;
            }
            else if (letter == 'X' && prevLetter != 'I' && nextLetter != 'C' && nextLetter != 'L')
            {
                sum += 10;
                i++;
                continue;
            }
            else if (letter == 'X' && nextLetter == 'C')
            {
                sum += 90;
                i++;
                continue;
            }
            else if (letter == 'C' && prevLetter != 'X' && nextLetter != 'D' && nextLetter != 'M')
            {
                sum += 100;
                i++;
                continue;
            }
            else if (letter == 'I' && nextLetter != 'L')
            {
                sum += 49;
                i++;
                continue;
            }
            else if (letter == 'L' && prevLetter != 'I' && prevLetter != 'X')
            {
                sum += 50;
                i++;
                continue;
            }
            else if (letter == 'X' && nextLetter == 'L')
            {
                sum += 40;
                i++;
                continue;
            }
            else if (letter == 'C' && nextLetter == 'D')
            {
                sum += 400;
                i++;
                continue;
            }
            else if (letter == 'D' && prevLetter != 'C')
            {
                sum += 500;
                i++;
                continue;
            }
            else if (letter == 'M' && prevLetter != 'C')
            {
                sum += 1000;
                i++;
                continue;
            }
            else if (letter == 'M' && prevLetter == 'C')
            {
                sum += 900;
                i++;
                continue;
            }
            else
            {
                i++;
            }
        }
        string number = sum.ToString();
        for (int j = 0; j < number.Length; j++)
        {
            int digit = (int)Char.GetNumericValue(number[j]);
            if (j == number.Length-1)
            {
                if (digit>0 && digit < 4)
                {
                    for (int l = 0; l < digit; l++)
                    {
                        Console.Write("I");
                    }
                }
                if (digit == 4)
                {
                    Console.Write("IV");
                }
                if (digit == 5)
                {
                    Console.Write("V");
                }
                if (digit > 5 && digit < 9)
                {
                    Console.Write("V");
                    for (int l = 0; l < digit-5; l++)
                    {
                        Console.Write("I");
                    }
                }
                if (digit == 9)
                {
                    Console.Write("IX");
                }
            }
            if (j == number.Length-2)
            {
                if (digit > 0 && digit < 4)
                {
                    for (int l = 0; l < digit; l++)
                    {
                        Console.Write("X");
                    } 
                }
                if (digit == 4)
                {
                    Console.Write("XL");
                }
                if (digit == 5)
                {
                    Console.Write("L");
                }
                if (digit > 5 && digit < 9)
                {
                    Console.Write("L");
                    for (int l = 0; l < digit-5; l++)
                    {
                        Console.Write("X");
                    }
                }
                if (digit == 9)
                {
                    Console.Write("XC");
                }
            }
            if (j == number.Length-3)
            {
                if (digit > 0 && digit < 4)
                {
                    for (int l = 0; l < digit; l++)
                    {
                        Console.Write("C");
                    }
                }
                if (digit == 4)
                {
                    Console.Write("CD");
                }
                if (digit > 5 && digit < 9)
                {
                    Console.Write("D");
                    for (int l = 0; l < digit - 5; l++)
                    {
                        Console.Write("C");
                    }
                }
                if (digit == 9)
                {
                    Console.Write("CM");
                }
            }
            if (j == number.Length-4)
            {
                if (digit > 0 && digit < 3)
                {
                    for (int l = 0; l < digit; l++)
                    {
                        Console.Write("M");
                    }
                }
            }
        }

    }
}
