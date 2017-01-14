<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpChartControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmpPickingChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UserLbl = New System.Windows.Forms.Label()
        Me.TimeScaleLbl = New System.Windows.Forms.Label()
        Me.DaysInLbl = New System.Windows.Forms.Label()
        Me.DaysTotalLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.EmpPickingChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EmpPickingChart)
        Me.Panel1.Location = New System.Drawing.Point(120, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 110)
        Me.Panel1.TabIndex = 0
        '
        'EmpPickingChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.EmpPickingChart.ChartAreas.Add(ChartArea2)
        Me.EmpPickingChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.EmpPickingChart.Legends.Add(Legend2)
        Me.EmpPickingChart.Location = New System.Drawing.Point(0, 0)
        Me.EmpPickingChart.Name = "EmpPickingChart"
        Me.EmpPickingChart.Size = New System.Drawing.Size(539, 110)
        Me.EmpPickingChart.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DaysTotalLbl)
        Me.Panel2.Controls.Add(Me.DaysInLbl)
        Me.Panel2.Controls.Add(Me.TimeScaleLbl)
        Me.Panel2.Controls.Add(Me.UserLbl)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(111, 116)
        Me.Panel2.TabIndex = 1
        '
        'UserLbl
        '
        Me.UserLbl.AutoSize = True
        Me.UserLbl.Location = New System.Drawing.Point(3, 2)
        Me.UserLbl.Name = "UserLbl"
        Me.UserLbl.Size = New System.Drawing.Size(41, 13)
        Me.UserLbl.TabIndex = 0
        Me.UserLbl.Text = "(Name)"
        '
        'TimeScaleLbl
        '
        Me.TimeScaleLbl.AutoSize = True
        Me.TimeScaleLbl.Location = New System.Drawing.Point(3, 21)
        Me.TimeScaleLbl.Name = "TimeScaleLbl"
        Me.TimeScaleLbl.Size = New System.Drawing.Size(65, 13)
        Me.TimeScaleLbl.TabIndex = 1
        Me.TimeScaleLbl.Text = "(Days/Time)"
        '
        'DaysInLbl
        '
        Me.DaysInLbl.AutoSize = True
        Me.DaysInLbl.Location = New System.Drawing.Point(3, 34)
        Me.DaysInLbl.Name = "DaysInLbl"
        Me.DaysInLbl.Size = New System.Drawing.Size(13, 13)
        Me.DaysInLbl.TabIndex = 2
        Me.DaysInLbl.Text = "0"
        '
        'DaysTotalLbl
        '
        Me.DaysTotalLbl.AutoSize = True
        Me.DaysTotalLbl.Location = New System.Drawing.Point(54, 34)
        Me.DaysTotalLbl.Name = "DaysTotalLbl"
        Me.DaysTotalLbl.Size = New System.Drawing.Size(13, 13)
        Me.DaysTotalLbl.TabIndex = 3
        Me.DaysTotalLbl.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "/"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Days"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "State"
        '
        'EmpChartControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmpChartControl"
        Me.Size = New System.Drawing.Size(665, 122)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmpPickingChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmpPickingChart As DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DaysTotalLbl As Label
    Friend WithEvents DaysInLbl As Label
    Friend WithEvents TimeScaleLbl As Label
    Friend WithEvents UserLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
