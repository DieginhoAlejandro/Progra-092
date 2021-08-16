Imports System.Math
Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Visible = True
        Else
            TextBox1.Visible = False
            TextBox1.Text = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Visible = True
        Else
            TextBox2.Visible = False
            TextBox2.Text = 0
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.Visible = True
        Else
            TextBox3.Visible = False
            TextBox3.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ingresar.Click

        If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Then
            If RadioButton1.Checked Then
                If IsNumeric(Saldo_Anterior.Text) And Val(Saldo_Anterior.Text) > 0 Or Saldo_Anterior.Text = "" Then
                    saldoanterior = Saldo_Anterior.Text
                Else
                    MsgBox("Error no hay datos en saldo anterior")
                    Saldo_Anterior.Focus()
                End If
            ElseIf RadioButton2.Checked Then
                If IsNumeric(Saldo_Anterior.Text) And Val(Saldo_Anterior.Text) > 0 Or Saldo_Anterior.Text = "" Then
                    saldoanterior = Saldo_Anterior.Text
                Else
                    MsgBox("Error no hay datos en saldo anterior")
                    Saldo_Anterior.Focus()
                End If
            ElseIf RadioButton3.Checked Then
                If IsNumeric(Saldo_Anterior.Text) And Val(Saldo_Anterior.Text) > 0 Or Saldo_Anterior.Text = "" Then
                    saldoanterior = Saldo_Anterior.Text
                Else
                    MsgBox("Error no hay datos en saldo anterior")
                    Saldo_Anterior.Focus()
                End If
            End If
        Else
            MessageBox.Show("Error No Eligió Tipo De Transacción")
        End If
        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then
            If CheckBox1.Checked Then
                If IsNumeric(TextBox1.Text) And Val(TextBox1.Text) > 0 Then
                    chequepropio = TextBox1.Text
                Else
                    MessageBox.Show("Error en casilla 1 ingrese nuevamente")
                    TextBox1.Focus()
                End If
            End If
            If CheckBox2.Checked Then
                If IsNumeric(TextBox2.Text) And Val(TextBox2.Text) > 0 Then
                    chequebanco = TextBox2.Text
                Else
                    MessageBox.Show("Error en casilla 2 ingrese nuevamente")
                    TextBox2.Focus()
                End If
            End If
            If CheckBox3.Checked Then
                If IsNumeric(TextBox3.Text) And Val(TextBox3.Text) > 0 Then
                    efectivo = TextBox3.Text
                Else
                    MessageBox.Show("Error en casilla 3 ingrese nuevamente")
                    TextBox3.Focus()
                End If
            End If
        Else
            MsgBox("Error No Eligió Tipo De Depósito")
        End If
        If Saldo_Anterior.Text = "" Or Saldo_Anterior.Text = 0 Then
            Saldo_Anterior.Focus()
        Else
            Resultados.Show()
            Me.Hide()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Module1.limpiar()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox3.Location = New Point(177, 46)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Saldo_Anterior.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Saldo_Anterior.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Saldo_Anterior.Enabled = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Resultados.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox3.Location = New Point(465165165, 865164165)
    End Sub
End Class
