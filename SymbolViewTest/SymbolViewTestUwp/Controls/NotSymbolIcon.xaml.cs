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
    public sealed partial class NotSymbolIcon : UserControl
    {
        public NotSymbolIcon()
        {
            this.InitializeComponent();
        }

        public string Symbol
        {
            get
            {
                return (string)(GetValue(SymbolProperty));
            }

            set
            {
                SetValue(SymbolProperty, value);
            }
        }

        public static readonly DependencyProperty SymbolProperty = DependencyProperty.Register("Symbol", typeof(string), typeof(NotSymbolIcon), new PropertyMetadata(default(string), new PropertyChangedCallback(OnSymbolChanged)));

        private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
