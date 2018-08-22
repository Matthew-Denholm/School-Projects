<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMenuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCurrentRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpGenInfo = New System.Windows.Forms.GroupBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCity1 = New System.Windows.Forms.Label()
        Me.lblGender1 = New System.Windows.Forms.Label()
        Me.lblAge1 = New System.Windows.Forms.Label()
        Me.lblPhone1 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.grpPayInfo = New System.Windows.Forms.GroupBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblWage = New System.Windows.Forms.Label()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.lblNet1 = New System.Windows.Forms.Label()
        Me.lblGross1 = New System.Windows.Forms.Label()
        Me.lblWage1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblDT = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.mnuMenuMain.SuspendLayout()
        Me.grpGenInfo.SuspendLayout()
        Me.grpPayInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuMain
        '
        Me.mnuMenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMenuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuMain.Name = "mnuMenuMain"
        Me.mnuMenuMain.Size = New System.Drawing.Size(759, 33)
        Me.mnuMenuMain.TabIndex = 0
        Me.mnuMenuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewRecordToolStripMenuItem, Me.EditCurrentRecordToolStripMenuItem, Me.PrintRecordToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CreateNewRecordToolStripMenuItem
        '
        Me.CreateNewRecordToolStripMenuItem.Name = "CreateNewRecordToolStripMenuItem"
        Me.CreateNewRecordToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.CreateNewRecordToolStripMenuItem.Text = "Create New Record"
        '
        'EditCurrentRecordToolStripMenuItem
        '
        Me.EditCurrentRecordToolStripMenuItem.Name = "EditCurrentRecordToolStripMenuItem"
        Me.EditCurrentRecordToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.EditCurrentRecordToolStripMenuItem.Text = "Edit Current Record"
        '
        'PrintRecordToolStripMenuItem
        '
        Me.PrintRecordToolStripMenuItem.Name = "PrintRecordToolStripMenuItem"
        Me.PrintRecordToolStripMenuItem.Size = New System.Drawing.Size(237, 30)
        Me.PrintRecordToolStripMenuItem.Text = "Print Record"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(134, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'grpGenInfo
        '
        Me.grpGenInfo.Controls.Add(Me.lblState)
        Me.grpGenInfo.Controls.Add(Me.lblGender)
        Me.grpGenInfo.Controls.Add(Me.lblAge)
        Me.grpGenInfo.Controls.Add(Me.lblPhone)
        Me.grpGenInfo.Controls.Add(Me.lblCity)
        Me.grpGenInfo.Controls.Add(Me.lblAddress)
        Me.grpGenInfo.Controls.Add(Me.lblName)
        Me.grpGenInfo.Controls.Add(Me.lblCity1)
        Me.grpGenInfo.Controls.Add(Me.lblGender1)
        Me.grpGenInfo.Controls.Add(Me.lblAge1)
        Me.grpGenInfo.Controls.Add(Me.lblPhone1)
        Me.grpGenInfo.Controls.Add(Me.lblAddress1)
        Me.grpGenInfo.Controls.Add(Me.lblName1)
        Me.grpGenInfo.Location = New System.Drawing.Point(31, 110)
        Me.grpGenInfo.Name = "grpGenInfo"
        Me.grpGenInfo.Size = New System.Drawing.Size(332, 342)
        Me.grpGenInfo.TabIndex = 1
        Me.grpGenInfo.TabStop = False
        Me.grpGenInfo.Text = "General Information"
        Me.ToolTip1.SetToolTip(Me.grpGenInfo, "General Information ")
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.Location = New System.Drawing.Point(193, 127)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(79, 28)
        Me.lblState.TabIndex = 21
        '
        'lblGender
        '
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGender.Location = New System.Drawing.Point(112, 280)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(160, 28)
        Me.lblGender.TabIndex = 20
        '
        'lblAge
        '
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAge.Location = New System.Drawing.Point(112, 231)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(160, 28)
        Me.lblAge.TabIndex = 19
        '
        'lblPhone
        '
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.Location = New System.Drawing.Point(112, 178)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(160, 28)
        Me.lblPhone.TabIndex = 18
        '
        'lblCity
        '
        Me.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCity.Location = New System.Drawing.Point(70, 126)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(97, 28)
        Me.lblCity.TabIndex = 17
        '
        'lblAddress
        '
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Location = New System.Drawing.Point(112, 86)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(160, 28)
        Me.lblAddress.TabIndex = 16
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(112, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(160, 28)
        Me.lblName.TabIndex = 15
        '
        'lblCity1
        '
        Me.lblCity1.AutoSize = True
        Me.lblCity1.Location = New System.Drawing.Point(24, 127)
        Me.lblCity1.Name = "lblCity1"
        Me.lblCity1.Size = New System.Drawing.Size(39, 20)
        Me.lblCity1.TabIndex = 14
        Me.lblCity1.Text = "City:"
        '
        'lblGender1
        '
        Me.lblGender1.AutoSize = True
        Me.lblGender1.Location = New System.Drawing.Point(25, 288)
        Me.lblGender1.Name = "lblGender1"
        Me.lblGender1.Size = New System.Drawing.Size(67, 20)
        Me.lblGender1.TabIndex = 4
        Me.lblGender1.Text = "Gender:"
        '
        'lblAge1
        '
        Me.lblAge1.AutoSize = True
        Me.lblAge1.Location = New System.Drawing.Point(25, 239)
        Me.lblAge1.Name = "lblAge1"
        Me.lblAge1.Size = New System.Drawing.Size(42, 20)
        Me.lblAge1.TabIndex = 3
        Me.lblAge1.Text = "Age:"
        '
        'lblPhone1
        '
        Me.lblPhone1.AutoSize = True
        Me.lblPhone1.Location = New System.Drawing.Point(25, 190)
        Me.lblPhone1.Name = "lblPhone1"
        Me.lblPhone1.Size = New System.Drawing.Size(59, 20)
        Me.lblPhone1.TabIndex = 2
        Me.lblPhone1.Text = "Phone:"
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(20, 86)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress1.TabIndex = 1
        Me.lblAddress1.Text = "Address:"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Location = New System.Drawing.Point(25, 40)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(55, 20)
        Me.lblName1.TabIndex = 0
        Me.lblName1.Text = "Name:"
        '
        'grpPayInfo
        '
        Me.grpPayInfo.Controls.Add(Me.lblTax)
        Me.grpPayInfo.Controls.Add(Me.lblNet)
        Me.grpPayInfo.Controls.Add(Me.lblGross)
        Me.grpPayInfo.Controls.Add(Me.lblWage)
        Me.grpPayInfo.Controls.Add(Me.lblTax1)
        Me.grpPayInfo.Controls.Add(Me.lblNet1)
        Me.grpPayInfo.Controls.Add(Me.lblGross1)
        Me.grpPayInfo.Controls.Add(Me.lblWage1)
        Me.grpPayInfo.Location = New System.Drawing.Point(422, 110)
        Me.grpPayInfo.Name = "grpPayInfo"
        Me.grpPayInfo.Size = New System.Drawing.Size(286, 342)
        Me.grpPayInfo.TabIndex = 2
        Me.grpPayInfo.TabStop = False
        Me.grpPayInfo.Text = "Payment Information"
        Me.ToolTip1.SetToolTip(Me.grpPayInfo, "Payment Information")
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(116, 254)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(126, 26)
        Me.lblTax.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.lblTax, "Total Taxes ")
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.Control
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNet.Location = New System.Drawing.Point(116, 180)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(126, 26)
        Me.lblNet.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.lblNet, "Total Pay after taxes")
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGross.Location = New System.Drawing.Point(116, 110)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(126, 26)
        Me.lblGross.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.lblGross, "Total pay before taxes")
        '
        'lblWage
        '
        Me.lblWage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWage.Location = New System.Drawing.Point(116, 45)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(126, 26)
        Me.lblWage.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.lblWage, "Hourly Wage")
        '
        'lblTax1
        '
        Me.lblTax1.AutoSize = True
        Me.lblTax1.Location = New System.Drawing.Point(6, 264)
        Me.lblTax1.Name = "lblTax1"
        Me.lblTax1.Size = New System.Drawing.Size(55, 20)
        Me.lblTax1.TabIndex = 13
        Me.lblTax1.Text = "Taxes:"
        '
        'lblNet1
        '
        Me.lblNet1.AutoSize = True
        Me.lblNet1.Location = New System.Drawing.Point(6, 190)
        Me.lblNet1.Name = "lblNet1"
        Me.lblNet1.Size = New System.Drawing.Size(68, 20)
        Me.lblNet1.TabIndex = 12
        Me.lblNet1.Text = "Net Pay:"
        '
        'lblGross1
        '
        Me.lblGross1.AutoSize = True
        Me.lblGross1.Location = New System.Drawing.Point(6, 120)
        Me.lblGross1.Name = "lblGross1"
        Me.lblGross1.Size = New System.Drawing.Size(86, 20)
        Me.lblGross1.TabIndex = 11
        Me.lblGross1.Text = "Gross Pay:"
        '
        'lblWage1
        '
        Me.lblWage1.AutoSize = True
        Me.lblWage1.Location = New System.Drawing.Point(6, 55)
        Me.lblWage1.Name = "lblWage1"
        Me.lblWage1.Size = New System.Drawing.Size(104, 20)
        Me.lblWage1.TabIndex = 10
        Me.lblWage1.Text = "Hourly Wage:"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(101, 465)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(124, 54)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "&Create New Record"
        Me.ToolTip1.SetToolTip(Me.btnCreate, "Click to Create New Record")
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(299, 465)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 54)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "&Edit Current Record"
        Me.ToolTip1.SetToolTip(Me.btnEdit, "Click to edit current Record")
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(497, 465)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(124, 54)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "&Print Records"
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Click to Print Records")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblDT
        '
        Me.lblDT.Location = New System.Drawing.Point(521, 537)
        Me.lblDT.Name = "lblDT"
        Me.lblDT.Size = New System.Drawing.Size(236, 40)
        Me.lblDT.TabIndex = 3
        Me.lblDT.Text = "Label1"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(31, 58)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(0, 25)
        Me.lblFileName.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 583)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblDT)
        Me.Controls.Add(Me.grpPayInfo)
        Me.Controls.Add(Me.grpGenInfo)
        Me.Controls.Add(Me.mnuMenuMain)
        Me.MainMenuStrip = Me.mnuMenuMain
        Me.Name = "frmMain"
        Me.Text = "Records"
        Me.mnuMenuMain.ResumeLayout(False)
        Me.mnuMenuMain.PerformLayout()
        Me.grpGenInfo.ResumeLayout(False)
        Me.grpGenInfo.PerformLayout()
        Me.grpPayInfo.ResumeLayout(False)
        Me.grpPayInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCurrentRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpGenInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblGender1 As System.Windows.Forms.Label
    Friend WithEvents lblAge1 As System.Windows.Forms.Label
    Friend WithEvents lblPhone1 As System.Windows.Forms.Label
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents grpPayInfo As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblWage As System.Windows.Forms.Label
    Friend WithEvents lblTax1 As System.Windows.Forms.Label
    Friend WithEvents lblNet1 As System.Windows.Forms.Label
    Friend WithEvents lblGross1 As System.Windows.Forms.Label
    Friend WithEvents lblWage1 As System.Windows.Forms.Label
    Friend WithEvents lblDT As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblCity1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label

End Class
