Public Class Form1
  


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pantalla2 As Form2 = New Form2()
        pantalla2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pantalla3 As Form3 = New Form3()
        pantalla3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pantalla4 As Form4 = New Form4()
        pantalla4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pantalla5 As Form5 = New Form5()
        pantalla5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pantalla6 As Form6 = New Form6()
        pantalla6.Show()
    End Sub
End Class
