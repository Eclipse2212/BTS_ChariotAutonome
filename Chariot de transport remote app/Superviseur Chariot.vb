Imports System.IO.Ports

Public Class Form1

    Dim donnees(10) As Char 'On définit les données en variable globale
    Dim TagsHex As New List(Of String) From
        {
        "0000000000000000000000", 'Badge 1
        "010B030107407157FFCF06",
        "010B030107073F91FF4AE9",
        "0000000000000000000000",
        "010B030107075B2FFF3040", 'Badge 5
        "010B0304600E0F3AFF80B6", 'Carte 1
        "010B0304600DF345FF953E",
        "010B0304600DF163FF571E",
        "010B0304600E1912FFFE3A" 'Carte 4
        }

    'Trigger quand on change l'élément actif
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Serial.PortName = ComboBox1.SelectedItem.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Paramétrage de la comm série
        Serial.BaudRate = 9600
        Serial.StopBits = 1
        Serial.RtsEnable = False
        Serial.DtrEnable = False
        Serial.Parity = Parity.None
        Serial.NewLine = vbCr

        GetSerialPortNames()

        'Réglage du texte d'un élément
        LabelRFID.Text = "Non connecté"

        'Chargement d'une image à partir d'un fichier
        PictureBox1.Image = Image.FromFile("Img\Unconnected.jpg")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Serial.IsOpen = False Then 'Si le port série est fermé, alors
            Serial.Open()
            ComboBox1.Enabled = False 'On désactive le contrôle pour éviter d'ouvrir plusieurs fois le port
            PictureBox1.Image = Image.FromFile("Img\Connected.jpg")
            LabelRFID.Text = "aucune donnée reçue"
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Si port série ouver, alors
        If Serial.IsOpen = True Then
            Serial.Close()
            PictureBox1.Image = Image.FromFile("Img\Unconnected.jpg")
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub DriverButton_Click(sender As Object, e As EventArgs) Handles DriverButton.Click
        'Installation du pilote
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        With procStartInfo
            .UseShellExecute = True
            .FileName = ".\Res\DriverMM232R\CDM v2.12.00 WHQL Certified.exe"
            .WindowStyle = ProcessWindowStyle.Normal
            .Verb = "runas" 'Demande de droits admin pour installer
        End With

        procExecuting = Process.Start(procStartInfo) 'On lance un sous programme
    End Sub

    Private Sub Vroum1ConnStatus_Click(sender As Object, e As EventArgs) Handles Vroum1ConnStatus.Click
        'Quand on clique sur l'id de la voiture, c'est copié en mémoire
        Clipboard.SetText(Vroum1ConnStatus.Text)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Un bouton pour renommer l'onglet
        TabGroup.SelectedTab.Text = RenameBoxTab2.Text
        'Serial.WriteLine(RenameBoxTab2.Text)
    End Sub

    'Fonction créée de tout pièce pour définir une vitesse et l'envoyer au chariot
    Public Sub SetCarSpeed(speed As Char) 'Entre &H00 et &HFF, &H80 valeur moyenne


        Dim Dat_0d As Char = ChrW(&HD) 'Conversion du la données Hexa en char
        Dim send_buf_O() As Char = {"O", Dat_0d} 'Buffer d'envoi de la première partie (char de contrôle)
        Dim send_buf_speed() As Char = {speed, Dat_0d} 'Buffer d'envoi de la seconde partie (donnée)


        Serial.Write(send_buf_O, 0, send_buf_O.Length) 'Fonction(buffer As Char, offset, buffer.length)
        Console.WriteLine("[envoyé_Trame1] " + send_buf_O) 'Log dans la console (à fin de débug)
        Task.Delay(100) 'Delais 100ms pour temporiser l'envoi
        Serial.Write(send_buf_speed, 0, send_buf_speed.Length) 'Fonction(buffer As Char, offset, buffer.length)
        Console.WriteLine("[Envoyé_Trame2] " + send_buf_speed)
    End Sub

    Private Sub Serial_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles Serial.DataReceived
        'Quand on reçoit des données série, on les log dans la console de débug et on l'affiche dans l'encart RFID
        'donnees = Serial.ReadLine() 'Normalement un tag RFID est constitué de "B[Tag en hex]"
        Dim donnees_char As Char
        Dim b_char As Char = ChrW(&H42)
        Dim D As Char
        Dim cr_char As Char = Convert.ToChar(vbCr)

        donnees_char = Convert.ToChar(Serial.ReadChar()) 'Lecture données as Char
        If donnees_char = b_char Then
            Dim i As Integer = 0
            While donnees(10) = vbNullChar
                Serial.ReadChar() 'On vide le VbCr
                D = Convert.ToChar(Serial.ReadChar())
                Console.WriteLine("Test: " + D)
                If D <> cr_char Then
                    donnees(i) = D
                    i += 1
                End If


            End While

            Console.WriteLine("[Mise en forme] " + donnees)
        End If

        'Console.WriteLine("[Reçu] " + donnees_char)
        'TODO: Foreach tag in list pour comparer avec la donnée reçue sans le "B"

    End Sub



    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Quand on ferme le programme, on ferme la connection série (si ouverte)
        If Serial.IsOpen = True Then
            Serial.Close()
        End If
    End Sub

    Sub GetSerialPortNames()
        ' Lister tous les ports série disponibles de l'appareil
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
    End Sub

    Private Sub SpeedSendButton_Click(sender As Object, e As EventArgs) Handles SpeedSendButton.Click
        Dim vitesse As Integer
        vitesse = SpeedScrollBar.Value * 2.5
        SetCarSpeed(vitesse.ToString())
    End Sub

    Private Sub SpeedScrollBar_ValueChanged(sender As Object, e As EventArgs) Handles SpeedScrollBar.ValueChanged
        SpeedProgBar.Value = SpeedScrollBar.Value
        LabelPourcent.Text = SpeedScrollBar.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not String.IsNullOrEmpty(donnees) Then
            LabelRFID.Text = donnees
        End If

        'Procédure de test
    End Sub


End Class
