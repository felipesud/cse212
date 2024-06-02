public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // Ignore duplicate values
    }

    public bool Contains(int value) {
        if (value == Data) {
            return true;
        }
        else if (value < Data) {
            if (Left is null) {
                return false;
            }
            else {
                return Left.Contains(value);
            }
        }
        else {
            if (Right is null) {
                return false;
            }
            else {
                return Right.Contains(value);
            }
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (Left is null && Right is null) {
            return 1;
        }
        else if (Left is null) {
            return 1 + Right.GetHeight();
        }
        else if (Right is null) {
            return 1 + Left.GetHeight();
        }
        else {
            int leftHeight = Left.GetHeight();
            int rightHeight = Right.GetHeight();
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
}