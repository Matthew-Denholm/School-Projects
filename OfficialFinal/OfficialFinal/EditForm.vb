Imports System.IO               'Must use this to use files
Public Class frmEdit
    'Final Project
    'Form allows user to edit files
    'Addisyn Randolph
    '11/27/16

    Const TAX As Decimal = 0.027        'To hold tax percent

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate labels with information from file
        frmOpenFile.PopulateLabels(Me)

        'Calculate the money
        CalcPay()

    End Sub

    Private Sub txtWage_TextChanged(sender As Object, e As EventArgs) Handles txtWage.TextChanged
        'When hourly wage is changed, the gross and net pay will change
        Dim decNum As Decimal
        'checks if wage text box is empty
        If txtWage.Text <> String.Empty Then
            If Decimal.TryParse(txtWage.Text, decNum) Then
                CalcPay()
            End If
        Else
            'if txtwage is empty, clear the other money text boxes
            txtGross.Clear()
            txtTax.Clear()
            txtNet.Clear()
        End If

    End Sub
    'Function to calculate gross pay
    Function CalculateGross()
        Dim decGross As Decimal
        Dim decWage As Decimal

        decWage = CDec(txtWage.Text)
        decGross = decWage * 40             'Hourly wage times 40 hours
        Return decGross

    End Function
    'Function to calculate net pay
    Function CalculateNet()
        Dim decNet As Decimal
        Dim decGross As Decimal

        decGross = CalculateGross()
        decNet = decGross - (decGross * TAX)          'net pay

        Return decNet
    End Function
    Sub CalcPay()
        Dim decGross As Decimal             'To hold gross pay
        Dim decNet As Decimal               'To hold net pay

        decGross = CalculateGross()
        decNet = CalculateNet()

        txtGross.Text = decGross.ToString("c")
        txtNet.Text = decNet.ToString("c")
        txtTax.Text = (decGross * TAX).ToString("c")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close application
        'Display message box asking user if he wants to save
        If MessageBox.Show("Do you wish to save the changes?", "Save changes", MessageBoxButtons.YesNo) _
            = Windows.Forms.DialogResult.Yes Then
            btnSave_Click(sender, e)        'save changes if yes is clicked
        End If

        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Deletes current file
        'Message box to ensure user wishes to delete file
        If MessageBox.Show("Are you sure you wish to permanently delete this file?", _
                              "Delete File", MessageBoxButtons.YesNo) = _
                          Windows.Forms.DialogResult.Yes Then           'Deleting file only if user clicks 'yes'

            'Variable to hold file name

            Dim strFileName As String
            strFileName = lblFileName.Text.Substring(11)        'Getting only file name
            My.Computer.FileSystem.DeleteFile("records\" & strFileName)

            'Call method to clear labels
            ClearLabels()
        Else
            'If user does not wish to delete file
            Exit Sub
        End If

        Me.Close()

    End Sub

    'Method to clear labels on main form
    Sub ClearLabels()
        With frmMain
            .lblFileName.Text = String.Empty
            .lblGender.Text = String.Empty
            .lblGross.Text = String.Empty
            .lblName.Text = String.Empty
            .lblAddress.Text = String.Empty
            .lblAge.Text = String.Empty
            .lblCity.Text = String.Empty
            .lblState.Text = String.Empty
            .lblWage.Text = String.Empty
            .lblNet.Text = String.Empty
            .lblTax.Text = String.Empty
            .lblPhone.Text = String.Empty


        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Saves changes to record

        Dim strName As String
        Dim strAddress As String
        Dim strGender As String
        Dim strPhone As String
        Dim intAge As Integer
        Dim decWage As Decimal
        Dim strCity As String
        Dim strState As String


        If txtName.Text <> String.Empty Then        'Makes sure name has text
            strName = txtName.Text
        Else
            MessageBox.Show("Please fill in Name", "No input")
            txtName.Focus()
            Exit Sub
        End If
        If txtAddress.Text <> String.Empty Then     ' makes sure address has text
            strAddress = txtAddress.Text
        Else
            MessageBox.Show("Please fill in Address.", "No input")
            txtAddress.Focus()
            Exit Sub
        End If
        If txtGender.Text <> String.Empty Then
            If txtGender.Text.ToUpper = "MALE" Or txtGender.Text.ToUpper = "FEMALE" Then 'Makes sure gender has text
                strGender = txtGender.Text
            Else
                'message box if text entered was not a valid gender
                MessageBox.Show("Please enter a valid gender (male or female)", "Invalid Input")
                txtGender.Clear()
                txtGender.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please fill in Gender", "No input")
            txtGender.Focus()
            Exit Sub
        End If


        'Makes sure phone is filled 
        If txtPhone.Text <> String.Empty Then
            '
            If Long.TryParse(txtPhone.Text, strPhone) And txtPhone.Text.Length = 10 Then
                strPhone = txtPhone.Text
            Else
                MessageBox.Show("Please enter a phone number in xxxxxxxxxx form with numbers.", "Invalid input")
                txtPhone.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Please fill phone.", "no input")
            txtPhone.Focus()
            Exit Sub
        End If


        'checks to make sure age entered is an integer
        If Integer.TryParse(txtAge.Text, intAge) Then
            intAge = txtAge.Text
        Else
            'display error message if age is not an integer
            MessageBox.Show("Please enter a valid age as an integer.", "Invalid input")
            txtAge.Focus()
            txtAge.Clear()
            Exit Sub
        End If
        'Checks to make sure wage entered is a decimal
        If Decimal.TryParse(txtWage.Text, decWage) Then
            decWage = txtWage.Text
        Else
            'Displays message box if wage isnot a decimal
            MessageBox.Show("Please enter a valid hourly wage", "Invalid input")
            txtWage.Focus()
            txtWage.Clear()
            Exit Sub
        End If
        strCity = txtCity.Text
        'Makes sure user does not input his own information into combo box
        If cboState.SelectedIndex <> -1 Then
            strState = cboState.SelectedItem
        Else
            MessageBox.Show("Please select a valid state", "Invalid Selection")
            cboState.Focus()
            Exit Sub
        End If

        Dim PersonFile As StreamWriter
        PersonFile = File.CreateText("records\" & lblFileName.Text.Substring(11))
        With PersonFile
            .WriteLine(txtName.Text)
            .WriteLine(txtAddress.Text)
            .WriteLine(txtCity.Text)
            .WriteLine(cboState.SelectedItem.ToString)
            .WriteLine(txtPhone.Text)
            .WriteLine(txtAge.Text)
            .WriteLine(txtGender.Text)
            .WriteLine(txtWage.Text)
        End With
        PersonFile.Close()

        OpenFile(CalculateGross(), CalculateNet())

        'close form
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Saves record
        btnSave_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        'Deletes file
        btnDelete_Click(sender, e)

    End Sub


    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        'Closes application
        btnCancel_Click(sender, e)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Allows user to change name of file
        Dim strNewName As String
        strNewName = InputBox("Enter new name of file")

        'Check to make sure the new file name is not already in existence
        'Loop through each file and make sure the new name doesn't match any
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("records")
            Dim strRecordName As String = My.Computer.FileSystem.GetName(foundFile)
            If strNewName & ".txt" = strRecordName Then     'If the created file name already exists
                If strNewName & ".txt" <> lblFileName.Text.Substring(11) Then
                    MessageBox.Show("There is currently a file with that name." & ControlChars.CrLf & _
                                   "Please enter a new name.", "File already exists")
                    strNewName = InputBox("Please enter a new name for the file.")
                Else
                    'If the name is the same as it was previously do nothing
                    Exit Sub

                End If
            End If
        Next

        My.Computer.FileSystem.RenameFile("records\" & lblFileName.Text.Substring(11), strNewName & ".txt")
        lblFileName.Text = "File Name: " & strNewName & ".txt"

    End Sub

    Sub OpenFile(ByVal decGross As Decimal, ByVal decNet As Decimal)
        'Dim decGross As Decimal = CalculateGross()
        'Dim decNet As Decimal = CalculateNet()
        Dim ReadFile As StreamReader
        ReadFile = File.OpenText("records\" & lblFileName.Text.Substring(11))


        With frmMain
            .lblName.Text = ReadFile.ReadLine()
            .lblAddress.Text = ReadFile.ReadLine()
            .lblCity.Text = ReadFile.ReadLine()
            .lblState.Text = ReadFile.ReadLine()
            .lblPhone.Text = ReadFile.ReadLine()
            .lblAge.Text = ReadFile.ReadLine()
            .lblGender.Text = ReadFile.ReadLine()
            .lblWage.Text = ReadFile.ReadLine()
            .lblGross.Text = decGross.ToString("c")
            .lblNet.Text = decNet.ToString("c")
            .lblFileName.Text = "File Name: " & lblFileName.Text.Substring(11)
        End With
        ReadFile.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays message box with information 
        MessageBox.Show("Edit File Form coded by Addie Randolph", "About")
    End Sub
End Class