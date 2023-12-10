namespace foobar;

public class Solution
{
    private Dictionary<int, string> _foobar = new();
    
    public Dictionary<int, string> Solve(int n)
    {
        int i;
        
        for (i = 0; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                _foobar.Add(i,"foo");
            }
            else if (i % 5 == 0 && i % 3 != 0)
            {
                _foobar.Add(i,"bar");
            }
            else if (i % 3 == 0 && i % 5 == 0 && i != 0)
            {
                _foobar.Add(i,"foobar");
            }
            else
            {
                _foobar.Add(i,String.Empty);
            }
        }

        return _foobar;
    }

    public void PrintSolution()
    {
        foreach (var foobar in _foobar)
        {
            Console.WriteLine($"{foobar.Key} : {foobar.Value}");
        }
    }
}