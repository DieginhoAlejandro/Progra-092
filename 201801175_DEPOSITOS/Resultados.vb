Public Class Resultados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculo_interes()
        TextBox1.Text = interes
        TextBox2.Text = saldonuevo
        TextBox3.Text = saldo_total
    End Sub
End Class