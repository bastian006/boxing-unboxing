﻿List<object> myList = new List<object>();

        myList.Add(7);
        myList.Add(28);
        myList.Add(-1);
        myList.Add(true);
        myList.Add("chair");

        Console.WriteLine("valores de la lista:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        
        int sum = 0;
        foreach (var item in myList)
        {
            if (item is int)
            {
                sum += (int)item;
            }
        }

        Console.WriteLine("suma de los valores: " + sum);