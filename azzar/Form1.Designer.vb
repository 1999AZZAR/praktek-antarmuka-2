<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QUITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AKTIFITASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aktifitas1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aktifitas2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aktifitas3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aktifitas4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Aktifitas5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QUITToolStripMenuItem, Me.AKTIFITASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(208, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QUITToolStripMenuItem
        '
        Me.QUITToolStripMenuItem.Name = "QUITToolStripMenuItem"
        Me.QUITToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.QUITToolStripMenuItem.Text = "QUIT"
        '
        'AKTIFITASToolStripMenuItem
        '
        Me.AKTIFITASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Aktifitas1, Me.Aktifitas2, Me.Aktifitas3, Me.Aktifitas4, Me.Aktifitas5})
        Me.AKTIFITASToolStripMenuItem.Name = "AKTIFITASToolStripMenuItem"
        Me.AKTIFITASToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AKTIFITASToolStripMenuItem.Text = "AKTIFITAS"
        '
        'Aktifitas1
        '
        Me.Aktifitas1.Name = "Aktifitas1"
        Me.Aktifitas1.Size = New System.Drawing.Size(180, 22)
        Me.Aktifitas1.Text = "AKTIFITAS 1"
        '
        'Aktifitas2
        '
        Me.Aktifitas2.Name = "Aktifitas2"
        Me.Aktifitas2.Size = New System.Drawing.Size(180, 22)
        Me.Aktifitas2.Text = "AKTIFITAS 2"
        '
        'Aktifitas3
        '
        Me.Aktifitas3.Name = "Aktifitas3"
        Me.Aktifitas3.Size = New System.Drawing.Size(180, 22)
        Me.Aktifitas3.Text = "AKTIFITAS 3"
        '
        'Aktifitas4
        '
        Me.Aktifitas4.Name = "Aktifitas4"
        Me.Aktifitas4.Size = New System.Drawing.Size(180, 22)
        Me.Aktifitas4.Text = "AKTIFITAS 4"
        '
        'Aktifitas5
        '
        Me.Aktifitas5.Name = "Aktifitas5"
        Me.Aktifitas5.Size = New System.Drawing.Size(180, 22)
        Me.Aktifitas5.Text = "AKTIFITAS 5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 111)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "tutorial vb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents QUITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AKTIFITASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Aktifitas1 As ToolStripMenuItem
    Friend WithEvents Aktifitas2 As ToolStripMenuItem
    Friend WithEvents Aktifitas3 As ToolStripMenuItem
    Friend WithEvents Aktifitas4 As ToolStripMenuItem
    Friend WithEvents Aktifitas5 As ToolStripMenuItem
End Class
