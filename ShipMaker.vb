Public Class ShipMaker

    Public MainSave(500), Saveling(28) As String

    Private Sub ShipMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainSave = Split(My.Settings.Saves, ".")
    End Sub

    Private Sub FactionSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FactionSelect.SelectedIndexChanged
        Select Case FactionSelect.SelectedIndex
            Case 0 ''Hive
                FactionStory.Text = "Even at its birth, that drone was a little different. Its hive-link wasn't the same as its other siblings. It wasn't weaker, quite the opposite, it was almost as strong as a queen's. But feedbacks from its hive-link always had some unnecessary information. Some would even dare to say it had emotions. Every junction in the network decided to exterminate it and recycle its biomass. But The Mind ordered to give it a ship and banish it."
                ShipSelect.Items.Clear()
                ShipSelect.Items.Add("Basic Space-Shell")
                ShipSelect.SelectedIndex = 0
                HullSelect.Items.Clear()
                HullSelect.Items.Add("Space-Adapted Tissue")
                HullSelect.SelectedIndex = 0
                EngineSelect.Items.Clear()
                EngineSelect.Items.Add("Ion Emitting Flagella")
                EngineSelect.SelectedIndex = 0
                ShieldSelect.Items.Clear()
                ShieldSelect.Items.Add("Nothing")
                ShieldSelect.SelectedIndex = 0
                ReactorSelect.Items.Clear()
                ReactorSelect.Items.Add("Mitocondria Sacs") ''Prolly wrong spelling
                ReactorSelect.SelectedIndex = 0
                DriveSelect.Items.Clear()
                DriveSelect.Items.Add("Allucobery Mysilia") ''Prolly wrong spelling
                DriveSelect.SelectedIndex = 0
                perks.Text = "Hive-Link - You can connect and control hive ships and equipment. But you can not use humanoid ships and equipment.

Organic Ship - Ship hull will regenerate, and the ship itself can evolve.

Hiveling - You can evolve yourself with hive biocomposit. You are not welcome in any space. Humanoids will NOT communicate with you and attack on sight. But other creatures might be more welcome towards you.

Weak And Alone - You just have been born and banished from your hive. Thanks to hive-link you will start with high skills but almost every creature is your enemy and as a new born you don't have any traits. You need to evolve, fast."


            Case 1 ''Pirates
                FactionStory.Text = "Ether Skull, one of the most feared pirates in federation space, and sometimes even beyond. Even with their relatively small fleet, they have raided over 20 federation stations. Until admiral Rephieve and his three federation fleet ambush them. The Battle was short but ferocious. The only survivor is you. You stole a ship from the planet your escape pod crashed and continue to do what you know best to do."
                ShipSelect.Items.Clear()
                ShipSelect.Items.Add("Civilian Corvette")
                ShipSelect.SelectedIndex = 0
                HullSelect.Items.Clear()
                HullSelect.Items.Add("Neo-Steel Alloy")
                HullSelect.SelectedIndex = 0
                EngineSelect.Items.Clear()
                EngineSelect.Items.Add("Chemical Pulse Engine")
                EngineSelect.SelectedIndex = 0
                ShieldSelect.Items.Clear()
                ShieldSelect.Items.Add("Deflector")
                ShieldSelect.SelectedIndex = 0
                ReactorSelect.Items.Clear()
                ReactorSelect.Items.Add("2nd Gen Fussion Reactor")
                ReactorSelect.SelectedIndex = 0
                DriveSelect.Items.Clear()
                DriveSelect.Items.Add("Hyperlane Mass Ejector")
                DriveSelect.SelectedIndex = 0
                perks.Text = "Shady Connections - You have access to the black market.

Boarding - You can board a defeated ship to capture the ship and its crew.

Raider - You can raid small settlements.

Pirate - You are not welcome in any space."


            Case 2 ''Empire
                FactionStory.Text = "Life is not always easy, but if you in the empire, which you are, then it's really not that hard. Almost all the time there is an abundance of pretty much anything. The difference between rich and poor isn't a difference at all, since, in the empire, everything belongs to the empress. Well, except the discarded ship you bought by doing some work for a, apparently very generous noble."
                ShipSelect.Items.Clear()
                ShipSelect.Items.Add("Discarded Imperial Corvette")
                ShipSelect.SelectedIndex = 0
                HullSelect.Items.Clear()
                HullSelect.Items.Add("Damaged Low Grade Drobium Alloy")
                HullSelect.SelectedIndex = 0
                EngineSelect.Items.Clear()
                EngineSelect.Items.Add("Damaged Ion Super Accelerator Engine") ''Prolly wrong spelling
                EngineSelect.SelectedIndex = 0
                ShieldSelect.Items.Clear()
                ShieldSelect.Items.Add("Damaged Momentum Disperser") ''Prolly wrong spelling
                ShieldSelect.SelectedIndex = 0
                ReactorSelect.Items.Clear()
                ReactorSelect.Items.Add("Damaged Stalled Meltdown Reactor")
                ReactorSelect.SelectedIndex = 0
                DriveSelect.Items.Clear()
                DriveSelect.Items.Add("Damaged 1st Gen Jump Drive")
                DriveSelect.SelectedIndex = 0
                perks.Text = "Bio-Engineered - Like everyone in the empire, you have engineered to perfection. (Boosted Traints)

Imperial DNA - You are welcome in imperial space, and you can use bio-locked Imperial ships.

Imperial - Can be welcome in federal space with a visa."


            Case 3 ''Federation
                FactionStory.Text = "Ahh, federation, the utopia where all needs are provided and everyone lives in perfect harmony. At least that's how it was in the beginning, and the beginning was long ago. Nowadays, it's just a battleground between the government and corporations. Luckily you had your father's ship and decided to leave everything behind. Not that you had much anyway."
                ShipSelect.Items.Clear()
                ShipSelect.Items.Add("Small Trade Ship")
                ShipSelect.SelectedIndex = 0
                HullSelect.Items.Clear()
                HullSelect.Items.Add("Neo-Steel Alloy")
                HullSelect.SelectedIndex = 0
                EngineSelect.Items.Clear()
                EngineSelect.Items.Add("Chemical Pulse Engine")
                EngineSelect.SelectedIndex = 0
                ShieldSelect.Items.Clear()
                ShieldSelect.Items.Add("Deflector")
                ShieldSelect.SelectedIndex = 0
                ReactorSelect.Items.Clear()
                ReactorSelect.Items.Add("2nd Gen Fussion Reactor")
                ReactorSelect.SelectedIndex = 0
                DriveSelect.Items.Clear()
                DriveSelect.Items.Add("Hyperlane Mass Ejector")
                DriveSelect.SelectedIndex = 0
                perks.Text = "Federal Education - Every federation citizen must have an F.S.E diploma. (+25% Experience Gain)

Federation Implants - You can use advanced implants and start with standard citizen implants.

Federal - Only welcome in federal space."
        End Select
    End Sub

    Sub ShipCreate_Click(sender As Object, e As EventArgs) Handles ShipCreate.Click
        Dim i = 0
        Do While i < 500
            Saveling = Split(MainSave(i), ",")
            If Saveling(3) = "Name" Then
                Saveling(0) = i.ToString + "  "
                Saveling(1) = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
                Saveling(2) = FactionSelect.SelectedIndex.ToString

                Saveling(3) = "Name"
                Saveling(4) = "ShipName"

                Saveling(5) = ShipSelect.SelectedItem
                Saveling(6) = HullSelect.SelectedItem
                Saveling(7) = EngineSelect.SelectedItem
                Saveling(8) = ShieldSelect.SelectedItem
                Saveling(9) = ReactorSelect.SelectedItem
                Saveling(10) = DriveSelect.SelectedItem
                Saveling(11) = Wep_Slot.Text
                Saveling(12) = Util_Slot.Text
                Saveling(13) = Crew_Max.Text

                Saveling(14) = "Strength"
                Saveling(15) = "Agility"
                Saveling(16) = "Endurance"
                Saveling(17) = "Perception"
                Saveling(18) = "Piloting"
                Saveling(19) = "Engineering"
                Saveling(20) = "Medical"
                Saveling(21) = "Science"
                Saveling(22) = "HairStyle"
                Saveling(23) = "HairColor"
                Saveling(24) = "EyeColor"
                Saveling(25) = "Height"
                Saveling(26) = "BodyType"
                Saveling(27) = "SkinColor"
                Saveling(28) = "Age"

                My.Settings.ActiveSave = i
                MainSave(i) = Join(Saveling, ",")
                My.Settings.Saves = Join(MainSave, ".")

                i = 500
            Else
                i = i + 1
            End If
        Loop
        i = 0



        CaptainMaker.Show()


        Select Case FactionSelect.SelectedIndex
            Case 0 '' Hive Stats
                CaptainMaker.StrP.Text = "0"
                CaptainMaker.AglP.Text = "0"
                CaptainMaker.EndurP.Text = "0"
                CaptainMaker.PercepP.Text = "0"

                CaptainMaker.PilotP.Text = "30"
                CaptainMaker.EngiP.Text = "30"
                CaptainMaker.MedicP.Text = "30"
                CaptainMaker.ScienceP.Text = "30"
            Case 1 '' Pirate Stats
                CaptainMaker.StrP.Text = "2"
                CaptainMaker.AglP.Text = "1"
                CaptainMaker.EndurP.Text = "2"
                CaptainMaker.PercepP.Text = "1"

                CaptainMaker.PilotP.Text = "10"
                CaptainMaker.EngiP.Text = "5"
                CaptainMaker.MedicP.Text = "10"
                CaptainMaker.ScienceP.Text = "5"
            Case 2 '' Imperial Stats
                CaptainMaker.StrP.Text = "3"
                CaptainMaker.AglP.Text = "3"
                CaptainMaker.EndurP.Text = "3"
                CaptainMaker.PercepP.Text = "3"

                CaptainMaker.PilotP.Text = "10"
                CaptainMaker.EngiP.Text = "15"
                CaptainMaker.MedicP.Text = "10"
                CaptainMaker.ScienceP.Text = "15"
            Case 3 '' Federal Stats
                CaptainMaker.StrP.Text = "1"
                CaptainMaker.AglP.Text = "1"
                CaptainMaker.EndurP.Text = "2"
                CaptainMaker.PercepP.Text = "2"

                CaptainMaker.PilotP.Text = "20"
                CaptainMaker.EngiP.Text = "15"
                CaptainMaker.MedicP.Text = "15"
                CaptainMaker.ScienceP.Text = "15"
        End Select


        Me.Close()
    End Sub
End Class