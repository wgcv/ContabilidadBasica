Public Class Transaccion
    Public nombre As String
    Public debe As Integer
    Public haber As Integer

    Public Sub New(ByVal nombre As String, debe As Integer, haber As Integer)
        Me.nombre = nombre
        Me.debe = debe
        Me.haber = haber


    End Sub
    Public Sub realizar()
        Lista_cuentas.mod_xnombre(nombre, debe, haber)

    End Sub

End Class
