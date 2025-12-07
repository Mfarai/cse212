public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Problem 1: Only insert unique values (no duplicates)
        if (value == Data)
        {
            // Value already exists, do not insert duplicate
            return;
        }
        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // Problem 2: Search for a value in the tree
        if (value == Data)
        {
            // Found the value
            return true;
        }
        else if (value < Data)
        {
            // Search in the left subtree
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // Search in the right subtree
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Problem 4: Calculate the height of the tree
        // Height is 1 + max height of left or right subtree
        
        int leftHeight = 0;
        int rightHeight = 0;
        
        // Get height of left subtree
        if (Left is not null)
        {
            leftHeight = Left.GetHeight();
        }
        
        // Get height of right subtree
        if (Right is not null)
        {
            rightHeight = Right.GetHeight();
        }
        
        // Return 1 (for current node) plus the maximum of the two subtree heights
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}