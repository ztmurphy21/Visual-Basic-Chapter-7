' Name:         Favorites Project
' Purpose:      Displays a message indicating
'               a favorite actor, actress,
'               movie, singer, or song
' Programmer:   Zach Murphy on 3-15-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' independent Sub procedure
    Private Sub DisplayMsg(ByVal strType As String,
                           ByVal strFavorite As String)
        lblFavorite.Text = "Your favorite " & strType & " is " & strFavorite & " ."
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' gets the favorite and then calls
        ' a procedure to display the favorite

        Dim strCategory As String
        Dim strName As String

        Select Case True
            Case radActor.Checked
                strCategory = "actor"
            Case radActress.Checked
                strCategory = "actress"
            Case radMovie.Checked
                strCategory = "movie"
            Case radSinger.Checked
                strCategory = "singer"
            Case Else
                strCategory = "song"
        End Select
        strName = InputBox("Your favorite " &
                           strCategory & "?", "Favorite")
        Call DisplayMsg(strCategory, strName)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearFavoriteMsg(sender As Object, e As EventArgs) Handles radActor.CheckedChanged, radActress.CheckedChanged, radMovie.CheckedChanged, radSinger.CheckedChanged, radSinger.CheckedChanged
        lblFavorite.Text = String.Empty
    End Sub
End Class
