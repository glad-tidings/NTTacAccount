<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainF))
        Me.CGTab = New System.Windows.Forms.TabControl()
        Me.CGTGeneral = New System.Windows.Forms.TabPage()
        Me.CGPassIsUser = New System.Windows.Forms.CheckBox()
        Me.CGComment = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CGPrivilege = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CGMaxLogin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CGActiveDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CGExpireDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CGUserStart = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CGUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CGTPassword = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CGGPassB = New System.Windows.Forms.Button()
        Me.CGPassSymCase = New System.Windows.Forms.CheckBox()
        Me.CGPassLowCase = New System.Windows.Forms.CheckBox()
        Me.CGPassUpCase = New System.Windows.Forms.CheckBox()
        Me.CGPassNum = New System.Windows.Forms.CheckBox()
        Me.CGPassList = New System.Windows.Forms.ListBox()
        Me.CGCOGen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CGPassLen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CGTGroupMembership = New System.Windows.Forms.TabPage()
        Me.CGBTB = New System.Windows.Forms.Button()
        Me.CGNBTB = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CGNotBelong = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CGBelong = New System.Windows.Forms.ListBox()
        Me.CGAccGenerated = New System.Windows.Forms.TabPage()
        Me.UserGenList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CGSaveB = New System.Windows.Forms.Button()
        Me.CGAccGen = New System.Windows.Forms.TextBox()
        Me.CGExitB = New System.Windows.Forms.Button()
        Me.CGGenerateB = New System.Windows.Forms.Button()
        Me.AccSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.CGTab.SuspendLayout()
        Me.CGTGeneral.SuspendLayout()
        Me.CGTPassword.SuspendLayout()
        Me.CGTGroupMembership.SuspendLayout()
        Me.CGAccGenerated.SuspendLayout()
        Me.SuspendLayout()
        '
        'CGTab
        '
        Me.CGTab.Controls.Add(Me.CGTGeneral)
        Me.CGTab.Controls.Add(Me.CGTPassword)
        Me.CGTab.Controls.Add(Me.CGTGroupMembership)
        Me.CGTab.Controls.Add(Me.CGAccGenerated)
        Me.CGTab.Location = New System.Drawing.Point(12, 12)
        Me.CGTab.Name = "CGTab"
        Me.CGTab.SelectedIndex = 0
        Me.CGTab.Size = New System.Drawing.Size(558, 370)
        Me.CGTab.TabIndex = 0
        '
        'CGTGeneral
        '
        Me.CGTGeneral.Controls.Add(Me.CGPassIsUser)
        Me.CGTGeneral.Controls.Add(Me.CGComment)
        Me.CGTGeneral.Controls.Add(Me.Label7)
        Me.CGTGeneral.Controls.Add(Me.CGPrivilege)
        Me.CGTGeneral.Controls.Add(Me.Label6)
        Me.CGTGeneral.Controls.Add(Me.CGMaxLogin)
        Me.CGTGeneral.Controls.Add(Me.Label5)
        Me.CGTGeneral.Controls.Add(Me.CGActiveDate)
        Me.CGTGeneral.Controls.Add(Me.Label4)
        Me.CGTGeneral.Controls.Add(Me.CGExpireDate)
        Me.CGTGeneral.Controls.Add(Me.Label3)
        Me.CGTGeneral.Controls.Add(Me.CGUserStart)
        Me.CGTGeneral.Controls.Add(Me.Label2)
        Me.CGTGeneral.Controls.Add(Me.CGUser)
        Me.CGTGeneral.Controls.Add(Me.Label1)
        Me.CGTGeneral.Location = New System.Drawing.Point(4, 22)
        Me.CGTGeneral.Name = "CGTGeneral"
        Me.CGTGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.CGTGeneral.Size = New System.Drawing.Size(550, 344)
        Me.CGTGeneral.TabIndex = 0
        Me.CGTGeneral.Text = "General"
        Me.CGTGeneral.UseVisualStyleBackColor = True
        '
        'CGPassIsUser
        '
        Me.CGPassIsUser.AutoSize = True
        Me.CGPassIsUser.Location = New System.Drawing.Point(176, 58)
        Me.CGPassIsUser.Name = "CGPassIsUser"
        Me.CGPassIsUser.Size = New System.Drawing.Size(134, 17)
        Me.CGPassIsUser.TabIndex = 2
        Me.CGPassIsUser.Text = "Password Is Username"
        Me.CGPassIsUser.UseVisualStyleBackColor = True
        '
        'CGComment
        '
        Me.CGComment.Location = New System.Drawing.Point(176, 185)
        Me.CGComment.Multiline = True
        Me.CGComment.Name = "CGComment"
        Me.CGComment.Size = New System.Drawing.Size(368, 153)
        Me.CGComment.TabIndex = 7
        Me.CGComment.Text = "(group)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Comment :"
        '
        'CGPrivilege
        '
        Me.CGPrivilege.Location = New System.Drawing.Point(176, 159)
        Me.CGPrivilege.Name = "CGPrivilege"
        Me.CGPrivilege.Size = New System.Drawing.Size(157, 20)
        Me.CGPrivilege.TabIndex = 6
        Me.CGPrivilege.Text = "(group)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Privilege (0-15) :"
        '
        'CGMaxLogin
        '
        Me.CGMaxLogin.Location = New System.Drawing.Point(176, 133)
        Me.CGMaxLogin.Name = "CGMaxLogin"
        Me.CGMaxLogin.Size = New System.Drawing.Size(157, 20)
        Me.CGMaxLogin.TabIndex = 5
        Me.CGMaxLogin.Text = "(group)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Max Concurrent Logins (0-9999) :"
        '
        'CGActiveDate
        '
        Me.CGActiveDate.Location = New System.Drawing.Point(176, 107)
        Me.CGActiveDate.Name = "CGActiveDate"
        Me.CGActiveDate.Size = New System.Drawing.Size(157, 20)
        Me.CGActiveDate.TabIndex = 4
        Me.CGActiveDate.Text = "(group)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Activation Date :"
        '
        'CGExpireDate
        '
        Me.CGExpireDate.Location = New System.Drawing.Point(176, 81)
        Me.CGExpireDate.Name = "CGExpireDate"
        Me.CGExpireDate.Size = New System.Drawing.Size(157, 20)
        Me.CGExpireDate.TabIndex = 3
        Me.CGExpireDate.Text = "(group)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Expiration Date :"
        '
        'CGUserStart
        '
        Me.CGUserStart.Location = New System.Drawing.Point(176, 32)
        Me.CGUserStart.Name = "CGUserStart"
        Me.CGUserStart.Size = New System.Drawing.Size(157, 20)
        Me.CGUserStart.TabIndex = 1
        Me.CGUserStart.Text = "20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username Start :"
        '
        'CGUser
        '
        Me.CGUser.Location = New System.Drawing.Point(176, 6)
        Me.CGUser.Name = "CGUser"
        Me.CGUser.Size = New System.Drawing.Size(157, 20)
        Me.CGUser.TabIndex = 0
        Me.CGUser.Text = "meme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'CGTPassword
        '
        Me.CGTPassword.Controls.Add(Me.Label13)
        Me.CGTPassword.Controls.Add(Me.Label12)
        Me.CGTPassword.Controls.Add(Me.Label11)
        Me.CGTPassword.Controls.Add(Me.Label10)
        Me.CGTPassword.Controls.Add(Me.CGGPassB)
        Me.CGTPassword.Controls.Add(Me.CGPassSymCase)
        Me.CGTPassword.Controls.Add(Me.CGPassLowCase)
        Me.CGTPassword.Controls.Add(Me.CGPassUpCase)
        Me.CGTPassword.Controls.Add(Me.CGPassNum)
        Me.CGTPassword.Controls.Add(Me.CGPassList)
        Me.CGTPassword.Controls.Add(Me.CGCOGen)
        Me.CGTPassword.Controls.Add(Me.Label9)
        Me.CGTPassword.Controls.Add(Me.CGPassLen)
        Me.CGTPassword.Controls.Add(Me.Label8)
        Me.CGTPassword.Location = New System.Drawing.Point(4, 22)
        Me.CGTPassword.Name = "CGTPassword"
        Me.CGTPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.CGTPassword.Size = New System.Drawing.Size(550, 344)
        Me.CGTPassword.TabIndex = 1
        Me.CGTPassword.Text = "Password"
        Me.CGTPassword.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "!@#$%()^*-_=+\/<>[]{}?:."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "abcdefghijklmnopqrstuvwxyz"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "0123456789"
        '
        'CGGPassB
        '
        Me.CGGPassB.Location = New System.Drawing.Point(6, 315)
        Me.CGGPassB.Name = "CGGPassB"
        Me.CGGPassB.Size = New System.Drawing.Size(124, 23)
        Me.CGGPassB.TabIndex = 6
        Me.CGGPassB.Text = "Genarate Password"
        Me.CGGPassB.UseVisualStyleBackColor = True
        '
        'CGPassSymCase
        '
        Me.CGPassSymCase.AutoSize = True
        Me.CGPassSymCase.Location = New System.Drawing.Point(11, 184)
        Me.CGPassSymCase.Name = "CGPassSymCase"
        Me.CGPassSymCase.Size = New System.Drawing.Size(125, 17)
        Me.CGPassSymCase.TabIndex = 5
        Me.CGPassSymCase.Text = "Include Symbol Case"
        Me.CGPassSymCase.UseVisualStyleBackColor = True
        '
        'CGPassLowCase
        '
        Me.CGPassLowCase.AutoSize = True
        Me.CGPassLowCase.Location = New System.Drawing.Point(12, 143)
        Me.CGPassLowCase.Name = "CGPassLowCase"
        Me.CGPassLowCase.Size = New System.Drawing.Size(120, 17)
        Me.CGPassLowCase.TabIndex = 4
        Me.CGPassLowCase.Text = "Include Lower Case"
        Me.CGPassLowCase.UseVisualStyleBackColor = True
        '
        'CGPassUpCase
        '
        Me.CGPassUpCase.AutoSize = True
        Me.CGPassUpCase.Location = New System.Drawing.Point(12, 102)
        Me.CGPassUpCase.Name = "CGPassUpCase"
        Me.CGPassUpCase.Size = New System.Drawing.Size(120, 17)
        Me.CGPassUpCase.TabIndex = 3
        Me.CGPassUpCase.Text = "Include Upper Case"
        Me.CGPassUpCase.UseVisualStyleBackColor = True
        '
        'CGPassNum
        '
        Me.CGPassNum.AutoSize = True
        Me.CGPassNum.Checked = True
        Me.CGPassNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CGPassNum.Location = New System.Drawing.Point(12, 61)
        Me.CGPassNum.Name = "CGPassNum"
        Me.CGPassNum.Size = New System.Drawing.Size(101, 17)
        Me.CGPassNum.TabIndex = 2
        Me.CGPassNum.Text = "Include Number"
        Me.CGPassNum.UseVisualStyleBackColor = True
        '
        'CGPassList
        '
        Me.CGPassList.FormattingEnabled = True
        Me.CGPassList.Location = New System.Drawing.Point(229, 9)
        Me.CGPassList.Name = "CGPassList"
        Me.CGPassList.Size = New System.Drawing.Size(315, 329)
        Me.CGPassList.TabIndex = 7
        '
        'CGCOGen
        '
        Me.CGCOGen.Location = New System.Drawing.Point(116, 35)
        Me.CGCOGen.Name = "CGCOGen"
        Me.CGCOGen.Size = New System.Drawing.Size(104, 20)
        Me.CGCOGen.TabIndex = 1
        Me.CGCOGen.Text = "20"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Count Of Generate :"
        '
        'CGPassLen
        '
        Me.CGPassLen.Location = New System.Drawing.Point(116, 9)
        Me.CGPassLen.Name = "CGPassLen"
        Me.CGPassLen.Size = New System.Drawing.Size(104, 20)
        Me.CGPassLen.TabIndex = 0
        Me.CGPassLen.Text = "5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Password Length :"
        '
        'CGTGroupMembership
        '
        Me.CGTGroupMembership.Controls.Add(Me.CGBTB)
        Me.CGTGroupMembership.Controls.Add(Me.CGNBTB)
        Me.CGTGroupMembership.Controls.Add(Me.Label15)
        Me.CGTGroupMembership.Controls.Add(Me.CGNotBelong)
        Me.CGTGroupMembership.Controls.Add(Me.Label14)
        Me.CGTGroupMembership.Controls.Add(Me.CGBelong)
        Me.CGTGroupMembership.Location = New System.Drawing.Point(4, 22)
        Me.CGTGroupMembership.Name = "CGTGroupMembership"
        Me.CGTGroupMembership.Padding = New System.Windows.Forms.Padding(3)
        Me.CGTGroupMembership.Size = New System.Drawing.Size(550, 344)
        Me.CGTGroupMembership.TabIndex = 2
        Me.CGTGroupMembership.Text = "Group Membership"
        Me.CGTGroupMembership.UseVisualStyleBackColor = True
        '
        'CGBTB
        '
        Me.CGBTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CGBTB.Location = New System.Drawing.Point(257, 188)
        Me.CGBTB.Name = "CGBTB"
        Me.CGBTB.Size = New System.Drawing.Size(36, 23)
        Me.CGBTB.TabIndex = 2
        Me.CGBTB.Text = "<<"
        Me.CGBTB.UseVisualStyleBackColor = True
        '
        'CGNBTB
        '
        Me.CGNBTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CGNBTB.Location = New System.Drawing.Point(257, 153)
        Me.CGNBTB.Name = "CGNBTB"
        Me.CGNBTB.Size = New System.Drawing.Size(36, 23)
        Me.CGNBTB.TabIndex = 1
        Me.CGNBTB.Text = ">>"
        Me.CGNBTB.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(296, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Doesn't belong to :"
        '
        'CGNotBelong
        '
        Me.CGNotBelong.FormattingEnabled = True
        Me.CGNotBelong.Location = New System.Drawing.Point(299, 22)
        Me.CGNotBelong.Name = "CGNotBelong"
        Me.CGNotBelong.Size = New System.Drawing.Size(245, 316)
        Me.CGNotBelong.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Belongs to :"
        '
        'CGBelong
        '
        Me.CGBelong.FormattingEnabled = True
        Me.CGBelong.Location = New System.Drawing.Point(6, 22)
        Me.CGBelong.Name = "CGBelong"
        Me.CGBelong.Size = New System.Drawing.Size(245, 316)
        Me.CGBelong.TabIndex = 0
        '
        'CGAccGenerated
        '
        Me.CGAccGenerated.Controls.Add(Me.UserGenList)
        Me.CGAccGenerated.Controls.Add(Me.CGSaveB)
        Me.CGAccGenerated.Controls.Add(Me.CGAccGen)
        Me.CGAccGenerated.Location = New System.Drawing.Point(4, 22)
        Me.CGAccGenerated.Name = "CGAccGenerated"
        Me.CGAccGenerated.Padding = New System.Windows.Forms.Padding(3)
        Me.CGAccGenerated.Size = New System.Drawing.Size(550, 344)
        Me.CGAccGenerated.TabIndex = 3
        Me.CGAccGenerated.Text = "Account Generated"
        Me.CGAccGenerated.UseVisualStyleBackColor = True
        '
        'UserGenList
        '
        Me.UserGenList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.UserGenList.FullRowSelect = True
        Me.UserGenList.GridLines = True
        Me.UserGenList.Location = New System.Drawing.Point(6, 6)
        Me.UserGenList.Name = "UserGenList"
        Me.UserGenList.Size = New System.Drawing.Size(241, 332)
        Me.UserGenList.TabIndex = 0
        Me.UserGenList.UseCompatibleStateImageBehavior = False
        Me.UserGenList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 55
        '
        'CGSaveB
        '
        Me.CGSaveB.Location = New System.Drawing.Point(469, 6)
        Me.CGSaveB.Name = "CGSaveB"
        Me.CGSaveB.Size = New System.Drawing.Size(75, 23)
        Me.CGSaveB.TabIndex = 2
        Me.CGSaveB.Text = "Save"
        Me.CGSaveB.UseVisualStyleBackColor = True
        '
        'CGAccGen
        '
        Me.CGAccGen.Location = New System.Drawing.Point(253, 6)
        Me.CGAccGen.Multiline = True
        Me.CGAccGen.Name = "CGAccGen"
        Me.CGAccGen.Size = New System.Drawing.Size(210, 332)
        Me.CGAccGen.TabIndex = 1
        '
        'CGExitB
        '
        Me.CGExitB.Location = New System.Drawing.Point(495, 388)
        Me.CGExitB.Name = "CGExitB"
        Me.CGExitB.Size = New System.Drawing.Size(75, 23)
        Me.CGExitB.TabIndex = 2
        Me.CGExitB.Text = "Exit"
        Me.CGExitB.UseVisualStyleBackColor = True
        '
        'CGGenerateB
        '
        Me.CGGenerateB.Location = New System.Drawing.Point(414, 388)
        Me.CGGenerateB.Name = "CGGenerateB"
        Me.CGGenerateB.Size = New System.Drawing.Size(75, 23)
        Me.CGGenerateB.TabIndex = 1
        Me.CGGenerateB.Text = "Genarate"
        Me.CGGenerateB.UseVisualStyleBackColor = True
        '
        'MainF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 423)
        Me.Controls.Add(Me.CGGenerateB)
        Me.Controls.Add(Me.CGExitB)
        Me.Controls.Add(Me.CGTab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainF"
        Me.Text = "Pars Card Generator"
        Me.CGTab.ResumeLayout(False)
        Me.CGTGeneral.ResumeLayout(False)
        Me.CGTGeneral.PerformLayout()
        Me.CGTPassword.ResumeLayout(False)
        Me.CGTPassword.PerformLayout()
        Me.CGTGroupMembership.ResumeLayout(False)
        Me.CGTGroupMembership.PerformLayout()
        Me.CGAccGenerated.ResumeLayout(False)
        Me.CGAccGenerated.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CGTab As System.Windows.Forms.TabControl
    Friend WithEvents CGTGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CGTPassword As System.Windows.Forms.TabPage
    Friend WithEvents CGTGroupMembership As System.Windows.Forms.TabPage
    Friend WithEvents CGUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CGComment As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CGPrivilege As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CGMaxLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CGActiveDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CGExpireDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CGUserStart As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CGExitB As System.Windows.Forms.Button
    Friend WithEvents CGGenerateB As System.Windows.Forms.Button
    Friend WithEvents CGPassList As System.Windows.Forms.ListBox
    Friend WithEvents CGCOGen As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CGPassLen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CGPassSymCase As System.Windows.Forms.CheckBox
    Friend WithEvents CGPassLowCase As System.Windows.Forms.CheckBox
    Friend WithEvents CGPassUpCase As System.Windows.Forms.CheckBox
    Friend WithEvents CGPassNum As System.Windows.Forms.CheckBox
    Friend WithEvents CGGPassB As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CGBTB As System.Windows.Forms.Button
    Friend WithEvents CGNBTB As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CGNotBelong As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CGBelong As System.Windows.Forms.ListBox
    Friend WithEvents CGPassIsUser As System.Windows.Forms.CheckBox
    Friend WithEvents CGAccGenerated As System.Windows.Forms.TabPage
    Friend WithEvents CGSaveB As System.Windows.Forms.Button
    Friend WithEvents CGAccGen As System.Windows.Forms.TextBox
    Friend WithEvents UserGenList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AccSaveDialog As System.Windows.Forms.SaveFileDialog

End Class
