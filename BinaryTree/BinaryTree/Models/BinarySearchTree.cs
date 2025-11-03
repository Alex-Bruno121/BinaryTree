namespace BinaryTree.Models;

public class BinarySearchTree
{
    private Node? Root;

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    public void Search(int value)
    {
        var node = SearchValueTreeRecursive(Root, value);
        if (!node)
            Console.WriteLine("Value not found in tree\n");
        else
            Console.WriteLine("Value finded in tree\n");
    }

    public void InOrder()
    {
        var values = GetValuesInOrder(Root, Root!.Value);
        Console.WriteLine("Values in-order: ");
        Console.WriteLine(string.Join(", ", values) + "\n");
    }

    public void GetHeight()
    {
        int height = CalculateHeight(Root);
        Console.WriteLine($"Height from tree is: {height}");
    }

    public static int CalculateHeight(Node? root)
    {
        if (root is null)
            return -1;

        if (root.Left is null || root.Right is null)
            return 0;

        int leftHeight = CalculateHeight(root!.Left);
        int rightHeight = CalculateHeight(root!.Right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    //Busca recursiva na árvore binária até encontrar os valores em ordem
    public static List<int> GetValuesInOrder(Node? root, int values)
    {
        var result = new List<int>();

        if (root is null)
            return result;

        if (root.Left is null)
        {
            if (!result.Contains(values))
                result.Add(values);

            if (root.Left is null && root.Right is not null)
            {
                var res = GetValuesInOrder(root.Right, root.Right.Value);
                if (!result.Contains(res[0]))
                    result.AddRange(res);
            }

            return result;
        }

        result.AddRange(GetValuesInOrder(root.Left, root.Left.Value));

        if (!result.Contains(root.Value))
            result.Add(root.Value);

        if (root.Right is null)
        {
            if (!result.Contains(values))
                result.Add(values);

            if (root.Right is null && root.Left is not null)
            {
                var res = GetValuesInOrder(root.Left, root.Left.Value);
                if (!result.Contains(res[0]))
                    result.AddRange(res);
            }

            return result;
        }

        result.AddRange(GetValuesInOrder(root.Right, root.Right.Value));

        if (!result.Contains(root.Value))
            result.Add(root.Value);

        return result;
    }

    //Busca recursiva na árvore binária de busca
    private static bool SearchValueTreeRecursive(Node? root, int value)
    {
        bool exists = false;

        if (root is null)
            return false;

        if (root.Value == value)
            exists = true;

        //se o valor for menor que o valor do nó atual,
        //entra no metodo metodo e verifica se o valor existe na subárvore esquerda,
        //se repete até encontrar o valor ou chegar em um nó nulo
        if (value < root.Value)
            exists = SearchValueTreeRecursive(root.Left, value);

        //se o valor for menor que o valor do nó atual,
        //entra no metodo metodo e verifica se o valor existe na subárvore direita,
        //se repete até encontrar o valor ou chegar em um nó nulo
        if (value > root.Value)
            exists = SearchValueTreeRecursive(root.Right, value);

        return exists;
    }

    //Inserção recursiva na árvore binária de busca
    private static Node InsertRecursive(Node? root, int value)
    {
        if (root is null)
            return new Node(value);

        //se o valor for menor que o valor do nó atual, insere na subárvore esquerda
        if (value < root.Value)
            root.Left = InsertRecursive(root.Left, value);

        //se o valor for maior que o valor do nó atual, insere na subárvore direita
        if (value > root.Value)
            root.Right = InsertRecursive(root.Right, value);

        return root;
    }
}
