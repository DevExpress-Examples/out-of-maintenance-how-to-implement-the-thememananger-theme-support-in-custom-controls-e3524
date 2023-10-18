' Developer Express Code Central Example:
' How to implement the ThemeMananger theme support in custom controls
' 
' This is a sample project for the K18542 (http://www.devexpress.com/scid=K18542)
' KB article illustrating how to support themes in custom controls.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3524
Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub comboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            ApplicationThemeHelper.ApplicationThemeName = TryCast(e.NewValue, String)
        End Sub
    End Class
End Namespace
