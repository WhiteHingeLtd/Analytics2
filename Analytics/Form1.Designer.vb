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
        Me.LoadAnalyticsBtn = New System.Windows.Forms.Button()
        Me.FirstDate = New System.Windows.Forms.DateTimePicker()
        Me.SecondDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmpPickingChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NoSplitRadio = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicklistSplitRadio = New System.Windows.Forms.RadioButton()
        Me.PickPackSplitRadio = New System.Windows.Forms.RadioButton()
        Me.WarehouseStatsTable = New System.Windows.Forms.DataGridView()
        Me.EmpCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinglePickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxPickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiPickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinglePackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimeSpentRadio = New System.Windows.Forms.RadioButton()
        Me.TotalRadio = New System.Windows.Forms.RadioButton()
        Me.AverageRadio = New System.Windows.Forms.RadioButton()
        CType(Me.EmpPickingChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.WarehouseStatsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadAnalyticsBtn
        '
        Me.LoadAnalyticsBtn.Location = New System.Drawing.Point(15, 12)
        Me.LoadAnalyticsBtn.Name = "LoadAnalyticsBtn"
        Me.LoadAnalyticsBtn.Size = New System.Drawing.Size(121, 23)
        Me.LoadAnalyticsBtn.TabIndex = 1
        Me.LoadAnalyticsBtn.Text = "Load Analytics"
        Me.LoadAnalyticsBtn.UseVisualStyleBackColor = True
        '
        'FirstDate
        '
        Me.FirstDate.Location = New System.Drawing.Point(226, 11)
        Me.FirstDate.Name = "FirstDate"
        Me.FirstDate.Size = New System.Drawing.Size(200, 20)
        Me.FirstDate.TabIndex = 4
        '
        'SecondDate
        '
        Me.SecondDate.Location = New System.Drawing.Point(226, 37)
        Me.SecondDate.Name = "SecondDate"
        Me.SecondDate.Size = New System.Drawing.Size(200, 20)
        Me.SecondDate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To:"
        '
        'EmpPickingChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.EmpPickingChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.EmpPickingChart.Legends.Add(Legend1)
        Me.EmpPickingChart.Location = New System.Drawing.Point(432, 12)
        Me.EmpPickingChart.Name = "EmpPickingChart"
        Me.EmpPickingChart.Size = New System.Drawing.Size(1141, 828)
        Me.EmpPickingChart.TabIndex = 8
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PicklistSplitRadio)
        Me.Panel1.Controls.Add(Me.PickPackSplitRadio)
        Me.Panel1.Controls.Add(Me.NoSplitRadio)
        Me.Panel1.Location = New System.Drawing.Point(15, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 86)
        Me.Panel1.TabIndex = 10
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
        'WarehouseStatsTable
        '
        Me.WarehouseStatsTable.AllowUserToAddRows = False
        Me.WarehouseStatsTable.AllowUserToDeleteRows = False
        Me.WarehouseStatsTable.AllowUserToResizeRows = False
        Me.WarehouseStatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WarehouseStatsTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpCol, Me.SinglePickCol, Me.BoxPickCol, Me.MultiPickCol, Me.SinglePackCol, Me.BoxPackCol, Me.MultiPackCol})
        Me.WarehouseStatsTable.Location = New System.Drawing.Point(15, 155)
        Me.WarehouseStatsTable.Name = "WarehouseStatsTable"
        Me.WarehouseStatsTable.RowHeadersVisible = False
        Me.WarehouseStatsTable.Size = New System.Drawing.Size(411, 685)
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
        Me.SinglePickCol.HeaderText = "S-Pi"
        Me.SinglePickCol.Name = "SinglePickCol"
        Me.SinglePickCol.ReadOnly = True
        Me.SinglePickCol.Width = 50
        '
        'BoxPickCol
        '
        Me.BoxPickCol.HeaderText = "B-Pi"
        Me.BoxPickCol.Name = "BoxPickCol"
        Me.BoxPickCol.ReadOnly = True
        Me.BoxPickCol.Width = 50
        '
        'MultiPickCol
        '
        Me.MultiPickCol.HeaderText = "M-Pi"
        Me.MultiPickCol.Name = "MultiPickCol"
        Me.MultiPickCol.ReadOnly = True
        Me.MultiPickCol.Width = 50
        '
        'SinglePackCol
        '
        Me.SinglePackCol.HeaderText = "S-Pa"
        Me.SinglePackCol.Name = "SinglePackCol"
        Me.SinglePackCol.ReadOnly = True
        Me.SinglePackCol.Width = 50
        '
        'BoxPackCol
        '
        Me.BoxPackCol.HeaderText = "B-Pa"
        Me.BoxPackCol.Name = "BoxPackCol"
        Me.BoxPackCol.ReadOnly = True
        Me.BoxPackCol.Width = 50
        '
        'MultiPackCol
        '
        Me.MultiPackCol.HeaderText = "M-Pa"
        Me.MultiPackCol.Name = "MultiPackCol"
        Me.MultiPackCol.ReadOnly = True
        Me.MultiPackCol.Width = 50
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TimeSpentRadio)
        Me.Panel2.Controls.Add(Me.TotalRadio)
        Me.Panel2.Controls.Add(Me.AverageRadio)
        Me.Panel2.Location = New System.Drawing.Point(226, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 86)
        Me.Panel2.TabIndex = 13
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
        'AnalyticsBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 852)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WarehouseStatsTable)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EmpPickingChart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondDate)
        Me.Controls.Add(Me.FirstDate)
        Me.Controls.Add(Me.LoadAnalyticsBtn)
        Me.Name = "AnalyticsBaseForm"
        Me.Text = "Warehouse Analytics"
        CType(Me.EmpPickingChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WarehouseStatsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadAnalyticsBtn As Button
    Friend WithEvents FirstDate As DateTimePicker
    Friend WithEvents SecondDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EmpPickingChart As DataVisualization.Charting.Chart
    Friend WithEvents NoSplitRadio As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PicklistSplitRadio As RadioButton
    Friend WithEvents PickPackSplitRadio As RadioButton
    Friend WithEvents Label1 As Label
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TimeSpentRadio As RadioButton
    Friend WithEvents TotalRadio As RadioButton
    Friend WithEvents AverageRadio As RadioButton
End Class
