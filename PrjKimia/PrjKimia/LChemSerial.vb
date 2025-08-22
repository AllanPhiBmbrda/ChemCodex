Public Class LChemSerial

    Private Sub LCSCmb01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LCSCmb01.KeyPress
        e.Handled = True
    End Sub

    Private Sub LChemSerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDB()
        UpKimCmb01.Items.Clear()
        LoadKimiaCombo()
    End Sub

    Sub LoadChemicalData()

        LoadChemBerat()

        GridHeaderMode()

        Select Case Nothing

            Case UpKimTbx01.Text, UpKimTbx02.Text

                SQL = Nothing
                SQL = SQL & "Select * From chem_inout "
                SQL = SQL & "Where chem_name = ('" & UpKimCmb01.Text & "') "
                SQL = SQL & "And chem_dateIN = ('" & LCSDP01.Value.ToString("yyyy-MM-dd") & "') "

                Select Case LCSCmb01.Text
                    Case "IN", "OUT"
                        SQL = SQL & "And chem_status = ('" & LCSCmb01.Text & "') "
                End Select

                OpenTbl(GKimCon, GKimTb1, SQL)
                If GKimTb1.RecordCount > 0 Then
                    GKimTb1.MoveFirst()
                    Do While Not GKimTb1.EOF

                        Dim DateGetIn As Date = IIf(IsDBNull(GKimTb1("chem_dateIN").Value), Nothing, GKimTb1("chem_dateIN").Value)
                        Dim DateGetOut As Date = IIf(IsDBNull(GKimTb1("chem_dateOUT").Value), Nothing, GKimTb1("chem_dateOUT").Value)

                        LCSGrid01.Rows.Add(IIf(IsDBNull(GKimTb1("chem_name").Value), "", GKimTb1("chem_name").Value), _
                                        IIf(IsDBNull(GKimTb1("chem_skode").Value), "", GKimTb1("chem_skode").Value), _
                                        IIf(DateGetIn = Nothing, Nothing, DateGetIn.ToString("dd MMM yyyy")), _
                                        IIf(DateGetOut = Nothing, Nothing, DateGetOut.ToString("dd MMM yyyy")), _
                                        IIf(IsDBNull(GKimTb1("chem_status").Value), "", GKimTb1("chem_status").Value))
                        GKimTb1.MoveNext()
                    Loop

                    Label5.Text = GKimTb1.RecordCount.ToString
                    Label7.Text = (GKimTb1.RecordCount * ChemWeight).ToString & " Kg"

                End If

            Case Else

                For i = Val(UpKimTbx01.Text) To Val(UpKimTbx02.Text)

                    SQL = Nothing
                    SQL = SQL & "Select * From chem_inout "
                    SQL = SQL & "Where chem_name = ('" & UpKimCmb01.Text & "') "
                    SQL = SQL & "And chem_dateIN = ('" & LCSDP01.Value.ToString("yyyy-MM-dd") & "') "
                    SQL = SQL & "And chem_skode = ('" & i.ToString & "') "

                    Select Case LCSCmb01.Text
                        Case "IN", "OUT"
                            SQL = SQL & "And chem_status = ('" & LCSCmb01.Text & "') "
                    End Select

                    OpenTbl(GKimCon, GKimTb1, SQL)

                    If GKimTb1.RecordCount > 0 Then

                        Dim DateGetIn As Date = IIf(IsDBNull(GKimTb1("chem_dateIN").Value), Nothing, GKimTb1("chem_dateIN").Value)
                        Dim DateGetOut As Date = IIf(IsDBNull(GKimTb1("chem_dateOUT").Value), Nothing, GKimTb1("chem_dateOUT").Value)

                        LCSGrid01.Rows.Add(IIf(IsDBNull(GKimTb1("chem_name").Value), "", GKimTb1("chem_name").Value), _
                                        IIf(IsDBNull(GKimTb1("chem_skode").Value), "", GKimTb1("chem_skode").Value), _
                                        IIf(DateGetIn = Nothing, Nothing, DateGetIn.ToString("dd MMM yyyy")), _
                                        IIf(DateGetOut = Nothing, Nothing, DateGetOut.ToString("dd MMM yyyy")), _
                                        IIf(IsDBNull(GKimTb1("chem_status").Value), "", GKimTb1("chem_status").Value))

                        Label5.Text = GKimTb1.RecordCount.ToString
                        Label7.Text = (GKimTb1.RecordCount * ChemWeight).ToString & " Kg"
                    End If

                Next
        End Select

    End Sub

    Sub GridHeaderMode()
        With LCSGrid01
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("col0", "Chemical Name")
            .Columns.Add("col1", "Chemical Code")
            .Columns.Add("col2", "Date IN")
            .Columns.Add("col3", "Date OUT")
            .Columns.Add("col4", "Status")

            .Columns(0).Width = "200"
            .Columns(1).Width = "150"
            .Columns(2).Width = "150"
            .Columns(3).Width = "150"
            .Columns(4).Width = "150"

        End With
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

    Dim ChemWeight As String

    Sub LoadChemBerat()
        ChemWeight = Nothing
        SQL = Nothing
        SQL = SQL & "Select * From chem_title "
        SQL = SQL & "Where chem_name = ('" & UpKimCmb01.Text & "') "
        OpenTbl(GKimCon, GKimTb1, SQL)
        If GKimTb1.RecordCount > 0 Then
            ChemWeight = IIf(IsDBNull(GKimTb1("chem_weight").Value), "", GKimTb1("chem_weight").Value)
        End If
    End Sub
    Private Sub LCSBtn01_Click(sender As Object, e As EventArgs) Handles LCSBtn01.Click
        Select Case UpKimTbx02.Text
            Case Is < UpKimTbx01.Text
                Exit Sub
        End Select
        Label5.Text = "##"
        Label7.Text = "##"
        LoadChemicalData()
    End Sub

    Private Sub UpKimCmb01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimCmb01.KeyPress
        e.Handled = True
    End Sub

    Private Sub UpKimTbx01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimTbx01.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UpKimTbx02_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UpKimTbx02.KeyPress
        If Not InValid2.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub UpKimTbx01_TextChanged(sender As Object, e As EventArgs) Handles UpKimTbx01.TextChanged
        UpKimTbx02.Text = UpKimTbx01.Text
    End Sub

End Class