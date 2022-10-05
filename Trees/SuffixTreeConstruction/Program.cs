// See https://aka.ms/new-console-template for more information

TreeNode root = new TreeNode();
char EndSymbol = '*';

PopulateTree("babc");
System.Console.WriteLine(Contains("bc"));

void PopulateTree(string str)
{
  for (int i = 0; i < str.Length; i++)
  {
    PopulateSubTree(i, str);
  }
}

void PopulateSubTree(int i, string str)
{
    var node = root;

    for (int j=i; j < str.Length; j++)
    {
      var symbol = str[j];

      if (!node.Children.ContainsKey(symbol))
      {
          node.Children.Add(symbol, new TreeNode());
      }
      node = node.Children[symbol];
    }

    node.Children[EndSymbol] = null;
}

bool Contains(string str)
{
    var node = root;

    foreach(var symbol in str)
    {
        if (!node.Children.ContainsKey(symbol))
          return false;

          node = node.Children[symbol];
    }

    return node.Children.ContainsKey(EndSymbol);
}

public class TreeNode
{
 public Dictionary<char, TreeNode> Children = new Dictionary<char, TreeNode>();
}

