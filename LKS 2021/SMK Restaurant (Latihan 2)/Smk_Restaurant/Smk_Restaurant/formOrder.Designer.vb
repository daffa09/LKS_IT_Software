<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrder
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btn_order = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.btn_add = New System.Windows.Forms.Button()
		Me.btn_delete = New System.Windows.Forms.Button()
		Me.btn_close = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(238, 34)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(194, 37)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Form Order"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.PictureBox1.Location = New System.Drawing.Point(95, 261)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(145, 136)
		Me.PictureBox1.TabIndex = 13
		Me.PictureBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(268, 319)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(23, 13)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Qty"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(268, 282)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Name"
		'
		'btn_order
		'
		Me.btn_order.Location = New System.Drawing.Point(287, 580)
		Me.btn_order.Name = "btn_order"
		Me.btn_order.Size = New System.Drawing.Size(84, 30)
		Me.btn_order.TabIndex = 10
		Me.btn_order.Text = "Order"
		Me.btn_order.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(317, 316)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(177, 20)
		Me.TextBox2.TabIndex = 8
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(317, 279)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(177, 20)
		Me.TextBox1.TabIndex = 9
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(635, 145)
		Me.DataGridView1.TabIndex = 7
		'
		'DataGridView2
		'
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(12, 414)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(635, 145)
		Me.DataGridView2.TabIndex = 7
		'
		'btn_add
		'
		Me.btn_add.Location = New System.Drawing.Point(317, 367)
		Me.btn_add.Name = "btn_add"
		Me.btn_add.Size = New System.Drawing.Size(71, 30)
		Me.btn_add.TabIndex = 10
		Me.btn_add.Text = "Add"
		Me.btn_add.UseVisualStyleBackColor = True
		'
		'btn_delete
		'
		Me.btn_delete.Location = New System.Drawing.Point(406, 367)
		Me.btn_delete.Name = "btn_delete"
		Me.btn_delete.Size = New System.Drawing.Size(71, 30)
		Me.btn_delete.TabIndex = 10
		Me.btn_delete.Text = "Delete"
		Me.btn_delete.UseVisualStyleBackColor = True
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(495, 367)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(71, 30)
		Me.btn_close.TabIndex = 10
		Me.btn_close.Text = "CLose"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 562)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 13)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Carbon : "
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(123, 562)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(49, 13)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Protein : "
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(507, 562)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(40, 13)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Total : "
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(58, 562)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(10, 13)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "-"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(545, 562)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(10, 13)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "-"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(172, 562)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(10, 13)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "-"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(9, 644)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(84, 13)
		Me.Label10.TabIndex = 11
		Me.Label10.Text = "TangkapCarbon"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(208, 644)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(83, 13)
		Me.Label11.TabIndex = 11
		Me.Label11.Text = "TangkapProtein"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(123, 644)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(74, 13)
		Me.Label12.TabIndex = 11
		Me.Label12.Text = "TangkapPrice"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(297, 644)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(85, 13)
		Me.Label13.TabIndex = 11
		Me.Label13.Text = "TangkapOrderId"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(388, 644)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(86, 13)
		Me.Label14.TabIndex = 11
		Me.Label14.Text = "TangkapIdMenu"
		'
		'formOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(670, 633)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_delete)
		Me.Controls.Add(Me.btn_add)
		Me.Controls.Add(Me.btn_order)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView2)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "formOrder"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formOrder"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents btn_order As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents btn_add As Button
	Friend WithEvents btn_delete As Button
	Friend WithEvents btn_close As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
End Class
