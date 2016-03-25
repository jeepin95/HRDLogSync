Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStringL As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password=password", lblLocalFile.Text)
        Dim connStringR As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password=password", lblRemoteFile.Text)

        connL = New OleDbConnection(connStringL)
        connR = New OleDbConnection(connStringR)

        Dim command As New OleDb.OleDbCommand
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim row As System.Data.DataRow
        Dim count As Integer
        connL.Open()
        command.Connection = connL
        da.SelectCommand = New OleDbCommand("SELECT syncid FROM TABLE_HRD_CONTACTS_V01", connL)
        da.Fill(ds, "Table")
        count = ds.Tables("Table").Rows.Count
        Label1.Text = "Local Records: " & FormatNumber(count, 0)
        command.Dispose()
        ds.Tables.Clear()

        connR.Open()
        command = New OleDbCommand
        command.Connection = connR
        da.SelectCommand = New OleDbCommand("SELECT syncid FROM TABLE_HRD_CONTACTS_V01", connR)
        da.Fill(ds, "Table")
        count = ds.Tables("Table").Rows.Count
        Label2.Text = "Remote Records: " & FormatNumber(count, 0)
        command.Dispose()




    End Sub

    Private connL As OleDbConnection
    Private connR As OleDbConnection


    Private Sub openLocalDB()

    End Sub

    Private Sub openRemoteDB()

    End Sub
    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dlgMDB.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\HRDLLC\HRD Logbook"

        dlgMDB.ShowDialog()
        lblLocalFile.Text = dlgMDB.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dlgMDB.ShowDialog()
        lblRemoteFile.Text = dlgMDB.FileName

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim command As New OleDb.OleDbCommand
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim row As System.Data.DataRow
        Dim count As Integer
        connL.Open()
        command.Connection = connL
        da.SelectCommand = New OleDbCommand("SELECT * FROM TABLE_HRD_CONTACTS_V01", connL)
        da.Fill(ds, "Table")
        count = ds.Tables("Table").Rows.Count
        Label1.Text = "Local Records: " & FormatNumber(count, 0)
        command.Dispose()

        While count > -1
            row = ds.Tables("Table").Rows.Item(count)

        End While
    End Sub
End Class
