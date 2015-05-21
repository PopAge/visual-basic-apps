﻿Public Class Form1

    'Valery Samovich
    '2015-05-20

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        ' Align the label text to the left.
        lblTranslator.TextAlign = ContentAlignment.MiddleLeft
        ' Make the translation visible.
        lblTranslator.Visible = True
        ' Display left
        lblTranslator.Text = "left"
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        ' Align the label text to the right.
        lblTranslator.TextAlign = ContentAlignment.MiddleRight
        ' Make the translation visible.
        lblTranslator.Visible = True
        ' Display right
        lblTranslator.Text = "right"
    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        ' Align the label text to the center.
        lblTranslator.TextAlign = ContentAlignment.MiddleCenter
        ' Make the translation visible.
        lblTranslator.Visible = True
        ' Display center
        lblTranslator.Text = "center"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
