Imports System.IO           'Must use this to be able to create files
Public Class frmNew
    'Final Project
    'Form allows user to create a new file
    'Addisyn Randolph
    '11/27/16

    Const TAX As Decimal = 0.027

    Dim strName As String               'To hold name of person
    Dim strAddress As String            'To hold address 
    Dim strPhone As String              'To hold phone
    Dim intAge As Integer               'To hold age 
    Dim strGender As String             'To hold gender
    Dim decWage As Decimal              'To hold hourly wage
    Dim strCity As String               'To hold city
    Dim strState As String              'To hold state

    Dim strFileName As String           'To hold name of file

    'Public lstRecords As List(Of String)

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all text boxes

        txtAddress.Text = String.Empty
        txtAge.Text = String.Empty
        txtGender.Text = String.Empty
        txtName.Text = String.Empty
        txtPhone.Text = String.Empty
        txtWage.Text = String.Empty
        txtCity.Text = String.Empty
        cboState.SelectedIndex = -1             'No selected index
        cboState.Text = "State"                 'Set text back to 'state'

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Saves information to a text file


        'Get inputed user information

        'Call function to check for input in name
        If CheckInput(strName, txtName) = False Then        'Exiting sub if there is no input
            Exit Sub
        Else
            strName = txtName.Text
        End If
        'Check input in address text box
        If CheckInput(strAddress, txtAddress) = False Then
            Exit Sub
        Else
            strAddress = txtAddress.Text
        End If
        If CheckInput(strCity, txtCity) = False Then                'Check input of txtCity
            Exit Sub
        Else
            strCity = txtCity.Text
        End If
        'Makes sure user does not input his own information into combo box
        If cboState.SelectedIndex <> -1 Then
            strState = cboState.SelectedItem
        Else
            MessageBox.Show("Please select a valid state", "Invalid Selection")
            cboState.Focus()
            Exit Sub
        End If
        'If txtName.Text <> String.Empty Then        'Makes sure name has text
        '    strName = txtName.Text
        'Else
        '    MessageBox.Show("Please fill in Name", "No input")
        '    txtName.Focus()
        '    Exit Sub
        'End If
        'If txtAddress.Text <> String.Empty Then     ' makes sure address has text
        '    strAddress = txtAddress.Text
        'Else
        '    MessageBox.Show("Please fill in Address.", "No input")
        '    txtAddress.Focus()
        '    Exit Sub
        'End If

        'Makes sure phone is filled 
        If CheckPhone(strPhone, txtPhone) = False Then
            Exit Sub
        Else
            strPhone = txtPhone.Text
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

        'If txtPhone.Text <> String.Empty Then
        '    '
        '    If Long.TryParse(txtPhone.Text, strPhone) And txtPhone.Text.Length = 10 Then
        '        strPhone = txtPhone.Text
        '    Else
        '        MessageBox.Show("Please enter a phone number in xxxxxxxxxx form with numbers.", "Invalid input")
        '        txtPhone.Focus()
        '        Exit Sub
        '    End If
        'Else
        '    MessageBox.Show("Please fill phone.", "no input")
        '    txtPhone.Focus()
        '    Exit Sub
        'End If


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


        'Input box to set name of file
        strFileName = InputBox("Please enter the name of the file.")

            'Check to make sure created file is not already in existence
            For Each foundFile As String In My.Computer.FileSystem.GetFiles("records")
            Dim strRecordName As String = My.Computer.FileSystem.GetName(foundFile)
            If strFileName & ".txt" = strRecordName Then     'If the created file name already exists
                If MessageBox.Show("There is currently a file with that name." & ControlChars.CrLf & _
                                "Do you wish to replace it?", "File already exists", MessageBoxButtons.YesNo) _
                            = Windows.Forms.DialogResult.No Then            'If user does not want to replace file
                    strFileName = InputBox("Please enter a new name for the file.")

                End If
            End If
            Next

            Dim PersonFile As StreamWriter              'Stream writer variable to create file
            Try
                'Try to create file and write information to file.
                'PersonFile = File.CreateText("C:\Users\" & strName & "\Dropbox\Final Project\Records\" & strFileName & ".txt")
            PersonFile = File.CreateText("records\" & strFileName & ".txt")
                PersonFile.WriteLine(strName)
                PersonFile.WriteLine(strAddress)
                PersonFile.WriteLine(strCity)
                PersonFile.WriteLine(strState)
                PersonFile.WriteLine(strPhone)
                PersonFile.WriteLine(intAge)
                PersonFile.WriteLine(strGender)
                PersonFile.WriteLine(decWage)

                PersonFile.Close()
            Catch ex As Exception
                'Error if file couldn't be created
                MessageBox.Show("Error: File could not be created.")
                Exit Sub
            End Try

            'frmOpenFile.lstFiles.SelectedItem = strFileName
            'frmOpenFile.PopulateLabels(frmMain)

            'Open and read file created. Display it in main form
            OpenFile(strFileName)
            Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Closes application
        Me.Close()

    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        'Calls the create button
        btnCreate_Click(sender, e)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Calls clear button
        btnClear_Click(sender, e)
    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        'Closes application
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays message box with information about 
        MessageBox.Show("Create New File Form Coded by Addie Randolph", "About")
    End Sub

    'Methods to calculate gross pay
    Function CalculateGross()
        Dim decGross As Decimal
        Dim decWage As Decimal

        decWage = CDec(txtWage.Text)
        decGross = decWage * 40             'Hourly wage times 40 hours
        Return decGross

    End Function
    'Method to calculate net pay
    Function CalculateNet()
        Dim decNet As Decimal
        Dim decGross As Decimal

        decGross = CalculateGross()
        decNet = decGross - (decGross * TAX)          'net pay

        Return decNet
    End Function
    'Method to open file 
    Sub OpenFile(ByVal strFileName As String)
        Dim decGross As Decimal = CalculateGross()
        Dim decNet As Decimal = CalculateNet()
        Dim ReadFile As StreamReader
        ReadFile = File.OpenText("records\" & strFileName & ".txt")


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
            .lblFileName.Text = "File Name: " & strFileName & ".txt"
        End With
        ReadFile.Close()
        CalcPay()
    End Sub
    'Method to calculate pay and display in labels
    Sub CalcPay()
        Dim decGross As Decimal             'To hold gross pay
        Dim decNet As Decimal               'To hold net pay

        decGross = CalculateGross()
        decNet = CalculateNet()

        frmMain.lblGross.Text = decGross.ToString("c")
        frmMain.lblNet.Text = decNet.ToString("c")
        frmMain.lblTax.Text = (decGross * TAX).ToString("c")
    End Sub
    'Function to check for input of text box
    Function CheckInput(ByRef strInput As String, ByVal txtBox As TextBox)

        If txtBox.Text <> String.Empty Then
            strInput = txtName.Text
            Return True             'Return True when requirements are met
        Else
            MessageBox.Show("Please fill in appropriate text box", "No input")
            txtBox.Focus()
            Return False            'Returns false if requirements aren't met.
        End If
    End Function

    'Function to check to input of phone number
    Function CheckPhone(ByVal strInput As String, ByVal txtBox As TextBox)

        If txtBox.Text <> String.Empty Then
            If Long.TryParse(txtBox.Text, strInput) And txtBox.Text.Length = 10 Then            'Makes sure phone number is a number
                strInput = txtBox.Text                                                          'Have to long parse because the largest number (9999999999) is bigger than the largest integer
                'Also makes sure there are only 10 numbers.
                Return True
            Else
                'If the input is invalid
                MessageBox.Show("Please enter a phone number in xxxxxxxxxx form with numbers.", "Invalid input")
                txtBox.Focus()
                Return False
            End If
        Else
            'If there is no input
            MessageBox.Show("Please fill in Phone number", "No input")
            txtBox.Focus()
            Return False
        End If
    End Function
End Class