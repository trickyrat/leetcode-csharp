using Leetcode.WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Leetcode.WinUI.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
