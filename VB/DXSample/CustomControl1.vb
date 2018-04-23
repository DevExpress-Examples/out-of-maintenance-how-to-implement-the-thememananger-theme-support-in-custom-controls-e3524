Imports System.Windows
Imports System.Windows.Controls

Namespace DXSample
	Public Class CustomControl1
		Inherits Control
		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl1), New FrameworkPropertyMetadata(GetType(CustomControl1)))
		End Sub
	End Class
End Namespace
