Public Class DBConnection

#Region "Class Import"
    Friend WithEvents OLEConn As New System.Data.OleDb.OleDbConnection
    Friend WithEvents OLEComm As New System.Data.OleDb.OleDbCommand
#End Region

#Region "class Function"

    Function ConnectMe(ByVal DBString As String) As Boolean
        Dim DBProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0"
        Dim DBMode As String = "Mode=ReadWrite"
        Dim DBPath As String = "Data source=C:\NTTacPlus2\ODBC\NTTacDB.mdb"
        Dim DBPass As String = "Jet OLEDB:Database Password=bhmz2006hgt10"
        Try
            OLEConn.ConnectionString = DBProvider & ";" & DBMode & ";" & DBPath '& ";" & DBPass
            OLEConn.Open()
            OLEComm.CommandText = DBString
            Return True
        Catch err As System.Exception
            Return False
        End Try
    End Function

#End Region

End Class