Public Class frmPreview
    'Final Project
    'Form allows the user to Print a record or records of their selection.
    'Programmed by: Matthew Denholm
    'Date last modified: 11/26/2016


    'Global Vairables
    Dim CurrentFont As New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
    Dim CurrentColor As SolidBrush
    Dim strFileName As String
    Dim lstRecords As List(Of String)

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        'Returns you to the main Form.
        Me.Close()
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        'brings up a menu with the ability to select different fonts and colors.
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Saves your font and color selection
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
            CurrentFont = FontDialog1.Font
            CurrentColor = New SolidBrush(FontDialog1.Color)
        End If

    End Sub
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        'Opens the File viewer and allows the user to check which records to print.
        frmOpenFile.Show()
        frmOpenFile.clbRecords.Visible = True
        frmOpenFile.lstFiles.Visible = False
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
            frmOpenFile.clbRecords.Items.Add(lstRecords(intNum))
        Next

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1  'Sets this as the document to print, which is what is inside the richtextbox
        'An if statement is needed here to detect if the cancel button if pressed. if so, don't print the document.
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        PrintDocument1.Print()                  'Prints the document
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        'Shows a message box with the version info
        MessageBox.Show("Record Editor V1.1.314", "Version Information")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'This sets up the document for printing
        e.Graphics.DrawString(RichTextBox1.Text, CurrentFont, CurrentColor, 100, 100)
    End Sub

    Private Sub frmPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization for Font Panel
        FontDialog1.ShowColor = True
        'Initialization for the textbox
        RichTextBox1.Text = "Name                   Address     City            State      Phone            Age     Gender  Hourly Wage"
        RichTextBox1.WordWrap = False
        CurrentColor = Brushes.Black 'Sets as the default brush color to avoid a null exception.
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        btnPrint_Click(sender, e) 'Calls the same code form the print button.
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Dislays Information about this application
        MessageBox.Show("Printing Page Designed and coded by Matthew Denholm", "About")
    End Sub

    Private Sub SelectRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectRecordsToolStripMenuItem.Click
        btnRecords_Click(sender, e) 'Calls the same code from the Select Records button.
    End Sub

    Private Sub SelectFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFontToolStripMenuItem.Click
        btnFont_Click(sender, e) 'Calls the same code from the Select Font button.
    End Sub
End Class
