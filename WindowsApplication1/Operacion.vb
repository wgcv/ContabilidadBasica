Public Class Operacion
    Public Shared operaciones As List(Of Operacion) = New List(Of Operacion)
    Public Shared cont As Integer = 1
    Public lista_transaccion As List(Of Transaccion)
    Public fecha As DateTime
    Public id As Integer
    Public nota As String

    Public Sub New(ByVal f As DateTime, n As String)
        fecha = f
        id = Operacion.cont
        cont = Operacion.cont + 1
        nota = n



        lista_transaccion = New List(Of Transaccion)
    End Sub
    Public Shared Function librodiario(ByVal transaccion As Operacion) As GroupBox
        Dim gb As GroupBox = New GroupBox()
        '* 13*/
        Dim alt As Integer = 25
        Dim nota As Label = New Label()
        gb.Text = "Transaccion " & transaccion.id
        For Each t In transaccion.lista_transaccion
            Dim l1 As Label = New Label()
            Dim l2 As Label = New Label()
            Dim l3 As Label = New Label()
            Dim l4 As Label = New Label()
            Dim l5 As Label = New Label()
            l1.Text = transaccion.fecha
            l2.Text = t.nombre
            l3.Text = Lista_cuentas.cod(t.nombre)
            l4.Text = t.debe
            l5.Text = t.haber
            gb.Size = New System.Drawing.Size(529, 113)
            l1.Size = New System.Drawing.Size(100, 13)
            l1.Location = New System.Drawing.Point(6, alt)
            l2.Size = New System.Drawing.Size(174, 13)
            l2.Location = New System.Drawing.Point(127, alt)
            l3.Size = New System.Drawing.Size(72, 13)
            l3.Location = New System.Drawing.Point(315, alt)
            l4.Size = New System.Drawing.Size(55, 13)
            l4.Location = New System.Drawing.Point(405, alt)
            l5.Size = New System.Drawing.Size(55, 13)
            l5.Location = New System.Drawing.Point(466, alt)
            gb.Controls.Add(l1)
            gb.Controls.Add(l2)
            gb.Controls.Add(l3)
            gb.Controls.Add(l4)
            gb.Controls.Add(l5)

            alt = alt + 13
        Next


        nota.Text = transaccion.nota
        nota.BorderStyle = BorderStyle.Fixed3D



        nota.Size = New System.Drawing.Size(500, 50)
        nota.Location = New System.Drawing.Point(7, 112)
        gb.Controls.Add(nota)
        gb.Size = New System.Drawing.Size(550, 170)
        Return gb

    End Function
    Public Shared Function ld() As FlowLayoutPanel
        Dim flp As FlowLayoutPanel = New FlowLayoutPanel()
        flp.AutoScroll = True
        flp.Size = New System.Drawing.Size(585, 453)
        For Each t In operaciones
            flp.Controls.Add(librodiario(t))

        Next
        Return flp

    End Function

    Public Shared Function Mayo1(ByVal cuenta As Cuentas) As GroupBox
        Dim gb As GroupBox = New GroupBox()
        Dim tipo As Label = New Label()
        Dim debe As Label = New Label()
        Dim haber As Label = New Label()
        Dim saldo As Label = New Label()
        Dim saldovalor As Label = New Label()
        Dim i As Integer = 58
        Dim j As Integer = 58
        debe.Text = "Debe"
        debe.Location = New System.Drawing.Point(16, 34)
        debe.Size = New System.Drawing.Size(33, 13)
        gb.Controls.Add(debe)
        haber.Text = "Haber"
        haber.Location = New System.Drawing.Point(61, 34)
        haber.Size = New System.Drawing.Size(36, 13)
        gb.Controls.Add(haber)
        saldo.Text = "Saldo"
        saldo.Location = New System.Drawing.Point(6, 184)
        saldo.Size = New System.Drawing.Size(34, 13)
        gb.Controls.Add(saldo)
        Dim tc As String
        gb.Size = New System.Drawing.Size(139, 200)
        gb.Text = cuenta.nombre
        If (cuenta.saldodeudor = True) Then
            tc = "Deudora"
        Else
            tc = "Acredora"
        End If
        If (cuenta.tipo = 10) Then tipo.Text = "Cuenta Activo " & tc
        If (cuenta.tipo = 20) Then tipo.Text = "Cuenta Pasivo " & tc
        If (cuenta.tipo = 30) Then tipo.Text = "Cuenta Capital " & tc
        If (cuenta.tipo = 40) Then tipo.Text = "Cuenta Ingresos " & tc
        If (cuenta.tipo = 50) Then tipo.Text = "Cuenta Gastos " & tc
        tipo.Location = New System.Drawing.Point(4, 16)
        tipo.Size = New System.Drawing.Size(130, 13)
        gb.Controls.Add(tipo)

        saldovalor.Text = cuenta.valorcuenta()


        saldovalor.Location = New System.Drawing.Point(46, 184)
        saldovalor.Size = New System.Drawing.Size(45, 13)
        gb.Controls.Add(saldovalor)
        Dim lisbox2 As ListBox = New ListBox()

        lisbox2.Location = New System.Drawing.Point(61, 55)
        lisbox2.Size = New System.Drawing.Size(34, 95)
        Dim lisbox1 As ListBox = New ListBox()
        lisbox1.Location = New System.Drawing.Point(16, 55)
        lisbox1.Size = New System.Drawing.Size(34, 95)
        For Each t In cuenta.list_debe

            'Dim cd As Label = New Label()
            'cd.Text = t
            'cd.Location = New System.Drawing.Point(16, i)

            'gb.Controls.Add(cd)
            lisbox2.Items.Add(t)
            'i = i + 23

        Next
        For Each t In cuenta.list_haber
            'Dim ch As Label = New Label()
            'ch.Text = t
            'ch.Location = New System.Drawing.Point(61, j)

            'gb.Controls.Add(ch)
            'j = j + 23
            lisbox1.Items.Add(t)
        Next
        gb.Controls.Add(lisbox1)
        gb.Controls.Add(lisbox2)
        Return (gb)

    End Function

    Public Shared Function mayorizar() As FlowLayoutPanel
        Dim flp As FlowLayoutPanel = New FlowLayoutPanel()
        flp.AutoScroll = True
        flp.Size = New System.Drawing.Size(582, 458)
        flp.Location = New System.Drawing.Point(2, 5)
        For Each t In Lista_cuentas.lista
            flp.Controls.Add(Mayo1(t))

        Next
        Return flp

    End Function
End Class
