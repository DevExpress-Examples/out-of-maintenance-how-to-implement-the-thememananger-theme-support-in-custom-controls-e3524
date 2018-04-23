// Developer Express Code Central Example:
// How to implement the ThemeMananger theme support in custom controls
// 
// This is a sample project for the K18542 (http://www.devexpress.com/scid=K18542)
// KB article illustrating how to support themes in custom controls.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3524

using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Internal;
using DevExpress.Xpf.Utils.Themes;
using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Linq;
using System.Reflection;

namespace DXSample
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
    public partial class MainWindow : System.Windows.Window {
		public MainWindow()
		{
			InitializeComponent();
		}

        private void comboBoxEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e) {
            ApplicationThemeHelper.ApplicationThemeName = e.NewValue as string;
        }
    }
}
