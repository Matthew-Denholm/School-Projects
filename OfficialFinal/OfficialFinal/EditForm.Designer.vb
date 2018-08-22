<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpPayInfo = New System.Windows.Forms.GroupBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.lblNet1 = New System.Windows.Forms.Label()
        Me.lblGross1 = New System.Windows.Forms.Label()
        Me.lblWage1 = New System.Windows.Forms.Label()
        Me.grpGenInfo = New System.Windows.Forms.GroupBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.grpPayInfo.SuspendLayout()
        Me.grpGenInfo.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(520, 477)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 54)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Click to Return")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(320, 477)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 54)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "&Delete Record"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Click to Delete Records")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(124, 477)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 54)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save Record"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Click to Save Changes")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grpPayInfo
        '
        Me.grpPayInfo.Controls.Add(Me.txtTax)
        Me.grpPayInfo.Controls.Add(Me.txtNet)
        Me.grpPayInfo.Controls.Add(Me.txtGross)
        Me.grpPayInfo.Controls.Add(Me.txtWage)
        Me.grpPayInfo.Controls.Add(Me.lblTax1)
        Me.grpPayInfo.Controls.Add(Me.lblNet1)
        Me.grpPayInfo.Controls.Add(Me.lblGross1)
        Me.grpPayInfo.Controls.Add(Me.lblWage1)
        Me.grpPayInfo.Location = New System.Drawing.Point(445, 94)
        Me.grpPayInfo.Name = "grpPayInfo"
        Me.grpPayInfo.Size = New System.Drawing.Size(264, 342)
        Me.grpPayInfo.TabIndex = 8
        Me.grpPayInfo.TabStop = False
        Me.grpPayInfo.Text = "Payment Information"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(116, 258)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(130, 26)
        Me.txtTax.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtTax, "Edit Taxes")
        '
        'txtNet
        '
        Me.txtNet.Location = New System.Drawing.Point(116, 184)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.Size = New System.Drawing.Size(130, 26)
        Me.txtNet.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtNet, "Edit Net Pay")
        '
        'txtGross
        '
        Me.txtGross.Location = New System.Drawing.Point(116, 117)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(130, 26)
        Me.txtGross.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtGross, "Edit Gross Pay")
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(116, 49)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(130, 26)
        Me.txtWage.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtWage, "Edit Hourly Wage")
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
        'grpGenInfo
        '
        Me.grpGenInfo.Controls.Add(Me.cboState)
        Me.grpGenInfo.Controls.Add(Me.txtCity)
        Me.grpGenInfo.Controls.Add(Me.lblCity)
        Me.grpGenInfo.Controls.Add(Me.txtGender)
        Me.grpGenInfo.Controls.Add(Me.txtAge)
        Me.grpGenInfo.Controls.Add(Me.txtPhone)
        Me.grpGenInfo.Controls.Add(Me.txtAddress)
        Me.grpGenInfo.Controls.Add(Me.txtName)
        Me.grpGenInfo.Controls.Add(Me.lblGender)
        Me.grpGenInfo.Controls.Add(Me.lblAge)
        Me.grpGenInfo.Controls.Add(Me.lblPhone)
        Me.grpGenInfo.Controls.Add(Me.lblAddress)
        Me.grpGenInfo.Controls.Add(Me.lblName)
        Me.grpGenInfo.Location = New System.Drawing.Point(54, 94)
        Me.grpGenInfo.Name = "grpGenInfo"
        Me.grpGenInfo.Size = New System.Drawing.Size(326, 342)
        Me.grpGenInfo.TabIndex = 7
        Me.grpGenInfo.TabStop = False
        Me.grpGenInfo.Text = "General Information"
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV"})
        Me.cboState.Location = New System.Drawing.Point(200, 117)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(85, 28)
        Me.cboState.TabIndex = 12
        Me.cboState.Text = "State"
        Me.ToolTip1.SetToolTip(Me.cboState, "Edit State")
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(70, 119)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(124, 26)
        Me.txtCity.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtCity, "Edit City")
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(25, 123)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 20)
        Me.lblCity.TabIndex = 10
        Me.lblCity.Text = "City:"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(112, 282)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(163, 26)
        Me.txtGender.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtGender, "Edit Gender")
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(112, 224)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(163, 26)
        Me.txtAge.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtAge, "Edit Age")
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(112, 162)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(163, 26)
        Me.txtPhone.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtPhone, "Edit Phone number")
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(112, 82)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(163, 26)
        Me.txtAddress.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtAddress, "Edit Address")
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(112, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 26)
        Me.txtName.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtName, "Edit Name")
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(25, 288)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(67, 20)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(25, 230)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(42, 20)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(25, 168)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(59, 20)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(25, 88)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 20)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(25, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(769, 33)
        Me.mnuMenu.TabIndex = 13
        Me.mnuMenu.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.CancelToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(152, 30)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.CancelToolStripMenuItem.Text = "Cancel"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(54, 51)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(57, 20)
        Me.lblFileName.TabIndex = 14
        Me.lblFileName.Text = "Label1"
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 583)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpPayInfo)
        Me.Controls.Add(Me.grpGenInfo)
        Me.Controls.Add(Me.mnuMenu)
        Me.Name = "frmEdit"
        Me.Text = "Edit Record"
        Me.grpPayInfo.ResumeLayout(False)
        Me.grpPayInfo.PerformLayout()
        Me.grpGenInfo.ResumeLayout(False)
        Me.grpGenInfo.PerformLayout()
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpPayInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtNet As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents lblTax1 As System.Windows.Forms.Label
    Friend WithEvents lblNet1 As System.Windows.Forms.Label
    Friend WithEvents lblGross1 As System.Windows.Forms.Label
    Friend WithEvents lblWage1 As System.Windows.Forms.Label
    Friend WithEvents grpGenInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
End Class
