﻿namespace DataStructure;

public static class Data
{
    public static int[] SortedData =
    [
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
        31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58,
        59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86,
        87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100,1200
    ];

    private static readonly Random Rand = new Random();

    public static readonly int[] UnsortedData = Enumerable
        .Repeat(0, 100)
        .Select(i => Rand.Next(1, 100)).ToArray();

    public static int[] StaticData = [10, 48, 29, 47, 15, 3, 41, 11, 19, 4, 27, 27, 23, 12, 45, 44, 34, 25, 41, 20];


}