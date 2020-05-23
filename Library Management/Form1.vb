Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.BOOKS' table. You can move, or remove it, as needed.
        Me.BOOKSTableAdapter.Fill(Me.DataSet11.BOOKS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Visible = False
        Try
            BOOKSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            MessageBox.Show("Data inserted", "Message")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Visible = False
        If TextBox1.Text = "" Then
            Exit Sub
        End If
        If TextBox3.Text = "" And TextBox4.Text - "" And TextBox5.Text = "" Then
            Try
                BOOKSTableAdapter.UpdateTitleQuery(TextBox1.Text, TextBox2.Text)
                MessageBox.Show("Data updated", "Message")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf TextBox2.Text = "" And TextBox4.Text - "" And TextBox5.Text = "" Then
            Try
                BOOKSTableAdapter.UpdateTitleQuery(TextBox1.Text, TextBox3.Text)
                MessageBox.Show("Data updated", "Message")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf TextBox2.Text = "" And TextBox3.Text - "" And TextBox5.Text = "" Then
            Try
                BOOKSTableAdapter.UpdateTitleQuery(TextBox1.Text, TextBox4.Text)
                MessageBox.Show("Data updated", "Message")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf TextBox2.Text = "" And TextBox3.Text - "" And TextBox4.Text = "" Then
            Try
                BOOKSTableAdapter.UpdateTitleQuery(TextBox1.Text, TextBox5.Text)
                MessageBox.Show("Data updated", "Message")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BOOKSTableAdapter.Fill(DataSet11.BOOKS)
        DataGridView1.DataSource = BOOKSBindingSource
        DataGridView1.Visible = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Form5.Show()
    End Sub
End Class
