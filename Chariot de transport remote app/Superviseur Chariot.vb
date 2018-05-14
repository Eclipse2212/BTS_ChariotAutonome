Imports System.IO.Ports

Public Class Form1

    Dim donnees As String

    'Trigger quand on change l'élément actif
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Serial.PortName = ComboBox1.SelectedItem.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Serial.BaudRate = 9600
        Serial.StopBits = 1
        Serial.RtsEnable = False
        Serial.DtrEnable = False
        Serial.Parity = IO.Ports.Parity.None

        LabelRFID.Text = "Non connecté"

        PictureBox1.Image = Image.FromFile("Img\Unconnected.jpg")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Serial.IsOpen = False Then
            Serial.Open()
            ComboBox1.Enabled = False
            PictureBox1.Image = Image.FromFile("Img\Connected.jpg")
            LabelRFID.Text = "aucune donnée reçue"
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        If Serial.IsOpen = True Then
            Serial.Close()
            PictureBox1.Image = Image.FromFile("Img\Unconnected.jpg")
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub DriverButton_Click(sender As Object, e As EventArgs) Handles DriverButton.Click
        'Start pilot installing
        Dim procStartInfo As New ProcessStartInfo
        Dim procExecuting As New Process

        With procStartInfo
            .UseShellExecute = True
            .FileName = ".\Res\DriverMM232R\CDM v2.12.00 WHQL Certified.exe"
            .WindowStyle = ProcessWindowStyle.Normal
            .Verb = "runas" 'add this to prompt for elevation
        End With

        procExecuting = Process.Start(procStartInfo)
    End Sub

    Private Sub Vroum1ConnStatus_Click(sender As Object, e As EventArgs) Handles Vroum1ConnStatus.Click
        Clipboard.SetText(Vroum1ConnStatus.Text)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabGroup.SelectedTab.Text = RenameBoxTab2.Text
    End Sub


    Public Sub SendStart()
        'Send start data to chariot
        Serial.WriteLine("START")
    End Sub

    Public Sub SendStop()
        'Send stop order to chariot
        Serial.WriteLine("STOP")
    End Sub

    Public Sub SetCarSpeed(speed As Integer)
        Serial.WriteLine(speed.ToString())
    End Sub

    Private Sub Serial_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles Serial.DataReceived
        donnees = Serial.ReadLine()
        Console.WriteLine(donnees)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelRFID.Text = donnees

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Serial.IsOpen = True Then
            Serial.Close()
        End If
    End Sub
End Class
