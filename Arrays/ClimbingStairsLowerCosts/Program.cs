
System.Console.WriteLine(Solve(new List<int> { 1, 2,4,2,3,5}));

int Solve(List<int> A)
{
  if (A.Count() == 0)
    return 0;

  if (A.Count() == 1)
    return A[0];

  if (A.Count() == 2)
    return A[0]+A[1];

  var steps = new int[A.Count()];
  steps[0] = A[0];
  steps[1] = A[0] + A[1];

  for (var idx=2; idx < A.Count(); idx++){

    steps[idx] = A[idx] + Math.Min(steps[idx - 1], steps[idx - 2]);
  }

  return steps[steps.Length - 1];

}
