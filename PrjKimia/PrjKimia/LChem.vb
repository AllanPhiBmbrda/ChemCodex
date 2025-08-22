Public Class LChem

    Private Sub LChem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDB()
        LoadKemia()
    End Sub


    Sub LoadGridHeader()

        With KimiaGrid01
            .Rows.Clear()
            .Columns.Clear()

            .Columns.Add("col0", "Chemical Name")
            .Columns.Add("col1", "Chemical Weight")
            .Columns(0).Width = 350
            .Columns(1).Width = 200
        End With
    End Sub

    Sub LoadKemia()
        LoadGridHeader()

        SQL = Nothing
        SQL = SQL & "Select * From chem_title "
        OpenTbl(GKimCon, GKimTb1, SQL)
        If GKimTb1.RecordCount <> 0 Then
            GKimTb1.MoveFirst()
            Do While Not GKimTb1.EOF
                KimiaGrid01.Rows.Add(IIf(IsDBNull(GKimTb1("chem_name").Value), "", GKimTb1("chem_name").Value), IIf(IsDBNull(GKimTb1("chem_weight").Value), "", GKimTb1("chem_weight").Value))
                GKimTb1.MoveNext()
            Loop
        End If

    End Sub
End Class