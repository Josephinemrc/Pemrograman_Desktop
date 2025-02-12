<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        txtBasis10 = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtBasis2 = New TextBox()
        txtBasis8 = New TextBox()
        txtBasis16 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 0
        Label1.Text = "Bilangan"
        ' 
        ' txtBasis10
        ' 
        txtBasis10.Location = New Point(177, 67)
        txtBasis10.Name = "txtBasis10"
        txtBasis10.Size = New Size(125, 27)
        txtBasis10.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(321, 65)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(432, 65)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(104, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 4
        Label2.Text = "Basis 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 5
        Label3.Text = "Basis 8"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(104, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 6
        Label4.Text = "Basis 16"
        ' 
        ' txtBasis2
        ' 
        txtBasis2.Location = New Point(177, 126)
        txtBasis2.Name = "txtBasis2"
        txtBasis2.Size = New Size(125, 27)
        txtBasis2.TabIndex = 7
        ' 
        ' txtBasis8
        ' 
        txtBasis8.Location = New Point(177, 171)
        txtBasis8.Name = "txtBasis8"
        txtBasis8.Size = New Size(125, 27)
        txtBasis8.TabIndex = 8
        ' 
        ' txtBasis16
        ' 
        txtBasis16.Location = New Point(177, 222)
        txtBasis16.Name = "txtBasis16"
        txtBasis16.Size = New Size(125, 27)
        txtBasis16.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtBasis16)
        Controls.Add(txtBasis8)
        Controls.Add(txtBasis2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtBasis10)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBasis10 As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBasis2 As TextBox
    Friend WithEvents txtBasis8 As TextBox
    Friend WithEvents txtBasis16 As TextBox

End Class
