Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.DataSource = Lista_cuentas.lista_nombres()
        ComboBox1.Text = ""
        ComboBox2.DataSource = Lista_cuentas.lista_nombres()
        ComboBox2.Text = ""
        ComboBox3.DataSource = Lista_cuentas.lista_nombres()
        ComboBox3.Text = ""
        ComboBox4.DataSource = Lista_cuentas.lista_nombres()
        ComboBox4.Text = ""
        ComboBox5.DataSource = Lista_cuentas.lista_nombres()
        ComboBox5.Text = ""
        ComboBox6.DataSource = Lista_cuentas.lista_nombres()
        ComboBox6.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim debe As Integer
        Dim haber As Integer
        Dim t1, t2, t3, t4, t5, t6 As Transaccion
        Dim Op As Operacion

        Try
            If (Not ComboBox1.SelectedValue.ToString() = "") Then
                Dim b As Integer
                Dim c As Integer
                If (TextBox1.Text = "") Then
                    b = -1
                Else
                    b = TextBox1.Text
                End If
                If (TextBox2.Text = "") Then
                    c = -1
                Else
                    c = TextBox2.Text
                End If


                Dim a As String = ComboBox1.SelectedValue.ToString()
                If ((Not (b = -1 And c = -1)) And (b = -1 Or c = -1)) Then



                    If Not b = -1 Then debe += b
                    If Not c = -1 Then haber += c
                    If b = -1 Then b = 0
                    If c = -1 Then c = 0
                    t1 = New Transaccion(a, b, c)


                End If

            End If

        Catch ex As Exception

        End Try
       
        Try
            If (Not ComboBox2.SelectedValue.ToString() = "") Then
                Dim b As Integer
                Dim c As Integer
                If (TextBox3.Text = "") Then
                    b = -1
                Else
                    b = TextBox3.Text
                End If
                If (TextBox4.Text = "") Then
                    c = -1
                Else
                    c = TextBox4.Text
                End If


                Dim a As String = ComboBox2.SelectedValue.ToString()
                If ((Not (b = -1 And c = -1)) And (b = -1 Or c = -1)) Then



                    If Not b = -1 Then debe += b
                    If Not c = -1 Then haber += c
                    If b = -1 Then b = 0
                    If c = -1 Then c = 0
                    t2 = New Transaccion(a, b, c)


                End If

            End If

        Catch ex As Exception

        End Try
        Try
            If (Not ComboBox3.SelectedValue.ToString() = "") Then
                Dim b As Integer
                Dim c As Integer
                If (TextBox5.Text = "") Then
                    b = -1
                Else
                    b = TextBox5.Text
                End If
                If (TextBox6.Text = "") Then
                    c = -1
                Else
                    c = TextBox6.Text
                End If


                Dim a As String = ComboBox3.SelectedValue.ToString()
                If ((Not (b = -1 And c = -1)) And (b = -1 Or c = -1)) Then



                    If Not b = -1 Then debe += b
                    If Not c = -1 Then haber += c
                    If b = -1 Then b = 0
                    If c = -1 Then c = 0
                    t3 = New Transaccion(a, b, c)


                End If

            End If

        Catch ex As Exception

        End Try
        Try
            If (Not ComboBox4.SelectedValue.ToString() = "") Then
                Dim b As Integer
                Dim c As Integer
                If (TextBox7.Text = "") Then
                    b = -1
                Else
                    b = TextBox7.Text
                End If
                If (TextBox8.Text = "") Then
                    c = -1
                Else
                    c = TextBox8.Text
                End If


                Dim a As String = ComboBox4.SelectedValue.ToString()
                If ((Not (b = -1 And c = -1)) And (b = -1 Or c = -1)) Then



                    If Not b = -1 Then debe += b
                    If Not c = -1 Then haber += c
                    If b = -1 Then b = 0
                    If c = -1 Then c = 0
                    t4 = New Transaccion(a, b, c)


                End If

            End If

        Catch ex As Exception

        End Try

        Try
            If (Not ComboBox5.SelectedValue.ToString() = "") Then
                Dim b As Integer
                Dim c As Integer
                If (TextBox9.Text = "") Then
                    b = -1
                Else
                    b = TextBox9.Text
                End If
                If (TextBox10.Text = "") Then
                    c = -1
                Else
                    c = TextBox10.Text
                End If


                Dim a As String = ComboBox5.SelectedValue.ToString()
                If ((Not (b = -1 And c = -1)) And (b = -1 Or c = -1)) Then



                    If Not b = -1 Then debe += b
                    If Not c = -1 Then haber += c
                    If b = -1 Then b = 0
                    If c = -1 Then c = 0
                    t5 = New Transaccion(a, b, c)


                End If

            End If

        Catch ex As Exception

        End Try
        Try
            If (Not ComboBox6.SelectedValue.ToString() = "") Then
                Dim b As Integer
                Dim c As Integer
                If (TextBox11.Text = "") Then
                    b = -1
                Else
                    b = TextBox11.Text
                End If
                If (TextBox12.Text = "") Then
                    c = -1
                Else
                    c = TextBox12.Text
                End If


                Dim a As String = ComboBox6.SelectedValue.ToString()
                If ((Not (b = -1 And c = -1)) And (b = -1 Or c = -1)) Then


                    If Not b = -1 Then debe += b
                    If Not c = -1 Then haber += c
                    If b = -1 Then b = 0
                    If c = -1 Then c = 0
                    t6 = New Transaccion(a, b, c)


                End If

            End If

        Catch ex As Exception

        End Try
        If haber = debe Then

            Op = New Operacion(DateTimePicker1.Value.Date(), RichTextBox1.Text)
            If (Not t1 Is Nothing) Then
                t1.realizar()
                Op.lista_transaccion.Add(t1)

            End If
            If (Not t2 Is Nothing) Then
                t2.realizar()
                Op.lista_transaccion.Add(t2)

            End If
            If (Not t3 Is Nothing) Then
                t3.realizar()
                Op.lista_transaccion.Add(t3)

            End If
            If (Not t4 Is Nothing) Then
                t4.realizar()
                Op.lista_transaccion.Add(t4)

            End If
            If (Not t6 Is Nothing) Then
                t6.realizar()
                Op.lista_transaccion.Add(t6)


            End If
            If (Not t5 Is Nothing) Then
                t5.realizar()
                Op.lista_transaccion.Add(t5)


            End If
            Operacion.operaciones.Add(Op)

            MsgBox("Se realizo la operacion")
            Me.Dispose()

        Else
            MsgBox("Error no cuadra")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox42_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub
End Class