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
                    MainText.Text = ""

                Case 1 'Pirate
                    MainText.Text = ""

                Case 2 'Empire
                    MainText.Text = ""

                Case 3 'Federation
                    MainText.Text = ""

            End Select


        Else





        End If
    End Sub

    Sub Action_Handler(Index As Integer)





    End Sub




End Class