﻿Imports WHLClasses
Imports WHLClasses.WarehouseAnalytics

Public Class Form1
    Dim empsColl As New EmployeeCollection

    Private Sub LoadData() Handles MyBase.Load
        NoSplitRadio.Checked = True
    End Sub

    Private Sub LoadAnalyticsBtn_Click(sender As Object, e As EventArgs) Handles LoadAnalyticsBtn.Click
        Dim empStatsList As New List(Of EmpStats)
        For Each emp As Employee In empsColl.Employees
            Dim newEmpStats As EmpStats = GetEmployeeStats(emp.PayrollId) '
            If Not newEmpStats Is Nothing Then
                empStatsList.Add(newEmpStats)
            End If
        Next

        'So now we have EVERY employee's stats. We have our main loading done. We just need to put it on a graph...
        'Thankfully, it's not hard to find a tutorial http://www.visual-basic-tutorials.com/display-data-as-charts-and-graph-in-visual-basic.html
        'Oh, you apply your own references to your copy-pastes? Nope. t(*u*t )

        'Adding a bar of data to each employee
        Try
            EmpPickingChart.Series.Clear()
        Catch ex As Exception

        End Try

        'Neutralise Time.
        Dim date1str As String = FirstDate.Value.ToString("yyyy/MM/dd")
        Dim date2str As String = SecondDate.Value.ToString("yyyy/MM/dd")
        Dim Date1 As Date = date1str
        Dim Date2 As Date = date2str

        'List of dates, because doing everything else in a while loop is... silly.
        Dim ListOfDates As New List(Of Date)
        While Date1 <= Date2
            ListOfDates.Add(Date1)
            Date1 = Date1.AddDays(1)
        End While

        'Mandatory chart setup
        SetUpTables()

        If NoSplitRadio.Checked = True Then
            NoSplit(empStatsList, ListOfDates)
        ElseIf PickPackSplitRadio.Checked = True Then
            SplitByPickPack(empStatsList, ListOfDates)
        ElseIf PicklistSplitRadio.Checked = True Then
            SplitByPickList(empStatsList, ListOfDates)
        End If

        '-----Old code - Resulted in a better table than the previous one... Not by much.
        'For Each emp In empStatsList 'For every employee on every day
        '    Try
        '        EmpPickingChart.Series.Add("Picking")
        '        EmpPickingChart.Series.Add("Packing")
        '        EmpPickingChart.Series("Picking")("PixelPointWidth") = "40"
        '        EmpPickingChart.Series("Packing")("PixelPointWidth") = "40"
        '        EmpPickingChart.Series("Picking").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        '        EmpPickingChart.Series("Packing").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        '        'EmpPickingChart.Series.Add(day.ToString("yyyy/MM/dd") + " Picking")
        '        'EmpPackingChart.Series.Add(day.ToString("yyyy/MM/dd") + " Packing")
        '        'EmpPickingChart.Series(day.ToString("yyyy/MM/dd") + " Picking")("PixelPointWidth") = "40"
        '        'EmpPackingChart.Series(day.ToString("yyyy/MM/dd") + " Packing")("PixelPointWidth") = "40"
        '        'EmpPickingChart.Series(day.ToString("yyyy/MM/dd") + " Picking").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        '        'EmpPackingChart.Series(day.ToString("yyyy/MM/dd") + " Packing").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        '    Catch ex As ArgumentException
        '        'Will happen if the "series" exists
        '    End Try

        '    Dim totalPickingHours As Double = 0
        '    Dim totalPackingHours As Double = 0

        '    Dim ListOfSessions As New List(Of SessionAnalytic)
        '    For Each day As Date In ListOfDates
        '        Try
        '            For Each session As SessionAnalytic In emp.allSessions(day)
        '                ListOfSessions.Add(session)
        '            Next

        '        Catch ex As System.Collections.Generic.KeyNotFoundException

        '        End Try
        '    Next

        '    For Each session As SessionAnalytic In ListOfSessions
        '        If session.SessionType = SessionType.Packing Then
        '            totalPackingHours += session.TimeSpan.TotalHours
        '        Else
        '            totalPickingHours += session.TimeSpan.TotalHours
        '        End If
        '    Next
        '    EmpPickingChart.Series("Packing").Points.AddXY(emp.EmpID, totalPackingHours)
        '    EmpPickingChart.Series("Picking").Points.AddXY(emp.EmpID, totalPickingHours)
        '    'EmpPackingChart.Series(day.ToString("yyyy/MM/dd") + " Packing").Points.AddXY(emp.EmpID, totalPackingHours)
        '    'EmpPickingChart.Series(day.ToString("yyyy/MM/dd") + " Picking").Points.AddXY(emp.EmpID, totalPickingHours)
        'Next



        '-----OLD - resulted in a table though

        'For Each emp In empStatsList
        '    EmpAnalyticsChart.Series.Add(emp.EmpID + " Picking")
        '    EmpAnalyticsChart.Series(emp.EmpID + " Picking")("PixelPointWidth") = "100"

        '    Dim date1str As String = FirstDate.Value.ToString("yyyy/MM/dd")
        '    Dim date2str As String = SecondDate.Value.ToString("yyyy/MM/dd")
        '    Dim Date1 As Date = date1str
        '    Dim Date2 As Date = date2str

        '    While Date1 <= Date2
        '        Try
        '            For Each session As SessionAnalytic In emp.allSessions(Date1)
        '                EmpAnalyticsChart.Series(emp.EmpID + " Picking").Points.AddXY(Date1, emp.allSessions(Date1).Count)
        '            Next
        '        Catch ex As System.Collections.Generic.KeyNotFoundException
        '        End Try
        '        Date1 = Date1.AddDays(1)
        '    End While
        'Next
    End Sub

    Private Sub SetUpTables()
        'We want to see EVERY employee on a scale to the hour.
        EmpPickingChart.ChartAreas("ChartArea1").AxisY.Interval = 1
        EmpPickingChart.ChartAreas("ChartArea1").AxisX.Interval = 1
        EmpPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Hours"
        EmpPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
    End Sub

    Private Sub NoSplit(empStatsList As List(Of EmpStats), ListOfDates As List(Of Date))
        Try
            EmpPickingChart.Series.Add("Full Data")
            EmpPickingChart.Series("Full Data")("PixelPointWidth") = "40"
            EmpPickingChart.Series("Full Data").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Catch ex As ArgumentException
        End Try

        For Each emp In empStatsList 'For every employee on every day

            Dim totalHours As Double = 0

            Dim ListOfSessions As New List(Of SessionAnalytic)
            For Each day As Date In ListOfDates
                Try
                    For Each session As SessionAnalytic In emp.allSessions(day)
                        ListOfSessions.Add(session)
                    Next
                Catch ex As System.Collections.Generic.KeyNotFoundException
                End Try
            Next

            For Each session As SessionAnalytic In ListOfSessions
                totalHours += session.TimeSpan.TotalHours
            Next
            EmpPickingChart.Series("Full Data").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalHours)
        Next
    End Sub

    Private Sub SplitByPickPack(empStatsList As List(Of EmpStats), ListOfDates As List(Of Date))
        Try
            EmpPickingChart.Series.Add("Picking")
            EmpPickingChart.Series.Add("Packing")
            EmpPickingChart.Series("Picking")("PixelPointWidth") = "40"
            EmpPickingChart.Series("Packing")("PixelPointWidth") = "40"
            EmpPickingChart.Series("Picking").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("Packing").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Catch ex As ArgumentException
        End Try

        For Each emp In empStatsList 'For every employee on every day

            Dim totalPickingHours As Double = 0
            Dim totalPackingHours As Double = 0

            Dim ListOfSessions As New List(Of SessionAnalytic)
            For Each day As Date In ListOfDates
                Try
                    For Each session As SessionAnalytic In emp.allSessions(day)
                        ListOfSessions.Add(session)
                    Next
                Catch ex As System.Collections.Generic.KeyNotFoundException
                End Try
            Next

            For Each session As SessionAnalytic In ListOfSessions
                If session.SessionType = SessionType.Packing Then
                    totalPackingHours += session.TimeSpan.TotalHours
                Else
                    totalPickingHours += session.TimeSpan.TotalHours
                End If
            Next
            EmpPickingChart.Series("Packing").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPackingHours)
            EmpPickingChart.Series("Picking").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPickingHours)
        Next
    End Sub

    Private Sub SplitByPickList(empStatsList As List(Of EmpStats), ListOfDates As List(Of Date))

        Try
            EmpPickingChart.Series.Add("PickingSingle")
            EmpPickingChart.Series.Add("PickingMulti")
            EmpPickingChart.Series.Add("PickingMixed")
            EmpPickingChart.Series.Add("PickingCourier")

            EmpPickingChart.Series.Add("PackingSingle")
            EmpPickingChart.Series.Add("PackingMulti")
            EmpPickingChart.Series.Add("PackingMixed")
            EmpPickingChart.Series.Add("PackingCourier")

            EmpPickingChart.Series("PickingSingle")("PixelPointWidth") = "40"
            EmpPickingChart.Series("PickingMulti")("PixelPointWidth") = "40"
            EmpPickingChart.Series("PickingMixed")("PixelPointWidth") = "40"
            EmpPickingChart.Series("PickingCourier")("PixelPointWidth") = "40"

            EmpPickingChart.Series("PackingSingle")("PixelPointWidth") = "40"
            EmpPickingChart.Series("PackingMulti")("PixelPointWidth") = "40"
            EmpPickingChart.Series("PackingMixed")("PixelPointWidth") = "40"
            EmpPickingChart.Series("PackingCourier")("PixelPointWidth") = "40"

            EmpPickingChart.Series("PickingSingle").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("PickingMulti").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("PickingMixed").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("PickingCourier").ChartType = DataVisualization.Charting.SeriesChartType.Bar

            EmpPickingChart.Series("PackingSingle").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("PackingMulti").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("PackingMixed").ChartType = DataVisualization.Charting.SeriesChartType.Bar
            EmpPickingChart.Series("PackingCourier").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Catch ex As ArgumentException
        End Try

        For Each emp In empStatsList 'For every employee on every day

            Dim totalPickingSHours As Double = 0
            Dim totalPickingMHours As Double = 0
            Dim totalPickingMMHours As Double = 0
            Dim totalPickingPFHours As Double = 0

            Dim totalPackingSHours As Double = 0
            Dim totalPackingMHours As Double = 0
            Dim totalPackingMMHours As Double = 0
            Dim totalPackingPFHours As Double = 0

            Dim ListOfSessions As New List(Of SessionAnalytic)
            For Each day As Date In ListOfDates
                Try
                    For Each session As SessionAnalytic In emp.allSessions(day)
                        ListOfSessions.Add(session)
                    Next
                Catch ex As System.Collections.Generic.KeyNotFoundException
                End Try
            Next

            For Each session As SessionAnalytic In ListOfSessions
                If session.SessionType = SessionType.Picking Then
                    If session.Picktype = Orders.ItemPicklistType.SingleFirst Or session.Picktype = Orders.ItemPicklistType.SingleSecond Then
                        totalPickingSHours += session.TimeSpan.TotalHours

                    ElseIf session.Picktype = Orders.ItemPicklistType.MultiSameFirst Or session.Picktype = Orders.ItemPicklistType.MultiSameSecond Then
                        totalPickingMHours += session.TimeSpan.TotalHours

                    ElseIf session.Picktype = Orders.ItemPicklistType.MultiMixedFirst Or session.Picktype = Orders.ItemPicklistType.MultiMixedSecond Then
                        totalPickingMMHours += session.TimeSpan.TotalHours

                    ElseIf session.Picktype = Orders.ItemPicklistType.Courier Or session.Picktype = Orders.ItemPicklistType.Resend Then
                        totalPickingPFHours += session.TimeSpan.TotalHours

                    End If
                Else
                    If session.Picktype = Orders.ItemPicklistType.SingleFirst Or session.Picktype = Orders.ItemPicklistType.SingleSecond Then
                        totalPackingSHours += session.TimeSpan.TotalHours

                    ElseIf session.Picktype = Orders.ItemPicklistType.MultiSameFirst Or session.Picktype = Orders.ItemPicklistType.MultiSameSecond Then
                        totalPackingMHours += session.TimeSpan.TotalHours

                    ElseIf session.Picktype = Orders.ItemPicklistType.MultiMixedFirst Or session.Picktype = Orders.ItemPicklistType.MultiMixedSecond Then
                        totalPackingMMHours += session.TimeSpan.TotalHours

                    ElseIf session.Picktype = Orders.ItemPicklistType.Courier Or session.Picktype = Orders.ItemPicklistType.Resend Then
                        totalPackingPFHours += session.TimeSpan.TotalHours

                    End If
                End If
            Next

            EmpPickingChart.Series("PickingSingle").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPickingSHours)
            EmpPickingChart.Series("PickingMulti").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPickingMHours)
            EmpPickingChart.Series("PickingMixed").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPickingMMHours)
            EmpPickingChart.Series("PickingCourier").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPickingPFHours)

            EmpPickingChart.Series("PackingSingle").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPackingSHours)
            EmpPickingChart.Series("PackingMulti").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPackingMHours)
            EmpPickingChart.Series("PackingMixed").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPackingMMHours)
            EmpPickingChart.Series("PackingCourier").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalPackingPFHours)

        Next
    End Sub


    Public Function GetEmployeeStats(ID As String) As EmpStats 'Dictionary(Of Date, DailyAnalytic) 'AGH
        Dim Text As String
        Dim Loader As New GenericDataController
        Try
            If IsNumeric(ID) Then
                If My.Computer.FileSystem.FileExists("T:\AppData\Analytics\" + ID + ".anal") Then
                    Dim analyticsfile As WHLClasses.WarehouseAnalytics.AnalyticBase = Loader.LoadAnything("T:\AppData\Analytics\" + ID + ".anal", False).Value
                    Dim date1str As String = FirstDate.Value.ToString("yyyy/MM/dd")
                    Dim date2str As String = SecondDate.Value.ToString("yyyy/MM/dd")
                    Dim Date1 As Date = date1str
                    Dim Date2 As Date = date2str

                    'HOW do I get a daily analytic?
                    'Dim dailyAnalytics As New Dictionary(Of Date, DailyAnalytic)
                    'For Each day As Date In analyticsfile.Data.Keys
                    '    dailyAnalytics.Add(day, analyticsfile.Data(day))
                    'Next

                    'Return dailyAnalytics
                    'Oh. That was actually pretty easy. Too bad it's useless for the graph because of how it returns. THANKS CHARTS.

                    '--------------Old stuff. This might be useful though for tearing data out of daily analytics. Keep it.

                    Dim allSessions As New Dictionary(Of Date, List(Of SessionAnalytic))
                    Dim dayCount As Integer = 0
                    While Date1 <= Date2
                        Try
                            Dim sessionList As New List(Of SessionAnalytic)
                            For Each session As SessionAnalytic In analyticsfile.Data(Date1).Sessions
                                sessionList.Add(session)
                            Next
                            allSessions.Add(Date1, sessionList)

                        Catch ex As System.Collections.Generic.KeyNotFoundException
                            'This is fine, don't let this get caught by the OTHER try, it'll override the result.
                        End Try
                        dayCount += 1
                        Date1 = Date1.AddDays(1)
                    End While

                    Dim employeeStats As New EmpStats(ID, allSessions)
                    Return employeeStats


                    'Now we have all the sessions for that person.

                    '///TEMPORARY RESULT///'    More than anything, this is my own proof of concept. If this works, it'll work. Thank God it does.
                    'If dayCount = 1 Then
                    '    Text = allSessions.Count.ToString + " records in " + dayCount.ToString + " day." + vbNewLine
                    '    For Each sessionlist In allSessions.Keys
                    '        Text += allSessions(sessionlist).Count.ToString + " on " + sessionlist.ToString("yyyy/MM/dd") + vbNewLine
                    '    Next
                    'Else
                    '    Text = allSessions.Count.ToString + " in " + dayCount.ToString + " days." + vbNewLine
                    '    For Each sessionlist In allSessions.Keys
                    '        Text += allSessions(sessionlist).Count.ToString + " on " + sessionlist.ToString("yyyy/MM/dd") + vbNewLine
                    '    Next
                    'End If
                    '///MAKE GRAPHS HERE///'
                Else
                    'Text = "File does not exist."
                End If
            Else
                'Text = "An ID number is needed"
            End If
        Catch ex As Exception
            'Text = ex.Message
        End Try

        'ReportLbl.Text = Text
        Return Nothing
    End Function

    Private Sub NoSplitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles NoSplitRadio.Click
        PickPackSplitRadio.Checked = False
        PicklistSplitRadio.Checked = False
        NoSplitRadio.Checked = True
    End Sub

    Private Sub PickPackSplitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PickPackSplitRadio.Click
        NoSplitRadio.Checked = False
        PicklistSplitRadio.Checked = False
        PickPackSplitRadio.Checked = True
    End Sub

    Private Sub PicklistSplitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PicklistSplitRadio.Click
        NoSplitRadio.Checked = False
        PickPackSplitRadio.Checked = False
        PicklistSplitRadio.Checked = True
    End Sub
End Class