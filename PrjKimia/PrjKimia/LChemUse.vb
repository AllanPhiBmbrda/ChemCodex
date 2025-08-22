Imports System.ComponentModel
Imports System.Globalization



Public Class LChemUse

    Private Sub LChemUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridGHeaderMode()
        UseKimCmb01.Items.Clear()
        LoadDB()
        LoadKimiaCombo()
    End Sub
    Sub LoadKimiaCombo()
        SQL = Nothing
        SQL = SQL & "Select * From chem_title "
        SQL = SQL & "Order by chem_name "
        OpenTbl(GKimCon, GKimTb1, SQL)
        If GKimTb1.RecordCount > 0 Then
            GKimTb1.MoveFirst()
            Do While Not GKimTb1.EOF
                UseKimCmb01.Items.Add(IIf(IsDBNull(GKimTb1("chem_name").Value), "", GKimTb1("chem_name").Value))
                GKimTb1.MoveNext()
            Loop
        End If
    End Sub

    Private Sub UseKimCmb01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UseKimCmb01.KeyPress
        e.Handled = True
    End Sub

    Private Sub UseKimTbx01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UseKimTbx01.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UseKimTbx02_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UseKimTbx02.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Sub GridGHeaderMode()
        With UseGrid01
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("col0", "Chemical Name")
            .Columns.Add("col1", "Chemical Code")
            .Columns.Add("col2", "Chemical Date IN")
            .Columns.Add("col3", "Remark")

            .Columns(0).Width = "200"
            .Columns(1).Width = "150"
            .Columns(2).Width = "150"
            .Columns(3).Width = "500"

        End With

    End Sub

    Private Sub UseKimTbx01_TextChanged(sender As Object, e As EventArgs) Handles UseKimTbx01.TextChanged
        UseKimTbx02.Text = UseKimTbx01.Text
    End Sub

    Private Sub UseKimBtn01_Click(sender As Object, e As EventArgs) Handles UseKimBtn01.Click
        Try
            Select Case UseKimCmb01.Text
                Case Nothing, ""
                Case Else
                    GenerateCode()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub GenerateCode()
        GridGHeaderMode()
        For i = Val(UseKimTbx01.Text) To Val(UseKimTbx02.Text)
            UseGrid01.Rows.Add(UseKimCmb01.Text, i.ToString, LCSDP01.Text)
            If UseGrid01.Rows.Count = 1000 Then
                Exit For
            End If
        Next
    End Sub


    Sub OUTChemical()
        For i = 0 To UseGrid01.Rows.Count - 1

            SQL = Nothing
            SQL = SQL & "Select * From chem_inout "
            SQL = SQL & "Where chem_name = ('" & UseKimCmb01.Text & "') "
            SQL = SQL & "and chem_dateIN = ('" & LCSDP01.Value.ToString("yyyy-MM-dd") & "') "
            SQL = SQL & "and chem_skode = ('" & UseGrid01(1, i).Value.ToString & "') "
            SQL = SQL & "and chem_status = ('" & "IN" & "') "
            OpenTbl(GKimCon, GKimTb2, SQL)
            If GKimTb2.RecordCount > 0 Then
                GKimTb2("chem_status").Value() = "OUT"
                GKimTb2("chem_dateOUT").Value() = Today.ToString("yyyy MMM dd")
                GKimTb2.Update()
                UseGrid01.Invoke(DirectCast(Sub() UseGrid01(3, i).Value = "Serial Code has been Used", MethodInvoker))
            Else
                UseGrid01.Invoke(DirectCast(Sub() UseGrid01(3, i).Value = "The Serial Code is Already BEEN USED / Is not Registered Yet", MethodInvoker))
            End If
        Next
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
        OUTChemical()
    End Sub

    Private Sub WorkerProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)

    End Sub

    Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        MessageBox.Show("Upload Done", Me.Text)
    End Sub

#End Region

    Private Sub UseKimBtn02_Click(sender As Object, e As EventArgs) Handles UseKimBtn02.Click
        OnClickTheWorker()
    End Sub

 
End Class