﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFXamlAnalysisReference
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButtonPage : ContentPage
    {
        public RadioButtonPage()
        {
            InitializeComponent();
        }
    }
}