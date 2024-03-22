// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Threading;

namespace LeetCode;
public class Foo
{
  private readonly SemaphoreSlim _firstSemaphore;
  private readonly SemaphoreSlim _secondSemaphore;
  public Foo()
  {
    _firstSemaphore = new SemaphoreSlim(0, 1);
    _secondSemaphore = new SemaphoreSlim(0, 1);
  }


  public void First(Action printFirst)
  {
    printFirst();
    _firstSemaphore.Release();
  }

  public void Second(Action printSecond)
  {
    _firstSemaphore.Wait();
    printSecond();
    _secondSemaphore.Release();
  }

  public void Third(Action printThird)
  {
    _secondSemaphore.Wait();
    printThird();
  }
}
