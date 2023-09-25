using BalancedSearchTree;

int elementsCount = int.Parse(args[0]);

var random = new Random();


var dataSet1 = DataSet(elementsCount);
var dataSet2 = DataSet(elementsCount);
var tree = new AvlTree<int>(dataSet1);

Console.WriteLine("Tree is created.");

Test(tree, dataSet1, dataSet2);

void Test(AvlTree<int> tree, int[] insertedData, int[] newData)
{
    const int numberOfOperationsInIteration = 1000;
    const int numberOfIterastions = 10000;
    for (int i = 0; i < numberOfIterastions; i++)
    {
        foreach (var number in insertedData.Take(numberOfOperationsInIteration))
        {
            tree.Contains(number);
        }

        foreach (var number in newData.Take(numberOfOperationsInIteration))
        {
            tree.Contains(number);
        }

        foreach (var number in newData.Take(numberOfOperationsInIteration))
        {
            tree.Insert(number);
        }

        foreach (var number in newData.Take(numberOfOperationsInIteration))
        {
            tree.Delete(number);
        }
    }
}

int[] DataSet(int count)
{
    var ints = Enumerable.Range(0, count)
        .Select(_ => random.Next())
        .ToArray();
    return ints;
}
