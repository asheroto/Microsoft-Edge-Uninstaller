Imports System.IO

Module Main

    Sub Main()
        Try
            Dim foundIt = False
            Dim baseEdgeDir = "C:\Program Files (x86)\Microsoft\Edge\Application"
            If Directory.Exists(baseEdgeDir) Then
                For Each gotDir In Directory.GetDirectories(baseEdgeDir)
                    Dim fullPath = gotDir & "\Installer\setup.exe"
                    If File.Exists(fullPath) Then
                        foundIt = True
                        Shell(fullPath & " --uninstall --system-level --verbose-logging --force-uninstall", AppWinStyle.NormalFocus, True)
                        Console.WriteLine("Issued uninstall command successfully.")
                    End If
                Next
            End If
            If foundIt = False Then
                Console.WriteLine("Could not find Edge.", vbInformation)
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
        End Try
        End
    End Sub

End Module
