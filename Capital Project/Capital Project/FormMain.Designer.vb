<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.cboStates = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboStates
        '
        Me.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStates.FormattingEnabled = True
        Me.cboStates.Location = New System.Drawing.Point(67, 52)
        Me.cboStates.Name = "cboStates"
        Me.cboStates.Size = New System.Drawing.Size(175, 28)
        Me.cboStates.TabIndex = 0
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(67, 29)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(48, 20)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "State"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(71, 135)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(189, 30)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "What is the capital?"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblCapital
        '
        Me.lblCapital.BackColor = System.Drawing.SystemColors.Info
        Me.lblCapital.Location = New System.Drawing.Point(362, 55)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(149, 25)
        Me.lblCapital.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Capital"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(298, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(426, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 266)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.cboStates)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboStates As ComboBox
    Friend WithEvents lblState As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents lblCapital As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
