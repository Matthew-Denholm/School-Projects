Imports System.IO
Public Class frmOpenFile
    'Final project
    'Form displays records created and allows user to choose one to display on main form
    'Addisyn Randolph & Matthew Denholm
    '11/26/16

    Dim decGross As Decimal             'To hold gross pay
    Const TAX As Decimal = 0.027             'To hold taxes
    Dim decNet As Decimal               'To hold net pay 

    Dim strFileName As String

    Dim lstRecords As List(Of String)
    Private Sub frmOpenFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Retrieves all created files and populated list box

        lstRecords = New List(Of String)        'List to hold records

        'For each file found in file 'records' add to list
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("records")
            Dim strRecordName As String
            strRecordName = My.Computer.FileSystem.GetName("records\" & foundFile)        'Only display name of file and not path (path is 83 characters)
            lstRecords.Add(strRecordName)
        Next

        'Populate list box with contents of list
        Dim intNum As Integer
        For intNum = 0 To lstRecords.ToArray.Length - 1
            lstFiles.Items.Add(lstRecords(intNum))
        Next


    End Sub

    Public Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Opens selected file and displays the text
        Dim intSelectedIndex As Integer = lstFiles.SelectedIndex
        If lstFiles.Visible = True Then
            'Makes sure there is a file selected
            If lstFiles.SelectedIndex <> -1 Then
                PopulateLabels(frmMain)

                Dim decWage As String = frmMain.lblWage.Text

                'If intwage is a decimal
                If CDec(decWage) Or decWage = 0 Then
                    decGross = decWage * 40         'Gross pay equals hourly wage times 40 hours
                    Taxes()                         'Calls the function that Calculates Net Pay.
                    frmMain.lblGross.Text = decGross.ToString("c")
                    frmMain.lblNet.Text = decNet.ToString("c")
                    frmMain.lblTax.Text = (decGross * TAX).ToString("c")
                End If
                Me.Close()

            Else
                'error if no file is selected
                MessageBox.Show("Please select a file to open", "No file selected")
                Exit Sub
            End If
        ElseIf clbRecords.Visible = True Then

            'Initialize with a new line
            frmPreview.RichTextBox1.Text &= ControlChars.CrLf
            'Declare the counting variable
            Dim intCount As Integer
            'Loop through each item in list box 
            For intCount = 0 To clbRecords.Items.Count - 1
                'If that item is checked
                If clbRecords.GetItemChecked(intCount) Then
                    'Declare a string as the name of the file
                    Dim strFileName As String
                    strFileName = clbRecords.Items.Item(intCount)       'The file name is the selected item at that index
                    'Declare varaible to open the file with that file name
                    Dim PersonFile As StreamReader = File.OpenText("records\" & strFileName)
                    'Do while loop to format the file into one line
                    Do While Not PersonFile.EndOfStream
                        'Each line of file is appended onto the end of the line with a space
                        frmPreview.RichTextBox1.Text &= PersonFile.ReadLine().ToString & "      "
                    Loop
                    'Add a new line after each line of file
                    frmPreview.RichTextBox1.Text &= ControlChars.CrLf
                    'close file
                    PersonFile.Close()
                End If
            Next
            'Close the form
            Me.Close()
        End If

    End Sub

    'Method to populate labels of main and edit form
    Sub PopulateLabels(ByVal frmForm As Form)           'Takes a form as a parameter

        If frmForm Is frmMain Then
            strFileName = lstFiles.SelectedItem.ToString
            Dim PersonFile As StreamReader = File.OpenText("records\" & strFileName)
            frmMain.lblName.Text = PersonFile.ReadLine().ToString
            frmMain.lblAddress.Text = PersonFile.ReadLine().ToString
            frmMain.lblCity.Text = PersonFile.ReadLine().ToString
            frmMain.lblState.Text = PersonFile.ReadLine().ToString
            frmMain.lblPhone.Text = PersonFile.ReadLine().ToString
            frmMain.lblAge.Text = PersonFile.ReadLine().ToString
            frmMain.lblGender.Text = PersonFile.ReadLine().ToString
            frmMain.lblWage.Text = PersonFile.ReadLine().ToString
            frmMain.lblFileName.Text = "File Name: " & strFileName
            Dim decWage As String = frmMain.lblWage.Text.ToString
            PersonFile.Close()
        ElseIf frmForm Is frmEdit Then
            strFileName = frmMain.lblFileName.Text.Substring(11)        'Getting the file name without other text
            frmEdit.lblFileName.Text = "File Name: " & strFileName
            Dim PersonFile As StreamReader = File.OpenText("records\" & strFileName)
            frmEdit.txtName.Text = PersonFile.ReadLine().ToString
            frmEdit.txtAddress.Text = PersonFile.ReadLine().ToString
            frmEdit.txtCity.Text = PersonFile.ReadLine().ToString
            frmEdit.cboState.Text = PersonFile.ReadLine().ToString
            frmEdit.txtPhone.Text = PersonFile.ReadLine().ToString
            frmEdit.txtAge.Text = PersonFile.ReadLine().ToString
            frmEdit.txtGender.Text = PersonFile.ReadLine().ToString
            frmEdit.txtWage.Text = PersonFile.ReadLine().ToString
            PersonFile.Close()

        End If

    End Sub

    Function Taxes()
        decNet = decGross - (decGross * TAX)
        Return decNet
    End Function
End Class