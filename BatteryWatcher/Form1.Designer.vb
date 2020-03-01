<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 3000
		'
		'Timer3
		'
		Me.Timer3.Interval = 1000
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(0, 0)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Opacity = 0R
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Battery Watcher"
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Timer1 As Timer
	Friend WithEvents Timer2 As Timer
	Friend WithEvents Timer3 As Timer
End Class
