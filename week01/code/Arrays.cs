public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Create a new array of doubles with size equal to 'length'
        // 2. Use a loop that runs 'length' times (from 0 to length-1)
        // 3. For each iteration at index i:
        //    - Calculate the multiple: number * (i + 1)
        //    - Store this value in the array at index i
        // 4. Return the completed array
        
        // Step 1: Create array to hold the results
        double[] result = new double[length];
        
        // Step 2-3: Loop through and calculate each multiple
        for (int i = 0; i < length; i++)
        {
            // Multiply number by (i+1) to get 1st, 2nd, 3rd, etc. multiple
            result[i] = number * (i + 1);
        }
        
        // Step 4: Return the array
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // When rotating right by 'amount', the last 'amount' elements move to the front
        // Example: {1,2,3,4,5,6,7,8,9} rotated right by 3 becomes {7,8,9,1,2,3,4,5,6}
        // The last 3 elements (7,8,9) moved to the front
        //
        // Steps:
        // 1. Calculate the split point: data.Count - amount
        //    This tells us where to split the list
        // 2. Extract the last 'amount' elements (the part that moves to front)
        //    Use GetRange(splitPoint, amount)
        // 3. Remove those elements from their current position
        //    Use RemoveRange(splitPoint, amount)
        // 4. Insert those elements at the beginning
        //    Use InsertRange(0, extractedElements)
        
        // Step 1: Calculate where to split the list
        int splitPoint = data.Count - amount;
        
        // Step 2: Get the last 'amount' elements that need to move to the front
        List<int> elementsToMove = data.GetRange(splitPoint, amount);
        
        // Step 3: Remove those elements from the end
        data.RemoveRange(splitPoint, amount);
        
        // Step 4: Insert them at the beginning
        data.InsertRange(0, elementsToMove);
    }
}