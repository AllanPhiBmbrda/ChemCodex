Imports System.ComponentModel
Imports System.Globalization

Public Class LChemAdd

    Private Sub LChemAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpKimCmb01.Items.Clear()
        LoadDB()
        LoadKimiaCombo()
        GridHeader01()
    End Sub

    Sub LoadKimiaCombo()
        SQL = Nothing
        SQL = SQL & "Select * From chem_title "
        SQL = SQL & "Order by chem_name "
        OpenTbl(GKimCon, GKimTb1, SQL)
        If GKimTb1.RecordCount > 0 Then
            GKimTb1.MoveFirst()
            Do While Not GKimTb1.EOF
                UpKimCmb01.Items.Add(IIf(IsDBNull(GKimTb1("chem_name").Value), "", GKimTb1("chem_name").Value))
                GKimTb1.MoveNext()
            Loop
        End If
    End Sub

    Sub GridHeader01()
        With LCSGrid01
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("col0", "Chemical Name")
            .Columns.Add("col1", "Chemical Date IN")
            .Columns.Add("col2", "Chemical Serial Code")
            .Columns.Add("col3", "Remark")

            .Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(2).Width = 150
            .Columns(3).Width = 200

        End With
    End Sub

    Sub GenerateCode()
        GridHeader01()
        For i = Val(UpKimTbx01.Text) To Val(UpKimTbx02.Text)
            LCSGrid01.Rows.Add(UpKimCmb01.Text, LCSDP01.Text, i.ToString)
            If LCSGrid01.Rows.Count = 1000 Then
                Exit For
            End If
        Next
    End Sub

    Sub SaveChemDateIn()

                SQL = Nothing
                SQL = SQL & "Select * From chem_datein "
                SQL = SQL & "Where chem_name = ('" & UpKimCmb01.Text & "') "
                SQL = SQL & "and chem_date = ('" & LCSDP01.Value.ToString("dd MMM yyyy") & "') "
                OpenTbl(GKimCon, GKimTb2, SQL)
                If Not GKimTb2.RecordCount <> 0 Then
                    GKimTb2.AddNew()
                End If

                GKimTb2("chem_name").Value() = UpKimCmb01.Text
                GKimTb2("chem_date").Value() = LCSDP01.Value.ToString("dd MMM yyyy")
                GKimTb2.Update()
    End Sub

    Sub UploadChemCode()

        For i = 0 To LCSGrid01.Rows.Count - 1

            SQL = Nothing
            SQL = SQL & "Select * From chem_inout "
            SQL = SQL & "Where chem_name = ('" & UpKimCmb01.Text & "') "
            SQL = SQL & "and chem_dateIN = ('" & LCSDP01.Value.ToString("yyyy-MM-dd") & "') "
            SQL = SQL & "and chem_skode = ('" & LCSGrid01(2, i).Value.ToString & "') "
            OpenTbl(GKimCon, GKimTb2, SQL)

            If Not GKimTb2.RecordCount > 0 Then

                GKimTb2.AddNew()
                GKimTb2("chem_name").Value() = LCSGrid01(0, i).Value.ToString
                GKimTb2("chem_dateIN").Value() = LCSDP01.Value.ToString("dd MMM yyyy")
                GKimTb2("chem_skode").Value() = LCSGrid01(2, i).Value.ToString
                GKimTb2("chem_status").Value() = "IN"
                GKimTb2.Update()
                LCSGrid01.Invoke(DirectCast(Sub() LCSGrid01(3, i).Value = "Has Been Uploaded", MethodInvoker))
            Else
                LCSGrid01.Invoke(DirectCast(Sub() LCSGrid01(3, i).Value = "The Data is already EXIST", MethodInvoker))
            End If
        Next
    End Sub

    Private Sub UpKimBtn01_Click(sender As Object, e As EventArgs) Handles UpKimBtn01.Click
        Try
            Select Case UpKimCmb01.Text
                Case Nothing, ""
                Case Else
                    GenerateCode()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub UpKimBtn02_Click(sender As Object, e As EventArgs) Handles UpKimBtn02.Click
        Try
               Select Nothing
                Case UpKimCmb01.Text, UpKimTbx02.Text, UpKimTbx01.Text
                    MessageBox.Show("Please Provide the Chemical Name and Serial Code")
                Case Else
                    GroupBox1.Enabled = False
                    SaveChemDateIn()
                    ' UploadChemCode()
                    OnClickTheWorker()
                    GroupBox1.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub UpKimTbx01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimTbx01.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UpKimTbx01_TextChanged(sender As Object, e As EventArgs) Handles UpKimTbx01.TextChanged
        UpKimTbx02.Text = UpKimTbx01.Text
    End Sub

#Region "BGW Mode"
    Private BGWorkMode() As BackgroundWorker
    Private i = 0
    Sub OnClickTheWorker()

        i += 1
        ReDim BGWorkMode(i)
        BGWorkMode(i) = New BackgroundWorker
        BGWorkMode(i).WorkerReportsProgress = True
        BGWorkMode(i).WorkerSupportsCancellation = True
        AddHandler BGWorkMode(i).DoWork, AddressOf WorkerDoWork
        AddHandler BGWorkMode(i).RunWorkerCompleted, AddressOf WorkerCompleted
        BGWorkMode(i).RunWorkerAsync()

    End Sub
    Private Sub WorkerDoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        UploadChemCode()
    End Sub

    Private Sub WorkerProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)

    End Sub

    Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        MessageBox.Show("Upload Done", Me.Text)
    End Sub

#End Region

    Private Sub UpKimCmb01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimCmb01.KeyPress
        e.Handled = True
    End Sub

    Private Sub UpKimTbx02_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimTbx02.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UpKimTbx03_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimTbx03.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If

        Select Case Nothing
            Case UpKimTbx01.Text, UpKimTbx02.Text
                e.Handled = True
        End Select

    End Sub

End Class