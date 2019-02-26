Imports System.IO
Imports System.Text
Imports System.Data.SQLite
Imports System.Management
Imports System.Net.NetworkInformation

Public Class FShieldMainForm
    Dim password_changed As Boolean
    Dim MainClicked As Boolean
    Private Sub FShieldMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        AdBlockPnl.Dock = DockStyle.Fill
        ParentalControlPnl.Visible = False
        BlockListPnl.Visible = False
        DNSControlPnl.Visible = False
        StatisticsPnl.Visible = False
        AboutUsPnl.Visible = False
        ListboxLoad()
        NetworkInterfaceLoad()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If (SideMenu.Width = 50) Then
            Me.Width = 924
            SmallLogo.Visible = False
            SideMenu.Visible = False
            SideMenu.Width = 244
            PanelAnimator.ShowSync(SideMenu)
            LogoAnimator.ShowSync(logo)



        Else
            Me.Width = 730
            SmallLogo.Visible = True
            'LogoAnimator.Hide(logo)
            logo.Visible = False
            SideMenu.Visible = False
            SideMenu.Width = 50
            PanelAnimator.ShowSync(SideMenu)


        End If
    End Sub

    Private Sub BtnAdBlock_Click(sender As Object, e As EventArgs) Handles BtnAdBlock.Click
        AdBlockPnl.Visible = True
        'AdBlockPnl.Dock = DockStyle.Fill
        ParentalControlPnl.Visible = False
        BlockListPnl.Visible = False
        DNSControlPnl.Visible = False
        StatisticsPnl.Visible = False
        AboutUsPnl.Visible = False
    End Sub

    Private Sub BtnParentalControl_Click(sender As Object, e As EventArgs) Handles BtnParentalControl.Click
        AdBlockPnl.Visible = False
        ParentalControlPnl.Visible = True
        'ParentalControlPnl.Dock = DockStyle.Fill
        BlockListPnl.Visible = False
        DNSControlPnl.Visible = False
        StatisticsPnl.Visible = False
        AboutUsPnl.Visible = False
        SideMenu.Visible = True
    End Sub

    Private Sub BtnBlockList_Click(sender As Object, e As EventArgs) Handles BtnBlockList.Click
        AdBlockPnl.Visible = False
        ParentalControlPnl.Visible = False
        BlockListPnl.Visible = True
        'BlockListPnl.Dock = DockStyle.Fill
        DNSControlPnl.Visible = False
        StatisticsPnl.Visible = False
        AboutUsPnl.Visible = False
    End Sub

    Private Sub BtnDNSControl_Click(sender As Object, e As EventArgs) Handles BtnDNSControl.Click
        AdBlockPnl.Visible = False
        ParentalControlPnl.Visible = False
        BlockListPnl.Visible = False
        DNSControlPnl.Visible = True
        'DNSControlPnl.Dock = DockStyle.Fill
        StatisticsPnl.Visible = False
        AboutUsPnl.Visible = False
    End Sub

    Private Sub BtnStatistics_Click(sender As Object, e As EventArgs) Handles BtnStatistics.Click
        AdBlockPnl.Visible = False
        ParentalControlPnl.Visible = False
        BlockListPnl.Visible = False
        DNSControlPnl.Visible = False
        StatisticsPnl.Visible = True
        'StatisticsPnl.Dock = DockStyle.Fill
        AboutUsPnl.Visible = False
    End Sub

    Private Sub BtnAboutUs_Click(sender As Object, e As EventArgs) Handles BtnAboutUs.Click
        AdBlockPnl.Visible = False
        ParentalControlPnl.Visible = False
        BlockListPnl.Visible = False
        DNSControlPnl.Visible = False
        StatisticsPnl.Visible = False
        AboutUsPnl.Visible = True
        'AboutUsPnl.Dock = DockStyle.Fill
    End Sub


    Public Sub Combine_Two_Files(filepath1 As String, filepath2 As String, CombinePath As String)
        Dim s1 As String() = IO.File.ReadAllLines(filepath1)
        Dim s2 As String() = IO.File.ReadAllLines(filepath2)
        Dim l As List(Of String) = New List(Of String)
        l.AddRange(s1.ToList)
        l.AddRange(s2.ToList)
        IO.File.WriteAllLines(CombinePath, l.ToArray)
    End Sub
    Private Sub BtnMain_Click(sender As Object, e As EventArgs)
        Combine_Two_Files("mainFiles/APPEND-FROM.txt", "mainFiles/APPEND-TO.txt", "mainFiles/here.txt")
    End Sub
    Private Sub BtnMain1_Click(sender As Object, e As EventArgs)
        Dim path As String = "mainFiles\hosts"
        Dim destination As String = "C:\Windows\System32\drivers\etc\hosts"
        If File.Exists(destination) Then
            'MessageBox.Show("already moved22")
            File.Move(destination, path)
            MessageBox.Show("moved from Windows\System32\drivers\etc\ to mainFiles\hosts")
        ElseIf File.Exists(path) Then
            'File.Move(path, destination)
            'MessageBox.Show("moved from mainFiles\hosts to moved from Windows\System32\drivers\etc\")
        End If
    End Sub
    Private Sub BtnMain_Click_1(sender As Object, e As EventArgs) Handles BtnMainOff.Click
        MainClicked = True
        If ToggleChildProtection.Value = True Then
            ChildProtectionOn()
        Else
            ChildProtectionOff()
        End If
    End Sub
    Public Sub RemoveItems()
        Dim IndexRemove As Integer
        Dim NewHostFile As List(Of String) = System.IO.File.ReadAllLines("mainFiles/here.txt").ToList
        Dim WhiteListFile As List(Of String) = System.IO.File.ReadAllLines("mainFiles/whitelist.txt").ToList
        For Each WhiteListItem In WhiteListFile
            IndexRemove = NewHostFile.IndexOf(WhiteListItem)
            NewHostFile.RemoveAt(IndexRemove)
        Next
        System.IO.File.WriteAllLines("mainFiles/here.txt", NewHostFile)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        TxtBxNewPassword.Text = ""
        TxtBxUsername.Text = ""
    End Sub


    Private ConnectionString As String = String.Empty
    Private Sub ParentalControlPnl_Paint(sender As Object, e As PaintEventArgs) Handles ParentalControlPnl.Paint
        ConnectionString = String.Format("Data source={0};Version=3;", Directory.GetCurrentDirectory() & "\mainfiles\" & "FShieldDB.db")

    End Sub




    ''' <summary>
    ''' Update User Using SQLite
    ''' </summary>



    Private Sub UserUpdate()
        ConnectionString = String.Format("Data source={0};Version=3;", Directory.GetCurrentDirectory() & "\mainfiles\" & "FShieldDB.db")
        Dim READER As SQLiteDataReader
        Dim sql As String
        Dim conn As New SQLiteConnection(ConnectionString.ToString)
        Dim cmd As New SQLiteCommand(conn)
        sql = "UPDATE  LoginTB SET user='" & TxtBxNewUsername.Text & "',password='" & TxtBxNewPassword.Text & "' WHERE user='" & TxtBxUsername.Text & "';"
        Try
            conn.Open()
            Dim Query As String
            Query = "update fshieldusers.users Set user='" & TxtBxNewUsername.Text & "',password='" & TxtBxNewPassword.Text & "' where user='" & TxtBxUsername.Text & "'"

            cmd = New SQLiteCommand(sql, conn)
            READER = cmd.ExecuteReader

            MessageBox.Show("User Details Updated")
            password_changed = True
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub BtnUpdateUser_Click(sender As Object, e As EventArgs) Handles BtnUpdateUser.Click
        If TxtBxUsername.Text = "" Then
            MessageBox.Show("Enter Username")
        ElseIf TxtBxNewUsername.Text = "" Then
            MessageBox.Show("Enter New Username")
        ElseIf TxtBxNewPassword.Text = "" Then
            MessageBox.Show("Enter New Password")
        Else
            UserUpdate()
        End If

    End Sub

    ''' <summary>
    ''' Check Box Password Show and Hide
    ''' </summary>

    Private Sub ChkBxPasswordShow_CheckedChanged_1(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles ChkBxPasswordShow.CheckedChanged
        If TxtBxNewPassword.isPassword = True Then
            TxtBxNewPassword.isPassword = False
        Else
            TxtBxNewPassword.isPassword = True

        End If
    End Sub




    Public Sub NetworkInterfaceLoad()
        For Each nic As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            If nic.OperationalStatus = OperationalStatus.Up Then
                CmbBxNetworkAdaptors.Items.Add(nic.Name.ToString())
                Exit For
            End If
        Next
        CmbBxNetworkAdaptors.SelectedIndex = CmbBxNetworkAdaptors.Items.Count = -1
    End Sub



    Private Sub BtnChangeDNS_Click(sender As Object, e As EventArgs) Handles BtnChangeDNS.Click
        Dim objMC As New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()
        If CmbBxNetworkAdaptors.SelectedItem = "" Then
            MessageBox.Show("Choose a Network Adapter")
        ElseIf TxtBxDNS.Text = "" Then
            MessageBox.Show("Enter DNS")
        Else
            For Each objMO As ManagementObject In objMOC
                If CBool(objMO("IPEnabled")) Then

                    ' if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                    Try


                        objMO("Caption").Equals(CmbBxNetworkAdaptors.SelectedIndex)

                        Dim newDNS As ManagementBaseObject = objMO.GetMethodParameters("SetDNSServerSearchOrder")
                        newDNS("DNSServerSearchOrder") = TxtBxDNS.Text.Split(","c)
                        Dim setDNS As ManagementBaseObject = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, Nothing)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try
                    MessageBox.Show("DNS Changed Successfully")
                End If
            Next
        End If

    End Sub

    Public Sub ListboxLoad()

        Dim path = "C:\Users\Loozer\Desktop\hosts.txt"
        Dim lines() As String = File.ReadAllLines(path)
        'Substring(9) the characters in "127.0.0.1" are index 0-8 so we begin with index 9
        'and return the rest of the string.
        Dim TrimmedList = From line In lines
                          Select line.Substring(8)
        For Each item In TrimmedList
            ListBxBlockedDomains.Items.Add(item)
        Next

        Dim sb As New StringBuilder()
        For Each item In ListBxBlockedDomains.Items
            sb.AppendLine("0.0.0.0 " & item.ToString)
        Next
        File.WriteAllText(path, sb.ToString)

    End Sub

    Public Sub BtnBlkDomainAdd_Click(sender As Object, e As EventArgs) Handles BtnBlkDomainAdd.Click

        If TxtBxBlockedDomains.Text = "" Then
            MessageBox.Show("No domain enterd !")
        Else
            ListBxBlockedDomains.Items.Add(TxtBxBlockedDomains.Text)
            ListBxBlockedDomains.SelectedIndex = ListBxBlockedDomains.SelectedIndex + 1
            TxtBxBlockedDomains.Text = ("0.0.0.0 " + TxtBxBlockedDomains.Text + vbNewLine)
            My.Computer.FileSystem.WriteAllText("C:\Users\Loozer\Desktop\hosts.txt", "" & TxtBxBlockedDomains.Text, True)
            'My.Computer.FileSystem.WriteAllText("C\Windows\System32\drivers\etc\hosts", " & BlockTextBox.Text, True)

            TxtBxBlockedDomains.Text = ""
            MessageBox.Show("URL added to Block List !", "Custom Block List")
            'ListboxLoad()
        End If
    End Sub

    Private Sub BtnBlkDomainRemove_Click(sender As Object, e As EventArgs) Handles BtnBlkDomainRemove.Click
        Dim lines As List(Of String) = System.IO.File.ReadAllLines("C:\Users\Loozer\Desktop\hosts.txt").ToList
        Dim Findstring = IO.File.ReadAllText("C:\Users\Loozer\Desktop\hosts.txt")
        Dim Lookfor As String = CStr("0.0.0.0 " + ListBxBlockedDomains.SelectedItem)

        If lines.Contains(Lookfor) Then
            For i = 0 To Findstring.Length - 1
                lines.Remove(Lookfor)
            Next
            System.IO.File.WriteAllLines("C:\Users\Loozer\Desktop\hosts.txt", lines)
            ListBxBlockedDomains.Items.Remove(ListBxBlockedDomains.SelectedItems)
            ListBxBlockedDomains.Items.Clear()
            ListboxLoad()
            MessageBox.Show("URL removed from Block List !", "Custom Block List")
        Else
            MsgBox("No Domain Selected !")
        End If
    End Sub

    Private Sub TxtBxBlockedDomains_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtBxBlockedDomains.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                Me.AcceptButton = BtnBlkDomainAdd()
            End If

        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)
        RemoveItems()
    End Sub


    Private Sub ChildProtectionOn()
        Dim objMC As New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()
        Dim ChildDNS As String = "176.103.130.132,176.103.130.134"
        For Each objMO As ManagementObject In objMOC
            If CBool(objMO("IPEnabled")) Then

                ' if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                Try


                    objMO("Caption").Equals(CmbBxNetworkAdaptors.SelectedIndex)

                    Dim newDNS As ManagementBaseObject = objMO.GetMethodParameters("SetDNSServerSearchOrder")
                    newDNS("DNSServerSearchOrder") = ChildDNS.Split(","c)
                    Dim setDNS As ManagementBaseObject = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, Nothing)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        Next

    End Sub
    Private Sub ChildProtectionOff()
        Dim objMC As New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()
        Dim ChildDNS As String = "176.103.130.130,176.103.130.131"
        For Each objMO As ManagementObject In objMOC
            If CBool(objMO("IPEnabled")) Then

                ' if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                Try


                    objMO("Caption").Equals(CmbBxNetworkAdaptors.SelectedIndex)

                    Dim newDNS As ManagementBaseObject = objMO.GetMethodParameters("SetDNSServerSearchOrder")
                    newDNS("DNSServerSearchOrder") = ChildDNS.Split(","c)
                    Dim setDNS As ManagementBaseObject = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, Nothing)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            End If
        Next

    End Sub
End Class
