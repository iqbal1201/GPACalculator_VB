<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        DataGridView1 = New DataGridView()
        btnBrowse = New Button()
        Label1 = New Label()
        txtFileName = New TextBox()
        cboSheet = New ComboBox()
        Label2 = New Label()
        btnCalculate = New Button()
        Label3 = New Label()
        LabelGPABox = New TextBox()
        LblGPA = New Label()
        LblCatGPA = New Label()
        ResultGPACat = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 274)
        DataGridView1.TabIndex = 0
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(753, 301)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(35, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 301)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 2
        Label1.Text = "File Name:"
        ' 
        ' txtFileName
        ' 
        txtFileName.Location = New Point(94, 301)
        txtFileName.Name = "txtFileName"
        txtFileName.Size = New Size(653, 27)
        txtFileName.TabIndex = 3
        ' 
        ' cboSheet
        ' 
        cboSheet.FormattingEnabled = True
        cboSheet.Location = New Point(94, 341)
        cboSheet.Name = "cboSheet"
        cboSheet.Size = New Size(148, 28)
        cboSheet.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 341)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 5
        Label2.Text = "Sheet:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(596, 341)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(151, 29)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate GPA"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(366, 389)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 31)
        Label3.TabIndex = 7
        Label3.Text = "Your Result"
        ' 
        ' LabelGPABox
        ' 
        LabelGPABox.Location = New Point(298, 423)
        LabelGPABox.Name = "LabelGPABox"
        LabelGPABox.Size = New Size(280, 27)
        LabelGPABox.TabIndex = 9
        LabelGPABox.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblGPA
        ' 
        LblGPA.AutoSize = True
        LblGPA.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblGPA.Location = New Point(224, 423)
        LblGPA.Name = "LblGPA"
        LblGPA.Size = New Size(43, 20)
        LblGPA.TabIndex = 11
        LblGPA.Text = "GPA:"
        ' 
        ' LblCatGPA
        ' 
        LblCatGPA.AutoSize = True
        LblCatGPA.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCatGPA.Location = New Point(184, 462)
        LblCatGPA.Name = "LblCatGPA"
        LblCatGPA.Size = New Size(111, 20)
        LblCatGPA.TabIndex = 12
        LblCatGPA.Text = "Category GPA:"
        ' 
        ' ResultGPACat
        ' 
        ResultGPACat.Location = New Point(301, 459)
        ResultGPACat.Name = "ResultGPACat"
        ResultGPACat.Size = New Size(277, 27)
        ResultGPACat.TabIndex = 13
        ResultGPACat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 514)
        Controls.Add(ResultGPACat)
        Controls.Add(LblCatGPA)
        Controls.Add(LblGPA)
        Controls.Add(LabelGPABox)
        Controls.Add(Label3)
        Controls.Add(btnCalculate)
        Controls.Add(Label2)
        Controls.Add(cboSheet)
        Controls.Add(txtFileName)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GPA Calculator"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents cboSheet As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelGPABox As TextBox
    Friend WithEvents LblGPA As Label
    Friend WithEvents LblCatGPA As Label
    Friend WithEvents ResultGPACat As TextBox

End Class
