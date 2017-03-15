<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radSong = New System.Windows.Forms.RadioButton()
        Me.radSinger = New System.Windows.Forms.RadioButton()
        Me.radActor = New System.Windows.Forms.RadioButton()
        Me.radActress = New System.Windows.Forms.RadioButton()
        Me.radMovie = New System.Windows.Forms.RadioButton()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFavorite = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'radSong
        '
        Me.radSong.AutoSize = true
        Me.radSong.Location = New System.Drawing.Point(79, 148)
        Me.radSong.Name = "radSong"
        Me.radSong.Size = New System.Drawing.Size(61, 24)
        Me.radSong.TabIndex = 6
        Me.radSong.Text = "&Song"
        Me.radSong.UseVisualStyleBackColor = true
        '
        'radSinger
        '
        Me.radSinger.AutoSize = true
        Me.radSinger.Location = New System.Drawing.Point(79, 118)
        Me.radSinger.Name = "radSinger"
        Me.radSinger.Size = New System.Drawing.Size(69, 24)
        Me.radSinger.TabIndex = 5
        Me.radSinger.Text = "Singe&r"
        Me.radSinger.UseVisualStyleBackColor = true
        '
        'radActor
        '
        Me.radActor.AutoSize = true
        Me.radActor.Checked = true
        Me.radActor.Location = New System.Drawing.Point(79, 28)
        Me.radActor.Name = "radActor"
        Me.radActor.Size = New System.Drawing.Size(63, 24)
        Me.radActor.TabIndex = 2
        Me.radActor.TabStop = true
        Me.radActor.Text = "&Actor"
        Me.radActor.UseVisualStyleBackColor = true
        '
        'radActress
        '
        Me.radActress.AutoSize = true
        Me.radActress.Location = New System.Drawing.Point(79, 58)
        Me.radActress.Name = "radActress"
        Me.radActress.Size = New System.Drawing.Size(74, 24)
        Me.radActress.TabIndex = 3
        Me.radActress.Text = "Ac&tress"
        Me.radActress.UseVisualStyleBackColor = true
        '
        'radMovie
        '
        Me.radMovie.AutoSize = true
        Me.radMovie.Location = New System.Drawing.Point(79, 88)
        Me.radMovie.Name = "radMovie"
        Me.radMovie.Size = New System.Drawing.Size(68, 24)
        Me.radMovie.TabIndex = 4
        Me.radMovie.Text = "&Movie"
        Me.radMovie.UseVisualStyleBackColor = true
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(208, 28)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(113, 33)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "&Get Favorite"
        Me.btnGet.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 67)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 33)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'lblFavorite
        '
        Me.lblFavorite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lblFavorite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFavorite.Location = New System.Drawing.Point(36, 192)
        Me.lblFavorite.Name = "lblFavorite"
        Me.lblFavorite.Size = New System.Drawing.Size(329, 60)
        Me.lblFavorite.TabIndex = 7
        Me.lblFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 286)
        Me.Controls.Add(Me.lblFavorite)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.radMovie)
        Me.Controls.Add(Me.radActress)
        Me.Controls.Add(Me.radActor)
        Me.Controls.Add(Me.radSinger)
        Me.Controls.Add(Me.radSong)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Favorites"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents radSong As RadioButton
    Friend WithEvents radSinger As RadioButton
    Friend WithEvents radActor As RadioButton
    Friend WithEvents radActress As RadioButton
    Friend WithEvents radMovie As RadioButton
    Friend WithEvents btnGet As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFavorite As Label
End Class
