Imports WHLClasses
Imports WHLClasses.WarehouseAnalytics

Public Class AnalyticsBaseForm
    Dim empsColl As New EmployeeCollection
    Dim LargestValue As Integer = 0
    Public Auth As New Authentication.AuthClass

    Private Sub LoadData() Handles MyBase.Load
        NoSplitRadio.Checked = True
        AverageRadio.Checked = True
    End Sub

    Private Sub LoadAnalyticsBtn_Click(sender As Object, e As EventArgs) Handles LoadAnalyticsBtn.Click
        HideWarning()
        If Not IsNothing(Auth.AuthenticatedUser) Then
            If Auth.AuthenticatedUser.Permissions.canViewAnalytics Then
                Dim empStatsList As New List(Of EmpStats)
                For Each emp As Employee In empsColl.Employees
                    Dim newEmpStats As EmpStats = GetEmployeeStats(emp.PayrollId) '
                    If Not newEmpStats Is Nothing Then
                        empStatsList.Add(newEmpStats)
                    End If
                Next
                empStatsList.Reverse()

                'So now we have EVERY employee's stats. We have our main loading done. We just need to put it on a graph...
                'Thankfully, it's not hard to find a tutorial--- Oh, you apply your own references to your copy-pastes? Nope. t(*u*t ) You lost your advertisement rights!
                'FROM SCRATCH.

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

                'Adding a bar of data to each employee
                Try
                    EmpPickingChart.Series.Clear()
                Catch ex As Exception

                End Try
                If NoSplitRadio.Checked = True Then
                    SetUpTables("NoSplit")
                    ProcessAnalyticsData(empStatsList, ListOfDates, "NoSplit")
                ElseIf PickPackSplitRadio.Checked = True Then
                    SetUpTables("SplitByPT")
                    ProcessAnalyticsData(empStatsList, ListOfDates, "SplitByPT")
                ElseIf PicklistSplitRadio.Checked = True Then
                    SetUpTables("SplitByPL")
                    ProcessAnalyticsData(empStatsList, ListOfDates, "SplitByPL")
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

    Private Sub SetUpTables(whatToDo As String)

        WarehouseStatsTable.Rows.Clear()

        Dim chartdisplaytype As New DataVisualization.Charting.SeriesChartType
        If ShowCumulative.Checked Then
            chartdisplaytype = DataVisualization.Charting.SeriesChartType.StackedBar
        Else
            chartdisplaytype = DataVisualization.Charting.SeriesChartType.Bar
        End If

        If TimeSpentRadio.Checked = True Then
            'We want to see employees on a scale to the hour.
            EmpPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Hours"
            EmpPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
        ElseIf TotalRadio.Checked = True Then
            'We want to see employees total pick / pack amounts.
            EmpPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Orders"
            EmpPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
        ElseIf AverageRadio.Checked = True Then
            'We want to see employees total amounts on average, scaled to the hour.

            EmpPickingChart.ChartAreas("ChartArea1").AxisY.Title = "Orders to the hour"
            EmpPickingChart.ChartAreas("ChartArea1").AxisX.Title = "Employee ID"
        End If

        If whatToDo = "SplitByPL" And ShowCumulative.Checked = True Then
            'This is probably not the best way to view this data
            MsgBox("Be aware that the stacked bars represent different sectors individually, the average is not cumulative. The total average for all data can be shown by selecting 'All employee data in one row'")
            If ShowSPickingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PickingSingle")
                EmpPickingChart.Series("PickingSingle")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PickingSingle").Color = Color.DeepSkyBlue
                EmpPickingChart.Series("PickingSingle").ChartType = chartdisplaytype
            End If
            If ShowSPackingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PackingSingle")
                EmpPickingChart.Series("PackingSingle")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PackingSingle").Color = Color.RoyalBlue
                EmpPickingChart.Series("PackingSingle").ChartType = chartdisplaytype
            End If
            If ShowBPickingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PickingBoxed")
                EmpPickingChart.Series("PickingBoxed")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PickingBoxed").Color = Color.Crimson
                EmpPickingChart.Series("PickingBoxed").ChartType = chartdisplaytype
            End If
            If ShowBPackingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PackingBoxed")
                EmpPickingChart.Series("PackingBoxed")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PackingBoxed").Color = Color.DarkRed
                EmpPickingChart.Series("PackingBoxed").ChartType = chartdisplaytype
            End If
            If ShowMPickingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PickingMulti")
                EmpPickingChart.Series("PickingMulti")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PickingMulti").Color = Color.Gold
                EmpPickingChart.Series("PickingMulti").ChartType = chartdisplaytype
            End If
            If ShowMPackingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PackingMulti")
                EmpPickingChart.Series("PackingMulti")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PackingMulti").Color = Color.Goldenrod
                EmpPickingChart.Series("PackingMulti").ChartType = chartdisplaytype
            End If
            If CheckPrepack.Checked = True Then
                EmpPickingChart.Series.Add("PrePack")
                EmpPickingChart.Series("PrePack")("PixelPointWidth") = "20"
                EmpPickingChart.Series("PrePack").Color = Color.MediumPurple
                EmpPickingChart.Series("PrePack").ChartType = chartdisplaytype
            End If

        ElseIf whatToDo = "SplitByPL" And ShowCumulative.Checked = False Then
            If ShowSPickingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PickingSingle")
                EmpPickingChart.Series("PickingSingle")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PickingSingle").Color = Color.DeepSkyBlue
                EmpPickingChart.Series("PickingSingle").ChartType = chartdisplaytype
            End If
            If ShowSPackingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PackingSingle")
                EmpPickingChart.Series("PackingSingle")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PackingSingle").Color = Color.RoyalBlue
                EmpPickingChart.Series("PackingSingle").ChartType = chartdisplaytype
            End If
            If ShowBPickingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PickingBoxed")
                EmpPickingChart.Series("PickingBoxed")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PickingBoxed").Color = Color.Crimson
                EmpPickingChart.Series("PickingBoxed").ChartType = chartdisplaytype
            End If
            If ShowBPackingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PackingBoxed")
                EmpPickingChart.Series("PackingBoxed")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PackingBoxed").Color = Color.DarkRed
                EmpPickingChart.Series("PackingBoxed").ChartType = chartdisplaytype
            End If
            If ShowMPickingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PickingMulti")
                EmpPickingChart.Series("PickingMulti")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PickingMulti").Color = Color.Gold
                EmpPickingChart.Series("PickingMulti").ChartType = chartdisplaytype
            End If
            If ShowMPackingCheck.Checked = True Then
                EmpPickingChart.Series.Add("PackingMulti")
                EmpPickingChart.Series("PackingMulti")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PackingMulti").Color = Color.Goldenrod
                EmpPickingChart.Series("PackingMulti").ChartType = chartdisplaytype
            End If
            If CheckPrepack.Checked = True Then
                EmpPickingChart.Series.Add("PrePack")
                EmpPickingChart.Series("PrePack")("PixelPointWidth") = "35"
                EmpPickingChart.Series("PrePack").Color = Color.MediumPurple
                EmpPickingChart.Series("PrePack").ChartType = chartdisplaytype
            End If
            '-----

        ElseIf whatToDo = "SplitByPT" And ShowCumulative.Checked = True Then
            EmpPickingChart.Series.Add("Picking")
            EmpPickingChart.Series.Add("Packing")
            EmpPickingChart.Series.Add("PrePack")
            EmpPickingChart.Series("Picking")("PixelPointWidth") = "20"
            EmpPickingChart.Series("Packing")("PixelPointWidth") = "20"
            EmpPickingChart.Series("PrePack")("PixelPointWidth") = "20"
            EmpPickingChart.Series("Picking").ChartType = chartdisplaytype
            EmpPickingChart.Series("Packing").ChartType = chartdisplaytype
            EmpPickingChart.Series("PrePack").ChartType = chartdisplaytype

        ElseIf whatToDo = "SplitByPT" And ShowCumulative.Checked = False Then
            EmpPickingChart.Series.Add("Picking")
            EmpPickingChart.Series.Add("Packing")
            EmpPickingChart.Series.Add("PrePack")
            EmpPickingChart.Series("Picking")("PixelPointWidth") = "35"
            EmpPickingChart.Series("Packing")("PixelPointWidth") = "35"
            EmpPickingChart.Series("PrePack")("PixelPointWidth") = "35"
            EmpPickingChart.Series("Picking").ChartType = chartdisplaytype
            EmpPickingChart.Series("Packing").ChartType = chartdisplaytype
            EmpPickingChart.Series("PrePack").ChartType = chartdisplaytype
            '-----

        ElseIf whatToDo = "NoSplit" Then
            EmpPickingChart.Series.Add("Full Data")
            EmpPickingChart.Series("Full Data")("PixelPointWidth") = "35"
            EmpPickingChart.Series("Full Data").ChartType = DataVisualization.Charting.SeriesChartType.Bar

        End If
    End Sub

    Private Sub ProcessAnalyticsData(empStatsList As List(Of EmpStats), ListOfDates As List(Of Date), whatToDo As String)
        LargestValue = 0
        Dim EveryOrderAmount As Integer = 0
        Dim EveryHourAmount As Double = 0
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
                ElseIf session.SessionType = SessionType.Packing Then
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
                ElseIf session.SessionType = SessionType.Prepack Then
                    If CheckPrepack.Checked Then
                        totalPrepackHours += session.TimeSpan.TotalHours
                        totalPrepackQuantity += session.OrderCount
                    End If
                End If
            Next

            Dim empsNumberGatherer As New totalNumberGatherer(totalPickingSHours, totalPickingSQuantity, totalPickingBHours, totalPickingBQuantity, totalPickingMHours, totalPickingMQuantity, totalPackingSHours, totalPackingSQuantity, totalPackingBHours, totalPackingBQuantity, totalPackingMHours, totalPackingMQuantity, totalPrepackHours, totalPrepackQuantity)

            '/////ROW CALCULATIONS/////

            Dim ndgvr As New DataGridViewRow
            ndgvr.CreateCells(WarehouseStatsTable)
            ndgvr.Cells(0).Value = empsColl.FindEmployeeByID(emp.EmpID).FullName


            If TimeSpentRadio.Checked = True Then
                If totalPickingSHours > 0 And ShowSPickingCheck.Checked = True Then
                    ndgvr.Cells(1).Value = Math.Round(totalPickingSHours, 2)
                    EveryOrderAmount += totalPickingSQuantity
                    EveryHourAmount += totalPickingSHours
                Else
                    ndgvr.Cells(1).Value = 0.00
                End If

                If totalPickingBHours > 0 And ShowBPickingCheck.Checked = True Then
                    ndgvr.Cells(2).Value = Math.Round(totalPickingBHours, 2)
                    EveryOrderAmount += totalPickingBQuantity
                    EveryHourAmount += totalPickingBHours
                Else
                    ndgvr.Cells(2).Value = 0.00
                End If

                If totalPickingMHours > 0 And ShowMPickingCheck.Checked = True Then
                    ndgvr.Cells(3).Value = Math.Round(totalPickingMHours, 2)
                    EveryOrderAmount += totalPickingMQuantity
                    EveryHourAmount += totalPickingMHours
                Else
                    ndgvr.Cells(3).Value = 0.00
                End If

                If totalPackingSHours > 0 And ShowSPackingCheck.Checked = True Then
                    ndgvr.Cells(4).Value = Math.Round(totalPackingSHours, 2)
                    EveryOrderAmount += totalPackingSQuantity
                    EveryHourAmount += totalPackingSHours
                Else
                    ndgvr.Cells(4).Value = 0.00
                End If

                If totalPackingBHours > 0 And ShowBPackingCheck.Checked = True Then
                    ndgvr.Cells(5).Value = Math.Round(totalPackingBHours, 2)
                    EveryOrderAmount += totalPackingBQuantity
                    EveryHourAmount += totalPackingBHours
                Else
                    ndgvr.Cells(5).Value = 0.00
                End If

                If totalPackingMHours > 0 And ShowMPackingCheck.Checked = True Then
                    ndgvr.Cells(6).Value = Math.Round(totalPackingMHours, 2)
                    EveryOrderAmount += totalPackingMQuantity
                    EveryHourAmount += totalPackingMHours
                Else
                    ndgvr.Cells(6).Value = 0.00
                End If

                If totalPrepackHours > 0 And CheckPrepack.Checked = True Then
                    ndgvr.Cells(7).Value = Math.Round(totalPrepackHours, 2)
                Else
                    ndgvr.Cells(7).Value = 0.00
                End If

                'ndgvr.Cells(1).Value = Math.Round(totalPickingSHours, 2)
                'ndgvr.Cells(2).Value = Math.Round(totalPickingBHours, 2)
                'ndgvr.Cells(3).Value = Math.Round(totalPickingMHours, 2)
                'ndgvr.Cells(4).Value = Math.Round(totalPackingSHours, 2)
                'ndgvr.Cells(5).Value = Math.Round(totalPackingBHours, 2)
                'ndgvr.Cells(6).Value = Math.Round(totalPackingMHours, 2)
                'ndgvr.Cells(7).Value = Math.Round(totalPrepackHours, 2)
            ElseIf TotalRadio.Checked = True Then
                If totalPickingSQuantity > 0 And ShowSPickingCheck.Checked = True Then
                    ndgvr.Cells(1).Value = Math.Round(totalPickingSQuantity, 2)
                    EveryOrderAmount += totalPickingSQuantity
                    EveryHourAmount += totalPickingSHours
                Else
                    ndgvr.Cells(1).Value = 0.00
                End If

                If totalPickingBQuantity > 0 And ShowBPickingCheck.Checked = True Then
                    ndgvr.Cells(2).Value = Math.Round(totalPickingBQuantity, 2)
                    EveryOrderAmount += totalPickingBQuantity
                    EveryHourAmount += totalPickingBHours
                Else
                    ndgvr.Cells(2).Value = 0.00
                End If

                If totalPickingMQuantity > 0 And ShowMPickingCheck.Checked = True Then
                    ndgvr.Cells(3).Value = Math.Round(totalPickingMQuantity, 2)
                    EveryOrderAmount += totalPickingMQuantity
                    EveryHourAmount += totalPickingMHours
                Else
                    ndgvr.Cells(3).Value = 0.00
                End If

                If totalPackingSQuantity > 0 And ShowSPackingCheck.Checked = True Then
                    ndgvr.Cells(4).Value = Math.Round(totalPackingSQuantity, 2)
                    EveryOrderAmount += totalPackingSQuantity
                    EveryHourAmount += totalPackingSHours
                Else
                    ndgvr.Cells(4).Value = 0.00
                End If

                If totalPackingBQuantity > 0 And ShowBPackingCheck.Checked = True Then
                    ndgvr.Cells(5).Value = Math.Round(totalPackingBQuantity, 2)
                    EveryOrderAmount += totalPackingBQuantity
                    EveryHourAmount += totalPackingBHours
                Else
                    ndgvr.Cells(5).Value = 0.00
                End If

                If totalPackingMQuantity > 0 And ShowMPackingCheck.Checked = True Then
                    ndgvr.Cells(6).Value = Math.Round(totalPackingMQuantity, 2)
                    EveryOrderAmount += totalPackingMQuantity
                    EveryHourAmount += totalPackingMHours
                Else
                    ndgvr.Cells(6).Value = 0.00
                End If

                If totalPrepackQuantity > 0 And CheckPrepack.Checked = True Then
                    ndgvr.Cells(7).Value = Math.Round(totalPrepackQuantity, 2)

                    'EveryOrderAmount += totalPrepackQuantity
                    'EveryHourAmount += totalPrepackHours
                Else
                    ndgvr.Cells(7).Value = 0.00
                End If

                'ndgvr.Cells(1).Value = Math.Round(totalPickingSQuantity, 2)
                'ndgvr.Cells(2).Value = Math.Round(totalPickingBQuantity, 2)
                'ndgvr.Cells(3).Value = Math.Round(totalPickingMQuantity, 2)
                'ndgvr.Cells(4).Value = Math.Round(totalPackingSQuantity, 2)
                'ndgvr.Cells(5).Value = Math.Round(totalPackingBQuantity, 2)
                'ndgvr.Cells(6).Value = Math.Round(totalPackingMQuantity, 2)
                'ndgvr.Cells(7).Value = Math.Round(totalPrepackQuantity, 2)
            ElseIf AverageRadio.Checked = True Then
                If totalPickingSQuantity > 0 And totalPickingSHours > 0 And ShowSPickingCheck.Checked = True Then
                    ndgvr.Cells(1).Value = Math.Round(totalPickingSQuantity / totalPickingSHours, 2)
                    EveryOrderAmount += totalPickingSQuantity
                    EveryHourAmount += totalPickingSHours
                Else
                    ndgvr.Cells(1).Value = 0.00
                End If

                If totalPickingBQuantity > 0 And totalPickingBHours > 0 And ShowBPickingCheck.Checked = True Then
                    ndgvr.Cells(2).Value = Math.Round(totalPickingBQuantity / totalPickingBHours, 2)
                    EveryOrderAmount += totalPickingBQuantity
                    EveryHourAmount += totalPickingBHours
                Else
                    ndgvr.Cells(2).Value = 0.00
                End If

                If totalPickingMQuantity > 0 And totalPickingMHours > 0 And ShowMPickingCheck.Checked = True Then
                    ndgvr.Cells(3).Value = Math.Round(totalPickingMQuantity / totalPickingMHours, 2)
                    EveryOrderAmount += totalPickingMQuantity
                    EveryHourAmount += totalPickingMHours
                Else
                    ndgvr.Cells(3).Value = 0.00
                End If

                If totalPackingSQuantity > 0 And totalPackingSHours > 0 And ShowSPackingCheck.Checked = True Then
                    ndgvr.Cells(4).Value = Math.Round(totalPackingSQuantity / totalPackingSHours, 2)
                    EveryOrderAmount += totalPackingSQuantity
                    EveryHourAmount += totalPackingSHours
                Else
                    ndgvr.Cells(4).Value = 0.00
                End If

                If totalPackingBQuantity > 0 And totalPackingBHours > 0 And ShowBPackingCheck.Checked = True Then
                    ndgvr.Cells(5).Value = Math.Round(totalPackingBQuantity / totalPackingBHours, 2)
                    EveryOrderAmount += totalPackingBQuantity
                    EveryHourAmount += totalPackingBHours
                Else
                    ndgvr.Cells(5).Value = 0.00
                End If

                If totalPackingMQuantity > 0 And totalPackingMHours > 0 And ShowMPackingCheck.Checked = True Then
                    ndgvr.Cells(6).Value = Math.Round(totalPackingMQuantity / totalPackingMHours, 2)
                    EveryOrderAmount += totalPackingMQuantity
                    EveryHourAmount += totalPackingMHours
                Else
                    ndgvr.Cells(6).Value = 0.00
                End If

                If totalPrepackQuantity > 0 And totalPrepackHours > 0 And CheckPrepack.Checked = True Then
                    ndgvr.Cells(7).Value = Math.Round(totalPrepackQuantity / totalPrepackHours, 2)

                    'EveryOrderAmount += totalPrepackQuantity
                    'EveryHourAmount += totalPrepackHours
                Else
                    ndgvr.Cells(7).Value = 0.00
                End If

                Dim totalHours As Double = totalPickingBHours + totalPickingSHours + totalPickingMHours + totalPackingBHours + totalPackingSHours + totalPackingMHours + totalPrepackHours
                Dim totalQuantity As Double = totalPickingBQuantity + totalPickingSQuantity + totalPickingMQuantity + totalPackingBQuantity + totalPackingSQuantity + totalPackingMQuantity + totalPrepackQuantity

                Dim newKVP As New KeyValuePair(Of Double, Double)(totalQuantity, totalHours)
                ndgvr.Tag = newKVP
            End If

            '/////DISPLAYING GRAPH DATA/////

            If whatToDo = "SplitByPL" Then
                If ShowSPickingCheck.Checked = True Then EmpPickingChart.Series("PickingSingle").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(1).Value)
                If ShowBPickingCheck.Checked = True Then EmpPickingChart.Series("PickingBoxed").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(2).Value)
                If ShowMPickingCheck.Checked = True Then EmpPickingChart.Series("PickingMulti").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(3).Value)
                If ShowSPackingCheck.Checked = True Then EmpPickingChart.Series("PackingSingle").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(4).Value)
                If ShowBPackingCheck.Checked = True Then EmpPickingChart.Series("PackingBoxed").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(5).Value)
                If ShowMPackingCheck.Checked = True Then EmpPickingChart.Series("PackingMulti").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(6).Value)
                If CheckPrepack.Checked = True Then EmpPickingChart.Series("PrePack").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(7).Value)
                Dim totalNum As Double = ndgvr.Cells(1).Value + ndgvr.Cells(2).Value + ndgvr.Cells(3).Value + ndgvr.Cells(4).Value + ndgvr.Cells(5).Value + ndgvr.Cells(6).Value + ndgvr.Cells(7).Value
                If totalNum > LargestValue Then
                    LargestValue = totalNum
                End If

            ElseIf whatToDo = "SplitByPT" Then

                Dim totalNum As Double
                If AverageRadio.Checked = True Then
                    If ndgvr.Tag.Key > 0 And ndgvr.Tag.Value > 0 Then
                        totalNum = Math.Round(ndgvr.Tag.Key / ndgvr.Tag.Value, 2)
                    Else
                        totalNum = 0
                    End If

                    Dim EqPicking As Double = 0.00
                    Dim EqPacking As Double = 0.00
                    Dim EqPicking2 As Double = 0.00
                    Dim EqPacking2 As Double = 0.00
                    If ShowSPickingCheck.Checked = True Then
                        EqPicking += empsNumberGatherer.pickSQ
                        EqPicking2 += empsNumberGatherer.pickSH
                    End If
                    If ShowBPickingCheck.Checked = True Then
                        EqPicking += empsNumberGatherer.pickBQ
                        EqPicking2 += empsNumberGatherer.pickBH
                    End If
                    If ShowMPickingCheck.Checked = True Then
                        EqPicking += empsNumberGatherer.pickMQ
                        EqPicking2 += empsNumberGatherer.pickMH
                    End If
                    If ShowSPackingCheck.Checked = True Then
                        EqPacking += empsNumberGatherer.packSQ
                        EqPacking2 += empsNumberGatherer.packSH
                    End If
                    If ShowBPackingCheck.Checked = True Then
                        EqPacking += empsNumberGatherer.packBQ
                        EqPacking2 += empsNumberGatherer.packBH
                    End If
                    If ShowMPackingCheck.Checked = True Then
                        EqPacking += empsNumberGatherer.packMQ
                        EqPacking2 += empsNumberGatherer.packMH
                    End If
                    If EqPicking > 0.00 And EqPicking2 > 0.00 Then
                        EmpPickingChart.Series("Picking").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, EqPicking / EqPicking2)
                    Else
                        EmpPickingChart.Series("Picking").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, 0)
                    End If
                    If EqPacking > 0.00 And EqPacking2 > 0.00 Then
                        EmpPickingChart.Series("Packing").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, EqPacking / EqPacking2)
                    Else
                        EmpPickingChart.Series("Packing").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, 0)
                    End If
                    If CheckPrepack.Checked = True Then EmpPickingChart.Series("PrePack").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(7).Value)
                Else
                    totalNum = ndgvr.Cells(1).Value + ndgvr.Cells(2).Value + ndgvr.Cells(3).Value + ndgvr.Cells(4).Value + ndgvr.Cells(5).Value + ndgvr.Cells(6).Value + ndgvr.Cells(7).Value
                    EmpPickingChart.Series("Picking").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(1).Value + ndgvr.Cells(2).Value + ndgvr.Cells(3).Value)
                    EmpPickingChart.Series("Packing").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(4).Value + ndgvr.Cells(5).Value + ndgvr.Cells(6).Value)
                    If CheckPrepack.Checked = True Then EmpPickingChart.Series("PrePack").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, ndgvr.Cells(7).Value)
                End If

                If totalNum > LargestValue Then
                    LargestValue = totalNum
                End If


            ElseIf whatToDo = "NoSplit" Then
                Dim totalNum As Double
                If AverageRadio.Checked = True Then
                    If ndgvr.Tag.Key > 0 And ndgvr.Tag.Value > 0 Then
                        totalNum = Math.Round(ndgvr.Tag.Key / ndgvr.Tag.Value, 2)
                    Else
                        totalNum = 0
                    End If
                Else
                    totalNum = ndgvr.Cells(1).Value + ndgvr.Cells(2).Value + ndgvr.Cells(3).Value + ndgvr.Cells(4).Value + ndgvr.Cells(5).Value + ndgvr.Cells(6).Value + ndgvr.Cells(7).Value
                End If

                If totalNum > LargestValue Then
                    LargestValue = totalNum
                End If
                EmpPickingChart.Series("Full Data").Points.AddXY(empsColl.FindEmployeeByID(emp.EmpID).FullName, totalNum)

            End If

            WarehouseStatsTable.Rows.Add(ndgvr)
        Next

        EmpPickingChart.ChartAreas("ChartArea1").AxisY.Interval = (Math.Round(LargestValue / 20) / 10) * 10
        EmpPickingChart.ChartAreas("ChartArea1").AxisX.Interval = 0.5

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

    Private Sub NoSplitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles NoSplitRadio.Click
        PickPackSplitRadio.Checked = False
        PicklistSplitRadio.Checked = False
        NoSplitRadio.Checked = True
        ShowWarning()
    End Sub

    Private Sub PickPackSplitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PickPackSplitRadio.Click
        NoSplitRadio.Checked = False
        PicklistSplitRadio.Checked = False
        PickPackSplitRadio.Checked = True
        ShowWarning()
    End Sub

    Private Sub PicklistSplitRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PicklistSplitRadio.Click
        NoSplitRadio.Checked = False
        PickPackSplitRadio.Checked = False
        PicklistSplitRadio.Checked = True
        ShowWarning()
    End Sub

    Private Sub AverageRadio_CheckedChanged(sender As Object, e As EventArgs) Handles AverageRadio.Click
        TotalRadio.Checked = False
        TimeSpentRadio.Checked = False
        AverageRadio.Checked = True
        ShowWarning()
    End Sub

    Private Sub TotalRadio_CheckedChanged(sender As Object, e As EventArgs) Handles TotalRadio.Click
        AverageRadio.Checked = False
        TimeSpentRadio.Checked = False
        TotalRadio.Checked = True
        ShowWarning()
    End Sub

    Private Sub TimeSpentRadio_CheckedChanged(sender As Object, e As EventArgs) Handles TimeSpentRadio.Click
        AverageRadio.Checked = False
        TotalRadio.Checked = False
        TimeSpentRadio.Checked = True
        ShowWarning()
    End Sub

    Private Sub ShowSPickingCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPrepack.CheckedChanged, ShowCumulative.CheckedChanged, ShowSPickingCheck.CheckedChanged, ShowBPickingCheck.CheckedChanged, ShowMPickingCheck.CheckedChanged, ShowSPackingCheck.CheckedChanged, ShowBPackingCheck.CheckedChanged, ShowMPackingCheck.CheckedChanged
        ShowWarning()
    End Sub

    Private Sub ShowWarning()
        WarningPnl.Visible = True
    End Sub

    Private Sub HideWarning()
        WarningPnl.Visible = False
    End Sub

End Class
