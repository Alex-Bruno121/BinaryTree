// See https://aka.ms/new-console-template for more information
using BinaryTree.Models;

Console.WriteLine("Enter any numbers to build a binary tree");
var input = Console.ReadLine();

var numbers = input!.Split(',').Select(int.Parse).ToArray();

var tree = new BinarySearchTree();

foreach (var number in numbers)
{
    tree.Insert(number);
}

Console.WriteLine("\nBinary tree constructed\n");

Console.WriteLine("Enter a int number to find in the tree");
var valueSearch = Convert.ToInt32(Console.ReadLine());
tree.Search(valueSearch);

tree.InOrder();

tree.GetHeight();

//Method insert ✅
//Method find/Search ✅
//Method In-Order ✅
//Method GetHeight ✅