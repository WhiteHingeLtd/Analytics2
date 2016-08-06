Imports WHLClasses
Imports WHLClasses.WarehouseAnalytics

Public Class EmpStats
    Public EmpID As String
    Public allSessions As New Dictionary(Of Date, List(Of SessionAnalytic))

    Public Sub New(ID As String, sessions As Dictionary(Of Date, List(Of SessionAnalytic)))
        EmpID = ID
        allSessions = sessions
    End Sub
    Public Sub New() 'And I guess a way to make new empty ones.

    End Sub
End Class
