<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gewonnenForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gewonnenForm))
        Me.lblGewonnen = New System.Windows.Forms.Label()
        Me.btnSchliessen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGewonnen
        '
        Me.lblGewonnen.AutoSize = True
        Me.lblGewonnen.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGewonnen.Location = New System.Drawing.Point(66, 146)
        Me.lblGewonnen.Name = "lblGewonnen"
        Me.lblGewonnen.Size = New System.Drawing.Size(697, 24)
        Me.lblGewonnen.TabIndex = 0
        Me.lblGewonnen.Text = "Herzlichen Glückwunsch du hast gewonnen und den Gnom nachhause geführt"
        '
        'btnSchliessen
        '
        Me.btnSchliessen.Location = New System.Drawing.Point(350, 245)
        Me.btnSchliessen.Name = "btnSchliessen"
        Me.btnSchliessen.Size = New System.Drawing.Size(100, 23)
        Me.btnSchliessen.TabIndex = 1
        Me.btnSchliessen.Text = "Exit to Desktop"
        Me.btnSchliessen.UseVisualStyleBackColor = True
        '
        'gewonnenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSchliessen)
        Me.Controls.Add(Me.lblGewonnen)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gewonnenForm"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGewonnen As Label
    Friend WithEvents btnSchliessen As Button
End Class
