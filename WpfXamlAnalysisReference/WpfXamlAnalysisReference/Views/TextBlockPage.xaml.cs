using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace WpfXamlAnalysisReference.Views
{
    public partial class TextBlockPage : GenericPage
    {
        public TextBlockPage()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
