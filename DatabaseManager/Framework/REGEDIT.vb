Imports Microsoft.Win32

''' <summary>
''' CLASSE PARA ACESSO/MANIPULACAO DO REGISTRO DO WINDOWS
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class REGEDIT

    Private Sub New()
    End Sub

    ''' <summary>
    ''' Read a key/value in the windows registry.
    ''' Recording path: HKEY_CURRENT_USER/Software/[APP_NAME]:[KEY]->[NAME::VALUE]
    ''' </summary>
    ''' <param name="key">registry key name</param>
    ''' <param name="name">Name value</param>
    ''' <param name="value">Default value</param>
    ''' <returns></returns>
    Public Shared Function GetRegistry(ByVal key As String, ByVal name As String, Optional ByVal value As String = "") As String

        Dim _REGISTRO As RegistryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey(Application.ProductName)

        If _REGISTRO Is Nothing Then
            Return value
        Else
            If key.Length > 0 Then
                _REGISTRO = _REGISTRO.OpenSubKey(key)
                If _REGISTRO Is Nothing Then
                    Return value
                Else
                    Return _REGISTRO.GetValue(name, "").ToString()
                End If
            Else
                Return _REGISTRO.GetValue(name, "").ToString()
            End If
        End If
    End Function

    ''' <summary>
    ''' Record a key/value in the windows registry.
    ''' Recording path: HKEY_CURRENT_USER/Software/[APP_NAME]:[KEY]->[NAME::VALUE]
    ''' </summary>
    ''' <param name="key">registry key name</param>
    ''' <param name="name">Name value</param>
    ''' <param name="value">Key valeu</param>
    ''' <returns></returns>
    Public Shared Function SetRegistry(ByVal key As String, ByVal name As String, ByVal value As String) As Boolean

        Try
            Dim _REGISTRO As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True).OpenSubKey(Application.ProductName, True)
            If _REGISTRO Is Nothing Then

                _REGISTRO = Registry.CurrentUser.OpenSubKey("Software", True).CreateSubKey(Application.ProductName)
                If _REGISTRO Is Nothing Then
                    Return False
                End If
            End If

            If key.Length > 0 Then
                _REGISTRO = _REGISTRO.CreateSubKey(key)
                If _REGISTRO Is Nothing Then
                    Return False
                Else
                    If name.Length > 0 Then
                        _REGISTRO.SetValue(name, value)
                    End If
                    _REGISTRO.Close()
                    Return True
                End If
            Else
                _REGISTRO.Close()
                Return True
            End If
        Catch e As Exception
            MsgBox("There was a problem writing the record" & vbCrLf & e.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

End Class
