﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PUBIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUBLISHERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Library_Management.DataSet1()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PUBLISHERTableAdapter = New Library_Management.DataSet1TableAdapters.PUBLISHERTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PUBLISHER"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(347, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 26)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "DISPLAY"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 338)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 26)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PUBIDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PUBLISHERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(459, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(338, 226)
        Me.DataGridView1.TabIndex = 26
        Me.DataGridView1.Visible = False
        '
        'PUBIDDataGridViewTextBoxColumn
        '
        Me.PUBIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_ID"
        Me.PUBIDDataGridViewTextBoxColumn.HeaderText = "PUB_ID"
        Me.PUBIDDataGridViewTextBoxColumn.Name = "PUBIDDataGridViewTextBoxColumn"
        Me.PUBIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PUBLISHERBindingSource
        '
        Me.PUBLISHERBindingSource.DataMember = "PUBLISHER"
        Me.PUBLISHERBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(213, 247)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(222, 22)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(213, 210)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(222, 22)
        Me.TextBox2.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(213, 173)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 22)
        Me.TextBox1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ADDRESS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "PUBLISHER ID"
        '
        'PUBLISHERTableAdapter
        '
        Me.PUBLISHERTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 454)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Publisher"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUBLISHERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents PUBLISHERBindingSource As BindingSource
    Friend WithEvents PUBLISHERTableAdapter As DataSet1TableAdapters.PUBLISHERTableAdapter
    Friend WithEvents PUBIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
