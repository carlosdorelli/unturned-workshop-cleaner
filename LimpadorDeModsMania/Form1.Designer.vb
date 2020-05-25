<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tela
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tela))
        Me.CleanButton = New System.Windows.Forms.Button()
        Me.DiscordButton = New System.Windows.Forms.Button()
        Me.Texto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CleanButton
        '
        Me.CleanButton.Location = New System.Drawing.Point(24, 269)
        Me.CleanButton.Name = "CleanButton"
        Me.CleanButton.Size = New System.Drawing.Size(284, 70)
        Me.CleanButton.TabIndex = 0
        Me.CleanButton.Text = "Clean workshop mods"
        Me.CleanButton.UseVisualStyleBackColor = True
        '
        'DiscordButton
        '
        Me.DiscordButton.Location = New System.Drawing.Point(24, 358)
        Me.DiscordButton.Name = "DiscordButton"
        Me.DiscordButton.Size = New System.Drawing.Size(284, 70)
        Me.DiscordButton.TabIndex = 1
        Me.DiscordButton.Text = "Join our Discord"
        Me.DiscordButton.UseVisualStyleBackColor = True
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.BackColor = System.Drawing.Color.Transparent
        Me.Texto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Texto.Location = New System.Drawing.Point(21, 240)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(268, 26)
        Me.Texto.TabIndex = 2
        Me.Texto.Text = "Just a program to clean all workshop mods. It's free and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "always will be."
        '
        'Tela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.DiscordButton)
        Me.Controls.Add(Me.CleanButton)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Tela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unturned Workshop Cleaner - Made by Eldremor from eldremorstudios.com | Unturned " &
    "Mania 2016-2020"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CleanButton As Button
    Friend WithEvents DiscordButton As Button
    Friend WithEvents Texto As Label
End Class
