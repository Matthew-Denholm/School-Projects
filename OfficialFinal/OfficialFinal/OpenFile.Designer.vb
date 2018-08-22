<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenFile
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
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.clbRecords = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'lstFiles
        '
        Me.lstFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.ItemHeight = 29
        Me.lstFiles.Location = New System.Drawing.Point(45, 99)
        Me.lstFiles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(434, 178)
        Me.lstFiles.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstFiles, "Records Created")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(120, 44)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(237, 26)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Choose a file to display"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(210, 342)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(101, 31)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.ToolTip1.SetToolTip(Me.btnDisplay, "Display selected record")
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'clbRecords
        '
        Me.clbRecords.CheckOnClick = True
        Me.clbRecords.FormattingEnabled = True
        Me.clbRecords.Location = New System.Drawing.Point(45, 103)
        Me.clbRecords.Name = "clbRecords"
        Me.clbRecords.Size = New System.Drawing.Size(434, 172)
        Me.clbRecords.TabIndex = 3
        Me.clbRecords.Visible = False
        '
        'frmOpenFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 408)
        Me.Controls.Add(Me.clbRecords)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstFiles)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmOpenFile"
        Me.Text = "Open File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents clbRecords As System.Windows.Forms.CheckedListBox
End Class
