' Developer Express Code Central Example:
' How to implement the ThemeMananger theme support in custom controls
' 
' This is a sample project for the K18542 (http://www.devexpress.com/scid=K18542)
' KB article illustrating how to support themes in custom controls.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3524

Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Utils.Themes
Imports System.Windows
Imports System.Windows.Controls

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

        Public Sub New()
        End Sub
    End Class

    Public Enum ThemeResourcesThemeKeys
        Background
        Foreground
        BorderBrush
        BorderThickness
        FontSize
    End Enum

    Public Class CustomComboBoxEdit
        Inherits ComboBoxEdit

    End Class
End Namespace
