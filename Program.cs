// Test cases
Console.WriteLine(IsGoodBinaryString("1100"));  // Output: true
Console.WriteLine(IsGoodBinaryString("11001")); // Output: false
Console.WriteLine(IsGoodBinaryString("1010"));  // Output: true
Console.WriteLine(IsGoodBinaryString("1001"));  // Output: false
Console.WriteLine(IsGoodBinaryString(""));      // Output: true (Empty string is trivially 'good')

static bool IsGoodBinaryString(string binaryString)
{
    int onesCount = 0;
    int zerosCount = 0;

    // Iterate through the binary string
    foreach (char ch in binaryString)
    {
        if (ch == '1')
        {
            onesCount++;
        }
        else if (ch == '0')
        {
            zerosCount++;
        }

        // At any point, number of 1's must not be less than number of 0's
        if (zerosCount > onesCount)
        {
            return false;
        }
    }

    // Check if the number of 0's and 1's are equal
    return onesCount == zerosCount;
}