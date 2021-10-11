Module PROCESOS
    Public NIT(6), PLACA(6), MARCA(6) As String
    Public DIAS(6) As Integer
    Public DESC(6), RECA(6), PARCIAL(6), TOTAL(6) As Double
    Public CONTADOR As Byte = 0

    Sub LIMPIAR_ENTRADA()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.TextBox5.Text = ""
        Form1.ComboBox1.Text = ""
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
    End Sub
    Public Sub limpiar_vector()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        ReDim NIT(0 To 6)
        ReDim PLACA(0 To 6)
        ReDim DIAS(0 To 6)
        ReDim DESC(0 To 6)
        ReDim RECA(0 To 6)
        ReDim PARCIAL(0 To 6)
        ReDim TOTAL(0 To 6)
        ReDim MARCA(0 To 6)
        CONTADOR = 0
    End Sub
    Public Sub INGRESO()
        If Form1.TextBox1.Text <> "" And Form1.TextBox2.Text <> "" And Form1.TextBox3.Text <> "" And IsNumeric(Form1.TextBox3.Text) And Form1.ComboBox1.Text <> "" Then
            If CONTADOR < 6 Then
                NIT(CONTADOR) = Form1.TextBox1.Text
                PLACA(CONTADOR) = Form1.TextBox2.Text
                DIAS(CONTADOR) = Form1.TextBox3.Text
                Select Case Form1.ComboBox1.SelectedIndex
                    Case 0
                        PARCIAL(CONTADOR) = DIAS(CONTADOR) * 250
                        MARCA(CONTADOR) = Form1.ComboBox1.Text
                    Case 1
                        PARCIAL(CONTADOR) = DIAS(CONTADOR) * 450
                        MARCA(CONTADOR) = Form1.ComboBox1.Text
                    Case 2
                        PARCIAL(CONTADOR) = DIAS(CONTADOR) * 325
                        MARCA(CONTADOR) = Form1.ComboBox1.Text
                    Case 3
                        PARCIAL(CONTADOR) = DIAS(CONTADOR) * 300
                        MARCA(CONTADOR) = Form1.ComboBox1.Text
                End Select

                If Form1.CheckBox1.Checked Then
                    If Form1.TextBox4.Text = 100 And IsNumeric(Form1.TextBox4.Text) And Form1.TextBox5.Text = "" Then
                        RECA(CONTADOR) = PARCIAL(CONTADOR) * 0.025
                        TOTAL(CONTADOR) = PARCIAL(CONTADOR) + RECA(CONTADOR)
                    End If
                End If

                If Form1.CheckBox2.Checked Then
                    If Form1.TextBox5.Text = 100 And IsNumeric(Form1.TextBox5.Text) And Form1.TextBox4.Text = "" Then
                        DESC(CONTADOR) = PARCIAL(CONTADOR) * 0.05
                        TOTAL(CONTADOR) = PARCIAL(CONTADOR) - DESC(CONTADOR)
                    End If
                End If

                If Form1.CheckBox1.Checked And Form1.CheckBox2.Checked Then
                    If Val(Form1.TextBox4.Text) + Val(Form1.TextBox5.Text) = 100 And IsNumeric(Form1.TextBox4.Text) And IsNumeric(Form1.TextBox5.Text) Then
                        TOTAL(CONTADOR) = PARCIAL(CONTADOR)

                    ElseIf Val(Form1.TextBox4.Text) + Val(Form1.TextBox5.Text) <> 100 Then
                        MessageBox.Show("ERROR PAGO INCOMPLETO")
                    End If
                End If

                LLENADO()
                LIMPIAR_ENTRADA()
                CONTADOR += 1

                Else
                    MessageBox.Show("VECTORES LLENOS")
            End If
        Else
            MessageBox.Show("ERROR VERIFICAR LOS DATOS INGRESADOS NUEVAMENTE")
        End If
    End Sub
    Public Sub LLENADO()
        Form1.ListBox1.Items.Add(PLACA(CONTADOR).ToString)
        Form1.ListBox2.Items.Add(MARCA(CONTADOR).ToString)
        Form1.ListBox3.Items.Add(DIAS(CONTADOR).ToString)
        Form1.ListBox4.Items.Add("Q" + " " + PARCIAL(CONTADOR).ToString)
        Form1.ListBox5.Items.Add("Q" + " " + DESC(CONTADOR).ToString)
        Form1.ListBox6.Items.Add("Q" + " " + TOTAL(CONTADOR).ToString)
        Form1.ListBox7.Items.Add(NIT(CONTADOR).ToString)
        Form1.ListBox8.Items.Add("Q" + " " + RECA(CONTADOR).ToString)
    End Sub
End Module
