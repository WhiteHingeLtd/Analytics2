<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnalyticsBaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmpPickingChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.WarehouseStatsTable = New System.Windows.Forms.DataGridView()
        Me.EmpCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinglePickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxPickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiPickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinglePackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrepackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExcludePercCheck = New System.Windows.Forms.CheckBox()
        Me.ExcludePercTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WarningPnl = New System.Windows.Forms.Panel()
        Me.WarningLbl = New System.Windows.Forms.Label()
        Me.OrdersPerHourLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckPrepack = New System.Windows.Forms.CheckBox()
        Me.ShowMPackingCheck = New System.Windows.Forms.CheckBox()
        Me.ShowBPackingCheck = New System.Windows.Forms.CheckBox()
        Me.ShowSPackingCheck = New System.Windows.Forms.CheckBox()
        Me.ShowMPickingCheck = New System.Windows.Forms.CheckBox()
        Me.ShowBPickingCheck = New System.Windows.Forms.CheckBox()
        Me.ShowSPickingCheck = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShowCumulative = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimeSpentRadio = New System.Windows.Forms.RadioButton()
        Me.TotalRadio = New System.Windows.Forms.RadioButton()
        Me.AverageRadio = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicklistSplitRadio = New System.Windows.Forms.RadioButton()
        Me.PickPackSplitRadio = New System.Windows.Forms.RadioButton()
        Me.NoSplitRadio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SecondDate = New System.Windows.Forms.DateTimePicker()
        Me.FirstDate = New System.Windows.Forms.DateTimePicker()
        Me.LoadAnalyticsBtn = New System.Windows.Forms.Button()
        CType(Me.EmpPickingChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouseStatsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WarningPnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmpPickingChart
        '
        Me.EmpPickingChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.EmpPickingChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.EmpPickingChart.Legends.Add(Legend1)
        Me.EmpPickingChart.Location = New System.Drawing.Point(483, 2)
        Me.EmpPickingChart.Name = "EmpPickingChart"
        Me.EmpPickingChart.Size = New System.Drawing.Size(1100, 848)
        Me.EmpPickingChart.TabIndex = 8
        '
        'WarehouseStatsTable
        '
        Me.WarehouseStatsTable.AllowUserToAddRows = False
        Me.WarehouseStatsTable.AllowUserToDeleteRows = False
        Me.WarehouseStatsTable.AllowUserToResizeRows = False
        Me.WarehouseStatsTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WarehouseStatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WarehouseStatsTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpCol, Me.SinglePickCol, Me.BoxPickCol, Me.MultiPickCol, Me.SinglePackCol, Me.BoxPackCol, Me.MultiPackCol, Me.PrepackCol})
        Me.WarehouseStatsTable.Location = New System.Drawing.Point(15, 303)
        Me.WarehouseStatsTable.Name = "WarehouseStatsTable"
        Me.WarehouseStatsTable.RowHeadersVisible = False
        Me.WarehouseStatsTable.Size = New System.Drawing.Size(462, 537)
        Me.WarehouseStatsTable.TabIndex = 11
        '
        'EmpCol
        '
        Me.EmpCol.HeaderText = "Employee"
        Me.EmpCol.Name = "EmpCol"
        Me.EmpCol.ReadOnly = True
        Me.EmpCol.Width = 107
        '
        'SinglePickCol
        '
        DataGridViewCellStyle1.Format = "N2"
        Me.SinglePickCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.SinglePickCol.HeaderText = "S-Pi"
        Me.SinglePickCol.Name = "SinglePickCol"
        Me.SinglePickCol.ReadOnly = True
        Me.SinglePickCol.Width = 50
        '
        'BoxPickCol
        '
        DataGridViewCellStyle2.Format = "N2"
        Me.BoxPickCol.DefaultCellStyle = DataGridViewCellStyle2
        Me.BoxPickCol.HeaderText = "B-Pi"
        Me.BoxPickCol.Name = "BoxPickCol"
        Me.BoxPickCol.ReadOnly = True
        Me.BoxPickCol.Width = 50
        '
        'MultiPickCol
        '
        DataGridViewCellStyle3.Format = "N2"
        Me.MultiPickCol.DefaultCellStyle = DataGridViewCellStyle3
        Me.MultiPickCol.HeaderText = "M-Pi"
        Me.MultiPickCol.Name = "MultiPickCol"
        Me.MultiPickCol.ReadOnly = True
        Me.MultiPickCol.Width = 50
        '
        'SinglePackCol
        '
        DataGridViewCellStyle4.Format = "N2"
        Me.SinglePackCol.DefaultCellStyle = DataGridViewCellStyle4
        Me.SinglePackCol.HeaderText = "S-Pa"
        Me.SinglePackCol.Name = "SinglePackCol"
        Me.SinglePackCol.ReadOnly = True
        Me.SinglePackCol.Width = 50
        '
        'BoxPackCol
        '
        DataGridViewCellStyle5.Format = "N2"
        Me.BoxPackCol.DefaultCellStyle = DataGridViewCellStyle5
        Me.BoxPackCol.HeaderText = "B-Pa"
        Me.BoxPackCol.Name = "BoxPackCol"
        Me.BoxPackCol.ReadOnly = True
        Me.BoxPackCol.Width = 50
        '
        'MultiPackCol
        '
        DataGridViewCellStyle6.Format = "N2"
        Me.MultiPackCol.DefaultCellStyle = DataGridViewCellStyle6
        Me.MultiPackCol.HeaderText = "M-Pa"
        Me.MultiPackCol.Name = "MultiPackCol"
        Me.MultiPackCol.ReadOnly = True
        Me.MultiPackCol.Width = 50
        '
        'PrepackCol
        '
        DataGridViewCellStyle7.Format = "N2"
        Me.PrepackCol.DefaultCellStyle = DataGridViewCellStyle7
        Me.PrepackCol.HeaderText = "PP"
        Me.PrepackCol.Name = "PrepackCol"
        Me.PrepackCol.Width = 50
        '
        'ExcludePercCheck
        '
        Me.ExcludePercCheck.AutoSize = True
        Me.ExcludePercCheck.Checked = True
        Me.ExcludePercCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExcludePercCheck.Location = New System.Drawing.Point(15, 68)
        Me.ExcludePercCheck.Name = "ExcludePercCheck"
        Me.ExcludePercCheck.Size = New System.Drawing.Size(15, 14)
        Me.ExcludePercCheck.TabIndex = 37
        Me.ExcludePercCheck.UseVisualStyleBackColor = True
        '
        'ExcludePercTxt
        '
        Me.ExcludePercTxt.Location = New System.Drawing.Point(174, 65)
        Me.ExcludePercTxt.Name = "ExcludePercTxt"
        Me.ExcludePercTxt.Size = New System.Drawing.Size(32, 20)
        Me.ExcludePercTxt.TabIndex = 36
        Me.ExcludePercTxt.Text = "2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(204, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "% of the largest value."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Exclude rows with less than:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "This table displays the exact numbers shown in the data on the graph"
        '
        'WarningPnl
        '
        Me.WarningPnl.BackColor = System.Drawing.Color.Khaki
        Me.WarningPnl.Controls.Add(Me.WarningLbl)
        Me.WarningPnl.Location = New System.Drawing.Point(15, 37)
        Me.WarningPnl.Name = "WarningPnl"
        Me.WarningPnl.Size = New System.Drawing.Size(121, 19)
        Me.WarningPnl.TabIndex = 32
        Me.WarningPnl.Visible = False
        '
        'WarningLbl
        '
        Me.WarningLbl.Location = New System.Drawing.Point(0, 0)
        Me.WarningLbl.Name = "WarningLbl"
        Me.WarningLbl.Size = New System.Drawing.Size(121, 19)
        Me.WarningLbl.TabIndex = 17
        Me.WarningLbl.Text = "Click load for new data"
        Me.WarningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrdersPerHourLbl
        '
        Me.OrdersPerHourLbl.AutoSize = True
        Me.OrdersPerHourLbl.Location = New System.Drawing.Point(142, 270)
        Me.OrdersPerHourLbl.Name = "OrdersPerHourLbl"
        Me.OrdersPerHourLbl.Size = New System.Drawing.Size(0, 13)
        Me.OrdersPerHourLbl.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Average orders per hour:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CheckPrepack)
        Me.Panel3.Controls.Add(Me.ShowMPackingCheck)
        Me.Panel3.Controls.Add(Me.ShowBPackingCheck)
        Me.Panel3.Controls.Add(Me.ShowSPackingCheck)
        Me.Panel3.Controls.Add(Me.ShowMPickingCheck)
        Me.Panel3.Controls.Add(Me.ShowBPickingCheck)
        Me.Panel3.Controls.Add(Me.ShowSPickingCheck)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(15, 182)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 85)
        Me.Panel3.TabIndex = 28
        '
        'CheckPrepack
        '
        Me.CheckPrepack.AutoSize = True
        Me.CheckPrepack.Location = New System.Drawing.Point(4, 65)
        Me.CheckPrepack.Name = "CheckPrepack"
        Me.CheckPrepack.Size = New System.Drawing.Size(122, 17)
        Me.CheckPrepack.TabIndex = 20
        Me.CheckPrepack.Text = "Show Prepack Data"
        Me.CheckPrepack.UseVisualStyleBackColor = True
        '
        'ShowMPackingCheck
        '
        Me.ShowMPackingCheck.AutoSize = True
        Me.ShowMPackingCheck.Location = New System.Drawing.Point(260, 44)
        Me.ShowMPackingCheck.Name = "ShowMPackingCheck"
        Me.ShowMPackingCheck.Size = New System.Drawing.Size(120, 17)
        Me.ShowMPackingCheck.TabIndex = 18
        Me.ShowMPackingCheck.Text = "Show Multi Packing"
        Me.ShowMPackingCheck.UseVisualStyleBackColor = True
        '
        'ShowBPackingCheck
        '
        Me.ShowBPackingCheck.AutoSize = True
        Me.ShowBPackingCheck.Location = New System.Drawing.Point(131, 44)
        Me.ShowBPackingCheck.Name = "ShowBPackingCheck"
        Me.ShowBPackingCheck.Size = New System.Drawing.Size(128, 17)
        Me.ShowBPackingCheck.TabIndex = 17
        Me.ShowBPackingCheck.Text = "Show Boxed Packing"
        Me.ShowBPackingCheck.UseVisualStyleBackColor = True
        '
        'ShowSPackingCheck
        '
        Me.ShowSPackingCheck.AutoSize = True
        Me.ShowSPackingCheck.Location = New System.Drawing.Point(4, 44)
        Me.ShowSPackingCheck.Name = "ShowSPackingCheck"
        Me.ShowSPackingCheck.Size = New System.Drawing.Size(127, 17)
        Me.ShowSPackingCheck.TabIndex = 16
        Me.ShowSPackingCheck.Text = "Show Single Packing"
        Me.ShowSPackingCheck.UseVisualStyleBackColor = True
        '
        'ShowMPickingCheck
        '
        Me.ShowMPickingCheck.AutoSize = True
        Me.ShowMPickingCheck.Location = New System.Drawing.Point(260, 23)
        Me.ShowMPickingCheck.Name = "ShowMPickingCheck"
        Me.ShowMPickingCheck.Size = New System.Drawing.Size(116, 17)
        Me.ShowMPickingCheck.TabIndex = 15
        Me.ShowMPickingCheck.Text = "Show Multi Picking"
        Me.ShowMPickingCheck.UseVisualStyleBackColor = True
        '
        'ShowBPickingCheck
        '
        Me.ShowBPickingCheck.AutoSize = True
        Me.ShowBPickingCheck.Location = New System.Drawing.Point(131, 23)
        Me.ShowBPickingCheck.Name = "ShowBPickingCheck"
        Me.ShowBPickingCheck.Size = New System.Drawing.Size(124, 17)
        Me.ShowBPickingCheck.TabIndex = 14
        Me.ShowBPickingCheck.Text = "Show Boxed Picking"
        Me.ShowBPickingCheck.UseVisualStyleBackColor = True
        '
        'ShowSPickingCheck
        '
        Me.ShowSPickingCheck.AutoSize = True
        Me.ShowSPickingCheck.Location = New System.Drawing.Point(4, 23)
        Me.ShowSPickingCheck.Name = "ShowSPickingCheck"
        Me.ShowSPickingCheck.Size = New System.Drawing.Size(123, 17)
        Me.ShowSPickingCheck.TabIndex = 13
        Me.ShowSPickingCheck.Text = "Show Single Picking"
        Me.ShowSPickingCheck.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Split by Picklist Type Settings"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ShowCumulative)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TimeSpentRadio)
        Me.Panel2.Controls.Add(Me.TotalRadio)
        Me.Panel2.Controls.Add(Me.AverageRadio)
        Me.Panel2.Location = New System.Drawing.Point(195, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 87)
        Me.Panel2.TabIndex = 29
        '
        'ShowCumulative
        '
        Me.ShowCumulative.AutoSize = True
        Me.ShowCumulative.Location = New System.Drawing.Point(80, 21)
        Me.ShowCumulative.Name = "ShowCumulative"
        Me.ShowCumulative.Size = New System.Drawing.Size(143, 17)
        Me.ShowCumulative.TabIndex = 19
        Me.ShowCumulative.Text = "Show single bar on chart"
        Me.ShowCumulative.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Data to collect:"
        '
        'TimeSpentRadio
        '
        Me.TimeSpentRadio.AutoSize = True
        Me.TimeSpentRadio.Location = New System.Drawing.Point(9, 62)
        Me.TimeSpentRadio.Name = "TimeSpentRadio"
        Me.TimeSpentRadio.Size = New System.Drawing.Size(48, 17)
        Me.TimeSpentRadio.TabIndex = 11
        Me.TimeSpentRadio.Text = "Time"
        Me.TimeSpentRadio.UseVisualStyleBackColor = True
        '
        'TotalRadio
        '
        Me.TotalRadio.AutoSize = True
        Me.TotalRadio.Location = New System.Drawing.Point(9, 41)
        Me.TotalRadio.Name = "TotalRadio"
        Me.TotalRadio.Size = New System.Drawing.Size(49, 17)
        Me.TotalRadio.TabIndex = 10
        Me.TotalRadio.Text = "Total"
        Me.TotalRadio.UseVisualStyleBackColor = True
        '
        'AverageRadio
        '
        Me.AverageRadio.AutoSize = True
        Me.AverageRadio.Location = New System.Drawing.Point(9, 20)
        Me.AverageRadio.Name = "AverageRadio"
        Me.AverageRadio.Size = New System.Drawing.Size(65, 17)
        Me.AverageRadio.TabIndex = 9
        Me.AverageRadio.Text = "Average"
        Me.AverageRadio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PicklistSplitRadio)
        Me.Panel1.Controls.Add(Me.PickPackSplitRadio)
        Me.Panel1.Controls.Add(Me.NoSplitRadio)
        Me.Panel1.Location = New System.Drawing.Point(15, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 87)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Employee Data Split Method"
        '
        'PicklistSplitRadio
        '
        Me.PicklistSplitRadio.AutoSize = True
        Me.PicklistSplitRadio.Location = New System.Drawing.Point(4, 62)
        Me.PicklistSplitRadio.Name = "PicklistSplitRadio"
        Me.PicklistSplitRadio.Size = New System.Drawing.Size(122, 17)
        Me.PicklistSplitRadio.TabIndex = 11
        Me.PicklistSplitRadio.TabStop = True
        Me.PicklistSplitRadio.Text = "Split by Picklist Type"
        Me.PicklistSplitRadio.UseVisualStyleBackColor = True
        '
        'PickPackSplitRadio
        '
        Me.PickPackSplitRadio.AutoSize = True
        Me.PickPackSplitRadio.Location = New System.Drawing.Point(4, 41)
        Me.PickPackSplitRadio.Name = "PickPackSplitRadio"
        Me.PickPackSplitRadio.Size = New System.Drawing.Size(147, 17)
        Me.PickPackSplitRadio.TabIndex = 10
        Me.PickPackSplitRadio.TabStop = True
        Me.PickPackSplitRadio.Text = "Split by Picking / Packing"
        Me.PickPackSplitRadio.UseVisualStyleBackColor = True
        '
        'NoSplitRadio
        '
        Me.NoSplitRadio.AutoSize = True
        Me.NoSplitRadio.Location = New System.Drawing.Point(4, 20)
        Me.NoSplitRadio.Name = "NoSplitRadio"
        Me.NoSplitRadio.Size = New System.Drawing.Size(160, 17)
        Me.NoSplitRadio.TabIndex = 9
        Me.NoSplitRadio.TabStop = True
        Me.NoSplitRadio.Text = "All employee data in one row"
        Me.NoSplitRadio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "From:"
        '
        'SecondDate
        '
        Me.SecondDate.Location = New System.Drawing.Point(226, 37)
        Me.SecondDate.MinDate = New Date(2016, 8, 4, 0, 0, 0, 0)
        Me.SecondDate.Name = "SecondDate"
        Me.SecondDate.Size = New System.Drawing.Size(202, 20)
        Me.SecondDate.TabIndex = 24
        '
        'FirstDate
        '
        Me.FirstDate.Checked = False
        Me.FirstDate.Location = New System.Drawing.Point(226, 11)
        Me.FirstDate.MinDate = New Date(2016, 8, 4, 0, 0, 0, 0)
        Me.FirstDate.Name = "FirstDate"
        Me.FirstDate.Size = New System.Drawing.Size(202, 20)
        Me.FirstDate.TabIndex = 23
        '
        'LoadAnalyticsBtn
        '
        Me.LoadAnalyticsBtn.Location = New System.Drawing.Point(15, 12)
        Me.LoadAnalyticsBtn.Name = "LoadAnalyticsBtn"
        Me.LoadAnalyticsBtn.Size = New System.Drawing.Size(121, 23)
        Me.LoadAnalyticsBtn.TabIndex = 22
        Me.LoadAnalyticsBtn.Text = "Load Analytics"
        Me.LoadAnalyticsBtn.UseVisualStyleBackColor = True
        '
        'AnalyticsBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 852)
        Me.Controls.Add(Me.ExcludePercCheck)
        Me.Controls.Add(Me.ExcludePercTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WarningPnl)
        Me.Controls.Add(Me.OrdersPerHourLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondDate)
        Me.Controls.Add(Me.FirstDate)
        Me.Controls.Add(Me.LoadAnalyticsBtn)
        Me.Controls.Add(Me.WarehouseStatsTable)
        Me.Controls.Add(Me.EmpPickingChart)
        Me.Name = "AnalyticsBaseForm"
        Me.Text = "Warehouse Analytics"
        CType(Me.EmpPickingChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouseStatsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WarningPnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmpPickingChart As DataVisualization.Charting.Chart
    Friend WithEvents WarehouseStatsTable As DataGridView
    Friend WithEvents MixedPickCol As DataGridViewTextBoxColumn
    Friend WithEvents MixedPackCol As DataGridViewTextBoxColumn
    Friend WithEvents EmpCol As DataGridViewTextBoxColumn
    Friend WithEvents SinglePickCol As DataGridViewTextBoxColumn
    Friend WithEvents BoxPickCol As DataGridViewTextBoxColumn
    Friend WithEvents MultiPickCol As DataGridViewTextBoxColumn
    Friend WithEvents SinglePackCol As DataGridViewTextBoxColumn
    Friend WithEvents BoxPackCol As DataGridViewTextBoxColumn
    Friend WithEvents MultiPackCol As DataGridViewTextBoxColumn
    Friend WithEvents PrepackCol As DataGridViewTextBoxColumn
    Friend WithEvents ExcludePercCheck As CheckBox
    Friend WithEvents ExcludePercTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WarningPnl As Panel
    Friend WithEvents WarningLbl As Label
    Friend WithEvents OrdersPerHourLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckPrepack As CheckBox
    Friend WithEvents ShowMPackingCheck As CheckBox
    Friend WithEvents ShowBPackingCheck As CheckBox
    Friend WithEvents ShowSPackingCheck As CheckBox
    Friend WithEvents ShowMPickingCheck As CheckBox
    Friend WithEvents ShowBPickingCheck As CheckBox
    Friend WithEvents ShowSPickingCheck As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShowCumulative As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeSpentRadio As RadioButton
    Friend WithEvents TotalRadio As RadioButton
    Friend WithEvents AverageRadio As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PicklistSplitRadio As RadioButton
    Friend WithEvents PickPackSplitRadio As RadioButton
    Friend WithEvents NoSplitRadio As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SecondDate As DateTimePicker
    Friend WithEvents FirstDate As DateTimePicker
    Friend WithEvents LoadAnalyticsBtn As Button
End Class
