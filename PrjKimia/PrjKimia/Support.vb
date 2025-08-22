Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Globalization
Imports System.Security.Cryptography

Module Support

    Public GKimCon As New ADODB.Connection
    Public GKimTb1 As New ADODB.Recordset ' Load Chemical
    Public GKimTb2 As New ADODB.Recordset ' 
    Public GKimTb3 As New ADODB.Recordset ' Loading Data

    Public PathStr As String
    Public SQL As String

    Public Const InValid2 As String = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm ~`'!@#$%^&*()_+|=\/,:;"

    Public Structure PurUserData
        Public PerUID As String
        Public PerUPK As String
        Public PerRN As String
        Public PerPR As String
        Sub ClearMode()
            PerUID = Nothing
            PerUPK = Nothing
            PerRN = Nothing
            PerPR = Nothing
        End Sub
    End Structure

    Public PurUser As PurUserData
    Public PurConnect As ReadConnect
    Public OptionConnect As OptConnect
    Public Structure ReadConnect
        Public GetLink As String
        Public TextConnect As String
        Public trappath As String
        Public TapConnect As String
        Sub ClearMode()
            GetLink = Nothing
            TextConnect = Nothing
            trappath = Nothing
            TapConnect = Nothing
        End Sub
    End Structure
    Public Structure OptConnect
        Public GetLink As String
        Public TextConnect As String
        Public trappath As String
        Public TapConnect As String
        Sub ClearMode()
            GetLink = Nothing
            TextConnect = Nothing
            trappath = Nothing
            TapConnect = Nothing
        End Sub
    End Structure

    Public Sub CreateDeConMe()
        PurConnect.trappath = Application.StartupPath + "\DefaultConnection\ConnectionString.txt"
        If Not File.Exists(PurConnect.trappath) Then
            ' Create a file to write to. 
            Using sw As StreamWriter = File.CreateText(PurConnect.trappath)
                sw.WriteLine(Encrypt("DRIVER={MySQL ODBC 5.3 ANSI Driver};" _
                  & "SERVER=localhost;" _
                  & "Port=3306;"))
            End Using
        End If
    End Sub

    Public Sub LoadDeConMe()
        PurConnect.GetLink = Application.StartupPath + "\DefaultConnection\ConnectionString.txt"
        If System.IO.File.Exists(PurConnect.GetLink) = True Then
            Dim objReader As New System.IO.StreamReader(PurConnect.GetLink)
            Do While objReader.Peek() <> -1
                PurConnect.TextConnect = objReader.ReadLine()
                PurConnect.TapConnect = Decrypt(PurConnect.TextConnect)
            Loop
            objReader.Close()
            objReader = Nothing
        End If
    End Sub
    Sub OpenDB(ByVal DBcon As ADODB.Connection, ByVal DBName As String, ByVal DBPass As String)
        PathStr = PurConnect.TapConnect _
                  & "DATABASE=" + DBName + ";" _
                  & "UID=root; PWD=" + DBPass _
                  & "; OPTION = 3"
        If DBcon.State = 1 Then DBcon.Close()
        DBcon.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        DBcon.ConnectionString = PathStr
        DBcon.Open()

        'PathStr = "DRIVER={MySQL ODBC 5.3 ANSI Driver};" _
        '     & "SERVER=" + IPMain + ";" _
        '     & "Port=" + PortMain + ";" _
        '     & "DATABASE=" + DBName + ";" _
        '     & "DATABASE=" + DBName + ";" _
        '     & "UID=root; PWD=" + DBPass _
        '     & "; OPTION = 3"
        'If DBcon.State = 1 Then DBcon.Close()
        'DBcon.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'DBcon.ConnectionString = PathStr
        'DBcon.Open()

    End Sub
    Sub OpenTbl(ByVal DB As ADODB.Connection, ByVal Tbl As ADODB.Recordset, ByVal SQL As String)
        If Tbl.State = 1 Then Tbl.Close()
        Tbl.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    End Sub
    Public Sub LoadDB()
        Try
            OpenDB(GKimCon, "gudangkemia", "ug2015") ' my Adodb connection ,  my Database Name , My User Password to my Database  [All of this is Part of Purchasing Entity]
        Catch ex As Exception
            'Dim DeleteOldConnect As Integer = MessageBox.Show(ex.Message + vbNewLine + "Do you want to delete your Old Server Connection?", "Error On Connection", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'If DeleteOldConnect = DialogResult.OK Then
            '    DeleteFileConnect()
            '    CreateDeConMe()
            'End If
            MessageBox.Show("Cannot Connect to Server")
        End Try
    End Sub
    Public Sub DeleteFileConnect()
        PurConnect.trappath = Application.StartupPath + "\DefaultConnection\ConnectionString.txt"
        If File.Exists(PurConnect.trappath) Then
            File.Delete(PurConnect.trappath)
        End If
    End Sub

    Sub LoadInitialization()
        If (Not System.IO.Directory.Exists(Application.StartupPath + "\DefaultConnection")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\DefaultConnection")
        End If
    End Sub

#Region "KEYtoKEY"
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "C0n+r@d!t!0nC+RL2o!6"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "C0n+r@d!t!0nC+RL2o!6"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

#End Region
End Module
