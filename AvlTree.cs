namespace AlgorithmBenchmark;

public class AvlTree<T> where T : IComparable<T>
{
    private class Node
    {
        public T Data;
        public int Height;
        public Node? Left;
        public Node? Right;

        public Node(T data)
        {
            Data = data;
            Height = 1;
        }
    }

    private Node? _root;

    public void Insert(T data)
    {
        _root = Insert(_root, data);
    }

    public void Delete(T data)
    {
        _root = Delete(_root, data);
    }

    public bool Contains(T data)
    {
        return Find(_root, data) != null;
    }

    private Node? Insert(Node? node, T data)
    {
        if (node == null)
            return new Node(data);

        if (data.CompareTo(node.Data) < 0)
            node.Left = Insert(node.Left, data);
        else if (data.CompareTo(node.Data) > 0)
            node.Right = Insert(node.Right, data);
        else // Duplicate data not allowed
            return node;

        // Update height of the current node
        node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

        // Rebalance the tree
        return Balance(node);
    }

    private Node? Delete(Node? node, T data)
    {
        if (node == null)
            return null;

        int compareResult = data.CompareTo(node.Data);

        switch (compareResult)
        {
            case < 0:
                node.Left = Delete(node.Left, data);
                break;
            case > 0:
                node.Right = Delete(node.Right, data);
                break;
            default:
            {
                if (node.Left == null)
                    return node.Right;
                if (node.Right == null)
                    return node.Left;

                // Node with two children; get the inorder successor
                node.Data = MinValue(node.Right);

                // Delete the inorder successor
                node.Right = Delete(node.Right, node.Data);
                break;
            }
        }

        // Update height of the current node
        node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

        // Rebalance the tree
        return Balance(node);
    }

    private Node? Find(Node? node, T data)
    {
        if (node == null)
            return null;

        int compareResult = data.CompareTo(node.Data);

        return compareResult switch
        {
            0 => node,
            < 0 => Find(node.Left, data),
            _ => Find(node.Right, data)
        };
    }

    private int Height(Node? node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }

    private int BalanceFactor(Node? node)
    {
        if (node == null)
            return 0;
        return Height(node.Left) - Height(node.Right);
    }

    private Node? Balance(Node? node)
    {
        if (node == null)
            return null;

        int balanceFactor = BalanceFactor(node);

        switch (balanceFactor)
        {
            case > 1 when BalanceFactor(node.Left) >= 0:
                return RotateRight(node);
            case > 1:
                node.Left = RotateLeft(node.Left!);
                return RotateRight(node);
            case < -1 when BalanceFactor(node.Right) <= 0:
                return RotateLeft(node);
            case < -1:
                node.Right = RotateRight(node.Right!);
                return RotateLeft(node);
            default:
                return node;
        }
    }

    private Node RotateRight(Node y)
    {
        var x = y.Left!;
        var t2 = x.Right;

        // Perform rotation
        x.Right = y;
        y.Left = t2;

        // Update heights
        y.Height = 1 + Math.Max(Height(y.Left), Height(y.Right));
        x.Height = 1 + Math.Max(Height(x.Left), Height(x.Right));

        return x;
    }

    private Node RotateLeft(Node x)
    {
        var y = x.Right!;
        var t2 = y.Left;

        // Perform rotation
        y.Left = x;
        x.Right = t2;

        // Update heights
        x.Height = 1 + Math.Max(Height(x.Left), Height(x.Right));
        y.Height = 1 + Math.Max(Height(y.Left), Height(y.Right));

        return y;
    }

    private T MinValue(Node node)
    {
        T minValue = node.Data;
        while (node.Left != null)
        {
            minValue = node.Left.Data;
            node = node.Left;
        }
        return minValue;
    }
}
