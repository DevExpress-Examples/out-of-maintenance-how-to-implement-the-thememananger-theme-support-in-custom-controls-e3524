' Developer Express Code Central Example:
' How to implement the ThemeMananger theme support in custom controls
' 
' This is a sample project for the K18542 (http://www.devexpress.com/scid=K18542)
' KB article illustrating how to support themes in custom controls.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3524

Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Internal
Imports DevExpress.Xpf.Utils.Themes
Imports System
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Linq
Imports System.Reflection

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits System.Windows.Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
			ApplicationThemeHelper.ApplicationThemeName = TryCast(e.NewValue, String)
		End Sub
	End Class
End Namespace
