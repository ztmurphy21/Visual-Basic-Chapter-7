<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbGlazed = New System.Windows.Forms.RadioButton()
        Me.rbSugar = New System.Windows.Forms.RadioButton()
        Me.rbChoc = New System.Windows.Forms.RadioButton()
        Me.rbFilled = New System.Windows.Forms.RadioButton()
        Me.gbDonuts = New System.Windows.Forms.GroupBox()
        Me.gbCoffee = New System.Windows.Forms.GroupBox()
        Me.rbCapp = New System.Windows.Forms.RadioButton()
        Me.rbReg = New System.Windows.Forms.RadioButton()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDonuts.SuspendLayout()
        Me.gbCoffee.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Donut_Project.My.Resources.Resources.DonutCoffee
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(732, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Our doughnuts and coffee are the best in town!"
        '
        'rbGlazed
        '
        Me.rbGlazed.AutoSize = True
        Me.rbGlazed.Location = New System.Drawing.Point(11, 28)
        Me.rbGlazed.Name = "rbGlazed"
        Me.rbGlazed.Size = New System.Drawing.Size(130, 24)
        Me.rbGlazed.TabIndex = 3
        Me.rbGlazed.TabStop = True
        Me.rbGlazed.Text = "&Glazed ($.75)"
        Me.rbGlazed.UseVisualStyleBackColor = True
        '
        'rbSugar
        '
        Me.rbSugar.AutoSize = True
        Me.rbSugar.Location = New System.Drawing.Point(11, 58)
        Me.rbSugar.Name = "rbSugar"
        Me.rbSugar.Size = New System.Drawing.Size(122, 24)
        Me.rbSugar.TabIndex = 4
        Me.rbSugar.TabStop = True
        Me.rbSugar.Text = "&Sugar ($.75)"
        Me.rbSugar.UseVisualStyleBackColor = True
        '
        'rbChoc
        '
        Me.rbChoc.AutoSize = True
        Me.rbChoc.Location = New System.Drawing.Point(11, 88)
        Me.rbChoc.Name = "rbChoc"
        Me.rbChoc.Size = New System.Drawing.Size(151, 24)
        Me.rbChoc.TabIndex = 5
        Me.rbChoc.TabStop = True
        Me.rbChoc.Text = "C&hocolate ($.75)"
        Me.rbChoc.UseVisualStyleBackColor = True
        '
        'rbFilled
        '
        Me.rbFilled.AutoSize = True
        Me.rbFilled.Location = New System.Drawing.Point(11, 118)
        Me.rbFilled.Name = "rbFilled"
        Me.rbFilled.Size = New System.Drawing.Size(116, 24)
        Me.rbFilled.TabIndex = 6
        Me.rbFilled.TabStop = True
        Me.rbFilled.Text = "&Filled ($.95)"
        Me.rbFilled.UseVisualStyleBackColor = True
        '
        'gbDonuts
        '
        Me.gbDonuts.Controls.Add(Me.rbFilled)
        Me.gbDonuts.Controls.Add(Me.rbChoc)
        Me.gbDonuts.Controls.Add(Me.rbSugar)
        Me.gbDonuts.Controls.Add(Me.rbGlazed)
        Me.gbDonuts.Location = New System.Drawing.Point(193, 75)
        Me.gbDonuts.Name = "gbDonuts"
        Me.gbDonuts.Size = New System.Drawing.Size(196, 172)
        Me.gbDonuts.TabIndex = 7
        Me.gbDonuts.TabStop = False
        Me.gbDonuts.Text = "Dou&ghnut choices"
        '
        'gbCoffee
        '
        Me.gbCoffee.Controls.Add(Me.rbCapp)
        Me.gbCoffee.Controls.Add(Me.rbReg)
        Me.gbCoffee.Controls.Add(Me.rbNone)
        Me.gbCoffee.Location = New System.Drawing.Point(193, 315)
        Me.gbCoffee.Name = "gbCoffee"
        Me.gbCoffee.Size = New System.Drawing.Size(188, 175)
        Me.gbCoffee.TabIndex = 8
        Me.gbCoffee.TabStop = False
        Me.gbCoffee.Text = "Coffee choices"
        '
        'rbCapp
        '
        Me.rbCapp.AutoSize = True
        Me.rbCapp.Location = New System.Drawing.Point(7, 97)
        Me.rbCapp.Name = "rbCapp"
        Me.rbCapp.Size = New System.Drawing.Size(172, 24)
        Me.rbCapp.TabIndex = 2
        Me.rbCapp.TabStop = True
        Me.rbCapp.Text = "Ca&ppuccino ($2.75)"
        Me.rbCapp.UseVisualStyleBackColor = True
        '
        'rbReg
        '
        Me.rbReg.AutoSize = True
        Me.rbReg.Location = New System.Drawing.Point(7, 66)
        Me.rbReg.Name = "rbReg"
        Me.rbReg.Size = New System.Drawing.Size(144, 24)
        Me.rbReg.TabIndex = 1
        Me.rbReg.TabStop = True
        Me.rbReg.Text = "&Regular ($1.50)"
        Me.rbReg.UseVisualStyleBackColor = True
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Location = New System.Drawing.Point(7, 35)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(72, 24)
        Me.rbNone.TabIndex = 0
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(608, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 142)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Info
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(129, 87)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.Info
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(129, 55)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 4
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.Info
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(131, 25)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubTotal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total due:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sales Tax:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(608, 350)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(164, 38)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(608, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 38)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 540)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbCoffee)
        Me.Controls.Add(Me.gbDonuts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Main_Form"
        Me.Text = "Donut Shoppe"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDonuts.ResumeLayout(False)
        Me.gbDonuts.PerformLayout()
        Me.gbCoffee.ResumeLayout(False)
        Me.gbCoffee.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbGlazed As RadioButton
    Friend WithEvents rbSugar As RadioButton
    Friend WithEvents rbChoc As RadioButton
    Friend WithEvents rbFilled As RadioButton
    Friend WithEvents gbDonuts As GroupBox
    Friend WithEvents gbCoffee As GroupBox
    Friend WithEvents rbCapp As RadioButton
    Friend WithEvents rbReg As RadioButton
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
