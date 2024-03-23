<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPayment
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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.ComboBox3 = New System.Windows.Forms.ComboBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btn_Save = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(192, 35)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(239, 37)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Form Payment"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(227, 107)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(183, 21)
		Me.ComboBox1.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(154, 110)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(42, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "OrderId"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(38, 148)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(554, 175)
		Me.DataGridView1.TabIndex = 10
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(250, 353)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(183, 21)
		Me.ComboBox2.TabIndex = 8
		'
		'ComboBox3
		'
		Me.ComboBox3.FormattingEnabled = True
		Me.ComboBox3.Location = New System.Drawing.Point(250, 425)
		Me.ComboBox3.Name = "ComboBox3"
		Me.ComboBox3.Size = New System.Drawing.Size(183, 21)
		Me.ComboBox3.TabIndex = 8
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(250, 389)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(181, 20)
		Me.TextBox1.TabIndex = 11
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(161, 352)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(75, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Payment Type"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(161, 392)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 13)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Card Number"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(161, 429)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Bank Name"
		'
		'btn_Save
		'
		Me.btn_Save.Location = New System.Drawing.Point(261, 473)
		Me.btn_Save.Name = "btn_Save"
		Me.btn_Save.Size = New System.Drawing.Size(120, 29)
		Me.btn_Save.TabIndex = 12
		Me.btn_Save.Text = "Save"
		Me.btn_Save.UseVisualStyleBackColor = True
		'
		'formPayment
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(623, 514)
		Me.Controls.Add(Me.btn_Save)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ComboBox3)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "formPayment"
		Me.Text = "formPayment"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents btn_Save As Button
End Class
