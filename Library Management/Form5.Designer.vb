<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataSet11 = New Library_Management.DataSet1()
        Me.DataTable1TableAdapter1 = New Library_Management.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.DataTable2TableAdapter1 = New Library_Management.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.DataTable3TableAdapter1 = New Library_Management.DataSet1TableAdapters.DataTable3TableAdapter()
        Me.DataTable4TableAdapter1 = New Library_Management.DataSet1TableAdapters.DataTable4TableAdapter()
        Me.DataTable5TableAdapter1 = New Library_Management.DataSet1TableAdapters.DataTable5TableAdapter()
        Me.DataTable6TableAdapter1 = New Library_Management.DataSet1TableAdapters.DataTable6TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIBRARY"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 26)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "BOOKS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 26)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "PUBLISHER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(443, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 26)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "MEMBER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(587, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 26)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "BORROW"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(60, 394)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 26)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "INNER JOIN"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(726, 230)
        Me.DataGridView1.TabIndex = 33
        Me.DataGridView1.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(185, 394)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 26)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "OUTER JOIN"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(310, 394)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 26)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "LEFT JOIN"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(435, 394)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 26)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "RIGHT JOIN"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(560, 394)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 26)
        Me.Button9.TabIndex = 37
        Me.Button9.Text = "ASC SORT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(685, 394)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(117, 26)
        Me.Button10.TabIndex = 38
        Me.Button10.Text = "DESC SORT"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter1
        '
        Me.DataTable1TableAdapter1.ClearBeforeFill = True
        '
        'DataTable2TableAdapter1
        '
        Me.DataTable2TableAdapter1.ClearBeforeFill = True
        '
        'DataTable3TableAdapter1
        '
        Me.DataTable3TableAdapter1.ClearBeforeFill = True
        '
        'DataTable4TableAdapter1
        '
        Me.DataTable4TableAdapter1.ClearBeforeFill = True
        '
        'DataTable5TableAdapter1
        '
        Me.DataTable5TableAdapter1.ClearBeforeFill = True
        '
        'DataTable6TableAdapter1
        '
        Me.DataTable6TableAdapter1.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 454)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents Button6 As Button
    Friend WithEvents DataTable1TableAdapter1 As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents DataTable2TableAdapter1 As DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents DataTable3TableAdapter1 As DataSet1TableAdapters.DataTable3TableAdapter
    Friend WithEvents DataTable4TableAdapter1 As DataSet1TableAdapters.DataTable4TableAdapter
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents DataTable5TableAdapter1 As DataSet1TableAdapters.DataTable5TableAdapter
    Friend WithEvents DataTable6TableAdapter1 As DataSet1TableAdapters.DataTable6TableAdapter
End Class
