Public Class Form1
    Dim DaveWin As Integer = 1
    Dim BillWin As Integer = 1

    Private Sub radioDave_CheckedChanged(sender As Object, e As EventArgs) Handles radioDave.CheckedChanged
        txtPlayer.Text = "Dave"
        txtDaveCount.Visible = True
        txtBillCount.Visible = False
    End Sub

    Private Sub radioBill_CheckedChanged(sender As Object, e As EventArgs) Handles radioBill.CheckedChanged
        txtPlayer.Text = "Bill"
        txtBillCount.Visible = True
        txtDaveCount.Visible = False
    End Sub

    Private Sub picRock_Click(sender As Object, e As EventArgs) Handles picRock.Click

        Dim randomNumber As New Random
        Dim computerChoice As Integer

        picPlayer.Image = picRock.Image

        computerChoice = randomNumber.Next(1, 4)
        Select Case computerChoice
            Case 1
                picComputer.Image = picRock.Image
                lblBigWinner.Text = "Tie"
                lblMessageWins.Visible = False

            Case 2
                picComputer.Image = picPaper.Image
                lblBigWinner.Text = "Computer wins because Paper covers Rock"
                lblMessageWins.Visible = False

            Case 3
                picComputer.Image = picScissors.Image
                lblBigWinner.Text = "Player wins because Rock Breaks Scissors"
                lblMessageWins.Visible = True
                lblMessageWins.BackColor = Color.Wheat
                If radioBill.Checked Then
                    txtBillCount.Text = BillWin
                    BillWin += 1
                ElseIf radioDave.Checked Then
                    txtDaveCount.Text = DaveWin
                    DaveWin += 1
                End If
        End Select

    End Sub

    Private Sub picPaper_Click(sender As Object, e As EventArgs) Handles picPaper.Click

        Dim randomNumber As New Random
        Dim computerChoice As Integer

        picPlayer.Image = picPaper.Image

        computerChoice = randomNumber.Next(1, 4)
        Select Case computerChoice
            Case 1
                picComputer.Image = picPaper.Image
                lblBigWinner.Text = "Tie"
                lblMessageWins.Visible = False

            Case 2
                picComputer.Image = picScissors.Image
                lblBigWinner.Text = "Computer wins because Scissors cuts Paper"
                lblMessageWins.Visible = False

            Case 3
                picComputer.Image = picRock.Image
                lblBigWinner.Text = "Player wins because Paper Covers Rock"
                lblMessageWins.Visible = True
                lblMessageWins.BackColor = Color.Wheat
                If radioBill.Checked Then
                    txtBillCount.Text = BillWin
                    BillWin += 1
                ElseIf radioDave.Checked Then
                    txtDaveCount.Text = DaveWin
                    DaveWin += 1
                End If

        End Select
    End Sub

    Private Sub picScissors_Click(sender As Object, e As EventArgs) Handles picScissors.Click

        Dim randomNumber As New Random
        Dim computerChoice As Integer

        picPlayer.Image = picScissors.Image

        computerChoice = randomNumber.Next(1, 4)
        Select Case computerChoice
            Case 1
                picComputer.Image = picScissors.Image
                lblBigWinner.Text = "Tie"
                lblMessageWins.Visible = False

            Case 2
                picComputer.Image = picRock.Image
                lblBigWinner.Text = "Computer wins because Rock breaks Scissors"
                lblMessageWins.Visible = False

            Case 3
                picComputer.Image = picPaper.Image
                lblBigWinner.Text = "Player wins because Scissors cuts Paper"
                lblMessageWins.Visible = True
                lblMessageWins.BackColor = Color.Wheat
                If radioBill.Checked Then
                    txtBillCount.Text = BillWin
                    BillWin += 1
                ElseIf radioDave.Checked Then
                    txtDaveCount.Text = DaveWin
                    DaveWin += 1
                End If

        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
