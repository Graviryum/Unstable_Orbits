Public Class Play
    Public MainSave(500), Saveling(), ProgressFlags() As String

    Private Sub Play_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        MainText.MaximumSize = New Size(Panel2.Width - 66, 0)
    End Sub

    Private Sub Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainSave = Split(My.Settings.Saves, ".")
        Saveling = Split(MainSave(My.Settings.ActiveSave), ",")
        ProgressFlags = Split(Saveling(29), "-")
        PC_Name.Text = Saveling(3)
        PC_ShipName.Text = Saveling(4)



        If ProgressFlags(0) = "Yes" Then
            Select Case Saveling(2)
                Case 0 'Hive
                    Cap_Health.Text = 5 + (Saveling(14) * 5) + (Saveling(16) * 8)
                    Ship_Health.Text = 2400
                    IP_Fuel.Text = 10
                    IS_Fuel.Text = 2
                    Money.Text = 0

                    MainText.Text = ""

                Case 1 'Pirate
                    Cap_Health.Text = (Saveling(14) * 5) + (Saveling(16) * 8)
                    Ship_Health.Text = 5000
                    IP_Fuel.Text = 15
                    IS_Fuel.Text = 5
                    Money.Text = 2000

                    MainText.Text = ""

                Case 2 'Empire
                    Cap_Health.Text = (Saveling(14) * 5) + (Saveling(16) * 8)
                    Ship_Health.Text = 7000
                    IP_Fuel.Text = 25
                    IS_Fuel.Text = 2
                    Money.Text = 0

                    MainText.Text = ""

                Case 3 'Federation
                    Cap_Health.Text = (Saveling(14) * 5) + (Saveling(16) * 8)
                    Ship_Health.Text = 5000
                    IP_Fuel.Text = 15
                    IS_Fuel.Text = 8
                    Money.Text = 600

                    MainText.Text = ""

            End Select


        Else





        End If
    End Sub

    Sub Action_Handler(Index As Integer)





    End Sub




End Class