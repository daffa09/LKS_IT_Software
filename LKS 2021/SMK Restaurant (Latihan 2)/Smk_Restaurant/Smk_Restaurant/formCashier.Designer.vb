<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCashier
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btn_logout = New System.Windows.Forms.Button()
		Me.btn_payment = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(30, 102)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(169, 18)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Welcome [Admin Name]"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(65, 29)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(306, 37)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Cashier Navigation"
		'
		'btn_logout
		'
		Me.btn_logout.Location = New System.Drawing.Point(145, 187)
		Me.btn_logout.Name = "btn_logout"
		Me.btn_logout.Size = New System.Drawing.Size(149, 32)
		Me.btn_logout.TabIndex = 5
		Me.btn_logout.Text = "Logout"
		Me.btn_logout.UseVisualStyleBackColor = True
		'
		'btn_payment
		'
		Me.btn_payment.Location = New System.Drawing.Point(145, 149)
		Me.btn_payment.Name = "btn_payment"
		Me.btn_payment.Size = New System.Drawing.Size(149, 32)
		Me.btn_payment.TabIndex = 9
		Me.btn_payment.Text = "Payment"
		Me.btn_payment.UseVisualStyleBackColor = True
		'
		'formCashier
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(439, 279)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btn_logout)
		Me.Controls.Add(Me.btn_payment)
		Me.Name = "formCashier"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formCashier"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents btn_logout As Button
	Friend WithEvents btn_payment As Button
End Class
