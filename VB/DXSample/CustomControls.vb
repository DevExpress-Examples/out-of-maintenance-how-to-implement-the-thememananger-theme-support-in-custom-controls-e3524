Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Internal
Imports DevExpress.Xpf.Utils.Themes

Namespace DXSample
	Public Class CustomControl1
		Inherits Control

		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl1), New FrameworkPropertyMetadata(GetType(CustomControl1)))
		End Sub

		Public Property Text() As String
			Get
				Return DirectCast(GetValue(TextProperty), String)
			End Get
			Set(ByVal value As String)
				SetValue(TextProperty, value)
			End Set
		End Property
		Public Shared ReadOnly TextProperty As DependencyProperty = DependencyProperty.Register("Text", GetType(String), GetType(CustomControl1), New PropertyMetadata(Nothing))
	End Class

	Public Class CustomControl2
		Inherits CustomControl1

		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl2), New FrameworkPropertyMetadata(GetType(CustomControl2)))
		End Sub
	End Class

	Public Class CustomControl3
		Inherits CustomControl1

		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl3), New FrameworkPropertyMetadata(GetType(CustomControl3)))
		End Sub
	End Class

	Public Class CustomControl4
		Inherits CustomControl1

		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl4), New FrameworkPropertyMetadata(GetType(CustomControl4)))
		End Sub
	End Class

	Public Class CustomControl5
		Inherits CustomControl1

		Shared Sub New()
			DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl5), New FrameworkPropertyMetadata(GetType(CustomControl5)))
		End Sub
	End Class

	Public Class ThemeResourcesThemeKeyExtension
		Inherits ThemeKeyExtensionBase(Of ThemeResourcesThemeKeys)

		Public Overrides ReadOnly Property Assembly() As System.Reflection.Assembly
			Get
				Return If(TypeInTargetAssembly IsNot Nothing, TypeInTargetAssembly.Assembly, Me.GetType().Assembly)
			End Get
		End Property
	End Class
	Public Enum ThemeResourcesThemeKeys
		Background
		Foreground
		BorderBrush
		BorderThickness
		FontSize
	End Enum
End Namespace
