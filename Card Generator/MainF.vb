Imports System.IO

Public Class MainF

    Dim DBConn As DBConnection
    Dim Item As ListViewItem
    Dim ExitCommand As Boolean

    Private Sub CGGPassB_Click(sender As Object, e As EventArgs) Handles CGGPassB.Click
        If CGPassNum.Checked = False And CGPassUpCase.Checked = False And CGPassLowCase.Checked = False And CGPassSymCase.Checked = False Then MsgBox("Not Selected 'Include'", MsgBoxStyle.Information) : Exit Sub
        If Not IsNumeric(CGPassLen.Text) Then MsgBox("'Password Length' not numeric", MsgBoxStyle.Information) : Exit Sub
        If Not IsNumeric(CGCOGen.Text) Then MsgBox("'Count Of Generate' not numeric", MsgBoxStyle.Information) : Exit Sub
        Dim TMP1 As Integer = Int(CGUserStart.Text)
        CGPassList.Items.Clear()
        Dim TMP As String
        For J As Integer = 1 To Int(CGCOGen.Text)
            TMP = ""
            If CGPassIsUser.Checked Then
                TMP = CGUser.Text & TMP1
            Else
                For I As Integer = 1 To Int(CGPassLen.Text)
                    TMP += GetChar(CGPassNum.Checked, CGPassUpCase.Checked, CGPassLowCase.Checked, CGPassSymCase.Checked)
                Next
            End If
            CGPassList.Items.Add(TMP)
            TMP1 += 1
        Next
    End Sub

    Private Sub MainF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = ExitCommand
    End Sub

    Private Sub MainF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CGNotBelong.Items.Clear()
        Try
            DBConn = New DBConnection
            DBConn.ConnectMe("SELECT TAC_ID FROM TAC_GRP GROUP BY TAC_ID;")
            Try
                DBConn.OLEComm.Connection = DBConn.OLEConn
                Dim d As OleDb.OleDbDataReader = DBConn.OLEComm.ExecuteReader()
                Do While d.Read
                    CGNotBelong.Items.Add(d("TAC_ID".ToString))
                Loop
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    MsgBox("Problem with connect to database", MsgBoxStyle.Critical, "NTTac Database")
                End Try
            Catch err As System.Exception
                MsgBox("Problem with connect to database", MsgBoxStyle.Critical, "NTTac Database")
            End Try
        Catch err As System.Exception
            MsgBox("Problem with connect to database", MsgBoxStyle.Critical, "NTTac Database")
        End Try
        ExitCommand = False
    End Sub

    Private Sub CGBTB_Click(sender As Object, e As EventArgs) Handles CGBTB.Click
        If CGNotBelong.SelectedItems.Count <> 0 Then
            CGBelong.Items.Add(CGNotBelong.SelectedItem)
            CGNotBelong.Items.RemoveAt(CGNotBelong.SelectedIndex)
        End If
    End Sub

    Private Sub CGNBTB_Click(sender As Object, e As EventArgs) Handles CGNBTB.Click
        If CGBelong.SelectedItems.Count <> 0 Then
            CGNotBelong.Items.Add(CGBelong.SelectedItem)
            CGBelong.Items.RemoveAt(CGBelong.SelectedIndex)
        End If
    End Sub

    Private Sub CGExpireDate_GotFocus(sender As Object, e As EventArgs) Handles CGExpireDate.GotFocus
        If CGExpireDate.Text = "(group)" Then CGExpireDate.Text = ""
    End Sub

    Private Sub CGExpireDate_LostFocus(sender As Object, e As EventArgs) Handles CGExpireDate.LostFocus
        If CGExpireDate.Text = "" Then CGExpireDate.Text = "(group)"
    End Sub

    Private Sub CGActiveDate_GotFocus(sender As Object, e As EventArgs) Handles CGActiveDate.GotFocus
        If CGActiveDate.Text = "(group)" Then CGActiveDate.Text = ""
    End Sub

    Private Sub CGActiveDate_LostFocus(sender As Object, e As EventArgs) Handles CGActiveDate.LostFocus
        If CGActiveDate.Text = "" Then CGActiveDate.Text = "(group)"
    End Sub

    Private Sub CGMaxLogin_GotFocus(sender As Object, e As EventArgs) Handles CGMaxLogin.GotFocus
        If CGMaxLogin.Text = "(group)" Then CGMaxLogin.Text = ""
    End Sub

    Private Sub CGMaxLogin_LostFocus(sender As Object, e As EventArgs) Handles CGMaxLogin.LostFocus
        If CGMaxLogin.Text = "" Then CGMaxLogin.Text = "(group)"
    End Sub

    Private Sub CGPrivilege_GotFocus(sender As Object, e As EventArgs) Handles CGPrivilege.GotFocus
        If CGPrivilege.Text = "(group)" Then CGPrivilege.Text = ""
    End Sub

    Private Sub CGPrivilege_LostFocus(sender As Object, e As EventArgs) Handles CGPrivilege.LostFocus
        If CGPrivilege.Text = "" Then CGPrivilege.Text = "(group)"
    End Sub

    Private Sub CGComment_GotFocus(sender As Object, e As EventArgs) Handles CGComment.GotFocus
        If CGComment.Text = "(group)" Then CGComment.Text = ""
    End Sub

    Private Sub CGComment_LostFocus(sender As Object, e As EventArgs) Handles CGComment.LostFocus
        If CGComment.Text = "" Then CGComment.Text = "(group)"
    End Sub

    Private Sub CGGenerateB_Click(sender As Object, e As EventArgs) Handles CGGenerateB.Click
        CGGenerateB.Enabled = False
        ExitCommand = True
        If CGUser.Text = "" Then MsgBox("Username is empty", MsgBoxStyle.Information) : Exit Sub
        If Not IsNumeric(CGUserStart.Text) Then MsgBox("'Username Start' not numeric", MsgBoxStyle.Information) : Exit Sub
        If CGPassList.Items.Count = 0 Then MsgBox("Passord List is empty", MsgBoxStyle.Information) : Exit Sub
        If CGBelong.Items.Count = 0 Then MsgBox("Belong List is empty", MsgBoxStyle.Information) : Exit Sub
        Dim TMP As Integer = Int(CGUserStart.Text)
        Dim GetErr As Boolean
        Dim TMP1 As String
        UserGenList.Items.Clear()
        CGAccGen.Text = ""
        For I As Integer = 0 To CGPassList.Items.Count - 1
            GetErr = False
            Try
                DBConn = New DBConnection
                DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]Passwd', '" & CGPassList.Items.Item(I) & "');")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            Catch err As System.Exception
                GetErr = True : GoTo Get_Error
            End Try
            If CGExpireDate.Text <> "(group)" Then
                Try
                    DBConn = New DBConnection
                    DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]Expires', '" & CGExpireDate.Text & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            End If
            If CGActiveDate.Text <> "(group)" Then
                Try
                    DBConn = New DBConnection
                    DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]EffectiveFrom', '" & CGActiveDate.Text & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            End If
            If CGMaxLogin.Text <> "(group)" Then
                Try
                    DBConn = New DBConnection
                    DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]MaxLogins', '" & CGMaxLogin.Text & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            End If
            If CGPrivilege.Text <> "(group)" Then
                Try
                    DBConn = New DBConnection
                    DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]Privilege', '" & CGPrivilege.Text & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            End If
            If CGComment.Text <> "(group)" Then
                Try
                    DBConn = New DBConnection
                    DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]Comment', '" & CGComment.Text & "');")
                    Try
                        DBConn.OLEComm.Connection = DBConn.OLEConn
                        DBConn.OLEComm.ExecuteNonQuery()
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                    Try
                        DBConn.OLEConn.Close()
                    Catch err As System.Exception
                        GetErr = True : GoTo Get_Error
                    End Try
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            End If
            TMP1 = ""
            For J As Integer = 0 To CGBelong.Items.Count - 1
                TMP1 += CGBelong.Items.Item(J)
                If J <> (CGBelong.Items.Count - 1) Then TMP1 += ","
            Next
            Try
                DBConn = New DBConnection
                DBConn.ConnectMe("Insert Into TAC_USR (TAC_ID,TAC_Attr,TAC_Val) Values ('" & CGUser.Text & TMP & "', '[Global]Groups', '" & TMP1 & "');")
                Try
                    DBConn.OLEComm.Connection = DBConn.OLEConn
                    DBConn.OLEComm.ExecuteNonQuery()
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
                Try
                    DBConn.OLEConn.Close()
                Catch err As System.Exception
                    GetErr = True : GoTo Get_Error
                End Try
            Catch err As System.Exception
                GetErr = True : GoTo Get_Error
            End Try
Get_Error:
            Item = UserGenList.Items.Add(CGUser.Text & TMP)
            Item.SubItems.Add(CGPassList.Items.Item(I))
            If GetErr Then
                Item.SubItems.Add("Error")
            Else
                Item.SubItems.Add("Created")
            End If
            TMP += 1
        Next
        For K As Integer = 0 To UserGenList.Items.Count - 1
            If UserGenList.Items.Item(K).SubItems(2).Text = "Created" Then
                CGAccGen.Text += UserGenList.Items.Item(K).SubItems(0).Text & ";" & UserGenList.Items.Item(K).SubItems(1).Text & ";" & vbCrLf
            End If
        Next
        CGGenerateB.Enabled = True
        ExitCommand = False
    End Sub

    Private Sub CGSaveB_Click(sender As Object, e As EventArgs) Handles CGSaveB.Click
        If UserGenList.Items.Count = 0 Then MsgBox("Created account list is empty", MsgBoxStyle.Information) : Exit Sub
        Dim SFD As New SaveFileDialog
        SFD.Filter = "Text Document (*.txt)|*.txt"
        If SFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim objWriter As New System.IO.StreamWriter(SFD.FileName, True)
            For I As Integer = 0 To UserGenList.Items.Count - 1
                objWriter.WriteLine("Username : " & UserGenList.Items.Item(I).SubItems(0).Text & "     Password : " & UserGenList.Items.Item(I).SubItems(1).Text & "     Website : acc.pars-tc.com")
            Next
            objWriter.Close()
        End If
    End Sub

    Private Sub CGExitB_Click(sender As Object, e As EventArgs) Handles CGExitB.Click
        Application.Exit()
    End Sub
End Class
