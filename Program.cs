int BottomUpCutRod(int[] p, int n)
{
    var r = new int[n + 1];
    r[0] = 0;

    for (var j = 1; j <= n; j++)
    {
        var q = int.MinValue;
        for (var i = 1; i <= j; i++)
        {
            q = Math.Max(q, p[i - 1] + r[j - i]);
        }

        r[j] = q;
    }

    return r[n];
}

var x = new[] {1, 5, 8, 9, 10};
Console.WriteLine($"The optimum cost is : {BottomUpCutRod(x, 5)}");
