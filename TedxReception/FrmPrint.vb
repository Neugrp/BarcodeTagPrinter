Public Class FrmPrint
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        print(id:=101, name:=TxtName.Text)
    End Sub
    Sub print(id As String, name As String)
        Dim rpt = New Badge
        Dim dt, dt2 As New DataTable
        rpt.SetParameterValue("id", id)
        rpt.SetParameterValue("name", name)

        FrmPrintCR.CrystalReportViewer1.ReportSource = rpt
        FrmPrintCR.ShowDialog()
    End Sub
    Private Sub BtnCrap_Click(sender As Object, e As EventArgs) Handles BtnCrap.Click
        LoadFromClipboardToDataGridView(dgv:=DGResult)
    End Sub
    Private Sub LoadFromClipboardToDataGridView(dgv As DataGridView)
        Try
            ' Get text from clipboard
            Dim clipboardText As String = Clipboard.GetText()
            If String.IsNullOrWhiteSpace(clipboardText) Then
                MessageBox.Show("Clipboard is empty or does not contain text.")
                Exit Sub
            End If

            ' Clear existing rows
            dgv.Rows.Clear()

            ' Split into lines
            Dim lines() As String = clipboardText.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

            For Each line As String In lines
                ' Split each line by tab
                Dim parts() As String = line.Split(ControlChars.Tab)
                If parts.Length >= 2 Then
                    dgv.Rows.Add(parts(0).Trim(), parts(1).Trim())
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnPrintDGV_Click(sender As Object, e As EventArgs) Handles BtnPrintDGV.Click
        For Each row As DataGridViewRow In DGResult.Rows
            PrintSilently(id:=row.Cells("ColID").Value,
                          name:=row.Cells("ColName").Value,
                          printerName:=CBPrinters.SelectedItem.ToString())
        Next
    End Sub

    Private Sub FrmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrinters()
    End Sub
    Private Sub LoadPrinters()
        CBPrinters.Items.Clear()
        For Each printer As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            CBPrinters.Items.Add(printer)
        Next

        If CBPrinters.Items.Count > 0 Then
            CBPrinters.SelectedIndex = 0 ' Select default
        End If
    End Sub

    Private Sub BtnRefreshPrinter_Click(sender As Object, e As EventArgs) Handles BtnRefreshPrinter.Click
        LoadPrinters()
    End Sub
    Sub PrintSilently(id As String, name As String, printerName As String)
        Try
            Dim rpt As New Badge()
            rpt.SetParameterValue("id", id)
            rpt.SetParameterValue("name", name)

            rpt.PrintOptions.PrinterName = printerName
            rpt.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            MessageBox.Show("Printing failed: " & ex.Message)
        End Try
    End Sub
End Class
