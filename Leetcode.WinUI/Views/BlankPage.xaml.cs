using Leetcode.WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Leetcode.WinUI.Views;

public sealed partial class BlankPage : Page
{
    public BlankViewModel ViewModel
    {
        get;
    }

    public BlankPage()
    {
        ViewModel = App.GetService<BlankViewModel>();
        InitializeComponent();
    }
}
