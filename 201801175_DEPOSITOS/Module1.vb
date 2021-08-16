Imports System.Math
Module Module1
    Public chequepropio As Double
    Public chequebanco As Double
    Public efectivo As Double
    Public saldoanterior As Double
    Public saldonuevo As Double
    Public interes As Double
    Public saldo_total As Double
    Public Sub limpiar()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.Saldo_Anterior.Clear()
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.CheckBox3.Checked = 0
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.TextBox1.Text = 0
        Form1.TextBox2.Text = 0
        Form1.TextBox3.Text = 0
        Form1.Saldo_Anterior.Text = 0
    End Sub
    Public Sub calculo_interes()
        chequepropio = Form1.TextBox1.Text
        chequebanco = Form1.TextBox2.Text
        efectivo = Form1.TextBox3.Text
        saldonuevo = Round(chequepropio + chequebanco + efectivo + saldoanterior, 2)
        Select Case Form1.RadioButton1.Checked() Or Form1.RadioButton2.Checked()
            Case saldonuevo > 1 Or saldonuevo < 1001
                interes = Round(saldonuevo * 0.015, 2)
            Case saldonuevo >= 1001 Or saldonuevo < 5001
                interes = Round(saldonuevo * 0.025, 2)
            Case saldonuevo >= 5001 Or saldonuevo < 15001
                interes = Round(saldonuevo * 0.075, 2)
            Case saldonuevo >= 15001
                interes = Round(saldonuevo * 0.1, 2)

            Case Form1.Saldo_Anterior.Text > 1 Or Form1.Saldo_Anterior.Text < 10001
                interes = Round(saldoanterior * 0.025, 2)
            Case Form1.Saldo_Anterior.Text >= 10001 Or Form1.Saldo_Anterior.Text < 15001
                interes = Round(saldoanterior * 0.03, 2)
            Case Form1.Saldo_Anterior.Text >= 15001
                interes = Round(saldoanterior * 0.045, 2)
            Case Else
                MessageBox.Show("Error Datos inválidos")
        End Select
        saldo_total = Round(saldonuevo + interes, 2)
    End Sub
End Module
