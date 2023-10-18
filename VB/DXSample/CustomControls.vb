Imports System.Reflection
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Utils.Themes

Namespace DXSample

    Public Class CustomControl1
        Inherits Control

        Shared Sub New()
            Call DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl1), New FrameworkPropertyMetadata(GetType(CustomControl1)))
        End Sub

        Public Property Text As String
            Get
                Return CStr(GetValue(TextProperty))
            End Get

            Set(ByVal value As String)
                SetValue(TextProperty, value)
            End Set
        End Property

        Public Shared ReadOnly TextProperty As DependencyProperty = DependencyProperty.Register("Text", GetType(String), GetType(CustomControl1), New PropertyMetadata(CType(Nothing, PropertyChangedCallback)))
    End Class

    Public Class CustomControl2
        Inherits CustomControl1

        Shared Sub New()
            Call DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl2), New FrameworkPropertyMetadata(GetType(CustomControl2)))
        End Sub
    End Class

    Public Class CustomControl3
        Inherits CustomControl1

        Shared Sub New()
            Call DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl3), New FrameworkPropertyMetadata(GetType(CustomControl3)))
        End Sub
    End Class

    Public Class CustomControl4
        Inherits CustomControl1

        Shared Sub New()
            Call DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl4), New FrameworkPropertyMetadata(GetType(CustomControl4)))
        End Sub
    End Class

    Public Class CustomControl5
        Inherits CustomControl1

        Shared Sub New()
            Call DefaultStyleKeyProperty.OverrideMetadata(GetType(CustomControl5), New FrameworkPropertyMetadata(GetType(CustomControl5)))
        End Sub
    End Class

    Public Class ThemeResourcesThemeKeyExtension
        Inherits ThemeKeyExtensionBase(Of ThemeResourcesThemeKeys)

        Protected Overrides Function GetAssembly() As Assembly
            Return If(TypeInTargetAssembly IsNot Nothing, TypeInTargetAssembly.Assembly, [GetType]().Assembly)
        End Function
    End Class

    Public Enum ThemeResourcesThemeKeys
        Background
        Foreground
        BorderBrush
        BorderThickness
        FontSize
    End Enum
End Namespace
