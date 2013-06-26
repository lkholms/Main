﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace InfoHub.Flyouts
{
    public sealed partial class About : UserControl
    {
        public About()
        {
            this.InitializeComponent();
            var _Version = Windows.ApplicationModel.Package.Current.Id.Version;
            this.MyContent.Text = string.Format("Version 130403 | {0}.{1}", _Version.Major, _Version.Minor);
        }
    }
}
