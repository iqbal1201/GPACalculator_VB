Imports System.Formats.Asn1
Imports System.IO
Imports ExcelDataReader

Public Class Form1
    Dim tables As DataTableCollection



    Private Function GPAFunction(ByVal a As Double, ByVal b As Double) As Double
        Dim gpa As Double
        gpa = a / b
        Return gpa

    End Function

    Private Function GPAClassFunction(ByVal c As Double) As String
        Dim gpa_class As String
        If c >= 3.9 Then
            gpa_class = "Your GPA is Summa Cum Laude"
        ElseIf c >= 3.8 Then
            gpa_class = "Your GPA is Magna Cum Laude"
        ElseIf c >= 3.5 Then
            gpa_class = "Your GPA is Cum Laude"
        ElseIf c >= 3.0 Then
            gpa_class = "Your GPA is Excellent"
        Else
            gpa_class = "Your GPA is Good"
        End If

        Return gpa_class

    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"}
            If ofd.ShowDialog() = DialogResult.OK Then
                txtFileName.Text = ofd.FileName
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        cboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalSKS As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            totalSKS += DataGridView1.Rows(i).Cells(2).Value
        Next

        Dim totalMutu As Double
        For i As Integer = 0 To DataGridView1.RowCount - 1
            totalMutu += DataGridView1.Rows(i).Cells(6).Value
        Next

        Dim result_gpa As Double
        result_gpa = GPAFunction(totalMutu, totalSKS)

        Dim yourgpaclass As String
        yourgpaclass = GPAClassFunction(result_gpa)

        LabelGPABox.Text = String.Format("{0:f}", result_gpa)

        ResultGPACat.Text = String.Format(yourgpaclass)



    End Sub


End Class
