<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShipMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FactionSelect = New System.Windows.Forms.ComboBox()
        Me.FactionStory = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HullSelect = New System.Windows.Forms.ComboBox()
        Me.EngineSelect = New System.Windows.Forms.ComboBox()
        Me.ShieldSelect = New System.Windows.Forms.ComboBox()
        Me.ReactorSelect = New System.Windows.Forms.ComboBox()
        Me.DriveSelect = New System.Windows.Forms.ComboBox()
        Me.ShipSelect = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Wep_Slot = New System.Windows.Forms.Label()
        Me.Util_Slot = New System.Windows.Forms.Label()
        Me.Crew_Max = New System.Windows.Forms.Label()
        Me.ShipCreate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.perks = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.DimGray
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(-1, 421)
        Me.ListBox1.MaximumSize = New System.Drawing.Size(507, 244)
        Me.ListBox1.MinimumSize = New System.Drawing.Size(507, 244)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(507, 244)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Starting Faction"
        '
        'FactionSelect
        '
        Me.FactionSelect.BackColor = System.Drawing.Color.DimGray
        Me.FactionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FactionSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FactionSelect.ForeColor = System.Drawing.Color.White
        Me.FactionSelect.FormattingEnabled = True
        Me.FactionSelect.Items.AddRange(New Object() {"Hive", "Pirates", "Empire", "Federation"})
        Me.FactionSelect.Location = New System.Drawing.Point(252, 24)
        Me.FactionSelect.Name = "FactionSelect"
        Me.FactionSelect.Size = New System.Drawing.Size(254, 33)
        Me.FactionSelect.TabIndex = 2
        '
        'FactionStory
        '
        Me.FactionStory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FactionStory.Location = New System.Drawing.Point(13, 69)
        Me.FactionStory.Name = "FactionStory"
        Me.FactionStory.Size = New System.Drawing.Size(493, 268)
        Me.FactionStory.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(512, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hull"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Engine"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shield"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(512, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Reactor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "IS Drive"
        '
        'HullSelect
        '
        Me.HullSelect.BackColor = System.Drawing.Color.DimGray
        Me.HullSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HullSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HullSelect.ForeColor = System.Drawing.Color.White
        Me.HullSelect.FormattingEnabled = True
        Me.HullSelect.Location = New System.Drawing.Point(688, 96)
        Me.HullSelect.Name = "HullSelect"
        Me.HullSelect.Size = New System.Drawing.Size(541, 33)
        Me.HullSelect.TabIndex = 10
        '
        'EngineSelect
        '
        Me.EngineSelect.BackColor = System.Drawing.Color.DimGray
        Me.EngineSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EngineSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EngineSelect.ForeColor = System.Drawing.Color.White
        Me.EngineSelect.FormattingEnabled = True
        Me.EngineSelect.Location = New System.Drawing.Point(688, 163)
        Me.EngineSelect.Name = "EngineSelect"
        Me.EngineSelect.Size = New System.Drawing.Size(541, 33)
        Me.EngineSelect.TabIndex = 11
        '
        'ShieldSelect
        '
        Me.ShieldSelect.BackColor = System.Drawing.Color.DimGray
        Me.ShieldSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShieldSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShieldSelect.ForeColor = System.Drawing.Color.White
        Me.ShieldSelect.FormattingEnabled = True
        Me.ShieldSelect.Location = New System.Drawing.Point(688, 233)
        Me.ShieldSelect.Name = "ShieldSelect"
        Me.ShieldSelect.Size = New System.Drawing.Size(541, 33)
        Me.ShieldSelect.TabIndex = 12
        '
        'ReactorSelect
        '
        Me.ReactorSelect.BackColor = System.Drawing.Color.DimGray
        Me.ReactorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReactorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReactorSelect.ForeColor = System.Drawing.Color.White
        Me.ReactorSelect.FormattingEnabled = True
        Me.ReactorSelect.Location = New System.Drawing.Point(688, 304)
        Me.ReactorSelect.Name = "ReactorSelect"
        Me.ReactorSelect.Size = New System.Drawing.Size(541, 33)
        Me.ReactorSelect.TabIndex = 13
        '
        'DriveSelect
        '
        Me.DriveSelect.BackColor = System.Drawing.Color.DimGray
        Me.DriveSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DriveSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DriveSelect.ForeColor = System.Drawing.Color.White
        Me.DriveSelect.FormattingEnabled = True
        Me.DriveSelect.Location = New System.Drawing.Point(688, 371)
        Me.DriveSelect.Name = "DriveSelect"
        Me.DriveSelect.Size = New System.Drawing.Size(541, 33)
        Me.DriveSelect.TabIndex = 14
        '
        'ShipSelect
        '
        Me.ShipSelect.BackColor = System.Drawing.Color.DimGray
        Me.ShipSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShipSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShipSelect.ForeColor = System.Drawing.Color.White
        Me.ShipSelect.FormattingEnabled = True
        Me.ShipSelect.Location = New System.Drawing.Point(688, 24)
        Me.ShipSelect.Name = "ShipSelect"
        Me.ShipSelect.Size = New System.Drawing.Size(541, 33)
        Me.ShipSelect.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(512, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 26)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Startin Ship"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 606)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 26)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Crew(Max)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(512, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Wepon slots"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(512, 524)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Utility slots"
        '
        'Wep_Slot
        '
        Me.Wep_Slot.AutoSize = True
        Me.Wep_Slot.Location = New System.Drawing.Point(683, 441)
        Me.Wep_Slot.Name = "Wep_Slot"
        Me.Wep_Slot.Size = New System.Drawing.Size(24, 26)
        Me.Wep_Slot.TabIndex = 21
        Me.Wep_Slot.Text = "0"
        '
        'Util_Slot
        '
        Me.Util_Slot.AutoSize = True
        Me.Util_Slot.Location = New System.Drawing.Point(683, 524)
        Me.Util_Slot.Name = "Util_Slot"
        Me.Util_Slot.Size = New System.Drawing.Size(24, 26)
        Me.Util_Slot.TabIndex = 22
        Me.Util_Slot.Text = "0"
        '
        'Crew_Max
        '
        Me.Crew_Max.AutoSize = True
        Me.Crew_Max.Location = New System.Drawing.Point(683, 606)
        Me.Crew_Max.Name = "Crew_Max"
        Me.Crew_Max.Size = New System.Drawing.Size(24, 26)
        Me.Crew_Max.TabIndex = 23
        Me.Crew_Max.Text = "0"
        '
        'ShipCreate
        '
        Me.ShipCreate.BackColor = System.Drawing.Color.Gray
        Me.ShipCreate.FlatAppearance.BorderSize = 0
        Me.ShipCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShipCreate.Location = New System.Drawing.Point(1070, 582)
        Me.ShipCreate.Name = "ShipCreate"
        Me.ShipCreate.Size = New System.Drawing.Size(173, 83)
        Me.ShipCreate.TabIndex = 24
        Me.ShipCreate.Text = "Finish" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.ShipCreate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.perks)
        Me.Panel1.Location = New System.Drawing.Point(-1, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 291)
        Me.Panel1.TabIndex = 25
        '
        'perks
        '
        Me.perks.AutoSize = True
        Me.perks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.perks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perks.Location = New System.Drawing.Point(0, 0)
        Me.perks.MaximumSize = New System.Drawing.Size(500, 0)
        Me.perks.Name = "perks"
        Me.perks.Size = New System.Drawing.Size(0, 20)
        Me.perks.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 345)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 26)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Perks"
        '
        'ShipMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1241, 661)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShipCreate)
        Me.Controls.Add(Me.Crew_Max)
        Me.Controls.Add(Me.Util_Slot)
        Me.Controls.Add(Me.Wep_Slot)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ShipSelect)
        Me.Controls.Add(Me.DriveSelect)
        Me.Controls.Add(Me.ReactorSelect)
        Me.Controls.Add(Me.ShieldSelect)
        Me.Controls.Add(Me.EngineSelect)
        Me.Controls.Add(Me.HullSelect)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FactionStory)
        Me.Controls.Add(Me.FactionSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "ShipMaker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FactionSelect As ComboBox
    Friend WithEvents FactionStory As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents HullSelect As ComboBox
    Friend WithEvents EngineSelect As ComboBox
    Friend WithEvents ShieldSelect As ComboBox
    Friend WithEvents ReactorSelect As ComboBox
    Friend WithEvents DriveSelect As ComboBox
    Friend WithEvents ShipSelect As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Wep_Slot As Label
    Friend WithEvents Util_Slot As Label
    Friend WithEvents Crew_Max As Label
    Friend WithEvents ShipCreate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents perks As Label
    Friend WithEvents Label11 As Label
End Class
