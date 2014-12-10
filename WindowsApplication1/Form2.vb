Public Class Form2

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nueva_cuenta As Cuentas
      
        Dim cod As Integer
        Dim tip As Integer
        Dim cuen As Boolean
        If ComboBox1.SelectedItem.ToString = "Activos" Then
            cod = 10
        End If
        If ComboBox1.SelectedItem.ToString = "Pasivos" Then
            cod = 20
        End If
        If ComboBox1.SelectedItem.ToString = "Capital" Then
            cod = 30
        End If
        If ComboBox1.SelectedItem.ToString = "Ingresos" Then
            cod = 40
        End If
        If ComboBox1.SelectedItem.ToString = "Gastos" Then
            cod = 50
        End If
        If RadioButton1.Checked = True Then
            cuen = True
        Else
            cuen = False

        End If
        If (Trim(TextBox1.Text) <> "" And Not (TextBox2.Text = "" And TextBox3.Text = "")) Then
            nueva_cuenta = New Cuentas(TextBox1.Text, cod, TextBox2.Text, TextBox3.Text, cuen)
            Lista_cuentas.lista.Add(nueva_cuenta)
            MsgBox("Se ha creado " & TextBox1.Text & " con exito.")
            Me.Dispose()
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class