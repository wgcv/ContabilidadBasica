Public Class Lista_cuentas
    Public Shared lista As List(Of Cuentas) = New List(Of Cuentas)

    Public Shared Function lista_codigos() As List(Of String)
        Dim listagen As List(Of String) = New List(Of String)
        For Each cuenta In lista
            listagen.Add(cuenta.codigo)
        Next
        Return listagen

    End Function
    Public Shared Function lista_nombres() As List(Of String)
        Dim listagen As List(Of String) = New List(Of String)
        For Each cuenta In lista
            listagen.Add(cuenta.nombre)
        Next
        Return listagen

    End Function
    Public Shared Sub mod_xnombre(ByVal nombre As String, debe As Integer, haber As Integer)

        For Each cuenta In lista
            If (cuenta.nombre = nombre) Then
                If (debe > 0) Then cuenta.adddebe(debe)
                If (haber > 0) Then cuenta.addhaber(haber)
            End If
        Next


    End Sub
    Public Shared Sub mod_xcodigo(ByVal codigo As String, debe As Integer, haber As Integer)
        For Each cuenta In lista
            If (cuenta.codigo = codigo) Then
                If (debe > 0) Then cuenta.adddebe(debe)
                If (haber > 0) Then cuenta.addhaber(haber)
            End If
        Next


    End Sub
    Public Shared Function cod(ByVal c As String) As String

        For Each cuenta In lista
            If (cuenta.nombre = c) Then
                Return cuenta.codigo
            End If
        Next
        Return 0

    End Function

End Class
