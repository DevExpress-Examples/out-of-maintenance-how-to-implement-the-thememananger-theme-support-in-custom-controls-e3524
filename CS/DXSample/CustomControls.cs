// Developer Express Code Central Example:
// How to implement the ThemeMananger theme support in custom controls
// 
// This is a sample project for the K18542 (http://www.devexpress.com/scid=K18542)
// KB article illustrating how to support themes in custom controls.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3524

using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Utils.Themes;
using System.Windows;
using System.Windows.Controls;

namespace DXSample
{
	public class CustomControl1 : Control{
		static CustomControl1(){
			DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), new FrameworkPropertyMetadata(typeof(CustomControl1)));
		}

        public string Text {
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
        public ThemeResourcesThemeKeyExtension() {
        }
    }

    public enum ThemeResourcesThemeKeys {
        Background,
        Foreground,
        BorderBrush,
        BorderThickness,
        FontSize
    }

    public class CustomComboBoxEdit : ComboBoxEdit {

    }
}
