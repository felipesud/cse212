public static class ArraysTester
{
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run()
    {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        /* Create an empty list to store the multiples: Initialize an empty list to store the multiples that will be generated.
        Iterate to generate multiples: Use a loop to iterate numberOfMultiples times, generating each multiple and adding it to the list.
        Initialize a loop that runs numberOfMultiples times.
        Inside the loop, calculate the current multiple by multiplying the startNumber by the loop index plus one (to get the first multiple, the loop index starts from 0).
        Add the calculated multiple to the list.
        Return the list of multiples: Once all multiples are generated, return the list. */

        // 1. Create an array to store the multiples
        double[] multiples = new double[length];

        // 2. Iterate to generate multiples
        for (int i = 0; i < length; i++)
        {
            // Calculate the current multiple
            multiples[i] = number * (i + 1);
        }

        // 3. Return the array of multiples
        return multiples;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)

    //Handle special cases: If the list data is null or empty, or if the amount is 0, there's nothing to rotate, so we can return early.
    //Adjust the rotation amount: Since rotating by an amount greater than the length of the list will result in the same list, we can use the modulo operator % to adjust the amount to be within the range of 0 to data.Count - 1.
    //Extract the rotated portion: Use the GetRange method to extract the last amount elements from the list.
    //Remove the rotated portion: Use the RemoveRange method to remove the extracted elements from the original list.
    //Insert the rotated portion at the beginning: Use the InsertRange method to insert the extracted elements at the beginning of the original list.
    {
        // 1. Handle special cases
        if (data == null || data.Count == 0 || amount == 0)
        {
            return; // Nothing to rotate
        }

        // 2. Adjust the rotation amount
        amount %= data.Count;

        // 3. Extract the rotated portion
        List<int> rotatedPortion = data.GetRange(data.Count - amount, amount);

        // 4. Remove the rotated portion
        data.RemoveRange(data.Count - amount, amount);

        // 5. Insert the rotated portion at the beginning
        data.InsertRange(0, rotatedPortion);
    }

}
