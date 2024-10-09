Public Class frmCostumeShop
    Private Sub btnFair_Click(sender As Object, e As EventArgs) Handles btnFair.Click
        picFair.Visible = True
        lblCost1.Visible = True
        picStorm.Visible = False
        lblCost2.Visible = False
        picBat.Visible = False
        lblCost3.Visible = False
        picPirate.Visible = False
        lblCost4.Visible = False
        btnBook.Enabled = True
    End Sub

    Private Sub btnStorm_Click(sender As Object, e As EventArgs) Handles btnStorm.Click
        picStorm.Visible = True
        lblCost2.Visible = True
        picFair.Visible = False
        lblCost1.Visible = False
        picBat.Visible = False
        lblCost3.Visible = False
        picPirate.Visible = False
        lblCost4.Visible = False
        btnBook.Enabled = True
    End Sub

    Private Sub btnBat_Click(sender As Object, e As EventArgs) Handles btnBat.Click
        picBat.Visible = True
        lblCost3.Visible = True
        picFair.Visible = False
        lblCost1.Visible = False
        picStorm.Visible = False
        lblCost2.Visible = False
        picPirate.Visible = False
        lblCost4.Visible = False
        btnBook.Enabled = True
    End Sub

    Private Sub btnPirate_Click(sender As Object, e As EventArgs) Handles btnPirate.Click
        picPirate.Visible = True
        lblCost4.Visible = True
        picFair.Visible = False
        lblCost1.Visible = False
        picStorm.Visible = False
        lblCost2.Visible = False
        picBat.Visible = False
        lblCost3.Visible = False
        btnBook.Enabled = True
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        btnFair.Visible = False
        btnBat.Visible = False
        btnStorm.Visible = False
        btnPirate.Visible = False
        btnExit.Enabled = True
        lblConfirmation.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
