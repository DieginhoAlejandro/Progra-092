Imports System.Math
Public Class Form1
    Public EDAD(7), REGIS(7) As Integer
    Public GENERO(7) As Char
    Public TIPO_TALLER(7) As String
    Public CONTA As Byte = 0
    Public MONTO(7), DEDUCIBLE(7), TOT As Double
    Public CON_1, CON_2, CON_3, CON_4, CON_5 As Integer
    Public PORCON_1, PORCON_2, PORCON_3, PORCON_4, PORCON_5 As Double
    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        Me.Hide()
        ADVERTENCIA.Show()
    End Sub
    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Dim a As Byte = 0
        For a = 0 To 7
            EDAD(a) = Nothing
            REGIS(a) = Nothing
            GENERO(a) = Nothing
            TIPO_TALLER(a) = Nothing
            MONTO(a) = Nothing
            DEDUCIBLE(a) = Nothing
        Next a
        TOT = 0
        CON_1 = 0
        CON_2 = 0
        CON_3 = 0
        CON_4 = 0
        CON_5 = 0
        PORCON_1 = 0
        PORCON_2 = 0
        PORCON_3 = 0
        PORCON_4 = 0
        PORCON_5 = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        DataGridView1.Rows.Clear()
        CONTA = 0
    End Sub
    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Dim X As Byte = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        DataGridView1.Rows.Clear()
        For X = 0 To 6
            If TIPO_TALLER(X) <> Nothing And GENERO(X) <> Nothing Then
                If EDAD(X) < 25 Then
                    CON_1 = CON_1 + 1
                    PORCON_1 = Round(CON_1 / 7 * 100, 2)
                End If
                If GENERO(X) = "F" Then
                    CON_2 = CON_2 + 1
                    PORCON_2 = Round(CON_2 / 7 * 100, 2)
                End If
                If (EDAD(X) >= 18 And EDAD(X) <= 25) And GENERO(X) = "M" Then
                    CON_3 = CON_3 + 1
                    PORCON_3 = Round(CON_3 / 7 * 100, 2)
                End If
                If REGIS(X) = 0 Then
                    CON_4 = CON_4 + 1
                    PORCON_4 = Round(CON_4 / 7 * 100, 2)
                End If
                CON_5 = X + 1
                TOT += MONTO(X)
            End If
        Next
        For X = 0 To 6
            If TIPO_TALLER(X) <> Nothing And GENERO(X) <> Nothing Then
                ListBox1.Items.Add(EDAD(X).ToString)
                ListBox3.Items.Add(REGIS(X).ToString)
                ListBox4.Items.Add("Q" + " " + MONTO(X).ToString)
                ListBox5.Items.Add(TIPO_TALLER(X))
                ListBox2.Items.Add(GENERO(X))
                ListBox6.Items.Add("Q" + " " + DEDUCIBLE(X).ToString)
            Else
                Exit For
            End If
        Next
        DataGridView1.Rows.Add(PORCON_1.ToString, PORCON_3.ToString, PORCON_4.ToString, CON_5.ToString, "Q" + " " + TOT.ToString, PORCON_2.ToString)
    End Sub
    Private Sub INGRESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INGRESARToolStripMenuItem.Click
        If TextBox1.Text <> Nothing And IsNumeric(TextBox1.Text) And TextBox4.Text <> Nothing And IsNumeric(TextBox4.Text) And Val(TextBox4.Text) > 0 And ComboBox1.Text <> Nothing And ComboBox2.Text <> Nothing And ComboBox3.Text <> Nothing Then
            If Val(TextBox1.Text) >= 18 And Val(TextBox1.Text) < 100 Then
                If CONTA < 7 Then
                    EDAD(CONTA) = TextBox1.Text
                    GENERO(CONTA) = ComboBox1.Text
                    REGIS(CONTA) = ComboBox2.Text
                    MONTO(CONTA) = TextBox4.Text
                    TIPO_TALLER(CONTA) = ComboBox3.Text
                    DEDUCIBLE(CONTA) = Round(MONTO(CONTA) * 0.06, 2)
                    CONTA += 1
                Else
                    MessageBox.Show("VECTORES LLENOS")
                End If
            Else
                MessageBox.Show("EDAD INCORRECTA")
            End If
        Else
            MessageBox.Show("ERROR EN EL INGRESO DE DATOS")
        End If
    End Sub
End Class