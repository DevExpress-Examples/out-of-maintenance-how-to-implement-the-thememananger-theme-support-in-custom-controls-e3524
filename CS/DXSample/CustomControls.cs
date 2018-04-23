using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Internal;
using DevExpress.Xpf.Utils.Themes;

namespace DXSample {
    public class CustomControl1 : Control {
        static CustomControl1() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), new FrameworkPropertyMetadata(typeof(CustomControl1)));
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(CustomControl1), new PropertyMetadata(null));
    }

    public class CustomControl2 : CustomControl1 {
        static CustomControl2() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl2), new FrameworkPropertyMetadata(typeof(CustomControl2)));
        }
    }

    public class CustomControl3 : CustomControl1 {
        static CustomControl3() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl3), new FrameworkPropertyMetadata(typeof(CustomControl3)));
        }
    }

    public class CustomControl4 : CustomControl1 {
        static CustomControl4() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl4), new FrameworkPropertyMetadata(typeof(CustomControl4)));
        }
    }

    public class CustomControl5 : CustomControl1 {
        static CustomControl5() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl5), new FrameworkPropertyMetadata(typeof(CustomControl5)));
        }
    }

    public class ThemeResourcesThemeKeyExtension : ThemeKeyExtensionBase<ThemeResourcesThemeKeys> {
        public override Assembly Assembly {
            get {
                return TypeInTargetAssembly != null ? TypeInTargetAssembly.Assembly : GetType().Assembly;
            }
        }
    }
    public enum ThemeResourcesThemeKeys {
        Background,
        Foreground,
        BorderBrush,
        BorderThickness,
        FontSize
    }
}
