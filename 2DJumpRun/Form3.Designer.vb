<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level3
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level3))
        Me.PboxMain = New System.Windows.Forms.PictureBox()
        Me.PboxBlock1 = New System.Windows.Forms.PictureBox()
        Me.PboxBlock2 = New System.Windows.Forms.PictureBox()
        Me.PboxFinish = New System.Windows.Forms.PictureBox()
        Me.pboxGehen = New System.Windows.Forms.PictureBox()
        Me.PboxBlock3 = New System.Windows.Forms.PictureBox()
        Me.pboxTeleport1 = New System.Windows.Forms.PictureBox()
        Me.pboxTeleport2 = New System.Windows.Forms.PictureBox()
        CType(Me.PboxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxGehen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxBlock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTeleport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTeleport2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PboxMain
        '
        Me.PboxMain.Image = CType(resources.GetObject("PboxMain.Image"), System.Drawing.Image)
        Me.PboxMain.Location = New System.Drawing.Point(74, 511)
        Me.PboxMain.Name = "PboxMain"
        Me.PboxMain.Size = New System.Drawing.Size(56, 51)
        Me.PboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PboxMain.TabIndex = 2
        Me.PboxMain.TabStop = False
        '
        'PboxBlock1
        '
        Me.PboxBlock1.Image = CType(resources.GetObject("PboxBlock1.Image"), System.Drawing.Image)
        Me.PboxBlock1.Location = New System.Drawing.Point(870, 214)
        Me.PboxBlock1.Name = "PboxBlock1"
        Me.PboxBlock1.Size = New System.Drawing.Size(21, 100)
        Me.PboxBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxBlock1.TabIndex = 3
        Me.PboxBlock1.TabStop = False
        '
        'PboxBlock2
        '
        Me.PboxBlock2.Image = CType(resources.GetObject("PboxBlock2.Image"), System.Drawing.Image)
        Me.PboxBlock2.Location = New System.Drawing.Point(608, 214)
        Me.PboxBlock2.Name = "PboxBlock2"
        Me.PboxBlock2.Size = New System.Drawing.Size(22, 100)
        Me.PboxBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxBlock2.TabIndex = 4
        Me.PboxBlock2.TabStop = False
        '
        'PboxFinish
        '
        Me.PboxFinish.Image = CType(resources.GetObject("PboxFinish.Image"), System.Drawing.Image)
        Me.PboxFinish.Location = New System.Drawing.Point(470, -3)
        Me.PboxFinish.Name = "PboxFinish"
        Me.PboxFinish.Size = New System.Drawing.Size(80, 291)
        Me.PboxFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxFinish.TabIndex = 5
        Me.PboxFinish.TabStop = False
        '
        'pboxGehen
        '
        Me.pboxGehen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pboxGehen.BackgroundImage = CType(resources.GetObject("pboxGehen.BackgroundImage"), System.Drawing.Image)
        Me.pboxGehen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pboxGehen.Location = New System.Drawing.Point(470, 255)
        Me.pboxGehen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pboxGehen.Name = "pboxGehen"
        Me.pboxGehen.Size = New System.Drawing.Size(710, 462)
        Me.pboxGehen.TabIndex = 7
        Me.pboxGehen.TabStop = False
        '
        'PboxBlock3
        '
        Me.PboxBlock3.Image = CType(resources.GetObject("PboxBlock3.Image"), System.Drawing.Image)
        Me.PboxBlock3.Location = New System.Drawing.Point(210, 552)
        Me.PboxBlock3.Name = "PboxBlock3"
        Me.PboxBlock3.Size = New System.Drawing.Size(22, 158)
        Me.PboxBlock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxBlock3.TabIndex = 8
        Me.PboxBlock3.TabStop = False
        '
        'pboxTeleport1
        '
        Me.pboxTeleport1.BackColor = System.Drawing.Color.IndianRed
        Me.pboxTeleport1.Location = New System.Drawing.Point(348, 585)
        Me.pboxTeleport1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pboxTeleport1.Name = "pboxTeleport1"
        Me.pboxTeleport1.Size = New System.Drawing.Size(127, 15)
        Me.pboxTeleport1.TabIndex = 9
        Me.pboxTeleport1.TabStop = False
        '
        'pboxTeleport2
        '
        Me.pboxTeleport2.BackColor = System.Drawing.Color.IndianRed
        Me.pboxTeleport2.Location = New System.Drawing.Point(963, 255)
        Me.pboxTeleport2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pboxTeleport2.Name = "pboxTeleport2"
        Me.pboxTeleport2.Size = New System.Drawing.Size(150, 15)
        Me.pboxTeleport2.TabIndex = 10
        Me.pboxTeleport2.TabStop = False
        '
        'Level3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1176, 709)
        Me.Controls.Add(Me.pboxTeleport2)
        Me.Controls.Add(Me.pboxTeleport1)
        Me.Controls.Add(Me.PboxBlock3)
        Me.Controls.Add(Me.pboxGehen)
        Me.Controls.Add(Me.PboxFinish)
        Me.Controls.Add(Me.PboxBlock2)
        Me.Controls.Add(Me.PboxBlock1)
        Me.Controls.Add(Me.PboxMain)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Level3"
        Me.Text = "Level3"
        CType(Me.PboxMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxFinish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxGehen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxBlock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTeleport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTeleport2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PboxMain As PictureBox
    Friend WithEvents PboxBlock1 As PictureBox
    Friend WithEvents PboxBlock2 As PictureBox
    Friend WithEvents PboxFinish As PictureBox
    Friend WithEvents pboxGehen As PictureBox
    Friend WithEvents PboxBlock3 As PictureBox
    Friend WithEvents pboxTeleport1 As PictureBox
    Friend WithEvents pboxTeleport2 As PictureBox
End Class
