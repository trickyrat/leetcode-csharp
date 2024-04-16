namespace LeetCode;

public class ZeroEvenOdd
{
    private int _n;
    private readonly SemaphoreSlim _zeroSemaphore = new(1, 1);
    private readonly SemaphoreSlim _evenSemaphore = new(0, 1);
    private readonly SemaphoreSlim _oddSemaphore = new(0, 1);

    public ZeroEvenOdd(int n)
    {
        _n = n;
    }

    public void Zero(Action<int> printNumber) 
    {
        for (int i = 1; i <= _n; i++) 
        {
            _zeroSemaphore.Wait();
            printNumber(0);
            if (i % 2 == 0) 
            {
                _evenSemaphore.Release();
            } 
            else 
            {
                _oddSemaphore.Release();
            }
        }
    }

    public void Even(Action<int> printNumber) 
    {
        for (int i = 2; i <= _n; i += 2) 
        {
            _evenSemaphore.Wait();
            printNumber(i);
            _zeroSemaphore.Release();
        }
    }

    public void Odd(Action<int> printNumber) 
    {
        for (int i = 1; i <= _n; i += 2) 
        {
            _oddSemaphore.Wait();
            printNumber(i);
            _zeroSemaphore.Release();
        }
    }
}
