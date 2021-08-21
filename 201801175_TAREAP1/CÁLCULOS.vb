Imports System.Math
Public Module CÁLCULOS
    Public Const MANO_IMPERIAL = 65.5
    Public Const MANO_MATRIMONIAL = 85.99
    Public Const MANO_QUEEN = 99.99
    Public Const MANO_KING = 105.99

    Public Const MAT_LINO = 15.0
    Public Const MAT_ALGODON = 85.99
    Public Const MAT_SEDA = 99.99
    Public Const MAT_HILOCRUDO = 105.99

    Public yar_lino As Double
    Public yar_algodon As Double
    Public yar_seda As Double
    Public yar_hilocrudo As Double
    Public total_yardas As Double
    Public costo_yard As Double
    Public costo_tot As Double
    Public venta As Double
    Public Sub Calculos()
        If (Form1.RadioButton1.Checked = True Or Form1.RadioButton2.Checked = True Or Form1.RadioButton3.Checked = True Or Form1.RadioButton4.Checked = True) And (Form1.CheckBox1.Checked = True Or Form1.CheckBox2.Checked = True Or Form1.CheckBox3.Checked = True Or Form1.CheckBox4.Checked = True) Then
            If Form1.CheckBox1.Checked = True Or Form1.CheckBox2.Checked = True Or Form1.CheckBox3.Checked = True Or Form1.CheckBox4.Checked = True Then
                If Form1.CheckBox1.Checked = True Then
                    If IsNumeric(Form1.TextBox1.Text) And Val(Form1.TextBox1.Text) > 0 Then
                        yar_lino = Form1.TextBox1.Text
                    Else
                        MessageBox.Show("Error Ingresar Las Yardas De Lino Nuevamente")
                        Form1.TextBox1.Text = ""
                        Form1.TextBox1.Focus()
                    End If
                Else
                    Form1.TextBox1.Text = ""
                End If
                If Form1.CheckBox2.Checked = True Then
                    If IsNumeric(Form1.TextBox2.Text) And Val(Form1.TextBox2.Text) > 0 Then
                        yar_algodon = Form1.TextBox2.Text
                    Else
                        MessageBox.Show("Error Ingresar Las Yardas De Lino Nuevamente")
                        Form1.TextBox2.Text = ""
                        Form1.TextBox2.Focus()
                    End If
                Else
                    Form1.TextBox2.Text = ""
                End If
                If Form1.CheckBox3.Checked = True Then
                    If IsNumeric(Form1.TextBox3.Text) And Val(Form1.TextBox3.Text) > 0 Then
                        yar_seda = Form1.TextBox3.Text
                    Else
                        MessageBox.Show("Error Ingresar Las Yardas De Lino Nuevamente")
                        Form1.TextBox3.Text = ""
                        Form1.TextBox3.Focus()
                    End If
                Else
                    Form1.TextBox3.Text = ""
                End If
                If Form1.CheckBox4.Checked = True Then
                    If IsNumeric(Form1.TextBox4.Text) And Val(Form1.TextBox4.Text) > 0 Then
                        yar_hilocrudo = Form1.TextBox4.Text
                    Else
                        MessageBox.Show("Error Ingresar Las Yardas De Lino Nuevamente")
                        Form1.TextBox4.Text = ""
                        Form1.TextBox4.Focus()
                    End If
                Else
                    Form1.TextBox4.Text = ""
                End If
            Else
                MessageBox.Show("Error No Ingreso Ningún Tipo De Material")
            End If
            total_yardas = yar_algodon + yar_hilocrudo + yar_lino + yar_seda

            If Form1.RadioButton1.Checked = True Then
                If total_yardas = 3 Then
                    costo_yard = yar_algodon * MAT_ALGODON + yar_hilocrudo * MAT_HILOCRUDO + yar_lino * MAT_LINO + yar_seda * MAT_SEDA
                    costo_tot = costo_yard + MANO_IMPERIAL
                ElseIf total_yardas < 3 Then
                    MessageBox.Show("Advertencia Necesita Más Yardas Necesarias Para Realizar Una Imperial")
                    Form1.TextBox1.Focus()
                ElseIf total_yardas > 3 Then
                    MessageBox.Show("Advertencia Excede De Las Yardas Necesarias Para Realizar Una Imperial")
                    Form1.TextBox1.Focus()
                End If
            ElseIf Form1.RadioButton2.Checked = True Then
                If total_yardas = 5 Then
                    costo_yard = yar_algodon * MAT_ALGODON + yar_hilocrudo * MAT_HILOCRUDO + yar_lino * MAT_LINO + yar_seda * MAT_SEDA
                    costo_tot = costo_yard + MANO_MATRIMONIAL
                ElseIf total_yardas < 5 Then
                    MessageBox.Show("Advertencia Necesita Más Yardas Necesarias Para Realizar Una Matrimonial")
                    Form1.TextBox2.Focus()
                ElseIf total_yardas > 5 Then
                    MessageBox.Show("Advertencia Excede De Las Yardas Necesarias Para Realizar Una Matrimonial")
                    Form1.TextBox2.Focus()
                End If
            ElseIf Form1.RadioButton3.Checked = True Then
                If total_yardas = 6 Then
                    costo_yard = yar_algodon * MAT_ALGODON + yar_hilocrudo * MAT_HILOCRUDO + yar_lino * MAT_LINO + yar_seda * MAT_SEDA
                    costo_tot = costo_yard + MANO_QUEEN
                ElseIf total_yardas < 6 Then
                    MessageBox.Show("Advertencia Necesita Más Yardas Necesarias Para Realizar Una Queen")
                    Form1.TextBox3.Focus()
                ElseIf total_yardas > 6 Then
                    MessageBox.Show("Advertencia Excede De Las Yardas Necesarias Para Realizar Una Queen")
                    Form1.TextBox3.Focus()
                End If
            ElseIf Form1.RadioButton4.Checked = True Then
                If total_yardas = 7 Then
                    costo_yard = yar_algodon * MAT_ALGODON + yar_hilocrudo * MAT_HILOCRUDO + yar_lino * MAT_LINO + yar_seda * MAT_SEDA
                    costo_tot = costo_yard + MANO_KING
                ElseIf total_yardas < 7 Then
                    MessageBox.Show("Advertencia Necesita Más Yardas Necesarias Para Realizar Una King")
                    Form1.TextBox4.Focus()
                ElseIf total_yardas > 7 Then
                    MessageBox.Show("Advertencia Excede De Las Yardas Necesarias Para Realizar Una King")
                    Form1.TextBox4.Focus()
                End If
            End If
            Resultados.Show()
        Else
            MessageBox.Show("Error Faltan Datos Por Ingresar")
        End If
        venta = costo_tot + costo_tot * 0.65
        Resultados.TextBox1.Text = Round(costo_yard, 2)
        Resultados.TextBox2.Text = Round(costo_tot, 2)
        Resultados.TextBox3.Text = Round(venta, 2)
    End Sub
    Public Sub limpiar()
        yar_lino = 0
        yar_algodon = 0
        yar_hilocrudo = 0
        yar_seda = 0
        costo_yard = 0
        total_yardas = 0
        venta = 0
        costo_tot = 0
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.RadioButton4.Checked = 0
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.CheckBox3.Checked = 0
        Form1.CheckBox4.Checked = 0
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Resultados.TextBox1.Clear()
        Resultados.TextBox2.Clear()
        Resultados.TextBox3.Clear()
    End Sub
End Module


