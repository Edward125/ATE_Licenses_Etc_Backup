Imports System.IO
Imports System.Reflection


Public Class frmMain


    Const AS2ASN As String = "MY49430174"
    Const AS2BSN As String = "MY49430173"
    Const AS3ASN As String = "MY49430202"
    Const AS3BSN As String = "MY49430198"
    Const AS4ASN As String = "MY49430215"
    Const AS4BSN As String = "MY49430214"
    Const AS5ASN As String = "SG44420142"
    Const AS5BSN As String = "SG44420130"
    Const AS6ASN As String = "SG44420114"
    Const AS6BSN As String = "SG01040410"
    Const AS7ASN As String = "MY47120078"
    Const AS7BSN As String = "MY47120086"
    Const AS8ASN As String = "MY47120229"
    Const AS8BSN As String = "MY47120230"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub combLine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combLine.SelectedIndexChanged

        Select Case combLine.SelectedIndex

            Case 0 'AS2A
                btnConfig.Text = combLine.SelectedItem & "-" & AS2ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS2ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS2ASN & "-LIC"

            Case 1 'AS2B
                btnConfig.Text = combLine.SelectedItem & "-" & AS2BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS2BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS2BSN & "-LIC"

            Case 2 'AS3A
                btnConfig.Text = combLine.SelectedItem & "-" & AS3ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS3ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS3ASN & "-LIC"
            Case 3 'AS3B
                btnConfig.Text = combLine.SelectedItem & "-" & AS3BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS3BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS3BSN & "-LIC"

            Case 4 'AS4A
                btnConfig.Text = combLine.SelectedItem & "-" & AS4ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS4ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS4ASN & "-LIC"

            Case 5 'AS4B
                btnConfig.Text = combLine.SelectedItem & "-" & AS4BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS4BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS4BSN & "-LIC"

            Case 6 'AS5A
                btnConfig.Text = combLine.SelectedItem & "-" & AS5ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS5ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS5ASN & "-LIC"

            Case 7 'AS5B
                btnConfig.Text = combLine.SelectedItem & "-" & AS5BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS5BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS5BSN & "-LIC"


            Case 8 'AS6A
                btnConfig.Text = combLine.SelectedItem & "-" & AS6ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS6ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS6ASN & "-LIC"

            Case 9 'AS6B
                btnConfig.Text = combLine.SelectedItem & "-" & AS6BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS6BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS6BSN & "-LIC"

            Case 10 'AS7A
                btnConfig.Text = combLine.SelectedItem & "-" & AS7ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS7ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS7ASN & "-LIC"

            Case 11 'AS7B
                btnConfig.Text = combLine.SelectedItem & "-" & AS7BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS7BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS7BSN & "-LIC"

            Case 12 'AS8A
                btnConfig.Text = combLine.SelectedItem & "-" & AS8ASN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS8ASN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS8ASN & "-LIC"

            Case 13 'AS8B
                btnConfig.Text = combLine.SelectedItem & "-" & AS8BSN & "-Config"
                btnEtc.Text = combLine.SelectedItem & "-" & AS8BSN & "-ETC"
                btnLIC.Text = combLine.SelectedItem & "-" & AS8BSN & "-LIC"


        End Select


    End Sub




    Private Sub WriteResourceFile(ByVal FileName As String)
        ' Dim FileName As String = fileNames

        Dim bufint As Integer
        Dim bufbytes(0) As Byte
        Dim fs As FileStream

        Try
            Dim Asm As [Assembly] = [Assembly].GetExecutingAssembly()
            Dim strm As Stream = Asm.GetManifestResourceStream( _
                         Asm.GetName().Name + "." + FileName)
            fs = File.OpenWrite(FileName)

            Do
                bufint = strm.ReadByte()
                If bufint = -1 Then Exit Do
                bufbytes(0) = Convert.ToByte(bufint)
                fs.Write(bufbytes, 0, bufbytes.Length)
            Loop

            fs.Close()
            fs.Dispose()
            strm.Close()

            File.SetAttributes(Application.StartupPath & "\" & FileName, FileAttributes.Hidden)
            '================
            Dim folderExists As Boolean
            folderExists = My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\ATE Licenses&ETC Backup")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\ATE Licenses&ETC Backup")
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & FileName, Application.StartupPath & "\ATE Licenses&ETC Backup\" & FileName)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\" & FileName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo(Application.StartupPath & "\ATE Licenses&ETC Backup\" & FileName)
            fileData.Attributes = FileAttributes.Normal
            '===========================
            MsgBox("Export " & FileName & " is OK")

        Catch ex As System.IO.IOException
            MsgBox("Exporting File Fail! " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        Catch ex As Exception
            MsgBox("Exporting File Fail! " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub btnLIC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLIC.Click
        Select Case combLine.SelectedIndex
            Case 0 'AS2A
                WriteResourceFile("AS2A-MY49430174-2011-lic.rar")
            Case 1 'AS2B
                WriteResourceFile("AS2B-MY49430173-2011-lic.rar")
            Case 2 'AS3A
                WriteResourceFile("AS3A-MY49430202-2012-lic.rar")
            Case 3 'AS3B
                WriteResourceFile("AS3B-MY49430198-2012-lic.rar")
            Case 4 'AS4A
                WriteResourceFile("AS4A-MY49430215-2012-lic.rar")
            Case 5 'AS4B
                WriteResourceFile("AS4B-MY49430214-2012-lic.rar")
            Case 6 'AS5A
                WriteResourceFile("AS5A-SG44420142-2005-lic.rar")
            Case 7 'AS5B
                WriteResourceFile("AS5B-SG44420130-2005-lic.rar")
            Case 8 'AS6A
                WriteResourceFile("AS6A-SG44420114-2005-lic.rar")
            Case 9 'AS6B
                WriteResourceFile("AS6B-SG01040410-2002-lic.rar")
            Case 10 'AS7A
                WriteResourceFile("AS7A-MY47120078-2008-lic.rar")
            Case 11 'AS7B
                WriteResourceFile("AS7B-MY47120086-2008-lic.rar")
            Case 12 'AS8A
                WriteResourceFile("AS8A-MY47120229-2010-lic.rar")
            Case 13 'AS8B
                WriteResourceFile("AS8B-MY47120230-2010-lic.rar")
        End Select

    End Sub

    Private Sub btnEtc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEtc.Click
       Select Case combLine.SelectedIndex
            Case 0 'AS2A
                WriteResourceFile("AS2A-MY49430174-2011-etc.rar")
            Case 1 'AS2B
                WriteResourceFile("AS2B-MY49430173-2011-etc.rar")
            Case 2 'AS3A
                WriteResourceFile("AS3A-MY49430202-2012-etc.rar")
            Case 3 'AS3B
                WriteResourceFile("AS3B-MY49430198-2012-etc.rar")
            Case 4 'AS4A
                WriteResourceFile("AS4A-MY49430215-2012-etc.rar")
            Case 5 'AS4B
                WriteResourceFile("AS4B-MY49430214-2012-etc.rar")
            Case 6 'AS5A
                WriteResourceFile("AS5A-SG44420142-2005-etc.rar")
            Case 7 'AS5B
                WriteResourceFile("AS5B-SG44420130-2005-etc.rar")
            Case 8 'AS6A
                WriteResourceFile("AS6A-SG44420114-2005-etc.rar")
            Case 9 'AS6B
                WriteResourceFile("AS6B-SG01040410-2002-etc.rar")
            Case 10 'AS7A
                WriteResourceFile("AS7A-MY47120078-2008-etc.rar")
            Case 11 'AS7B
                WriteResourceFile("AS7B-MY47120086-2008-etc.rar")
            Case 12 'AS8A
                WriteResourceFile("AS8A-MY47120229-2010-etc.rar")
            Case 13 'AS8B
                WriteResourceFile("AS8B-MY47120230-2010-etc.rar")
        End Select
    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        Select Case combLine.SelectedIndex
            Case 0 'AS2A
                WriteResourceFile("AS2A-MY49430174-2011-config.rar")
            Case 1 'AS2B
                WriteResourceFile("AS2B-MY49430173-2011-config.rar")
            Case 2 'AS3A
                WriteResourceFile("AS3A-MY49430202-2012-config.rar")
            Case 3 'AS3B
                WriteResourceFile("AS3B-MY49430198-2012-config.rar")
            Case 4 'AS4A
                WriteResourceFile("AS4A-MY49430215-2012-config.rar")
            Case 5 'AS4B
                WriteResourceFile("AS4B-MY49430214-2012-config.rar")
            Case 6 'AS5A
                WriteResourceFile("AS5A-SG44420142-2005-config.rar")
            Case 7 'AS5B
                WriteResourceFile("AS5B-SG44420130-2005-config.rar")
            Case 8 'AS6A
                WriteResourceFile("AS6A-SG44420114-2005-config.rar")
            Case 9 'AS6B
                WriteResourceFile("AS6B-SG01040410-2002-config.rar")
            Case 10 'AS7A
                WriteResourceFile("AS7A-MY47120078-2008-config.rar")
            Case 11 'AS7B
                WriteResourceFile("AS7B-MY47120086-2008-config.rar")
            Case 12 'AS8A
                WriteResourceFile("AS8A-MY47120229-2010-config.rar")
            Case 13 'AS8B
                WriteResourceFile("AS8B-MY47120230-2010-config.rar")
        End Select
    End Sub
End Class
