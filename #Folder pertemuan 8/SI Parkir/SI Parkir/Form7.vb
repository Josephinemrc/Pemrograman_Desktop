﻿Imports MySql.Data.MySqlClient

Public Class frmLaporan
    Private Sub formLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        loadLaporan()

    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        loadLaporan()
    End Sub

    Private Sub loadLaporan()

        Dim ds As New DataSet1
        Dim myAdapter As New MySqlDataAdapter

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir", myConn)
        myAdapter.Fill(ds.Tables(0))

        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1_LapParkir", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        formUtama.Show()
    End Sub
End Class