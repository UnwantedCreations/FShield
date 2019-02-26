Imports System.IO
Imports System.Data.SQLite
Public Class Login
    Private ConnectionString As String = String.Empty

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionString = String.Format("Data source={0};Version=3;", Directory.GetCurrentDirectory() & "\mainfiles\" & "FShieldDB.db")

    End Sub
    Private Sub ChkBxPasswordShow_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles ChkBxPasswordShow.CheckedChanged

        If TxtBxPassword.isPassword = True Then
            TxtBxPassword.isPassword = False
        Else
            TxtBxPassword.isPassword = True

        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtBxUsername.Text = "" Then
            MessageBox.Show("Enter Username")
        ElseIf TxtBxPassword.Text = "" Then
            MessageBox.Show("Enter Password")
        Else
            Try

                If IsUserValid(TxtBxUsername.Text.Trim, TxtBxPassword.Text.Trim) Then


                    MessageBox.Show("Login successful")
                    FShieldMainForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Login Unsuccessful")

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Function IsUserValid(username As String, password As String) As Boolean
        Dim IsValidUser As Boolean = False
        Dim UserInfo As DataRow = Nothing
        Dim sql As String = "SELECT * FROM LoginTB WHERE user = @username;"
        Try
            Using conn As New SQLiteConnection(ConnectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            UserInfo = dt.Rows(0)
                            If UserInfo("password").Equals(password) Then
                                IsValidUser = True
                            End If

                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return IsValidUser
    End Function
End Class