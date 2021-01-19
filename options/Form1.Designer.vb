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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPeter = New System.Windows.Forms.RadioButton()
        Me.radJames = New System.Windows.Forms.RadioButton()
        Me.radSteven = New System.Windows.Forms.RadioButton()
        Me.radGeorge = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStudio = New System.Windows.Forms.Label()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.lblBestMovie = New System.Windows.Forms.Label()
        Me.lblNetWorth = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPeter)
        Me.GroupBox1.Controls.Add(Me.radJames)
        Me.GroupBox1.Controls.Add(Me.radSteven)
        Me.GroupBox1.Controls.Add(Me.radGeorge)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 414)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "People"
        '
        'radPeter
        '
        Me.radPeter.AutoSize = True
        Me.radPeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPeter.Location = New System.Drawing.Point(24, 305)
        Me.radPeter.Name = "radPeter"
        Me.radPeter.Size = New System.Drawing.Size(205, 35)
        Me.radPeter.TabIndex = 3
        Me.radPeter.Text = "Peter Jackson"
        Me.radPeter.UseVisualStyleBackColor = True
        '
        'radJames
        '
        Me.radJames.AutoSize = True
        Me.radJames.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJames.Location = New System.Drawing.Point(24, 229)
        Me.radJames.Name = "radJames"
        Me.radJames.Size = New System.Drawing.Size(230, 35)
        Me.radJames.TabIndex = 2
        Me.radJames.Text = "James Cameron"
        Me.radJames.UseVisualStyleBackColor = True
        '
        'radSteven
        '
        Me.radSteven.AutoSize = True
        Me.radSteven.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSteven.Location = New System.Drawing.Point(24, 153)
        Me.radSteven.Name = "radSteven"
        Me.radSteven.Size = New System.Drawing.Size(238, 35)
        Me.radSteven.TabIndex = 1
        Me.radSteven.Text = "Steven Spielberg"
        Me.radSteven.UseVisualStyleBackColor = True
        '
        'radGeorge
        '
        Me.radGeorge.AutoSize = True
        Me.radGeorge.Checked = True
        Me.radGeorge.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGeorge.Location = New System.Drawing.Point(24, 77)
        Me.radGeorge.Name = "radGeorge"
        Me.radGeorge.Size = New System.Drawing.Size(202, 35)
        Me.radGeorge.TabIndex = 0
        Me.radGeorge.TabStop = True
        Me.radGeorge.Text = "George Lucas"
        Me.radGeorge.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblStudio)
        Me.GroupBox2.Controls.Add(Me.lblReleaseDate)
        Me.GroupBox2.Controls.Add(Me.lblBestMovie)
        Me.GroupBox2.Controls.Add(Me.lblNetWorth)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(470, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 414)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info"
        '
        'lblStudio
        '
        Me.lblStudio.AutoSize = True
        Me.lblStudio.Location = New System.Drawing.Point(18, 315)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(82, 29)
        Me.lblStudio.TabIndex = 3
        Me.lblStudio.Text = "Studio"
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Location = New System.Drawing.Point(18, 233)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(159, 29)
        Me.lblReleaseDate.TabIndex = 2
        Me.lblReleaseDate.Text = "Release Date"
        '
        'lblBestMovie
        '
        Me.lblBestMovie.AutoSize = True
        Me.lblBestMovie.Location = New System.Drawing.Point(18, 151)
        Me.lblBestMovie.Name = "lblBestMovie"
        Me.lblBestMovie.Size = New System.Drawing.Size(132, 29)
        Me.lblBestMovie.TabIndex = 1
        Me.lblBestMovie.Text = "Best Movie"
        '
        'lblNetWorth
        '
        Me.lblNetWorth.AutoSize = True
        Me.lblNetWorth.Location = New System.Drawing.Point(18, 69)
        Me.lblNetWorth.Name = "lblNetWorth"
        Me.lblNetWorth.Size = New System.Drawing.Size(120, 29)
        Me.lblNetWorth.TabIndex = 0
        Me.lblNetWorth.Text = "Net Worth"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1149, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuNew.Text = "New"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Top Actor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radGeorge As System.Windows.Forms.RadioButton
    Friend WithEvents radPeter As System.Windows.Forms.RadioButton
    Friend WithEvents radJames As System.Windows.Forms.RadioButton
    Friend WithEvents radSteven As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStudio As System.Windows.Forms.Label
    Friend WithEvents lblReleaseDate As System.Windows.Forms.Label
    Friend WithEvents lblBestMovie As System.Windows.Forms.Label
    Friend WithEvents lblNetWorth As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
