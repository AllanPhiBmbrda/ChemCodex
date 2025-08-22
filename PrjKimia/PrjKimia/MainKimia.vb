Public Class MainKimia

    Private Sub ListOfChemicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfChemicalToolStripMenuItem.Click
        LChem.MdiParent = Me
        LChem.Show()
    End Sub

    Private Sub ListOfChemicalInSerialCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfChemicalInSerialCodeToolStripMenuItem.Click
        LChemSerial.MdiParent = Me
        LChemSerial.Show()
    End Sub

    Private Sub MainKimia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInitialization()
        CreateDeConMe()
        LoadDeConMe()
        LoadDB()
    End Sub

    Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadToolStripMenuItem.Click
        LChemAdd.MdiParent = Me
        LChemAdd.Show()

    End Sub

    Private Sub ToUseChemicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToUseChemicalToolStripMenuItem.Click
        LChemUse.MdiParent = Me
        LChemUse.Show()

    End Sub
End Class
