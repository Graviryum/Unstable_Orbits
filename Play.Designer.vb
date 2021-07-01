<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Play
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Money = New System.Windows.Forms.Label()
        Me.IS_Fuel = New System.Windows.Forms.Label()
        Me.IP_Fuel = New System.Windows.Forms.Label()
        Me.Ship_Health = New System.Windows.Forms.Label()
        Me.Cap_Health = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Open_Ship = New System.Windows.Forms.Button()
        Me.PC_ShipName = New System.Windows.Forms.Label()
        Me.PC_Name = New System.Windows.Forms.Label()
        Me.SaveProg = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainText = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ActionList = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Money)
        Me.Panel1.Controls.Add(Me.IS_Fuel)
        Me.Panel1.Controls.Add(Me.IP_Fuel)
        Me.Panel1.Controls.Add(Me.Ship_Health)
        Me.Panel1.Controls.Add(Me.Cap_Health)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Open_Ship)
        Me.Panel1.Controls.Add(Me.PC_ShipName)
        Me.Panel1.Controls.Add(Me.PC_Name)
        Me.Panel1.Controls.Add(Me.SaveProg)
        Me.Panel1.Controls.Add(Me.Settings)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 681)
        Me.Panel1.TabIndex = 0
        '
        'Money
        '
        Me.Money.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Money.Location = New System.Drawing.Point(12, 448)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(203, 24)
        Me.Money.TabIndex = 16
        Me.Money.Text = "3000"
        Me.Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IS_Fuel
        '
        Me.IS_Fuel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IS_Fuel.AutoSize = True
        Me.IS_Fuel.Location = New System.Drawing.Point(142, 345)
        Me.IS_Fuel.Name = "IS_Fuel"
        Me.IS_Fuel.Size = New System.Drawing.Size(20, 24)
        Me.IS_Fuel.TabIndex = 15
        Me.IS_Fuel.Text = "6"
        Me.IS_Fuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IP_Fuel
        '
        Me.IP_Fuel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IP_Fuel.AutoSize = True
        Me.IP_Fuel.Location = New System.Drawing.Point(142, 280)
        Me.IP_Fuel.Name = "IP_Fuel"
        Me.IP_Fuel.Size = New System.Drawing.Size(30, 24)
        Me.IP_Fuel.TabIndex = 14
        Me.IP_Fuel.Text = "20"
        Me.IP_Fuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ship_Health
        '
        Me.Ship_Health.AutoSize = True
        Me.Ship_Health.Location = New System.Drawing.Point(142, 173)
        Me.Ship_Health.Name = "Ship_Health"
        Me.Ship_Health.Size = New System.Drawing.Size(50, 24)
        Me.Ship_Health.TabIndex = 13
        Me.Ship_Health.Text = "7600"
        Me.Ship_Health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cap_Health
        '
        Me.Cap_Health.AutoSize = True
        Me.Cap_Health.Location = New System.Drawing.Point(142, 108)
        Me.Cap_Health.Name = "Cap_Health"
        Me.Cap_Health.Size = New System.Drawing.Size(30, 24)
        Me.Cap_Health.TabIndex = 12
        Me.Cap_Health.Text = "80"
        Me.Cap_Health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ship"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Captain"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Interstellar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Interplanetary"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(12, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Money"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.Location = New System.Drawing.Point(12, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fuel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Health"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Open_Ship
        '
        Me.Open_Ship.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Open_Ship.BackColor = System.Drawing.Color.DimGray
        Me.Open_Ship.FlatAppearance.BorderSize = 0
        Me.Open_Ship.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Open_Ship.Location = New System.Drawing.Point(0, 492)
        Me.Open_Ship.Name = "Open_Ship"
        Me.Open_Ship.Size = New System.Drawing.Size(224, 63)
        Me.Open_Ship.TabIndex = 4
        Me.Open_Ship.Text = "Ship"
        Me.Open_Ship.UseVisualStyleBackColor = False
        '
        'PC_ShipName
        '
        Me.PC_ShipName.AutoSize = True
        Me.PC_ShipName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC_ShipName.Location = New System.Drawing.Point(12, 33)
        Me.PC_ShipName.Name = "PC_ShipName"
        Me.PC_ShipName.Size = New System.Drawing.Size(113, 20)
        Me.PC_ShipName.TabIndex = 3
        Me.PC_ShipName.Text = "PC_ShipName"
        '
        'PC_Name
        '
        Me.PC_Name.AutoSize = True
        Me.PC_Name.Location = New System.Drawing.Point(3, 9)
        Me.PC_Name.Name = "PC_Name"
        Me.PC_Name.Size = New System.Drawing.Size(96, 24)
        Me.PC_Name.TabIndex = 2
        Me.PC_Name.Text = "PC_Name"
        '
        'SaveProg
        '
        Me.SaveProg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveProg.BackColor = System.Drawing.Color.DimGray
        Me.SaveProg.FlatAppearance.BorderSize = 0
        Me.SaveProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveProg.Location = New System.Drawing.Point(0, 555)
        Me.SaveProg.Name = "SaveProg"
        Me.SaveProg.Size = New System.Drawing.Size(224, 63)
        Me.SaveProg.TabIndex = 1
        Me.SaveProg.Text = "Save"
        Me.SaveProg.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Settings.BackColor = System.Drawing.Color.DimGray
        Me.Settings.FlatAppearance.BorderSize = 0
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings.Location = New System.Drawing.Point(0, 618)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(224, 63)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.MainText)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(220, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1044, 492)
        Me.Panel2.TabIndex = 1
        '
        'MainText
        '
        Me.MainText.AutoSize = True
        Me.MainText.Location = New System.Drawing.Point(32, 19)
        Me.MainText.Name = "MainText"
        Me.MainText.Size = New System.Drawing.Size(66, 24)
        Me.MainText.TabIndex = 1
        Me.MainText.Text = "Label8"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ActionList)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(220, 492)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1044, 189)
        Me.Panel3.TabIndex = 0
        '
        'ActionList
        '
        Me.ActionList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ActionList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ActionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionList.ForeColor = System.Drawing.Color.White
        Me.ActionList.FormattingEnabled = True
        Me.ActionList.ItemHeight = 24
        Me.ActionList.Location = New System.Drawing.Point(0, 0)
        Me.ActionList.Name = "ActionList"
        Me.ActionList.Size = New System.Drawing.Size(1044, 189)
        Me.ActionList.TabIndex = 0
        '
        'Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Play"
        Me.Text = "Play"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PC_Name As Label
    Friend WithEvents SaveProg As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PC_ShipName As Label
    Friend WithEvents Open_Ship As Button
    Friend WithEvents Money As Label
    Friend WithEvents IS_Fuel As Label
    Friend WithEvents IP_Fuel As Label
    Friend WithEvents Ship_Health As Label
    Friend WithEvents Cap_Health As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MainText As Label
    Friend WithEvents ActionList As ListBox
End Class
