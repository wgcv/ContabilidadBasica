Public Class Cuentas
    Public nombre As String
    Public tipo As Integer
    Public codigo As Integer
    Public num As Integer
    Public saldodeudor As Boolean
    Public debe As Integer
    Public haber As Integer
    Public list_debe As LinkedList(Of Integer)
    Public list_haber As LinkedList(Of Integer)


    Public Sub New(ByVal nombre As String, tipo As Integer, codigo As Integer, num As Integer, saldodeudor As Boolean)
        list_debe = New LinkedList(Of Integer)
        list_haber = New LinkedList(Of Integer)
        Me.nombre = nombre
        Me.tipo = tipo
        Me.codigo = codigo
        Me.num = num
        Me.saldodeudor = saldodeudor
        Me.debe = 0
        Me.haber = 0



    End Sub

    Public Sub adddebe(ByVal valor As Integer)
        list_debe.AddLast(valor)
        debe = debe + valor

    End Sub
    Public Sub addhaber(ByVal valor As Integer)
        list_haber.AddLast(valor)
        haber = haber + valor

    End Sub
    Public Function valorcuenta() As Integer

        Dim valor As Integer
        If (saldodeudor) Then
            valor = Me.debe - Me.haber
        Else
            valor = Me.haber - Me.debe
        End If

        Return valor
    End Function
End Class
