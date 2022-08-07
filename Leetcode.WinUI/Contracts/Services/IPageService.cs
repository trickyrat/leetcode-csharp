using System;

namespace Leetcode.WinUI.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
