Imports WHLClasses
Imports WHLClasses.WarehouseAnalytics

Public Class AnalyticsBaseForm
    Dim empsColl As New EmployeeCollection
    Dim LargestValue As Integer = 0
    Public Auth As New Authentication.AuthClass

    Private Sub LoadProgram() Handles MyBase.Load
        LoadVisibleEmps()
        'That should be it.
    End Sub

    'USER OPTIONS
    Public LoadPickPackData As Boolean = True
    Public LoadPrepackData As Boolean = True

    Public LoadPickSinglesData As Boolean = True
    Public LoadPickBoxedData As Boolean = True
    Public LoadPickMultisData As Boolean = True
    Public LoadPackSinglesData As Boolean = True
    Public LoadPackBoxedData As Boolean = True
    Public LoadPackMultisData As Boolean = True

    Public AllOneBar As Boolean = True 'Graph chart type - one bar or multiple

    Private Sub LoadMultipleDaysBtn_Click(sender As Object, e As EventArgs) Handles LoadMultipleDaysBtn.Click

        If Not IsNothing(Auth.AuthenticatedUser) Then
            If Auth.AuthenticatedUser.Permissions.canViewAnalytics Then
                Dim empStatsList As New List(Of EmpStats)
                For Each emp As Employee In GetRelevantEmployees()
                    'Well if nothing returns, this won't run.
                    Dim newEmpStats As EmpStats = GetEmployeeStats(emp.PayrollId)
                    If Not newEmpStats Is Nothing Then
                        empStatsList.Add(newEmpStats)
                    End If
                Next

                'Did it work?
                If empStatsList.Count > 0 Then
                    'Set stuff up!
                    SetUpPreProcessing()
                    ProcessMultiDayAnalyticsData(empStatsList)
                Else
                    MsgBox("It looks like those users do not have any analytics data available. If they've never used the system, this makes sense. Otherwise, contact IT, that's a rather concerning issue.")
                End If
            Else
                MsgBox("You do not have permission to view analytics data.")
                Auth.LogUserOut()
            End If
        Else
            MsgBox("You do not have permission to view analytics data.")
            Auth.LogUserOut()
        End If
    End Sub

    Dim ListOfDates As New List(Of Date)
    Private Sub SetUpPreProcessing()
        'GOOD.
        'Neutralise our date's time portion
        Dim date1str As String = FirstDate.Value.ToString("yyyy/MM/dd")
        Dim date2str As String = SecondDate.Value.ToString("yyyy/MM/dd")
        Dim Date1 As Date = date1str
        Dim Date2 As Date = date2str

        'Get our list of days
        While Date1 <= Date2
            ListOfDates.Add(Date1)
            Date1 = Date1.AddDays(1)
        End While

        'Get rid of any existing chart data.
        Try
            EmpMultiDayPickingChart.Series.Clear()
        Catch ex As Exception
        End Try
        Try
            WarehouseMultiDayStatsTable.Rows.Clear()
        Catch ex As Exception
        End Try

        Dim chartdisplaytype As New DataVisualization.Charting.SeriesChartType
        chartdisplaytype = DataVisualization.Charting.SeriesChartType.Bar

        If TimeSpentRadio.Checked = True Then
            'We want to see employees on a scale to the hour.
            EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Hours"
            EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
        ElseIf TotalRadio.Checked = True Then
            'We want to see employees total pick / pack amounts.
            EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Orders"
            EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
        ElseIf AverageRadio.Checked = True Then
            'We want to see employees total amounts on average, scaled to the hour.

            EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Orders to the hour"
            EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
        End If

        'This is probably not the best way to view this data
        If PickPackChosen.Checked Then
            If CheckPickSingle.Checked = True Then
                EmpMultiDayPickingChart.Series.Add("PickingSingle")
                EmpMultiDayPickingChart.Series("PickingSingle")("PixelPointWidth") = "20"
                EmpMultiDayPickingChart.Series("PickingSingle").Color = Color.DeepSkyBlue
                EmpMultiDayPickingChart.Series("PickingSingle").ChartType = chartdisplaytype
            End If
            If CheckPackSingle.Checked = True Then
                EmpMultiDayPickingChart.Series.Add("PackingSingle")
                EmpMultiDayPickingChart.Series("PackingSingle")("PixelPointWidth") = "20"
                EmpMultiDayPickingChart.Series("PackingSingle").Color = Color.RoyalBlue
                EmpMultiDayPickingChart.Series("PackingSingle").ChartType = chartdisplaytype
            End If
            If CheckPickBox.Checked = True Then
                EmpMultiDayPickingChart.Series.Add("PickingBoxed")
                EmpMultiDayPickingChart.Series("PickingBoxed")("PixelPointWidth") = "20"
                EmpMultiDayPickingChart.Series("PickingBoxed").Color = Color.Crimson
                EmpMultiDayPickingChart.Series("PickingBoxed").ChartType = chartdisplaytype
            End If
            If CheckPackBox.Checked = True Then
                EmpMultiDayPickingChart.Series.Add("PackingBoxed")
                EmpMultiDayPickingChart.Series("PackingBoxed")("PixelPointWidth") = "20"
                EmpMultiDayPickingChart.Series("PackingBoxed").Color = Color.DarkRed
                EmpMultiDayPickingChart.Series("PackingBoxed").ChartType = chartdisplaytype
            End If
            If CheckPickMulti.Checked = True Then
                EmpMultiDayPickingChart.Series.Add("PickingMulti")
                EmpMultiDayPickingChart.Series("PickingMulti")("PixelPointWidth") = "20"
                EmpMultiDayPickingChart.Series("PickingMulti").Color = Color.Gold
                EmpMultiDayPickingChart.Series("PickingMulti").ChartType = chartdisplaytype
            End If
            If CheckPackMulti.Checked = True Then
                EmpMultiDayPickingChart.Series.Add("PackingMulti")
                EmpMultiDayPickingChart.Series("PackingMulti")("PixelPointWidth") = "20"
                EmpMultiDayPickingChart.Series("PackingMulti").Color = Color.Goldenrod
                EmpMultiDayPickingChart.Series("PackingMulti").ChartType = chartdisplaytype
            End If
        ElseIf PrepackChosen.Checked = True Then
            EmpMultiDayPickingChart.Series.Add("PrePack")
            EmpMultiDayPickingChart.Series("PrePack")("PixelPointWidth") = "20"
            EmpMultiDayPickingChart.Series("PrePack").Color = Color.Green
            EmpMultiDayPickingChart.Series("PrePack").ChartType = chartdisplaytype
        End If
    End Sub

    Private Sub LoadVisibleEmps(Optional CBList As List(Of CheckBox) = Nothing)
        If CheckBoxPanel.Controls.Count > 0 Then
            CheckBoxPanel.Controls.Clear()
        End If

        Dim verticalBoost As Integer = 4
        Dim EmpTotal As Integer = 0
        For Each emp As Employee In empsColl.Employees
            If emp.Visible = True Then
                Dim empCheckbox As New CheckBox
                empCheckbox.Name = "emp" + emp.PayrollId.ToString
                empCheckbox.Text = "(" + emp.PayrollId.ToString + ") " + emp.FullName
                AddHandler empCheckbox.CheckedChanged, AddressOf CountEmps
                EmpTotal += 1
                Dim newPoint As New Point(4, verticalBoost)
                verticalBoost += 20
                CheckBoxPanel.Controls.Add(empCheckbox)
                CheckBoxPanel.Controls(CheckBoxPanel.Controls.Count - 1).Location = newPoint
                empCheckbox.Checked = False
                If Not IsNothing(CBList) Then
                    For Each CB In CBList
                        If CB.Name = empCheckbox.Name Then
                            empCheckbox.Checked = CB.Checked
                        End If
                    Next
                Else
                End If

                CheckBoxPanel.Controls(CheckBoxPanel.Controls.Count - 1).AutoSize = False
                CheckBoxPanel.Controls(CheckBoxPanel.Controls.Count - 1).Size = New Size(160, 25)
            End If
        Next
        EmpCountLbl.Text = EmpTotal.ToString
    End Sub

    Private Function GetRelevantEmployees() As List(Of Employee)
        Dim newEmpList As New List(Of Employee)

        'If we have controls to work with.
        If CheckBoxPanel.Controls.Count > 0 Then
            'Get them all
            For Each CB As Object In CheckBoxPanel.Controls
                'Are they checkboxes?
                If CB.GetType = GetType(CheckBox) Then
                    'Are they checked?
                    If CB.Checked Then
                        'Get our employee ID from our preset text
                        Dim empID As String = CB.Text.Split(")")(0).Replace("(", "").Replace(")", "")
                        'Did I do it right?
                        If IsNumeric(empID) Then
                            'Lets get our employee
                            Dim foundEmp As Employee = empsColl.FindEmployeeByID(empID)
                            'Ensure we got one
                            If Not IsNothing(foundEmp) Then
                                'Go
                                newEmpList.Add(foundEmp)
                            End If
                        End If
                    End If
                End If
            Next
        End If
        'This can indeed return without anything, this has to be accounted for.
        Return newEmpList
    End Function

    Private Sub ProcessMultiDayAnalyticsData(empStatsList As List(Of EmpStats))
        LargestValue = 0
        Dim EveryOrderAmount As Integer = 0
        Dim EveryHourAmount As Double = 0
        Dim EmpTotalDictionary As New Dictionary(Of Integer, Double)
        Dim EmpTotalHighest As Double = 0
        For Each emp In empStatsList 'For every employee on every day

            '/////SETTING UP/////
            Dim totalPickingSHours As Double = 0
            Dim totalPickingBHours As Double = 0
            Dim totalPickingMHours As Double = 0

            Dim totalPackingSHours As Double = 0
            Dim totalPackingBHours As Double = 0
            Dim totalPackingMHours As Double = 0

            Dim totalPrepackHours As Double = 0

            Dim totalPickingSQuantity As Double = 0
            Dim totalPickingBQuantity As Double = 0
            Dim totalPickingMQuantity As Double = 0

            Dim totalPackingSQuantity As Double = 0
            Dim totalPackingBQuantity As Double = 0
            Dim totalPackingMQuantity As Double = 0

            Dim totalPrepackQuantity As Double = 0

            Dim ListOfPickingSessions As New List(Of SessionAnalytic)
            Dim ListOfPackingSessions As New List(Of SessionAnalytic)
            Dim ListOfPrepackSessions As New List(Of SessionAnalytic)
            For Each day As Date In ListOfDates
                Try
                    ListOfPickingSessions.AddRange(emp.allSessions(day).Where(Function(SesA As SessionAnalytic) (SesA.SessionType = SessionType.Picking)))
                Catch ex As System.Collections.Generic.KeyNotFoundException
                End Try
                Try
                    ListOfPackingSessions.AddRange(emp.allSessions(day).Where(Function(SesA As SessionAnalytic) (SesA.SessionType = SessionType.Packing)))
                Catch ex As System.Collections.Generic.KeyNotFoundException
                End Try
                Try
                    ListOfPrepackSessions.AddRange(emp.allSessions(day).Where(Function(SesA As SessionAnalytic) (SesA.SessionType = SessionType.Prepack)))
                Catch ex As System.Collections.Generic.KeyNotFoundException
                End Try
            Next

            For Each session As SessionAnalytic In ListOfPickingSessions
                If session.Picktype = Orders.ItemPicklistType.SingleFirst Or session.Picktype = Orders.ItemPicklistType.SingleSecond Then
                    If session.BoxedOrder Then
                        totalPickingBHours += session.TimeSpan.TotalHours
                        totalPickingBQuantity += session.OrderCount
                    Else
                        totalPickingSHours += session.TimeSpan.TotalHours
                        totalPickingSQuantity += session.OrderCount
                    End If
                ElseIf session.Picktype = Orders.ItemPicklistType.MultiSameFirst Or session.Picktype = Orders.ItemPicklistType.MultiSameSecond Or session.Picktype = Orders.ItemPicklistType.MultiMixedFirst Or session.Picktype = Orders.ItemPicklistType.MultiMixedSecond Then
                    totalPickingMHours += session.TimeSpan.TotalHours
                    totalPickingMQuantity += session.OrderCount
                End If
            Next

            For Each session As SessionAnalytic In ListOfPackingSessions
                If session.Picktype = Orders.ItemPicklistType.SingleFirst Or session.Picktype = Orders.ItemPicklistType.SingleSecond Then
                    If session.BoxedOrder Then
                        totalPackingBHours += session.TimeSpan.TotalHours
                        totalPackingBQuantity += session.OrderCount
                    Else
                        totalPackingSHours += session.TimeSpan.TotalHours
                        totalPackingSQuantity += session.OrderCount
                    End If
                ElseIf session.Picktype = Orders.ItemPicklistType.MultiSameFirst Or session.Picktype = Orders.ItemPicklistType.MultiSameSecond Or session.Picktype = Orders.ItemPicklistType.MultiMixedFirst Or session.Picktype = Orders.ItemPicklistType.MultiMixedSecond Then
                    totalPackingMHours += session.TimeSpan.TotalHours
                    totalPackingMQuantity += session.OrderCount
                End If
            Next

            For Each session As SessionAnalytic In ListOfPrepackSessions
                totalPrepackHours += session.TimeSpan.TotalHours
                totalPrepackQuantity += session.OrderCount
            Next

            Dim empsNumberGatherer As New totalNumberGatherer(totalPickingSHours, totalPickingSQuantity, totalPickingBHours, totalPickingBQuantity, totalPickingMHours, totalPickingMQuantity, totalPackingSHours, totalPackingSQuantity, totalPackingBHours, totalPackingBQuantity, totalPackingMHours, totalPackingMQuantity, totalPrepackHours, totalPrepackQuantity)

            '/////ROW CALCULATIONS/////

            Dim ndgvr As New DataGridViewRow
            ndgvr.CreateCells(WarehouseMultiDayStatsTable)
            ndgvr.Cells(0).Value = emp.EmpID.ToString + " (" + empsColl.FindEmployeeByID(emp.EmpID).FullName + ")"


            If TimeSpentRadio.Checked = True Then
                If totalPickingSHours > 0 Then
                    ndgvr.Cells(1).Value = Math.Round(totalPickingSHours, 2)
                Else
                    ndgvr.Cells(1).Value = 0.00
                End If

                If totalPickingBHours > 0 Then
                    ndgvr.Cells(2).Value = Math.Round(totalPickingBHours, 2)
                Else
                    ndgvr.Cells(2).Value = 0.00
                End If

                If totalPickingMHours > 0 Then
                    ndgvr.Cells(3).Value = Math.Round(totalPickingMHours, 2)
                Else
                    ndgvr.Cells(3).Value = 0.00
                End If

                If totalPackingSHours > 0 Then
                    ndgvr.Cells(4).Value = Math.Round(totalPackingSHours, 2)
                Else
                    ndgvr.Cells(4).Value = 0.00
                End If

                If totalPackingBHours > 0 Then
                    ndgvr.Cells(5).Value = Math.Round(totalPackingBHours, 2)
                Else
                    ndgvr.Cells(5).Value = 0.00
                End If

                If totalPackingMHours > 0 Then
                    ndgvr.Cells(6).Value = Math.Round(totalPackingMHours, 2)
                Else
                    ndgvr.Cells(6).Value = 0.00
                End If

                If totalPrepackHours > 0 Then
                    ndgvr.Cells(7).Value = Math.Round(totalPrepackHours, 2)
                Else
                    ndgvr.Cells(7).Value = 0.00
                End If

            ElseIf TotalRadio.Checked = True Then
                If totalPickingSQuantity > 0 Then
                    ndgvr.Cells(1).Value = Math.Round(totalPickingSQuantity, 2)
                Else
                    ndgvr.Cells(1).Value = 0.00
                End If

                If totalPickingBQuantity > 0 Then
                    ndgvr.Cells(2).Value = Math.Round(totalPickingBQuantity, 2)
                Else
                    ndgvr.Cells(2).Value = 0.00
                End If

                If totalPickingMQuantity > 0 Then
                    ndgvr.Cells(3).Value = Math.Round(totalPickingMQuantity, 2)
                Else
                    ndgvr.Cells(3).Value = 0.00
                End If

                If totalPackingSQuantity > 0 Then
                    ndgvr.Cells(4).Value = Math.Round(totalPackingSQuantity, 2)
                Else
                    ndgvr.Cells(4).Value = 0.00
                End If

                If totalPackingBQuantity > 0 Then
                    ndgvr.Cells(5).Value = Math.Round(totalPackingBQuantity, 2)
                Else
                    ndgvr.Cells(5).Value = 0.00
                End If

                If totalPackingMQuantity > 0 Then
                    ndgvr.Cells(6).Value = Math.Round(totalPackingMQuantity, 2)
                Else
                    ndgvr.Cells(6).Value = 0.00
                End If

                If totalPrepackQuantity > 0 Then
                    ndgvr.Cells(7).Value = Math.Round(totalPrepackQuantity, 2)
                Else
                    ndgvr.Cells(7).Value = 0.00
                End If
            ElseIf AverageRadio.Checked = True Then
                If totalPickingSQuantity > 0 And totalPickingSHours > 0 Then
                    ndgvr.Cells(1).Value = Math.Round(totalPickingSQuantity / totalPickingSHours, 2)
                Else
                    ndgvr.Cells(1).Value = 0.00
                End If

                If totalPickingBQuantity > 0 And totalPickingBHours > 0 Then
                    ndgvr.Cells(2).Value = Math.Round(totalPickingBQuantity / totalPickingBHours, 2)
                Else
                    ndgvr.Cells(2).Value = 0.00
                End If

                If totalPickingMQuantity > 0 And totalPickingMHours > 0 Then
                    ndgvr.Cells(3).Value = Math.Round(totalPickingMQuantity / totalPickingMHours, 2)
                Else
                    ndgvr.Cells(3).Value = 0.00
                End If

                If totalPackingSQuantity > 0 And totalPackingSHours > 0 Then
                    ndgvr.Cells(4).Value = Math.Round(totalPackingSQuantity / totalPackingSHours, 2)
                Else
                    ndgvr.Cells(4).Value = 0.00
                End If

                If totalPackingBQuantity > 0 And totalPackingBHours > 0 Then
                    ndgvr.Cells(5).Value = Math.Round(totalPackingBQuantity / totalPackingBHours, 2)
                Else
                    ndgvr.Cells(5).Value = 0.00
                End If

                If totalPackingMQuantity > 0 And totalPackingMHours > 0 Then
                    ndgvr.Cells(6).Value = Math.Round(totalPackingMQuantity / totalPackingMHours, 2)
                Else
                    ndgvr.Cells(6).Value = 0.00
                End If

                If totalPrepackQuantity > 0 And totalPrepackHours > 0 Then
                    ndgvr.Cells(7).Value = Math.Round(totalPrepackQuantity / totalPrepackHours, 2)
                Else
                    ndgvr.Cells(7).Value = 0.00
                End If

                Dim totalHours As Double = totalPickingBHours + totalPickingSHours + totalPickingMHours + totalPackingBHours + totalPackingSHours + totalPackingMHours + totalPrepackHours
                Dim totalQuantity As Double = totalPickingBQuantity + totalPickingSQuantity + totalPickingMQuantity + totalPackingBQuantity + totalPackingSQuantity + totalPackingMQuantity + totalPrepackQuantity

                '        Dim newKVP As New KeyValuePair(Of Double, Double)(totalQuantity, totalHours)
                '        ndgvr.Tag = newKVP
            End If

            If PickPackChosen.Checked = True Then
                If CheckPickSingle.Checked = True Then EmpMultiDayPickingChart.Series("PickingSingle").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(1).Value)
                If CheckPickBox.Checked = True Then EmpMultiDayPickingChart.Series("PickingBoxed").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(2).Value)
                If CheckPickMulti.Checked = True Then EmpMultiDayPickingChart.Series("PickingMulti").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(3).Value)
                If CheckPackSingle.Checked = True Then EmpMultiDayPickingChart.Series("PackingSingle").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(4).Value)
                If CheckPackBox.Checked = True Then EmpMultiDayPickingChart.Series("PackingBoxed").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(5).Value)
                If CheckPackMulti.Checked = True Then EmpMultiDayPickingChart.Series("PackingMulti").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(6).Value)
            Else
                If PrepackChosen.Checked = True Then EmpMultiDayPickingChart.Series("PrePack").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(7).Value)
            End If

            Dim totalNum As Double = ndgvr.Cells(1).Value + ndgvr.Cells(2).Value + ndgvr.Cells(3).Value + ndgvr.Cells(4).Value + ndgvr.Cells(5).Value + ndgvr.Cells(6).Value + ndgvr.Cells(7).Value
            If totalNum > LargestValue Then
                LargestValue = totalNum
            End If

            WarehouseMultiDayStatsTable.Rows.Add(ndgvr)
        Next

        ''OH MAN I HATE THIS SO MUCH

        If ExcludePercCheck.Checked Then
            For Each record In EmpTotalDictionary
                If record.Value < ((EmpTotalHighest / 100) * ExcludePercTxt.Text) Then
                    'Dim collectedDataPoints As New List(Of DataVisualization.Charting.DataPoint)
                    '(empsColl.FindEmployeeByID(record.Key).FullName)
                    If PickPackChosen.Checked Then
                        If CheckPickSingle.Checked Then
                            Try
                                Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PickingSingle").Points
                                For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                    If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                        thecoll.Remove(datapointobject)
                                        'datapointobject = Nothing
                                    End If
                                Next
                            Catch ex As Exception

                            End Try

                        End If
                        If CheckPackSingle.Checked Then
                            Try
                                Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PackingSingle").Points
                                For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                    If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                        thecoll.Remove(datapointobject)
                                        'datapointobject = Nothing
                                    End If
                                Next
                            Catch ex As Exception

                            End Try
                        End If
                        If CheckPickBox.Checked Then
                            Try
                                Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PickingBoxed").Points
                                For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                    If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                        thecoll.Remove(datapointobject)
                                        'datapointobject = Nothing
                                    End If
                                Next
                            Catch ex As Exception

                            End Try
                        End If
                        If CheckPackBox.Checked Then
                            Try
                                Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PackingBoxed").Points
                                For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                    If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                        thecoll.Remove(datapointobject)
                                        'datapointobject = Nothing
                                    End If
                                Next
                            Catch ex As Exception

                            End Try
                        End If
                        If CheckPickMulti.Checked Then
                            Try
                                Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PickingMulti").Points
                                For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                    If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                        thecoll.Remove(datapointobject)
                                        'datapointobject = Nothing
                                    End If
                                Next
                            Catch ex As Exception

                            End Try
                        End If
                        If CheckPackMulti.Checked Then
                            Try
                                Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PackingMulti").Points
                                For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                    If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                        thecoll.Remove(datapointobject)
                                        'datapointobject = Nothing
                                    End If
                                Next
                            Catch ex As Exception

                            End Try
                        End If


                    ElseIf PrepackChosen.Checked Then
                        Try
                            Dim thecoll As DataVisualization.Charting.DataPointCollection = EmpMultiDayPickingChart.Series("PrePack").Points
                            For Each datapointobject As DataVisualization.Charting.DataPoint In thecoll
                                If datapointobject.AxisLabel = empsColl.FindEmployeeByID(record.Key).FullName Then
                                    thecoll.Remove(datapointobject)
                                    'datapointobject = Nothing
                                End If
                            Next
                        Catch ex As Exception

                        End Try
                    End If

                End If
            Next
        End If

        EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisY.Interval = (Math.Round(LargestValue / 20) / 10) * 10
        EmpMultiDayPickingChart.ChartAreas("ChartArea1").AxisX.Interval = 0.5

        If EveryHourAmount > 0 Then
            OrdersPerHourLbl.Text = (Math.Round(EveryOrderAmount / EveryHourAmount, 0)).ToString + " orders per hour."
        End If
    End Sub


    Public Function GetEmployeeStats(ID As String) As EmpStats 'Dictionary(Of Date, DailyAnalytic) 'AGH
        'Dim Text As String
        Dim Loader As New GenericDataController
        Try
            If IsNumeric(ID) Then
                If My.Computer.FileSystem.FileExists("T:\AppData\Analytics\" + ID + ".anal") Then
                    Dim analyticsfile As WHLClasses.WarehouseAnalytics.AnalyticBase = Loader.LoadAnything("T:\AppData\Analytics\" + ID + ".anal", False).Value
                    Dim date1str As String = FirstDate.Value.ToString("yyyy/MM/dd")
                    Dim date2str As String = SecondDate.Value.ToString("yyyy/MM/dd")
                    Dim Date1 As Date = date1str
                    Dim Date2 As Date = date2str
                    Dim workCounted As Boolean = False
                    Dim allSessions As New Dictionary(Of Date, List(Of SessionAnalytic))
                    Dim dayCount As Integer = 0
                    While Date1 <= Date2
                        Dim sessionDone As Integer
                        'Dim timeToPass As TimeSpan = TimeSpan.FromMinutes(1)
                        Try
                            Dim sessionList As New List(Of SessionAnalytic)
                            For Each session As SessionAnalytic In analyticsfile.Data(Date1).Sessions
                                sessionDone = session.OrderCount
                                If sessionDone > 2 Then
                                    sessionList.Add(session)
                                    workCounted = True
                                End If
                            Next
                            allSessions.Add(Date1, sessionList)
                            dayCount += 1
                        Catch ex As System.Collections.Generic.KeyNotFoundException
                            'This is fine, don't let this get caught by the OTHER try, it'll override the result.
                        End Try
                        Date1 = Date1.AddDays(1)
                    End While

                    If workCounted Then
                        Dim employeeStats As New EmpStats(ID, allSessions)
                        Return employeeStats
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        Return Nothing
    End Function

    Private Sub ExcludePercTxt_TextChanged(sender As Object, e As EventArgs) Handles ExcludePercTxt.LostFocus
        If Not IsNumeric(ExcludePercTxt.Text) Then
            ExcludePercTxt.Text = "2"
        End If
    End Sub

    Private Sub AllEmpsBtn_Click(sender As Object, e As EventArgs) Handles AllEmpsBtn.Click
        For Each CB As CheckBox In CheckBoxPanel.Controls
            CB.Checked = True
        Next
    End Sub
    Private Sub NoEmpsBtn_Click(sender As Object, e As EventArgs) Handles NoEmpsBtn.Click
        For Each CB As CheckBox In CheckBoxPanel.Controls
            CB.Checked = False
        Next
    End Sub
    Private Sub CountEmps()
        Dim TotalEmpsChecked As Integer = 0
        For Each CB As CheckBox In CheckBoxPanel.Controls
            If CB.Checked Then TotalEmpsChecked += 1
        Next
        EmpSelectedLbl.Text = TotalEmpsChecked.ToString
    End Sub

    Private Sub RefreshEmpsBtn_Click(sender As Object, e As EventArgs) Handles RefreshEmpsBtn.Click
        Dim ControlList As New List(Of CheckBox)
        For Each ctrlObj As Control In CheckBoxPanel.Controls
            If ctrlObj.GetType = GetType(CheckBox) Then
                ControlList.Add(ctrlObj)
            End If
        Next
        LoadVisibleEmps(ControlList)
    End Sub

    Private Sub PickPackChosen_CheckedChanged(sender As Object, e As EventArgs) Handles PickPackChosen.Click
        LoadPickPackData = True
        PickPackPanel.Enabled = True

        LoadPrepackData = False
        PrepackPanel.Enabled = False
    End Sub
    Private Sub PrepackChosen_CheckedChanged(sender As Object, e As EventArgs) Handles PrepackChosen.Click
        LoadPickPackData = False
        PickPackPanel.Enabled = False

        LoadPrepackData = True
        PrepackPanel.Enabled = True
    End Sub

    Private Sub CheckPickSingle_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPickSingle.CheckedChanged
        LoadPickSinglesData = CheckPickSingle.Checked
    End Sub

    Private Sub CheckPickBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPickBox.CheckedChanged
        LoadPickBoxedData = CheckPickBox.Checked
    End Sub

    Private Sub CheckPickMulti_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPickMulti.CheckedChanged
        LoadPickMultisData = CheckPickMulti.Checked
    End Sub

    Private Sub CheckPackSingle_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPackSingle.CheckedChanged
        LoadPackSinglesData = CheckPackSingle.Checked
    End Sub

    Private Sub CheckPackBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPackBox.CheckedChanged
        LoadPackBoxedData = CheckPackBox.Checked
    End Sub

    Private Sub CheckPackMulti_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPackMulti.CheckedChanged
        LoadPackMultisData = CheckPackMulti.Checked
    End Sub

End Class
