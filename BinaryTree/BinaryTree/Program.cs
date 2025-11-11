// See https://aka.ms/new-console-template for more information
using BinaryTree.Models;

var tree = new BinarySearchTree();

bool exit = false;
while (!exit)
{
    tree.PrintMessage();
    Console.Write("Select an operation: ");
    int command = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (command)
    {
        case 1:
            Console.Write("Enter any numbers to build a binary tree: ");
            var input = Console.ReadLine();
            var numbers = input!.Split(',').Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                tree.Insert(number);
            }
            Console.Write("\nBinary tree constructed\n");
            Thread.Sleep(6000);
            tree.InOrder();
            Console.Clear();
            break;
        case 2:
            Console.Write("Enter a int number to find in the tree: ");
            var valueSearch = Convert.ToInt32(Console.ReadLine());
            tree.Search(valueSearch);
            Thread.Sleep(6000);
            Console.Clear();
            break;
        case 3:
            tree.InOrder();
            Thread.Sleep(6000);
            Console.Clear();
            break;
        case 4:
            tree.GetHeight();
            Thread.Sleep(4000);
            Console.Clear();
            break;
        case 5:
            Console.WriteLine("Enter a int number to remove from the tree: ");
            var valueRemove = Convert.ToInt32(Console.ReadLine());
            tree.Remove(valueRemove);
            tree.InOrder();
            Thread.Sleep(6000);
            Console.Clear();
            break;
        default:
            Console.WriteLine("Shut down/closing app in three seconds...");
            Thread.Sleep(3000);
            exit = true;
            break;
    }
}