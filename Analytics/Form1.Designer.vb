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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.ExcludePercCheck = New System.Windows.Forms.CheckBox()
        Me.ExcludePercTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SecondDate = New System.Windows.Forms.DateTimePicker()
        Me.FirstDate = New System.Windows.Forms.DateTimePicker()
        Me.LoadMultipleDaysBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TimeSelFromCB = New System.Windows.Forms.ComboBox()
        Me.TimeSelToCB = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxPanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmpSelectedLbl = New System.Windows.Forms.Label()
        Me.EmpCountLbl = New System.Windows.Forms.Label()
        Me.AllEmpsBtn = New System.Windows.Forms.Button()
        Me.NoEmpsBtn = New System.Windows.Forms.Button()
        Me.RefreshEmpsBtn = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PrepackPanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PickPackPanel = New System.Windows.Forms.Panel()
        Me.CheckPackMulti = New System.Windows.Forms.CheckBox()
        Me.CheckPackBox = New System.Windows.Forms.CheckBox()
        Me.CheckPackSingle = New System.Windows.Forms.CheckBox()
        Me.CheckPickMulti = New System.Windows.Forms.CheckBox()
        Me.CheckPickBox = New System.Windows.Forms.CheckBox()
        Me.CheckPickSingle = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AverageRadio = New System.Windows.Forms.RadioButton()
        Me.TotalRadio = New System.Windows.Forms.RadioButton()
        Me.TimeSpentRadio = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrepackChosen = New System.Windows.Forms.RadioButton()
        Me.PickPackChosen = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OrdersPerHourLbl = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.SettingsTab = New System.Windows.Forms.TabControl()
        Me.MultiDayTab = New System.Windows.Forms.TabPage()
        Me.SingleDayTab = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PPCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPackCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BPickCik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPickCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarehouseMultiDayStatsTable = New System.Windows.Forms.DataGridView()
        Me.EmpMultiDayPickingChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PrepackPanel.SuspendLayout()
        Me.PickPackPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        Me.MultiDayTab.SuspendLayout()
        Me.SingleDayTab.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.WarehouseMultiDayStatsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpMultiDayPickingChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExcludePercCheck
        '
        Me.ExcludePercCheck.AutoSize = True
        Me.ExcludePercCheck.Checked = True
        Me.ExcludePercCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExcludePercCheck.Location = New System.Drawing.Point(2, 19)
        Me.ExcludePercCheck.Name = "ExcludePercCheck"
        Me.ExcludePercCheck.Size = New System.Drawing.Size(15, 14)
        Me.ExcludePercCheck.TabIndex = 37
        Me.ExcludePercCheck.UseVisualStyleBackColor = True
        '
        'ExcludePercTxt
        '
        Me.ExcludePercTxt.Location = New System.Drawing.Point(154, 15)
        Me.ExcludePercTxt.Name = "ExcludePercTxt"
        Me.ExcludePercTxt.Size = New System.Drawing.Size(32, 20)
        Me.ExcludePercTxt.TabIndex = 36
        Me.ExcludePercTxt.Text = "2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(186, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "% of the largest value."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Exclude rows with less than:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "From:"
        '
        'SecondDate
        '
        Me.SecondDate.Location = New System.Drawing.Point(359, 8)
        Me.SecondDate.MinDate = New Date(2016, 8, 4, 0, 0, 0, 0)
        Me.SecondDate.Name = "SecondDate"
        Me.SecondDate.Size = New System.Drawing.Size(160, 20)
        Me.SecondDate.TabIndex = 24
        '
        'FirstDate
        '
        Me.FirstDate.Checked = False
        Me.FirstDate.Location = New System.Drawing.Point(163, 8)
        Me.FirstDate.MinDate = New Date(2016, 8, 4, 0, 0, 0, 0)
        Me.FirstDate.Name = "FirstDate"
        Me.FirstDate.Size = New System.Drawing.Size(160, 20)
        Me.FirstDate.TabIndex = 23
        '
        'LoadMultipleDaysBtn
        '
        Me.LoadMultipleDaysBtn.Location = New System.Drawing.Point(6, 6)
        Me.LoadMultipleDaysBtn.Name = "LoadMultipleDaysBtn"
        Me.LoadMultipleDaysBtn.Size = New System.Drawing.Size(121, 23)
        Me.LoadMultipleDaysBtn.TabIndex = 22
        Me.LoadMultipleDaysBtn.Text = "Load multiple days"
        Me.LoadMultipleDaysBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "On:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(359, 8)
        Me.DateTimePicker1.MinDate = New Date(2016, 8, 4, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 41
        '
        'TimeSelFromCB
        '
        Me.TimeSelFromCB.FormattingEnabled = True
        Me.TimeSelFromCB.Items.AddRange(New Object() {"8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00"})
        Me.TimeSelFromCB.Location = New System.Drawing.Point(163, 7)
        Me.TimeSelFromCB.Name = "TimeSelFromCB"
        Me.TimeSelFromCB.Size = New System.Drawing.Size(57, 21)
        Me.TimeSelFromCB.TabIndex = 42
        Me.TimeSelFromCB.Text = "8:00"
        '
        'TimeSelToCB
        '
        Me.TimeSelToCB.FormattingEnabled = True
        Me.TimeSelToCB.Items.AddRange(New Object() {"8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00"})
        Me.TimeSelToCB.Location = New System.Drawing.Point(266, 7)
        Me.TimeSelToCB.Name = "TimeSelToCB"
        Me.TimeSelToCB.Size = New System.Drawing.Size(57, 21)
        Me.TimeSelToCB.TabIndex = 43
        Me.TimeSelToCB.Text = "18:00"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Load single day"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxPanel
        '
        Me.CheckBoxPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxPanel.AutoScroll = True
        Me.CheckBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckBoxPanel.Location = New System.Drawing.Point(12, 125)
        Me.CheckBoxPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxPanel.MaximumSize = New System.Drawing.Size(192, 3000)
        Me.CheckBoxPanel.MinimumSize = New System.Drawing.Size(192, 355)
        Me.CheckBoxPanel.Name = "CheckBoxPanel"
        Me.CheckBoxPanel.Size = New System.Drawing.Size(192, 649)
        Me.CheckBoxPanel.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 804)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Employee Count:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 817)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Employees Selected:"
        '
        'EmpSelectedLbl
        '
        Me.EmpSelectedLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EmpSelectedLbl.AutoSize = True
        Me.EmpSelectedLbl.Location = New System.Drawing.Point(125, 817)
        Me.EmpSelectedLbl.Name = "EmpSelectedLbl"
        Me.EmpSelectedLbl.Size = New System.Drawing.Size(13, 13)
        Me.EmpSelectedLbl.TabIndex = 49
        Me.EmpSelectedLbl.Text = "0"
        '
        'EmpCountLbl
        '
        Me.EmpCountLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EmpCountLbl.AutoSize = True
        Me.EmpCountLbl.Location = New System.Drawing.Point(125, 804)
        Me.EmpCountLbl.Name = "EmpCountLbl"
        Me.EmpCountLbl.Size = New System.Drawing.Size(13, 13)
        Me.EmpCountLbl.TabIndex = 48
        Me.EmpCountLbl.Text = "0"
        '
        'AllEmpsBtn
        '
        Me.AllEmpsBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AllEmpsBtn.Location = New System.Drawing.Point(86, 777)
        Me.AllEmpsBtn.Name = "AllEmpsBtn"
        Me.AllEmpsBtn.Size = New System.Drawing.Size(59, 26)
        Me.AllEmpsBtn.TabIndex = 51
        Me.AllEmpsBtn.Text = "Select All"
        Me.AllEmpsBtn.UseVisualStyleBackColor = True
        '
        'NoEmpsBtn
        '
        Me.NoEmpsBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NoEmpsBtn.Location = New System.Drawing.Point(13, 777)
        Me.NoEmpsBtn.Name = "NoEmpsBtn"
        Me.NoEmpsBtn.Size = New System.Drawing.Size(72, 26)
        Me.NoEmpsBtn.TabIndex = 53
        Me.NoEmpsBtn.Text = "Deselect All"
        Me.NoEmpsBtn.UseVisualStyleBackColor = True
        '
        'RefreshEmpsBtn
        '
        Me.RefreshEmpsBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RefreshEmpsBtn.Location = New System.Drawing.Point(146, 777)
        Me.RefreshEmpsBtn.Name = "RefreshEmpsBtn"
        Me.RefreshEmpsBtn.Size = New System.Drawing.Size(59, 26)
        Me.RefreshEmpsBtn.TabIndex = 54
        Me.RefreshEmpsBtn.Text = "Refresh"
        Me.RefreshEmpsBtn.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.WarehouseMultiDayStatsTable)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EmpMultiDayPickingChart)
        Me.SplitContainer1.Size = New System.Drawing.Size(987, 659)
        Me.SplitContainer1.SplitterDistance = 342
        Me.SplitContainer1.TabIndex = 55
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Location = New System.Drawing.Point(917, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 79)
        Me.Panel5.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Other Settings"
        '
        'PrepackPanel
        '
        Me.PrepackPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PrepackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrepackPanel.Controls.Add(Me.CheckBox1)
        Me.PrepackPanel.Controls.Add(Me.CheckBox2)
        Me.PrepackPanel.Controls.Add(Me.CheckBox3)
        Me.PrepackPanel.Controls.Add(Me.CheckBox4)
        Me.PrepackPanel.Controls.Add(Me.CheckBox5)
        Me.PrepackPanel.Controls.Add(Me.CheckBox6)
        Me.PrepackPanel.Controls.Add(Me.Label12)
        Me.PrepackPanel.Enabled = False
        Me.PrepackPanel.Location = New System.Drawing.Point(612, 2)
        Me.PrepackPanel.Name = "PrepackPanel"
        Me.PrepackPanel.Size = New System.Drawing.Size(296, 79)
        Me.PrepackPanel.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Prepack Settings"
        '
        'PickPackPanel
        '
        Me.PickPackPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PickPackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PickPackPanel.Controls.Add(Me.CheckPackMulti)
        Me.PickPackPanel.Controls.Add(Me.CheckPackBox)
        Me.PickPackPanel.Controls.Add(Me.CheckPackSingle)
        Me.PickPackPanel.Controls.Add(Me.CheckPickMulti)
        Me.PickPackPanel.Controls.Add(Me.CheckPickBox)
        Me.PickPackPanel.Controls.Add(Me.CheckPickSingle)
        Me.PickPackPanel.Controls.Add(Me.Label11)
        Me.PickPackPanel.Location = New System.Drawing.Point(308, 2)
        Me.PickPackPanel.Name = "PickPackPanel"
        Me.PickPackPanel.Size = New System.Drawing.Size(296, 79)
        Me.PickPackPanel.TabIndex = 1
        '
        'CheckPackMulti
        '
        Me.CheckPackMulti.AutoSize = True
        Me.CheckPackMulti.Location = New System.Drawing.Point(214, 55)
        Me.CheckPackMulti.Name = "CheckPackMulti"
        Me.CheckPackMulti.Size = New System.Drawing.Size(77, 17)
        Me.CheckPackMulti.TabIndex = 47
        Me.CheckPackMulti.Text = "Packing M"
        Me.CheckPackMulti.UseVisualStyleBackColor = True
        '
        'CheckPackBox
        '
        Me.CheckPackBox.AutoSize = True
        Me.CheckPackBox.Location = New System.Drawing.Point(110, 55)
        Me.CheckPackBox.Name = "CheckPackBox"
        Me.CheckPackBox.Size = New System.Drawing.Size(75, 17)
        Me.CheckPackBox.TabIndex = 46
        Me.CheckPackBox.Text = "Packing B"
        Me.CheckPackBox.UseVisualStyleBackColor = True
        '
        'CheckPackSingle
        '
        Me.CheckPackSingle.AutoSize = True
        Me.CheckPackSingle.Location = New System.Drawing.Point(7, 55)
        Me.CheckPackSingle.Name = "CheckPackSingle"
        Me.CheckPackSingle.Size = New System.Drawing.Size(75, 17)
        Me.CheckPackSingle.TabIndex = 45
        Me.CheckPackSingle.Text = "Packing S"
        Me.CheckPackSingle.UseVisualStyleBackColor = True
        '
        'CheckPickMulti
        '
        Me.CheckPickMulti.AutoSize = True
        Me.CheckPickMulti.Location = New System.Drawing.Point(214, 37)
        Me.CheckPickMulti.Name = "CheckPickMulti"
        Me.CheckPickMulti.Size = New System.Drawing.Size(73, 17)
        Me.CheckPickMulti.TabIndex = 44
        Me.CheckPickMulti.Text = "Picking M"
        Me.CheckPickMulti.UseVisualStyleBackColor = True
        '
        'CheckPickBox
        '
        Me.CheckPickBox.AutoSize = True
        Me.CheckPickBox.Location = New System.Drawing.Point(110, 37)
        Me.CheckPickBox.Name = "CheckPickBox"
        Me.CheckPickBox.Size = New System.Drawing.Size(71, 17)
        Me.CheckPickBox.TabIndex = 43
        Me.CheckPickBox.Text = "Picking B"
        Me.CheckPickBox.UseVisualStyleBackColor = True
        '
        'CheckPickSingle
        '
        Me.CheckPickSingle.AutoSize = True
        Me.CheckPickSingle.Location = New System.Drawing.Point(7, 37)
        Me.CheckPickSingle.Name = "CheckPickSingle"
        Me.CheckPickSingle.Size = New System.Drawing.Size(71, 17)
        Me.CheckPickSingle.TabIndex = 42
        Me.CheckPickSingle.Text = "Picking S"
        Me.CheckPickSingle.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(174, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Picking and Packing Settings"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.ExcludePercCheck)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ExcludePercTxt)
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 79)
        Me.Panel2.TabIndex = 0
        '
        'AverageRadio
        '
        Me.AverageRadio.AutoSize = True
        Me.AverageRadio.Location = New System.Drawing.Point(155, 2)
        Me.AverageRadio.Name = "AverageRadio"
        Me.AverageRadio.Size = New System.Drawing.Size(65, 17)
        Me.AverageRadio.TabIndex = 43
        Me.AverageRadio.Text = "Average"
        Me.AverageRadio.UseVisualStyleBackColor = True
        '
        'TotalRadio
        '
        Me.TotalRadio.AutoSize = True
        Me.TotalRadio.Location = New System.Drawing.Point(77, 2)
        Me.TotalRadio.Name = "TotalRadio"
        Me.TotalRadio.Size = New System.Drawing.Size(49, 17)
        Me.TotalRadio.TabIndex = 42
        Me.TotalRadio.Text = "Total"
        Me.TotalRadio.UseVisualStyleBackColor = True
        '
        'TimeSpentRadio
        '
        Me.TimeSpentRadio.AutoSize = True
        Me.TimeSpentRadio.Checked = True
        Me.TimeSpentRadio.Location = New System.Drawing.Point(3, 2)
        Me.TimeSpentRadio.Name = "TimeSpentRadio"
        Me.TimeSpentRadio.Size = New System.Drawing.Size(48, 17)
        Me.TimeSpentRadio.TabIndex = 41
        Me.TimeSpentRadio.TabStop = True
        Me.TimeSpentRadio.Text = "Time"
        Me.TimeSpentRadio.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-1, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Basic Settings"
        '
        'PrepackChosen
        '
        Me.PrepackChosen.AutoSize = True
        Me.PrepackChosen.Location = New System.Drawing.Point(155, 1)
        Me.PrepackChosen.Name = "PrepackChosen"
        Me.PrepackChosen.Size = New System.Drawing.Size(65, 17)
        Me.PrepackChosen.TabIndex = 39
        Me.PrepackChosen.Text = "Prepack"
        Me.PrepackChosen.UseVisualStyleBackColor = True
        '
        'PickPackChosen
        '
        Me.PickPackChosen.AutoSize = True
        Me.PickPackChosen.Checked = True
        Me.PickPackChosen.Location = New System.Drawing.Point(3, 1)
        Me.PickPackChosen.Name = "PickPackChosen"
        Me.PickPackChosen.Size = New System.Drawing.Size(123, 17)
        Me.PickPackChosen.TabIndex = 38
        Me.PickPackChosen.TabStop = True
        Me.PickPackChosen.Text = "Picking and Packing"
        Me.PickPackChosen.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PickPackChosen)
        Me.Panel4.Controls.Add(Me.PrepackChosen)
        Me.Panel4.Location = New System.Drawing.Point(3, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(288, 19)
        Me.Panel4.TabIndex = 44
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TimeSpentRadio)
        Me.Panel6.Controls.Add(Me.TotalRadio)
        Me.Panel6.Controls.Add(Me.AverageRadio)
        Me.Panel6.Location = New System.Drawing.Point(3, 55)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(288, 21)
        Me.Panel6.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Total Orders Per Hour:"
        '
        'OrdersPerHourLbl
        '
        Me.OrdersPerHourLbl.AutoSize = True
        Me.OrdersPerHourLbl.Location = New System.Drawing.Point(128, 104)
        Me.OrdersPerHourLbl.Name = "OrdersPerHourLbl"
        Me.OrdersPerHourLbl.Size = New System.Drawing.Size(13, 13)
        Me.OrdersPerHourLbl.TabIndex = 58
        Me.OrdersPerHourLbl.Text = "0"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(198, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox1.TabIndex = 53
        Me.CheckBox1.Text = "(Placeholder)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(102, 55)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox2.TabIndex = 52
        Me.CheckBox2.Text = "(Placeholder)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(7, 55)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox3.TabIndex = 51
        Me.CheckBox3.Text = "(Placeholder)"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(198, 37)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox4.TabIndex = 50
        Me.CheckBox4.Text = "(Placeholder)"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(102, 37)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox5.TabIndex = 49
        Me.CheckBox5.Text = "(Placeholder)"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(7, 37)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox6.TabIndex = 48
        Me.CheckBox6.Text = "(Placeholder)"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'SettingsTab
        '
        Me.SettingsTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsTab.Controls.Add(Me.MultiDayTab)
        Me.SettingsTab.Controls.Add(Me.SingleDayTab)
        Me.SettingsTab.Location = New System.Drawing.Point(207, 104)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.SelectedIndex = 0
        Me.SettingsTab.Size = New System.Drawing.Size(1021, 726)
        Me.SettingsTab.TabIndex = 59
        '
        'MultiDayTab
        '
        Me.MultiDayTab.Controls.Add(Me.LoadMultipleDaysBtn)
        Me.MultiDayTab.Controls.Add(Me.FirstDate)
        Me.MultiDayTab.Controls.Add(Me.SecondDate)
        Me.MultiDayTab.Controls.Add(Me.Label2)
        Me.MultiDayTab.Controls.Add(Me.SplitContainer1)
        Me.MultiDayTab.Controls.Add(Me.Label3)
        Me.MultiDayTab.Location = New System.Drawing.Point(4, 22)
        Me.MultiDayTab.Name = "MultiDayTab"
        Me.MultiDayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MultiDayTab.Size = New System.Drawing.Size(1013, 700)
        Me.MultiDayTab.TabIndex = 0
        Me.MultiDayTab.Text = "Multiple Days"
        Me.MultiDayTab.UseVisualStyleBackColor = True
        '
        'SingleDayTab
        '
        Me.SingleDayTab.Controls.Add(Me.SplitContainer2)
        Me.SingleDayTab.Controls.Add(Me.Button1)
        Me.SingleDayTab.Controls.Add(Me.Label1)
        Me.SingleDayTab.Controls.Add(Me.Label4)
        Me.SingleDayTab.Controls.Add(Me.Label5)
        Me.SingleDayTab.Controls.Add(Me.DateTimePicker1)
        Me.SingleDayTab.Controls.Add(Me.TimeSelFromCB)
        Me.SingleDayTab.Controls.Add(Me.TimeSelToCB)
        Me.SingleDayTab.Location = New System.Drawing.Point(4, 22)
        Me.SingleDayTab.Name = "SingleDayTab"
        Me.SingleDayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SingleDayTab.Size = New System.Drawing.Size(1013, 700)
        Me.SingleDayTab.TabIndex = 1
        Me.SingleDayTab.Text = "Single Day"
        Me.SingleDayTab.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(6, 35)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1001, 659)
        Me.SplitContainer2.SplitterDistance = 342
        Me.SplitContainer2.TabIndex = 45
        '
        'PPCol
        '
        Me.PPCol.HeaderText = "PP"
        Me.PPCol.Name = "PPCol"
        Me.PPCol.ReadOnly = True
        Me.PPCol.Width = 40
        '
        'MPackCol
        '
        Me.MPackCol.HeaderText = "MPa"
        Me.MPackCol.Name = "MPackCol"
        Me.MPackCol.ReadOnly = True
        Me.MPackCol.Width = 40
        '
        'BPackCol
        '
        Me.BPackCol.HeaderText = "BPa"
        Me.BPackCol.Name = "BPackCol"
        Me.BPackCol.ReadOnly = True
        Me.BPackCol.Width = 40
        '
        'SPackCol
        '
        Me.SPackCol.HeaderText = "SPa"
        Me.SPackCol.Name = "SPackCol"
        Me.SPackCol.ReadOnly = True
        Me.SPackCol.Width = 40
        '
        'MPickCol
        '
        Me.MPickCol.HeaderText = "MPi"
        Me.MPickCol.Name = "MPickCol"
        Me.MPickCol.ReadOnly = True
        Me.MPickCol.Width = 40
        '
        'BPickCik
        '
        Me.BPickCik.HeaderText = "BPi"
        Me.BPickCik.Name = "BPickCik"
        Me.BPickCik.ReadOnly = True
        Me.BPickCik.Width = 40
        '
        'SPickCol
        '
        Me.SPickCol.HeaderText = "SPi"
        Me.SPickCol.Name = "SPickCol"
        Me.SPickCol.ReadOnly = True
        Me.SPickCol.Width = 40
        '
        'IDCol
        '
        Me.IDCol.HeaderText = "ID"
        Me.IDCol.Name = "IDCol"
        Me.IDCol.ReadOnly = True
        Me.IDCol.Width = 40
        '
        'WarehouseMultiDayStatsTable
        '
        Me.WarehouseMultiDayStatsTable.AllowUserToAddRows = False
        Me.WarehouseMultiDayStatsTable.AllowUserToDeleteRows = False
        Me.WarehouseMultiDayStatsTable.AllowUserToResizeRows = False
        Me.WarehouseMultiDayStatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WarehouseMultiDayStatsTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCol, Me.SPickCol, Me.BPickCik, Me.MPickCol, Me.SPackCol, Me.BPackCol, Me.MPackCol, Me.PPCol})
        Me.WarehouseMultiDayStatsTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WarehouseMultiDayStatsTable.Location = New System.Drawing.Point(0, 0)
        Me.WarehouseMultiDayStatsTable.Name = "WarehouseMultiDayStatsTable"
        Me.WarehouseMultiDayStatsTable.ReadOnly = True
        Me.WarehouseMultiDayStatsTable.RowHeadersVisible = False
        Me.WarehouseMultiDayStatsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.WarehouseMultiDayStatsTable.Size = New System.Drawing.Size(342, 659)
        Me.WarehouseMultiDayStatsTable.TabIndex = 0
        '
        'EmpMultiDayPickingChart
        '
        ChartArea3.Name = "ChartArea1"
        Me.EmpMultiDayPickingChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.EmpMultiDayPickingChart.Legends.Add(Legend3)
        Me.EmpMultiDayPickingChart.Location = New System.Drawing.Point(0, 0)
        Me.EmpMultiDayPickingChart.Name = "EmpMultiDayPickingChart"
        Me.EmpMultiDayPickingChart.Size = New System.Drawing.Size(641, 681)
        Me.EmpMultiDayPickingChart.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(342, 659)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "SPi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "BPi"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "MPi"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "SPa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "BPa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "MPa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "PP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.AutoScroll = True
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(655, 659)
        Me.Panel3.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.PrepackPanel)
        Me.Panel1.Controls.Add(Me.PickPackPanel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1216, 86)
        Me.Panel1.TabIndex = 56
        '
        'AnalyticsBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 842)
        Me.Controls.Add(Me.OrdersPerHourLbl)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.SettingsTab)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RefreshEmpsBtn)
        Me.Controls.Add(Me.NoEmpsBtn)
        Me.Controls.Add(Me.AllEmpsBtn)
        Me.Controls.Add(Me.EmpSelectedLbl)
        Me.Controls.Add(Me.EmpCountLbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBoxPanel)
        Me.MinimumSize = New System.Drawing.Size(1256, 881)
        Me.Name = "AnalyticsBaseForm"
        Me.Text = "Warehouse Analytics"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PrepackPanel.ResumeLayout(False)
        Me.PrepackPanel.PerformLayout()
        Me.PickPackPanel.ResumeLayout(False)
        Me.PickPackPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.SettingsTab.ResumeLayout(False)
        Me.MultiDayTab.ResumeLayout(False)
        Me.MultiDayTab.PerformLayout()
        Me.SingleDayTab.ResumeLayout(False)
        Me.SingleDayTab.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.WarehouseMultiDayStatsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpMultiDayPickingChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MixedPickCol As DataGridViewTextBoxColumn
    Friend WithEvents MixedPackCol As DataGridViewTextBoxColumn
    Friend WithEvents ExcludePercCheck As CheckBox
    Friend WithEvents ExcludePercTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SecondDate As DateTimePicker
    Friend WithEvents FirstDate As DateTimePicker
    Friend WithEvents LoadMultipleDaysBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TimeSelFromCB As ComboBox
    Friend WithEvents TimeSelToCB As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EmpSelectedLbl As Label
    Friend WithEvents EmpCountLbl As Label
    Friend WithEvents AllEmpsBtn As Button
    Friend WithEvents NoEmpsBtn As Button
    Friend WithEvents RefreshEmpsBtn As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents PrepackPanel As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PickPackPanel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PrepackChosen As RadioButton
    Friend WithEvents PickPackChosen As RadioButton
    Friend WithEvents CheckPackMulti As CheckBox
    Friend WithEvents CheckPackBox As CheckBox
    Friend WithEvents CheckPackSingle As CheckBox
    Friend WithEvents CheckPickMulti As CheckBox
    Friend WithEvents CheckPickBox As CheckBox
    Friend WithEvents CheckPickSingle As CheckBox
    Friend WithEvents AverageRadio As RadioButton
    Friend WithEvents TotalRadio As RadioButton
    Friend WithEvents TimeSpentRadio As RadioButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents OrdersPerHourLbl As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents WarehouseMultiDayStatsTable As DataGridView
    Friend WithEvents IDCol As DataGridViewTextBoxColumn
    Friend WithEvents SPickCol As DataGridViewTextBoxColumn
    Friend WithEvents BPickCik As DataGridViewTextBoxColumn
    Friend WithEvents MPickCol As DataGridViewTextBoxColumn
    Friend WithEvents SPackCol As DataGridViewTextBoxColumn
    Friend WithEvents BPackCol As DataGridViewTextBoxColumn
    Friend WithEvents MPackCol As DataGridViewTextBoxColumn
    Friend WithEvents PPCol As DataGridViewTextBoxColumn
    Friend WithEvents EmpMultiDayPickingChart As DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SettingsTab As TabControl
    Friend WithEvents MultiDayTab As TabPage
    Friend WithEvents SingleDayTab As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
End Class
