Public Class MainMenu

    Public Selected_Save
    Public MainSave(500), Saveling(28) As String
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Saves_Panel.Hide()
        Dim i As Integer = 0


        My.Settings.Saves = ""                         'Hard Reset
        My.Settings.Setup = False




        If My.Settings.Setup = False Then '' In first run, creates a array for 500 save slot

            My.Settings.Saves = ""

            Do While i < 500
                MainSave(i) = i.ToString + "  ,Date,Faction,Name,ShipName,ShipClass,Hull,Engine,Shield,Reactor,ISDrive,WeponSlots,UtilitySlots,MaxCrew,Strength,Agility,Endurance,Perception,Piloting,Engineering,Medical,Science,HairStyle,HairColor,EyeColor,Height,BodyType,SkinColor,Age,NewGame,Location,CptHP,ShpHP,IPFuel,ISFuel,Money"

                i += 1
            Loop

            My.Settings.Saves = Join(MainSave, ".")
            My.Settings.Setup = True
            i = 0

        End If

        MainSave = Split(My.Settings.Saves, ".")

        Do While i < 500 ' Prints save files to Save_List
            Saveling = Split(MainSave(i), ",")
            If Saveling(3) = "Name" Then

            Else
                Save_List.Items.Add(Saveling(1) + " - " + Saveling(3) + " - " + Saveling(4) + "                                                                                                                                               " + Saveling(0)) '' This is fine.
            End If
            i = i + 1
        Loop


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles NewGame.Click
        ShipMaker.Show()
        Me.Close()
    End Sub

    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Saves_Panel.Show()
        Label4.Text = "Load"
    End Sub

    Private Sub Save_List_DoubleClick(sender As Object, e As EventArgs) Handles Save_List.DoubleClick
        Selected_Save = Microsoft.VisualBasic.Strings.Right(Save_List.SelectedItem, 3)
        Play.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Saves_Panel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim answer
        answer = MsgBox("Selected file will be deleted. Are you sure", MsgBoxStyle.OkCancel)
        If answer = MsgBoxResult.Ok Then '' Deletes save file by changing PC name to "Name". Save files with the name "Name" can be overwritten and doesn't prints to Save_List
            Dim i = 0
            Do While i < 500
                Dim Check1 = Microsoft.VisualBasic.Strings.Left(MainSave(i), 3)
                Dim Check2 = Microsoft.VisualBasic.Strings.Right(Save_List.SelectedItem, 3)
                If Check1 = Check2 Then
                    Saveling = Split(MainSave(i), ",")
                    Saveling(3) = "Name"
                    Save_List.Items.RemoveAt(Save_List.SelectedIndex)
                    MainSave(i) = Join(Saveling, ",")
                    My.Settings.Saves = Join(MainSave, ".")
                    i = 500
                End If
                i = i + 1
            Loop

        End If

    End Sub
End Class

