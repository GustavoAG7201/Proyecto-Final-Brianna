Imports System.Data.OleDb
Module conexion

    Public conexion_ As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\pandora accdb.accdb")



End Module
