

class Task_2
{
    static void arry(string[] args)
    {
        // Define the nested array
        object[] nestedArray = new object[]
        {
            9827, 5976, 9561, 1422, 2184, 3858,
            new object[]
            {
                5323, 1457, 6664, 8481, 4380,
                new object[]
                {
                    7976, 7322, 6699, 2154, 2587, 4610,
                    new object[]
                    {
                        2581, 9977, 6956, 1203, 7467, 9292, 4454, 9133, 6837, 4196, 1269, 8726, 4499, 4934,
                        new object[] {8050, 5585, 9759, 1938, 9956}
                    },
                    5536, 6560, 4326, 2403, 8728
                },
                3308
            },
            9517, 958, 3837,
            new object[]
            {
                1522,
                new object[]
                {
                    7156, 4741,
                    new object[]
                    {
                        6300, 7602, 8031, 2597, 5356, 3639, 5596, 1761, 9878, 7025, 9467, 6089
                    },
                    new object[] {6379, 492, 6782, 945, 2120, 1460, 6503, 7309, 2490},
                    9532, 3858, 1235, 9121, 2204, 4059, 8809, 335
                },
                6977, 9755, 5196
            }
        };

        // Flatten the nested array
        List<int> flattenedArray = FlattenArray(nestedArray);

        // Print the flattened array
        Console.WriteLine("Flattened Array:");
        foreach (var item in flattenedArray)
        {
            Console.Write(item + "][");
        }
    }

    static List<int> FlattenArray(object[] nestedArray)
    {
        List<int> result = new List<int>();
        foreach (var item in nestedArray)
        {
            if (item is int)
            {
                result.Add((int)item);
            }
            else if (item is object[])
            {
                result.AddRange(FlattenArray((object[])item));
            }
            else
            {
                throw new ArgumentException("Unsupported data type in array.");
            }
        }
        return result;
    }
}
