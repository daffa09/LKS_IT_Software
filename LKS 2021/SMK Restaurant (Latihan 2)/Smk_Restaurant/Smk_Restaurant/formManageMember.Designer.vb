<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formManageMember
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
		Me.btn_insert = New System.Windows.Forms.Button()
		Me.btn_search = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btn_update = New System.Windows.Forms.Button()
		Me.btn_delete = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btn_close = New System.Windows.Forms.Button()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btn_insert
		'
		Me.btn_insert.Location = New System.Drawing.Point(174, 424)
		Me.btn_insert.Name = "btn_insert"
		Me.btn_insert.Size = New System.Drawing.Size(84, 30)
		Me.btn_insert.TabIndex = 8
		Me.btn_insert.Text = "Insert"
		Me.btn_insert.UseVisualStyleBackColor = True
		'
		'btn_search
		'
		Me.btn_search.Location = New System.Drawing.Point(171, 245)
		Me.btn_search.Name = "btn_search"
		Me.btn_search.Size = New System.Drawing.Size(93, 30)
		Me.btn_search.TabIndex = 9
		Me.btn_search.Text = "Search"
		Me.btn_search.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(35, 249)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(118, 20)
		Me.TextBox1.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(186, 30)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(360, 37)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Form Manage Member"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(35, 89)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(635, 145)
		Me.DataGridView1.TabIndex = 5
		'
		'btn_update
		'
		Me.btn_update.Location = New System.Drawing.Point(278, 424)
		Me.btn_update.Name = "btn_update"
		Me.btn_update.Size = New System.Drawing.Size(84, 30)
		Me.btn_update.TabIndex = 8
		Me.btn_update.Text = "Update"
		Me.btn_update.UseVisualStyleBackColor = True
		'
		'btn_delete
		'
		Me.btn_delete.Location = New System.Drawing.Point(380, 424)
		Me.btn_delete.Name = "btn_delete"
		Me.btn_delete.Size = New System.Drawing.Size(84, 30)
		Me.btn_delete.TabIndex = 8
		Me.btn_delete.Text = "Delete"
		Me.btn_delete.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(319, 254)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 13)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "MemberId"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(386, 250)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(177, 20)
		Me.TextBox2.TabIndex = 10
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(386, 285)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(177, 20)
		Me.TextBox3.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(319, 289)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(35, 13)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Name"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(386, 321)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(177, 20)
		Me.TextBox4.TabIndex = 10
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(319, 325)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(32, 13)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Email"
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(386, 359)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(177, 20)
		Me.TextBox5.TabIndex = 10
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(319, 363)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(63, 13)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Handphone"
		'
		'btn_close
		'
		Me.btn_close.Location = New System.Drawing.Point(481, 424)
		Me.btn_close.Name = "btn_close"
		Me.btn_close.Size = New System.Drawing.Size(84, 30)
		Me.btn_close.TabIndex = 8
		Me.btn_close.Text = "CLose"
		Me.btn_close.UseVisualStyleBackColor = True
		'
		'formManageMember
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(702, 485)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.btn_close)
		Me.Controls.Add(Me.btn_delete)
		Me.Controls.Add(Me.btn_update)
		Me.Controls.Add(Me.btn_insert)
		Me.Controls.Add(Me.btn_search)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "formManageMember"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formManageMember"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btn_insert As Button
	Friend WithEvents btn_search As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents btn_update As Button
	Friend WithEvents btn_delete As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents btn_close As Button
End Class
