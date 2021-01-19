Public Class Form1

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblStudio.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblReleaseDate.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblBestMovie.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radPeter.CheckedChanged
        lblNetWorth.Text = "Net Worth: $450 million"
        lblBestMovie.Text = "Best Movie: The Lord of the Rings: The Return of the King"
        lblReleaseDate.Text = "Release Date: December 17, 2003"
        lblStudio.Text = "Studio: New Line"

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radJames.CheckedChanged
        lblNetWorth.Text = "Net Worth: $700 million"
        lblBestMovie.Text = "Best Movie: Avatar"
        lblReleaseDate.Text = "Release Date: December 18, 2009"
        lblStudio.Text = "Studio: Fox"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radSteven.CheckedChanged
        lblNetWorth.Text = "Net Worth: $3.7 billion"
        lblBestMovie.Text = "Best Movie: E.T.: The Extra-Terrestrial"
        lblReleaseDate.Text = "Release Date: June 11, 1982"
        lblStudio.Text = "Studio: Universal"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radGeorge.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNetWorth.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles radGeorge.Click
        lblNetWorth.Text = "Net Worth: $4.9 billion"
        lblBestMovie.Text = "Best Movie: Star Wars: Episode I - The Phantom Menace"
        lblReleaseDate.Text = "Release Date: May 19, 1999"
        lblStudio.Text = "Studio: Fox"
    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        radGeorge.Checked = True
        lblNetWorth.Text = "Net Worth: $4.9 billion"
        lblBestMovie.Text = "Best Movie: Star Wars: Episode I - The Phantom Menace"
        lblReleaseDate.Text = "Release Date: May 19, 1999"
        lblStudio.Text = "Studio: Fox"

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub radJames_Click(sender As Object, e As EventArgs) Handles radJames.Click

    End Sub
End Class
