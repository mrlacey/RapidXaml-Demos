using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SymbolViewTestUwp.Controls
{
    public sealed partial class NotFontAwesome : UserControl
    {
        public NotFontAwesome()
        {
            this.InitializeComponent();
        }

        public string Icon
        {
            get
            {
                return (string)(GetValue(IconProperty));
            }

            set
            {
                SetValue(IconProperty, value);
            }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(string), typeof(NotFontAwesome), new PropertyMetadata(default(string), new PropertyChangedCallback(OnIconChanged)));

        private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
