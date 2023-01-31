Imports System
Imports System.Data.SqlClient
Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports

Public Class frm_mr


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "---------SELECT FIELD---------" Then
            txt_field.Visible = False
            lbl_field.Text = "***please select field first***"
            lbl_field.ForeColor = Color.Green
        ElseIf ComboBox1.Text <> "---------SELECT FIELD---------" Then
            lbl_field.Text = "PLEASE ENTER " & ComboBox1.Text
            txt_field.Visible = True
            lbl_field.ForeColor = Color.Black



        End If

    End Sub

    Private Sub frm_mr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_field.Text = "***please select field first***"
        lbl_field.ForeColor = Color.Green
        txt_field.Visible = False
        pnl_app.Visible = False
        pnl_test.Visible = False

    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_rqfor.SelectedIndexChanged
        If cmb_rqfor.Text = "TEST" Then
            pnl_app.Visible = False

            pnl_test.Visible = True



        End If
        If cmb_rqfor.Text = "CHECK UP" Then
            pnl_app.Visible = True


            pnl_test.Visible = False



        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        txt_amount.Text = 1200

        PNLDIS.Visible = True

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        txt_amount.Text = 700
        PNLDIS.Visible = True


    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        lbldis.Visible = True

        lbldis.Text = "ENTER AMOUNT"

        txtdis.Visible = True




        If CheckBox1.Checked Then
            CheckBox1.Checked = False
            lbldis.Visible = True

            lbldis.Text = "ENTER AMOUNT"

            txtdis.Visible = True


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
        lbldis.Visible = True

        lbldis.Text = "ENTER PERCENT"
        txtdis.Visible = True
        If CheckBox2.Checked Then
            CheckBox2.Checked = False
            lbldis.Visible = True

            lbldis.Text = "ENTER PERCENT"
            txtdis.Visible = True


        Else
            CheckBox2.Checked = False
            lbldis.Visible = True

            lbldis.Text = "ENTER PERCENT"
            txtdis.Visible = True

        End If
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim amount As Integer
        Dim discount As Integer
        amount = txt_amount.Text.ToString()

        discount = txtdis.Text

        lblfnlam.Text = "TOTAL AMOUNT IS RS   : " & amount - discount & "PKR"
        lblfnlam.Visible = True

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        BTNVR.Visible = True
        Button8.Enabled = False

    End Sub

    Private Sub BTNVR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNVR.Click
        Dim RPT As New CrystalReport1
        Dim viewform As New frm_rpt
        viewform.Show()


    End Sub
    Dim connection As New SqlConnection("SERVER=.\SQLEXPRESS;DATABASE=medical erp; Integrated security = true;")

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim command As New SqlCommand("", connection)
        If 
    End Sub
End Class