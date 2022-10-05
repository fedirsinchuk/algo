// See https://aka.ms/new-console-template for more information


Console.WriteLine(Solve(5, new List<int> { 1,2 }));

int Solve(int stairsNumber, List<int> possibleMoves)
{
  if (stairsNumber ==0 || stairsNumber == 1)
    return 1;

  var numberOfWays = new int [stairsNumber];
  numberOfWays[0] = 1;

  for (var stair = 1; stair < stairsNumber; stair++){

      int totalMoves = 0;

      foreach(var move in possibleMoves){

        if (stair - move >= 0)
          totalMoves += numberOfWays[stair - move];

      }

      numberOfWays[stair] = totalMoves;
  }

  return numberOfWays[stairsNumber-1];

}