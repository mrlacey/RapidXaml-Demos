﻿using System.Windows.Controls;

namespace WpfXamlAnalysisReference.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
