namespace WpfXamlAnalysisReference.Views
{
    public partial class LabelPage : GenericPage
    {
        public LabelPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string SomeText { get; } = "This is some text";
    }
}
