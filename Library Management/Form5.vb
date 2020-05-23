Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataTable1TableAdapter1.Fill(DataSet11.DataTable1)
        DataGridView1.DataSource = DataSet11.DataTable1
        DataGridView1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataTable2TableAdapter1.Fill(DataSet11.DataTable2)
        DataGridView1.DataSource = DataSet11.DataTable2
        DataGridView1.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DataTable3TableAdapter1.Fill(DataSet11.DataTable3)
        DataGridView1.DataSource = DataSet11.DataTable3
        DataGridView1.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataTable4TableAdapter1.Fill(DataSet11.DataTable4)
        DataGridView1.DataSource = DataSet11.DataTable4
        DataGridView1.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataTable5TableAdapter1.Fill(DataSet11.DataTable5)
        DataGridView1.DataSource = DataSet11.DataTable5
        DataGridView1.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DataTable6TableAdapter1.Fill(DataSet11.DataTable6)
        DataGridView1.DataSource = DataSet11.DataTable6
        DataGridView1.Visible = True
    End Sub
End Class