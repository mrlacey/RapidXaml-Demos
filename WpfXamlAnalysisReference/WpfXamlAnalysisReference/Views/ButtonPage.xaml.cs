﻿namespace WpfXamlAnalysisReference.Views
{
    public partial class ButtonPage : GenericPage
    {
        public ButtonPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string SomeText { get; } = "This is some text";
    }
}
