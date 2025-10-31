namespace BinaryTree.Models;

public class Node
{
    public int Value { get; set; } // Valor do nó: Valor utilizado para comparação, se é menor ou maior -> definindo a posição do nó na árvore
    public Node? Left { get; set; } // Filho esquerdo: Nó filho que contém valores menores que o nó atual
    public Node? Right { get; set; } // Filho direito: Nó filho que contém valores maiores que o nó atual

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}