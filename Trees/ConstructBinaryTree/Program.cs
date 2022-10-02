// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var bst = Solve(new int []{ 9, 4, 20, 1, 6, 15, 170});
bst.Print("Root: ");

BST Solve(int [] array)
{
  var tree = new BST(array[0]);
  for(var idx = 1; idx < array.Length; idx++)
  {
    tree.Insert(array[idx]);
  }

  return tree;
}

public class BST
{
  public BST Left;
  public BST Right;
  public int Value;
  public BST(int value)
  {
    this.Value = value;
  }
  public void Print(string node)
  {
      System.Console.WriteLine($"{node} {this.Value}");

      if (Left is not null )
      {
        System.Console.WriteLine($"Root {this.Value}");
        this.Left.Print("Lleft:");
      }

      if (Right is not null)
      {
        System.Console.WriteLine($"Root {this.Value}");
        this.Right.Print("Right:");
      }
  }

  public BST Insert(int value)
  {
      if (this.Value < value)
      {
          if (this.Left == null)
          {
              this.Left = new BST(value);
          }
          else
          {
              this.Left.Insert(value);
          }
      }
      else
      {
          if (this.Right == null)
          {
            this.Right = new BST(value);
          }
          else
          {
            this.Right.Insert(value);
          }
      }

      return this;
  }
}