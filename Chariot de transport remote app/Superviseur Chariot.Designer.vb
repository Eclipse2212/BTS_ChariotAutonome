<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DriverButton = New System.Windows.Forms.Button()
        Me.PilotButton = New System.Windows.Forms.Label()
        Me.TabGroup = New System.Windows.Forms.TabControl()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.TabVroum1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Vroum1ConnStatus = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RenameBoxTab2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGroup.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.TabVroum1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion port COM"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CloseButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DriverButton, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PilotButton, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.57747!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 58)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1. Choisir port COM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(325, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 22)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.ComboBox1.Location = New System.Drawing.Point(3, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ouvrir port"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(164, 31)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(155, 24)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Fermer port"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DriverButton
        '
        Me.DriverButton.Location = New System.Drawing.Point(446, 31)
        Me.DriverButton.Name = "DriverButton"
        Me.DriverButton.Size = New System.Drawing.Size(135, 23)
        Me.DriverButton.TabIndex = 6
        Me.DriverButton.Text = "Installer le pilote"
        Me.DriverButton.UseVisualStyleBackColor = True
        '
        'PilotButton
        '
        Me.PilotButton.AutoSize = True
        Me.PilotButton.Location = New System.Drawing.Point(325, 0)
        Me.PilotButton.Name = "PilotButton"
        Me.PilotButton.Size = New System.Drawing.Size(89, 13)
        Me.PilotButton.TabIndex = 5
        Me.PilotButton.Text = "Etat du port COM"
        '
        'TabGroup
        '
        Me.TabGroup.Controls.Add(Me.TabSettings)
        Me.TabGroup.Controls.Add(Me.TabVroum1)
        Me.TabGroup.Location = New System.Drawing.Point(12, 12)
        Me.TabGroup.Name = "TabGroup"
        Me.TabGroup.SelectedIndex = 0
        Me.TabGroup.Size = New System.Drawing.Size(595, 240)
        Me.TabGroup.TabIndex = 1
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.GroupBox1)
        Me.TabSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(587, 214)
        Me.TabSettings.TabIndex = 0
        Me.TabSettings.Text = "Paramètres"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'TabVroum1
        '
        Me.TabVroum1.Controls.Add(Me.GroupBox3)
        Me.TabVroum1.Controls.Add(Me.GroupBox2)
        Me.TabVroum1.Location = New System.Drawing.Point(4, 22)
        Me.TabVroum1.Name = "TabVroum1"
        Me.TabVroum1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVroum1.Size = New System.Drawing.Size(587, 214)
        Me.TabVroum1.TabIndex = 1
        Me.TabVroum1.Text = "Chariot 1"
        Me.TabVroum1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Vroum1ConnStatus)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 58)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identifiant du Chariot"
        '
        'Vroum1ConnStatus
        '
        Me.Vroum1ConnStatus.AutoSize = True
        Me.Vroum1ConnStatus.Location = New System.Drawing.Point(21, 26)
        Me.Vroum1ConnStatus.Name = "Vroum1ConnStatus"
        Me.Vroum1ConnStatus.Size = New System.Drawing.Size(75, 13)
        Me.Vroum1ConnStatus.TabIndex = 1
        Me.Vroum1ConnStatus.Text = "Non connecté"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 54)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Renommer l'onglet"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RenameBoxTab2, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(263, 32)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'RenameBoxTab2
        '
        Me.RenameBoxTab2.Location = New System.Drawing.Point(3, 3)
        Me.RenameBoxTab2.Name = "RenameBoxTab2"
        Me.RenameBoxTab2.Size = New System.Drawing.Size(125, 20)
        Me.RenameBoxTab2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(134, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Valider"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 264)
        Me.Controls.Add(Me.TabGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "PC superviseur Chariots"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGroup.ResumeLayout(False)
        Me.TabSettings.ResumeLayout(False)
        Me.TabVroum1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Serial As IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PilotButton As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabGroup As TabControl
    Friend WithEvents TabSettings As TabPage
    Friend WithEvents TabVroum1 As TabPage
    Friend WithEvents DriverButton As Button
    Friend WithEvents Vroum1ConnStatus As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RenameBoxTab2 As TextBox
    Friend WithEvents Button2 As Button
End Class
