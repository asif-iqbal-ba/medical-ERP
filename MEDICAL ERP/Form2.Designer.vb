<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.REToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CREATEMRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RECIEVEPAYMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1085, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REToolStripMenuItem
        '
        Me.REToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREATEMRToolStripMenuItem, Me.RECIEVEPAYMENTToolStripMenuItem})
        Me.REToolStripMenuItem.Name = "REToolStripMenuItem"
        Me.REToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.REToolStripMenuItem.Text = "RECEPTION"
        '
        'CREATEMRToolStripMenuItem
        '
        Me.CREATEMRToolStripMenuItem.Name = "CREATEMRToolStripMenuItem"
        Me.CREATEMRToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CREATEMRToolStripMenuItem.Text = "CREATE MR"
        '
        'RECIEVEPAYMENTToolStripMenuItem
        '
        Me.RECIEVEPAYMENTToolStripMenuItem.Name = "RECIEVEPAYMENTToolStripMenuItem"
        Me.RECIEVEPAYMENTToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RECIEVEPAYMENTToolStripMenuItem.Text = "RECIEVE PAYMENT"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 586)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents REToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CREATEMRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECIEVEPAYMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
