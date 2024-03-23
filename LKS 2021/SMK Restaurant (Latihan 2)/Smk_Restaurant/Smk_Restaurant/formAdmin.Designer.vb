<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdmin
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
		Me.btn_order = New System.Windows.Forms.Button()
		Me.btn_manageMenu = New System.Windows.Forms.Button()
		Me.btn_manageMember = New System.Windows.Forms.Button()
		Me.btn_report = New System.Windows.Forms.Button()
		Me.btn_logout = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(32, 95)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(169, 18)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Welcome [Admin Name]"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(97, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(286, 37)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Admin Navigation"
		'
		'btn_order
		'
		Me.btn_order.Location = New System.Drawing.Point(151, 142)
		Me.btn_order.Name = "btn_order"
		Me.btn_order.Size = New System.Drawing.Size(165, 32)
		Me.btn_order.TabIndex = 2
		Me.btn_order.Text = "Order"
		Me.btn_order.UseVisualStyleBackColor = True
		'
		'btn_manageMenu
		'
		Me.btn_manageMenu.Location = New System.Drawing.Point(151, 180)
		Me.btn_manageMenu.Name = "btn_manageMenu"
		Me.btn_manageMenu.Size = New System.Drawing.Size(165, 32)
		Me.btn_manageMenu.TabIndex = 2
		Me.btn_manageMenu.Text = "Manage Menu"
		Me.btn_manageMenu.UseVisualStyleBackColor = True
		'
		'btn_manageMember
		'
		Me.btn_manageMember.Location = New System.Drawing.Point(151, 218)
		Me.btn_manageMember.Name = "btn_manageMember"
		Me.btn_manageMember.Size = New System.Drawing.Size(165, 32)
		Me.btn_manageMember.TabIndex = 2
		Me.btn_manageMember.Text = "Manage Member"
		Me.btn_manageMember.UseVisualStyleBackColor = True
		'
		'btn_report
		'
		Me.btn_report.Location = New System.Drawing.Point(151, 256)
		Me.btn_report.Name = "btn_report"
		Me.btn_report.Size = New System.Drawing.Size(165, 32)
		Me.btn_report.TabIndex = 2
		Me.btn_report.Text = "Report"
		Me.btn_report.UseVisualStyleBackColor = True
		'
		'btn_logout
		'
		Me.btn_logout.Location = New System.Drawing.Point(151, 294)
		Me.btn_logout.Name = "btn_logout"
		Me.btn_logout.Size = New System.Drawing.Size(165, 32)
		Me.btn_logout.TabIndex = 2
		Me.btn_logout.Text = "Logout"
		Me.btn_logout.UseVisualStyleBackColor = True
		'
		'formAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(445, 354)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btn_logout)
		Me.Controls.Add(Me.btn_report)
		Me.Controls.Add(Me.btn_manageMember)
		Me.Controls.Add(Me.btn_manageMenu)
		Me.Controls.Add(Me.btn_order)
		Me.Name = "formAdmin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formAdmin"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents btn_order As Button
	Friend WithEvents btn_manageMenu As Button
	Friend WithEvents btn_manageMember As Button
	Friend WithEvents btn_report As Button
	Friend WithEvents btn_logout As Button
End Class
