<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCostumeShop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblCaption = New Label()
        picFair = New PictureBox()
        picStorm = New PictureBox()
        picBat = New PictureBox()
        picPirate = New PictureBox()
        btnFair = New Button()
        btnStorm = New Button()
        btnBat = New Button()
        btnPirate = New Button()
        lblCost1 = New Label()
        lblCost2 = New Label()
        lblCost3 = New Label()
        lblCost4 = New Label()
        btnBook = New Button()
        btnExit = New Button()
        lblConfirmation = New Label()
        CType(picFair, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStorm, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBat, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPirate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCaption
        ' 
        lblCaption.Anchor = AnchorStyles.Top
        lblCaption.AutoSize = True
        lblCaption.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCaption.Location = New Point(463, 9)
        lblCaption.Name = "lblCaption"
        lblCaption.Size = New Size(226, 23)
        lblCaption.TabIndex = 0
        lblCaption.Text = "Costume Shop Rentals"
        ' 
        ' picFair
        ' 
        picFair.Anchor = AnchorStyles.Top
        picFair.Image = My.Resources.Resources.renaissance_fair
        picFair.Location = New Point(139, 43)
        picFair.Name = "picFair"
        picFair.Size = New Size(178, 170)
        picFair.SizeMode = PictureBoxSizeMode.StretchImage
        picFair.TabIndex = 1
        picFair.TabStop = False
        picFair.Visible = False
        ' 
        ' picStorm
        ' 
        picStorm.Anchor = AnchorStyles.Top
        picStorm.Image = My.Resources.Resources.stormtrooper
        picStorm.Location = New Point(373, 43)
        picStorm.Name = "picStorm"
        picStorm.Size = New Size(178, 170)
        picStorm.SizeMode = PictureBoxSizeMode.StretchImage
        picStorm.TabIndex = 2
        picStorm.TabStop = False
        picStorm.Visible = False
        ' 
        ' picBat
        ' 
        picBat.Anchor = AnchorStyles.Top
        picBat.Image = My.Resources.Resources.batman_batgirl
        picBat.Location = New Point(597, 43)
        picBat.Name = "picBat"
        picBat.Size = New Size(178, 170)
        picBat.SizeMode = PictureBoxSizeMode.StretchImage
        picBat.TabIndex = 3
        picBat.TabStop = False
        picBat.Visible = False
        ' 
        ' picPirate
        ' 
        picPirate.Anchor = AnchorStyles.Top
        picPirate.Image = My.Resources.Resources.piratae
        picPirate.Location = New Point(835, 43)
        picPirate.Name = "picPirate"
        picPirate.Size = New Size(178, 170)
        picPirate.SizeMode = PictureBoxSizeMode.StretchImage
        picPirate.TabIndex = 4
        picPirate.TabStop = False
        picPirate.Visible = False
        ' 
        ' btnFair
        ' 
        btnFair.Anchor = AnchorStyles.Top
        btnFair.BackColor = Color.Silver
        btnFair.Cursor = Cursors.Hand
        btnFair.FlatStyle = FlatStyle.Flat
        btnFair.Font = New Font("Tahoma", 12F)
        btnFair.ForeColor = Color.White
        btnFair.Location = New Point(135, 263)
        btnFair.Name = "btnFair"
        btnFair.Size = New Size(168, 35)
        btnFair.TabIndex = 5
        btnFair.Text = "Renaissance Fair"
        btnFair.UseVisualStyleBackColor = False
        ' 
        ' btnStorm
        ' 
        btnStorm.Anchor = AnchorStyles.Top
        btnStorm.BackColor = Color.Silver
        btnStorm.Cursor = Cursors.Hand
        btnStorm.FlatStyle = FlatStyle.Flat
        btnStorm.Font = New Font("Tahoma", 12F)
        btnStorm.ForeColor = Color.White
        btnStorm.Location = New Point(384, 263)
        btnStorm.Name = "btnStorm"
        btnStorm.Size = New Size(168, 35)
        btnStorm.TabIndex = 6
        btnStorm.Text = "Stormtrooper"
        btnStorm.UseVisualStyleBackColor = False
        ' 
        ' btnBat
        ' 
        btnBat.Anchor = AnchorStyles.Top
        btnBat.BackColor = Color.Silver
        btnBat.Cursor = Cursors.Hand
        btnBat.FlatStyle = FlatStyle.Flat
        btnBat.Font = New Font("Tahoma", 12F)
        btnBat.ForeColor = Color.White
        btnBat.Location = New Point(605, 263)
        btnBat.Name = "btnBat"
        btnBat.Size = New Size(168, 35)
        btnBat.TabIndex = 7
        btnBat.Text = "Batman/Batgirl"
        btnBat.UseVisualStyleBackColor = False
        ' 
        ' btnPirate
        ' 
        btnPirate.Anchor = AnchorStyles.Top
        btnPirate.BackColor = Color.Silver
        btnPirate.Cursor = Cursors.Hand
        btnPirate.FlatStyle = FlatStyle.Flat
        btnPirate.Font = New Font("Tahoma", 12F)
        btnPirate.ForeColor = Color.White
        btnPirate.Location = New Point(849, 263)
        btnPirate.Name = "btnPirate"
        btnPirate.Size = New Size(168, 35)
        btnPirate.TabIndex = 8
        btnPirate.Text = "Pirate"
        btnPirate.UseVisualStyleBackColor = False
        ' 
        ' lblCost1
        ' 
        lblCost1.Anchor = AnchorStyles.Top
        lblCost1.AutoSize = True
        lblCost1.Font = New Font("Tahoma", 11.25F)
        lblCost1.Location = New Point(169, 229)
        lblCost1.Name = "lblCost1"
        lblCost1.Size = New Size(119, 18)
        lblCost1.TabIndex = 9
        lblCost1.Text = "$40 Week Rental"
        lblCost1.Visible = False
        ' 
        ' lblCost2
        ' 
        lblCost2.Anchor = AnchorStyles.Top
        lblCost2.AutoSize = True
        lblCost2.Font = New Font("Tahoma", 11.25F)
        lblCost2.Location = New Point(403, 229)
        lblCost2.Name = "lblCost2"
        lblCost2.Size = New Size(119, 18)
        lblCost2.TabIndex = 10
        lblCost2.Text = "$49 Week Rental"
        lblCost2.Visible = False
        ' 
        ' lblCost3
        ' 
        lblCost3.Anchor = AnchorStyles.Top
        lblCost3.AutoSize = True
        lblCost3.Font = New Font("Tahoma", 11.25F)
        lblCost3.Location = New Point(634, 229)
        lblCost3.Name = "lblCost3"
        lblCost3.Size = New Size(119, 18)
        lblCost3.TabIndex = 11
        lblCost3.Text = "$35 Week Rental"
        lblCost3.Visible = False
        ' 
        ' lblCost4
        ' 
        lblCost4.Anchor = AnchorStyles.Top
        lblCost4.AutoSize = True
        lblCost4.Font = New Font("Tahoma", 11.25F)
        lblCost4.Location = New Point(865, 229)
        lblCost4.Name = "lblCost4"
        lblCost4.Size = New Size(119, 18)
        lblCost4.TabIndex = 12
        lblCost4.Text = "$29 Week Rental"
        lblCost4.Visible = False
        ' 
        ' btnBook
        ' 
        btnBook.Anchor = AnchorStyles.Top
        btnBook.Cursor = Cursors.Hand
        btnBook.Enabled = False
        btnBook.Font = New Font("Tahoma", 12F)
        btnBook.ForeColor = Color.White
        btnBook.Location = New Point(494, 341)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(189, 30)
        btnBook.TabIndex = 13
        btnBook.Text = "Book Selected Costume"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top
        btnExit.Cursor = Cursors.Hand
        btnExit.Enabled = False
        btnExit.Font = New Font("Tahoma", 12F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(504, 421)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(168, 30)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.Anchor = AnchorStyles.Top
        lblConfirmation.AutoSize = True
        lblConfirmation.Font = New Font("Tahoma", 11.25F)
        lblConfirmation.Location = New Point(527, 387)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(125, 18)
        lblConfirmation.TabIndex = 15
        lblConfirmation.Text = "Costume Selected"
        lblConfirmation.Visible = False
        ' 
        ' frmCostumeShop
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1153, 749)
        Controls.Add(lblConfirmation)
        Controls.Add(btnExit)
        Controls.Add(btnBook)
        Controls.Add(lblCost4)
        Controls.Add(lblCost3)
        Controls.Add(lblCost2)
        Controls.Add(lblCost1)
        Controls.Add(btnPirate)
        Controls.Add(btnBat)
        Controls.Add(btnStorm)
        Controls.Add(btnFair)
        Controls.Add(picPirate)
        Controls.Add(picBat)
        Controls.Add(picStorm)
        Controls.Add(picFair)
        Controls.Add(lblCaption)
        Name = "frmCostumeShop"
        Text = "Costume Shop"
        CType(picFair, ComponentModel.ISupportInitialize).EndInit()
        CType(picStorm, ComponentModel.ISupportInitialize).EndInit()
        CType(picBat, ComponentModel.ISupportInitialize).EndInit()
        CType(picPirate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCaption As Label
    Friend WithEvents picFair As PictureBox
    Friend WithEvents picStorm As PictureBox
    Friend WithEvents picBat As PictureBox
    Friend WithEvents picPirate As PictureBox
    Friend WithEvents btnFair As Button
    Friend WithEvents btnStorm As Button
    Friend WithEvents btnBat As Button
    Friend WithEvents btnPirate As Button
    Friend WithEvents lblCost1 As Label
    Friend WithEvents lblCost2 As Label
    Friend WithEvents lblCost3 As Label
    Friend WithEvents lblCost4 As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConfirmation As Label

End Class
