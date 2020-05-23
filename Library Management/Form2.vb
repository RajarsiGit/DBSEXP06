Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.PUBLISHER' table. You can move, or remove it, as needed.
        Me.PUBLISHERTableAdapter.Fill(Me.DataSet11.PUBLISHER)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Visible = False
        Try
            PUBLISHERTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            MessageBox.Show("Data inserted", "Message")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Visible = False
        If TextBox1.Text = "" Then
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            Try
                PUBLISHERTableAdapter.UpdateNameQuery(TextBox1.Text, TextBox2.Text)
                MessageBox.Show("Data updated", "Message")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf TextBox2.Text = "" Then
            Try
                PUBLISHERTableAdapter.UpdateAddressQuery(TextBox1.Text, TextBox3.Text)
                MessageBox.Show("Data updated", "Message")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PUBLISHERTableAdapter.Fill(DataSet11.PUBLISHER)
        DataGridView1.DataSource = PUBLISHERBindingSource
        DataGridView1.Visible = True
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Form5.Show()
    End Sub
End Class