﻿using Rational_Numbers;

Console.WriteLine("Please enter 2 rational equations: ");
Console.Write("First Numerator: ");
int firstNumerator = Int32.Parse(Console.ReadLine());
Console.Write("First Denominator: ");
int firstDenominator = Int32.Parse(Console.ReadLine());

Console.Write("First Numerator: ");
int secondNumerator = Int32.Parse(Console.ReadLine());
Console.Write("First Denominator: ");
int secondDenominator = Int32.Parse(Console.ReadLine());

Rational RationalA = new Rational(firstNumerator, firstDenominator);
Rational RationalB = new Rational(secondNumerator, secondDenominator);
Rational Result;

Console.WriteLine("Choose an arithmetic operation: ");

Result = RationalA.Multiply(RationalB);
Console.WriteLine(Result.ToString());