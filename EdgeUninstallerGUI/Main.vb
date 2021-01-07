Imports System.IO
Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim foundIt = False
            Dim baseEdgeDir = "C:\Program Files (x86)\Microsoft\Edge\Application"
        If Directory.Exists(baseEdgeDir) Then
            For Each gotDir In Directory.GetDirectories(baseEdgeDir)
                Dim fullPath = gotDir & "\Installer\setup.exe"
                If File.Exists(fullPath) Then
                    foundIt = True
                    Shell(fullPath & " --uninstall --system-level --verbose-logging --force-uninstall", AppWinStyle.NormalFocus, True)
                    MsgBox("Issued uninstall command successfully.", vbInformation)
                End If
            Next
        End If
            If foundIt = False Then
                MsgBox("Could not find Edge.", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        End
    End Sub
End Class
