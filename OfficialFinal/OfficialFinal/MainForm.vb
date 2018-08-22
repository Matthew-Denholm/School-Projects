Imports System.IO               'Must use this to use files
Public Class frmMain

    'Final project
    'A form which displays employee information and allows user to edit, create, and or save the data
    'Addisyn Randolph
    '11/27/16

    Dim intFileName As Integer
    Dim strFileName As String

    'Dim lstRecords As List(Of String)
    'Dim lstDropDownItem As List(Of ToolStripDropDown)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Sets date and time. Updated by the second
        lblDT.Text = DateTime.Now

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Enable timer
        Timer1.Enabled = True

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays message box with info about project
        MessageBox.Show("CEO Personal Information Creator and Editor" & vbCr & "Designed and Programmed by: Matthew Denholm & Addie Randolph" & vbCr & vbCr & "Version 1.1.134", "About this Program")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Shows edit form
        'Must have a file displayed already
        If lblName.Text <> String.Empty Then
            frmEdit.Show()
        Else
            MessageBox.Show("Select a record from 'Records' tab then click edit")
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Shows new form
        frmNew.Show()

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPreview.Show()

    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        'Opens the open file form
        frmOpenFile.Show()

    End Sub

    Private Sub CreateNewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewRecordToolStripMenuItem.Click
        'Creates new record
        btnCreate_Click(sender, e)
    End Sub

    Private Sub EditCurrentRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCurrentRecordToolStripMenuItem.Click
        'Edits current record
        btnEdit_Click(sender, e)
    End Sub

    Private Sub PrintRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRecordToolStripMenuItem.Click
        'Opens the print form
        btnPrint_Click(sender, e)
    End Sub

    'Method to clear labels
    'Sub ClearLabels()
    '    lblName.Text = String.Empty
    '    lblAddress.Text = String.Empty
    '    lblCity.Text = String.Empty
    '    lblState.Text = String.Empty
    '    lblAge.Text = String.Empty
    '    lblGender.Text = String.Empty
    '    lblWage.Text = String.Empty
    '    lblPhone.Text = String.Empty
    '    lblGross.Text = String.Empty
    '    lblNet.Text = String.Empty
    '    lblTax.Text = String.Empty
    '    lblFileName.Text = String.Empty


    'End Sub
End Class