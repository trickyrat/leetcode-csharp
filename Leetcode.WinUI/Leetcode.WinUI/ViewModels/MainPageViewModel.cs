// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Threading.Tasks;
using System.Windows.Input;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Helpers;

namespace Leetcode.WinUI.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private int _counter;

        public int Counter 
        {
            get => _counter;
            private set => SetProperty(ref _counter, value);
        }

        public ICommand IncrementCounterCommand { get; }

        public IAsyncRelayCommand DownloadTextCommand { get; set; }

        public MainPageViewModel()
        {
            IncrementCounterCommand = new RelayCommand(IncrementCounterHandler);
            DownloadTextCommand = new AsyncRelayCommand(DownloadTextAsync);
        }

        private void IncrementCounterHandler()
        {
            Counter++;
        }

        private Task<string> DownloadTextAsync()
        {
            return Task.Run(() => 
            {
                return "Completed!";
            });
        }
    }
}
