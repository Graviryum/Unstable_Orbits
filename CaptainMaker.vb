Public Class CaptainMaker
    Public MainSave(500), Saveling(28) As String
    Private Sub CaptainMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainSave = Split(My.Settings.Saves, ".")

        resetting()
    End Sub

    Private Sub ResetPoints_Click(sender As Object, e As EventArgs) Handles ResetPoints.Click
        resetting()
    End Sub

    Sub resetting()
        Saveling = Split(MainSave(My.Settings.ActiveSave), ",")
        Select Case Saveling(2)
            Case 0 '' Hive Stats
                StrP.Text = "0"
                AglP.Text = "0"
                EndurP.Text = "0"
                PercepP.Text = "0"

                PilotP.Text = "20"
                EngiP.Text = "20"
                MedicP.Text = "20"
                ScienceP.Text = "20"

                TraitPoints.Text = 0
                SkillPoints.Text = 10

            Case 1 '' Pirate Stats
                StrP.Text = "2"
                AglP.Text = "1"
                EndurP.Text = "2"
                PercepP.Text = "1"

                PilotP.Text = "10"
                EngiP.Text = "5"
                MedicP.Text = "10"
                ScienceP.Text = "5"

                TraitPoints.Text = 3
                SkillPoints.Text = 8

            Case 2 '' Imperial Stats
                StrP.Text = "3"
                AglP.Text = "3"
                EndurP.Text = "3"
                PercepP.Text = "3"

                PilotP.Text = "10"
                EngiP.Text = "15"
                MedicP.Text = "10"
                ScienceP.Text = "15"

                TraitPoints.Text = 5
                SkillPoints.Text = 10

            Case 3 '' Federal Stats
                StrP.Text = "1"
                AglP.Text = "1"
                EndurP.Text = "2"
                PercepP.Text = "2"

                PilotP.Text = "20"
                EngiP.Text = "15"
                MedicP.Text = "15"
                ScienceP.Text = "15"

                TraitPoints.Text = 3
                SkillPoints.Text = 20

        End Select

        If Saveling(2) = 0 Then
            StrUP.Enabled = False
            AglUP.Enabled = False
            EndurUP.Enabled = False
            PerUP.Enabled = False
        Else
            StrUP.Enabled = True
            AglUP.Enabled = True
            EndurUP.Enabled = True
            PerUP.Enabled = True
        End If

        PilotUP.Enabled = True
        EngiUP.Enabled = True
        MedicUP.Enabled = True
        SciUP.Enabled = True

        StrDown.Enabled = False
        AglDown.Enabled = False
        EndurDown.Enabled = False
        PerDown.Enabled = False

        PilotDown.Enabled = False
        EngiDown.Enabled = False
        MedicDown.Enabled = False
        SciDown.Enabled = False
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        ShipMaker.Show()
        Me.Close()
    End Sub

    Private Sub Fin_Click(sender As Object, e As EventArgs) Handles FinButton.Click


        If PC_Naming.TextLength < 1 Then
            MsgBox("Give your captain name a name!")
        ElseIf Ship_Naming.TextLength < 1 Then
            MsgBox("What kind of captain don't give a name to their ship?")
        Else

            Saveling = Split(MainSave(My.Settings.ActiveSave), ",")

            Saveling(3) = PC_Naming.Text
            Saveling(4) = Ship_Naming.Text

            Saveling(14) = StrP.Text
            Saveling(15) = AglP.Text
            Saveling(16) = EndurP.Text
            Saveling(17) = PercepP.Text
            Saveling(18) = PilotP.Text
            Saveling(19) = EngiP.Text
            Saveling(20) = MedicP.Text
            Saveling(21) = ScienceP.Text
            Saveling(22) = HairS_Selecting.SelectedItem
            Saveling(23) = HairC_Selecting.SelectedItem
            Saveling(24) = Eye_Selecting.SelectedItem
            Saveling(25) = Height_Selecting.SelectedItem
            Saveling(26) = Body_Selecting.SelectedItem
            Saveling(27) = Skin_Selecting.SelectedItem
            Saveling(28) = Age_Selecting.SelectedItem


            MainSave(My.Settings.ActiveSave) = Join(Saveling, ",")
            My.Settings.Saves = Join(MainSave, ".")
            Play.Show()

            Me.Close()

        End If


    End Sub



    Private Sub StrUP_Click(sender As Object, e As EventArgs) Handles StrUP.Click
        StrP.Text = StrP.Text + 1
        StrDown.Enabled = True
        StatUP(0)
    End Sub

    Private Sub AglUP_Click(sender As Object, e As EventArgs) Handles AglUP.Click
        AglP.Text = AglP.Text + 1
        AglDown.Enabled = True
        StatUP(0)
    End Sub

    Private Sub EndurUP_Click(sender As Object, e As EventArgs) Handles EndurUP.Click
        EndurP.Text = EndurP.Text + 1
        EndurDown.Enabled = True
        StatUP(0)
    End Sub

    Private Sub PerUP_Click(sender As Object, e As EventArgs) Handles PerUP.Click
        PercepP.Text = PercepP.Text + 1
        PerDown.Enabled = True
        StatUP(0)
    End Sub

    Private Sub PilotUP_Click(sender As Object, e As EventArgs) Handles PilotUP.Click
        PilotP.Text = PilotP.Text + 1
        PilotDown.Enabled = True
        StatUP(1)
    End Sub

    Private Sub EngiUP_Click(sender As Object, e As EventArgs) Handles EngiUP.Click
        EngiP.Text = EngiP.Text + 1
        EngiDown.Enabled = True
        StatUP(1)
    End Sub

    Private Sub MedicUP_Click(sender As Object, e As EventArgs) Handles MedicUP.Click
        MedicP.Text = MedicP.Text + 1
        MedicDown.Enabled = True
        StatUP(1)
    End Sub

    Private Sub SciUP_Click(sender As Object, e As EventArgs) Handles SciUP.Click
        ScienceP.Text = ScienceP.Text + 1
        SciDown.Enabled = True
        StatUP(1)
    End Sub

    Sub StatUP(Stat As Integer)
        If Stat = 0 Then
            TraitPoints.Text = TraitPoints.Text - 1
            If TraitPoints.Text = 0 Then
                StrUP.Enabled = False
                AglUP.Enabled = False
                EndurUP.Enabled = False
                PerUP.Enabled = False
            End If
        Else
            SkillPoints.Text = SkillPoints.Text - 1
            If SkillPoints.Text = 0 Then
                PilotUP.Enabled = False
                EngiUP.Enabled = False
                MedicUP.Enabled = False
                SciUP.Enabled = False
            End If
        End If
    End Sub

    Private Sub StrDown_Click(sender As Object, e As EventArgs) Handles StrDown.Click
        StatDown(0)
    End Sub

    Private Sub AglDown_Click(sender As Object, e As EventArgs) Handles AglDown.Click
        StatDown(1)
    End Sub

    Private Sub EndurDown_Click(sender As Object, e As EventArgs) Handles EndurDown.Click
        StatDown(2)
    End Sub

    Private Sub PerDown_Click(sender As Object, e As EventArgs) Handles PerDown.Click
        StatDown(3)
    End Sub

    Private Sub PilotDown_Click(sender As Object, e As EventArgs) Handles PilotDown.Click
        StatDown(4)
    End Sub

    Private Sub EngiDown_Click(sender As Object, e As EventArgs) Handles EngiDown.Click
        StatDown(5)
    End Sub

    Private Sub MedicDown_Click(sender As Object, e As EventArgs) Handles MedicDown.Click
        StatDown(6)
    End Sub

    Private Sub SciDown_Click(sender As Object, e As EventArgs) Handles SciDown.Click
        StatDown(7)
    End Sub

    Private Sub C_HairS_Click(sender As Object, e As EventArgs) Handles C_HairS.Click
        Customize(0, C_HairS.Text)
    End Sub

    Private Sub C_HairC_Click(sender As Object, e As EventArgs) Handles C_HairC.Click
        Customize(1, C_HairC.Text)
    End Sub

    Private Sub C_Eye_Click(sender As Object, e As EventArgs) Handles C_Eye.Click
        Customize(2, C_Eye.Text)
    End Sub

    Private Sub C_Height_Click(sender As Object, e As EventArgs) Handles C_Height.Click
        Customize(3, C_Height.Text)
    End Sub

    Private Sub C_Body_Click(sender As Object, e As EventArgs) Handles C_Body.Click
        Customize(4, C_Body.Text)
    End Sub

    Private Sub C_Skin_Click(sender As Object, e As EventArgs) Handles C_Skin.Click
        Customize(5, C_Skin.Text)
    End Sub

    Private Sub C_Age_Click(sender As Object, e As EventArgs) Handles C_Age.Click
        Customize(6, C_Age.Text)
    End Sub

    Sub Customize(Aspect As Integer, Button As String)

        If Button = "Custom" Then
            Select Case Aspect
                Case 0
                    C_HairS.Text = "Back"
                    HairS_Selecting.Hide()
                Case 1
                    C_HairC.Text = "Back"
                    HairC_Selecting.Hide()
                Case 2
                    C_Eye.Text = "Back"
                    Eye_Selecting.Hide()
                Case 3
                    C_Height.Text = "Back"
                    Height_Selecting.Hide()
                Case 4
                    C_Body.Text = "Back"
                    Body_Selecting.Hide()
                Case 5
                    C_Skin.Text = "Back"
                    Skin_Selecting.Hide()
                Case 6
                    C_Age.Text = "Back"
                    Age_Selecting.Hide()
            End Select
        Else
            Select Case Aspect
                Case 0
                    C_HairS.Text = "Custom"
                    HairS_Selecting.Show()
                Case 1
                    C_HairC.Text = "Custom"
                    HairC_Selecting.Show()
                Case 2
                    C_Eye.Text = "Custom"
                    Eye_Selecting.Show()
                Case 3
                    C_Height.Text = "Custom"
                    Height_Selecting.Show()
                Case 4
                    C_Body.Text = "Custom"
                    Body_Selecting.Show()
                Case 5
                    C_Skin.Text = "Custom"
                    Skin_Selecting.Show()
                Case 6
                    C_Age.Text = "Custom"
                    Age_Selecting.Show()
            End Select
        End If

    End Sub

    Private Sub RandomApperance_Click(sender As Object, e As EventArgs) Handles RandomApperance.Click

    End Sub

    Sub StatDown(Stat As Integer)
        Saveling = Split(MainSave(My.Settings.ActiveSave), ",")
        Select Case Saveling(2)
            Case 0 '' Hive Stats
                Select Case Stat
                    Case 0 ' Str
                        If StrP.Text = 1 Then
                            StrP.Text = StrP.Text - 1
                            StrDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            StrP.Text = StrP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 1 'Agl
                        If AglP.Text = 1 Then
                            AglP.Text = AglP.Text - 1
                            AglDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            AglP.Text = AglP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 2 'Endur
                        If EndurP.Text = 1 Then
                            EndurP.Text = EndurP.Text - 1
                            EndurDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            EndurP.Text = EndurP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 3 'Percep
                        If PercepP.Text = 1 Then
                            PercepP.Text = PercepP.Text - 1
                            PerDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            PercepP.Text = PercepP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 4 'Pilot
                        If PilotP.Text = 21 Then
                            PilotP.Text = PilotP.Text - 1
                            PilotDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            PilotP.Text = PilotP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 5 'Engi
                        If EngiP.Text = 21 Then
                            EngiP.Text = EngiP.Text - 1
                            EngiDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            EngiP.Text = EngiP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 6 'Medic
                        If MedicP.Text = 21 Then
                            MedicP.Text = MedicP.Text - 1
                            MedicDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            MedicP.Text = MedicP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 7 'Science
                        If ScienceP.Text = 21 Then
                            ScienceP.Text = ScienceP.Text - 1
                            SciDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            ScienceP.Text = ScienceP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                End Select
            Case 1 '' Pirate Stats
                Select Case Stat
                    Case 0 ' Str
                        If StrP.Text = 3 Then
                            StrP.Text = StrP.Text - 1
                            StrDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            StrP.Text = StrP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 1 'Agl
                        If AglP.Text = 2 Then
                            AglP.Text = AglP.Text - 1
                            AglDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            AglP.Text = AglP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 2 'Endur
                        If EndurP.Text = 3 Then
                            EndurP.Text = EndurP.Text - 1
                            EndurDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            EndurP.Text = EndurP.Text - 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 3 'Percep
                        If PercepP.Text = 2 Then
                            PercepP.Text = PercepP.Text - 1
                            PerDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            PercepP.Text = PercepP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 4 'Pilot
                        If PilotP.Text = 11 Then
                            PilotP.Text = PilotP.Text - 1
                            PilotDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            PilotP.Text = PilotP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 5 'Engi
                        If EngiP.Text = 6 Then
                            EngiP.Text = EngiP.Text - 1
                            EngiDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            EngiP.Text = EngiP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 6 'Medic
                        If MedicP.Text = 11 Then
                            MedicP.Text = MedicP.Text - 1
                            MedicDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            MedicP.Text = MedicP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 7 'Science
                        If ScienceP.Text = 6 Then
                            ScienceP.Text = ScienceP.Text - 1
                            SciDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            ScienceP.Text = ScienceP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                End Select
            Case 2 '' Imperial Stats
                Select Case Stat
                    Case 0 ' Str
                        If StrP.Text = 4 Then
                            StrP.Text = StrP.Text - 1
                            StrDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            StrP.Text = StrP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 1 'Agl
                        If AglP.Text = 4 Then
                            AglP.Text = AglP.Text - 1
                            AglDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            AglP.Text = AglP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 2 'Endur
                        If EndurP.Text = 4 Then
                            EndurP.Text = EndurP.Text - 1
                            EndurDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            EndurP.Text = EndurP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 3 'Percep
                        If PercepP.Text = 4 Then
                            PercepP.Text = PercepP.Text - 1
                            PerDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            PercepP.Text = PercepP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 4 'Pilot
                        If PilotP.Text = 11 Then
                            PilotP.Text = PilotP.Text - 1
                            PilotDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            PilotP.Text = PilotP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 5 'Engi
                        If EngiP.Text = 16 Then
                            EngiP.Text = EngiP.Text - 1
                            EngiDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            EngiP.Text = EngiP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 6 'Medic
                        If MedicP.Text = 11 Then
                            MedicP.Text = MedicP.Text - 1
                            MedicDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            MedicP.Text = MedicP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 7 'Science
                        If ScienceP.Text = 16 Then
                            ScienceP.Text = ScienceP.Text - 1
                            SciDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            ScienceP.Text = ScienceP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                End Select
            Case 3 '' Federal Stats
                Select Case Stat
                    Case 0 ' Str
                        If StrP.Text = 2 Then
                            StrP.Text = StrP.Text - 1
                            StrDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            StrP.Text = StrP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 1 'Agl
                        If AglP.Text = 2 Then
                            AglP.Text = AglP.Text - 1
                            AglDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            AglP.Text = AglP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 2 'Endur
                        If EndurP.Text = 3 Then
                            EndurP.Text = EndurP.Text - 1
                            EndurDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            EndurP.Text = EndurP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 3 'Percep
                        If PercepP.Text = 3 Then
                            PercepP.Text = PercepP.Text - 1
                            PerDown.Enabled = False
                            TraitPoints.Text = TraitPoints.Text + 1
                        Else
                            PercepP.Text = PercepP.Text - 1
                            TraitPoints.Text = TraitPoints.Text + 1
                        End If
                        StrUP.Enabled = True
                        AglUP.Enabled = True
                        EndurUP.Enabled = True
                        PerUP.Enabled = True
                    Case 4 'Pilot
                        If PilotP.Text = 21 Then
                            PilotP.Text = PilotP.Text - 1
                            PilotDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            PilotP.Text = PilotP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 5 'Engi
                        If EngiP.Text = 16 Then
                            EngiP.Text = EngiP.Text - 1
                            EngiDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            EngiP.Text = EngiP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 6 'Medic
                        If MedicP.Text = 16 Then
                            MedicP.Text = MedicP.Text - 1
                            MedicDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            MedicP.Text = MedicP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                    Case 7 'Science
                        If ScienceP.Text = 16 Then
                            ScienceP.Text = ScienceP.Text - 1
                            SciDown.Enabled = False
                            SkillPoints.Text = SkillPoints.Text + 1
                        Else
                            ScienceP.Text = ScienceP.Text - 1
                            SkillPoints.Text = SkillPoints.Text + 1
                        End If
                        PilotUP.Enabled = True
                        EngiUP.Enabled = True
                        MedicUP.Enabled = True
                        SciUP.Enabled = True
                End Select
        End Select
    End Sub
End Class