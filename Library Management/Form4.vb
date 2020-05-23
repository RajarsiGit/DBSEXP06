Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.BORROW' table. You can move, or remove it, as needed.
        Me.BORROWTableAdapter.Fill(Me.DataSet11.BORROW)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Visible = False
        If TextBox1.Text = "" Then
            Exit Sub
        End If
        Try
            BORROWTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            MessageBox.Show("Data inserted", "Message")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BORROWTableAdapter.Fill(DataSet11.BORROW)
        DataGridView1.DataSource = BORROWBindingSource
        DataGridView1.Visible = True
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Form5.Show()
    End Sub
End Class