<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level1))
        Me.PboxMain = New System.Windows.Forms.PictureBox()
        Me.PboxBlock1 = New System.Windows.Forms.PictureBox()
        Me.PboxBlock2 = New System.Windows.Forms.PictureBox()
        Me.PboxFinish = New System.Windows.Forms.PictureBox()
        CType(Me.PboxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboxFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PboxMain
        '
        Me.PboxMain.Image = CType(resources.GetObject("PboxMain.Image"), System.Drawing.Image)
        Me.PboxMain.Location = New System.Drawing.Point(49, 332)
        Me.PboxMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PboxMain.Name = "PboxMain"
        Me.PboxMain.Size = New System.Drawing.Size(56, 51)
        Me.PboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PboxMain.TabIndex = 0
        Me.PboxMain.TabStop = False
        '
        'PboxBlock1
        '
        Me.PboxBlock1.Image = CType(resources.GetObject("PboxBlock1.Image"), System.Drawing.Image)
        Me.PboxBlock1.Location = New System.Drawing.Point(271, 364)
        Me.PboxBlock1.Margin = New System.Windows.Forms.Padding(2)
        Me.PboxBlock1.Name = "PboxBlock1"
        Me.PboxBlock1.Size = New System.Drawing.Size(14, 100)
        Me.PboxBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxBlock1.TabIndex = 1
        Me.PboxBlock1.TabStop = False
        '
        'PboxBlock2
        '
        Me.PboxBlock2.Image = CType(resources.GetObject("PboxBlock2.Image"), System.Drawing.Image)
        Me.PboxBlock2.Location = New System.Drawing.Point(477, 364)
        Me.PboxBlock2.Margin = New System.Windows.Forms.Padding(2)
        Me.PboxBlock2.Name = "PboxBlock2"
        Me.PboxBlock2.Size = New System.Drawing.Size(15, 100)
        Me.PboxBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxBlock2.TabIndex = 2
        Me.PboxBlock2.TabStop = False
        '
        'PboxFinish
        '
        Me.PboxFinish.Image = CType(resources.GetObject("PboxFinish.Image"), System.Drawing.Image)
        Me.PboxFinish.Location = New System.Drawing.Point(731, -9)
        Me.PboxFinish.Margin = New System.Windows.Forms.Padding(2)
        Me.PboxFinish.Name = "PboxFinish"
        Me.PboxFinish.Size = New System.Drawing.Size(53, 473)
        Me.PboxFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboxFinish.TabIndex = 3
        Me.PboxFinish.TabStop = False
        '
        'Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.PboxFinish)
        Me.Controls.Add(Me.PboxBlock2)
        Me.Controls.Add(Me.PboxBlock1)
        Me.Controls.Add(Me.PboxMain)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Level1"
        Me.Text = "Level1"
        CType(Me.PboxMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboxFinish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PboxMain As PictureBox
    Friend WithEvents PboxBlock1 As PictureBox
    Friend WithEvents PboxBlock2 As PictureBox
    Friend WithEvents PboxFinish As PictureBox
End Class
