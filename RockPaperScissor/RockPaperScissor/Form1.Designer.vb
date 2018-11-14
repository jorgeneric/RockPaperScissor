<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.radioDave = New System.Windows.Forms.RadioButton()
        Me.radioBill = New System.Windows.Forms.RadioButton()
        Me.lblMessageWins = New System.Windows.Forms.Label()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.lblNumberOfPlayerWins = New System.Windows.Forms.Label()
        Me.txtBillCount = New System.Windows.Forms.TextBox()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblClickImage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.lblBigWinner = New System.Windows.Forms.Label()
        Me.txtDaveCount = New System.Windows.Forms.TextBox()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radioDave
        '
        Me.radioDave.AutoSize = True
        Me.radioDave.Location = New System.Drawing.Point(90, 107)
        Me.radioDave.Name = "radioDave"
        Me.radioDave.Size = New System.Drawing.Size(51, 17)
        Me.radioDave.TabIndex = 0
        Me.radioDave.TabStop = True
        Me.radioDave.Text = "Dave"
        Me.radioDave.UseVisualStyleBackColor = True
        '
        'radioBill
        '
        Me.radioBill.AutoSize = True
        Me.radioBill.Location = New System.Drawing.Point(90, 148)
        Me.radioBill.Name = "radioBill"
        Me.radioBill.Size = New System.Drawing.Size(38, 17)
        Me.radioBill.TabIndex = 1
        Me.radioBill.TabStop = True
        Me.radioBill.Text = "Bill"
        Me.radioBill.UseVisualStyleBackColor = True
        '
        'lblMessageWins
        '
        Me.lblMessageWins.AutoSize = True
        Me.lblMessageWins.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageWins.Location = New System.Drawing.Point(310, 32)
        Me.lblMessageWins.Name = "lblMessageWins"
        Me.lblMessageWins.Size = New System.Drawing.Size(220, 25)
        Me.lblMessageWins.TabIndex = 2
        Me.lblMessageWins.Text = "Player Beats Computer!"
        '
        'picRock
        '
        Me.picRock.Image = Global.RockPaperScissor.My.Resources.Resources.Rock
        Me.picRock.Location = New System.Drawing.Point(189, 340)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(145, 179)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRock.TabIndex = 3
        Me.picRock.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = Global.RockPaperScissor.My.Resources.Resources.Paper
        Me.picPaper.Location = New System.Drawing.Point(340, 340)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(145, 179)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPaper.TabIndex = 4
        Me.picPaper.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = Global.RockPaperScissor.My.Resources.Resources.Scissors
        Me.picScissors.Location = New System.Drawing.Point(491, 340)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(145, 179)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScissors.TabIndex = 5
        Me.picScissors.TabStop = False
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(220, 73)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(36, 13)
        Me.lblPlayer.TabIndex = 6
        Me.lblPlayer.Text = "Player"
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(262, 73)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(43, 20)
        Me.txtPlayer.TabIndex = 7
        Me.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberOfPlayerWins
        '
        Me.lblNumberOfPlayerWins.AutoSize = True
        Me.lblNumberOfPlayerWins.Location = New System.Drawing.Point(360, 122)
        Me.lblNumberOfPlayerWins.Name = "lblNumberOfPlayerWins"
        Me.lblNumberOfPlayerWins.Size = New System.Drawing.Size(115, 13)
        Me.lblNumberOfPlayerWins.TabIndex = 8
        Me.lblNumberOfPlayerWins.Text = "Number of Player Wins"
        '
        'txtBillCount
        '
        Me.txtBillCount.Location = New System.Drawing.Point(399, 145)
        Me.txtBillCount.Name = "txtBillCount"
        Me.txtBillCount.Size = New System.Drawing.Size(31, 20)
        Me.txtBillCount.TabIndex = 9
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Location = New System.Drawing.Point(536, 73)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(52, 13)
        Me.lblComputer.TabIndex = 10
        Me.lblComputer.Text = "Computer"
        '
        'lblClickImage
        '
        Me.lblClickImage.AutoSize = True
        Me.lblClickImage.Location = New System.Drawing.Point(186, 307)
        Me.lblClickImage.Name = "lblClickImage"
        Me.lblClickImage.Size = New System.Drawing.Size(200, 13)
        Me.lblClickImage.TabIndex = 11
        Me.lblClickImage.Text = "Click the Rock, Paper, or Scissors Image"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(658, 551)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picPlayer
        '
        Me.picPlayer.Location = New System.Drawing.Point(223, 107)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(98, 115)
        Me.picPlayer.TabIndex = 13
        Me.picPlayer.TabStop = False
        '
        'picComputer
        '
        Me.picComputer.Location = New System.Drawing.Point(511, 107)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(98, 115)
        Me.picComputer.TabIndex = 14
        Me.picComputer.TabStop = False
        '
        'lblBigWinner
        '
        Me.lblBigWinner.AutoSize = True
        Me.lblBigWinner.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBigWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigWinner.Location = New System.Drawing.Point(220, 269)
        Me.lblBigWinner.Name = "lblBigWinner"
        Me.lblBigWinner.Size = New System.Drawing.Size(0, 16)
        Me.lblBigWinner.TabIndex = 15
        Me.lblBigWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDaveCount
        '
        Me.txtDaveCount.Location = New System.Drawing.Point(399, 145)
        Me.txtDaveCount.Name = "txtDaveCount"
        Me.txtDaveCount.Size = New System.Drawing.Size(31, 20)
        Me.txtDaveCount.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(887, 704)
        Me.Controls.Add(Me.txtDaveCount)
        Me.Controls.Add(Me.lblBigWinner)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblClickImage)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.txtBillCount)
        Me.Controls.Add(Me.lblNumberOfPlayerWins)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picRock)
        Me.Controls.Add(Me.lblMessageWins)
        Me.Controls.Add(Me.radioBill)
        Me.Controls.Add(Me.radioDave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioDave As RadioButton
    Friend WithEvents radioBill As RadioButton
    Friend WithEvents lblMessageWins As Label
    Friend WithEvents picRock As PictureBox
    Friend WithEvents picPaper As PictureBox
    Friend WithEvents picScissors As PictureBox
    Friend WithEvents lblPlayer As Label
    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents lblNumberOfPlayerWins As Label
    Friend WithEvents txtBillCount As TextBox
    Friend WithEvents lblComputer As Label
    Friend WithEvents lblClickImage As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picComputer As PictureBox
    Friend WithEvents lblBigWinner As Label
    Friend WithEvents txtDaveCount As TextBox
End Class
