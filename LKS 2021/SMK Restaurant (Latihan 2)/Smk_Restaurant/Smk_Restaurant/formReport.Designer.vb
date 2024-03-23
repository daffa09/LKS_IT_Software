<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReport
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(228, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(208, 37)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Form Report"
		'
		'Chart1
		'
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend1)
		Me.Chart1.Location = New System.Drawing.Point(36, 343)
		Me.Chart1.Name = "Chart1"
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Income"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(633, 191)
		Me.Chart1.TabIndex = 5
		Me.Chart1.Text = "Chart1"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(253, 103)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
		Me.ComboBox1.TabIndex = 6
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(75, 203)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(555, 118)
		Me.DataGridView1.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(202, 106)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(44, 18)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "From"
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(253, 141)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(201, 21)
		Me.ComboBox2.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(202, 144)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(26, 18)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "To"
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.Button1.Location = New System.Drawing.Point(472, 140)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(97, 28)
		Me.Button1.TabIndex = 9
		Me.Button1.Text = "Generate"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'formReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(681, 564)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Chart1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "formReport"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "formReport"
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Button1 As Button
End Class
