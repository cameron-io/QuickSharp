using System;
using System.Security.Cryptography.X509Certificates;

namespace Lib.Delegates;

public class IntProcessor
{
    public int x;

    public delegate void Handler(int x);

    public int Process(int x, Handler handler)
    {
        this.x = 0;
        handler(x);
        return this.x;
    }

    public void ApplyOne(int x)
    {
        this.x += 1;
    }

    public void ApplyDouble(int x)
    {
        this.x *= 2;
    }
}
