// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StriverSDEPratice.LinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedListOps list = new LinkedListOps();
        Node<int> head = new Node<int>(1);
        list.Add(2, head);
        list.Add(3, head);
        head = list.ReverseList(head);
        list.display(head);
        Console.ReadKey();
    }
}