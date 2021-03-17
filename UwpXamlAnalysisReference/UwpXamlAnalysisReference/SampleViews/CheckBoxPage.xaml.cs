using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpXamlAnalysisReference.SampleViews
{
    public sealed partial class CheckBoxPage : Page
    {
        public CheckBoxPage()
        {
            this.InitializeComponent();
        }

        private void MyCheckedEvent(object sender, RoutedEventArgs e)
        {
        }

        private void MyUncheckedEvent(object sender, RoutedEventArgs e)
        {
        }
    }
}
