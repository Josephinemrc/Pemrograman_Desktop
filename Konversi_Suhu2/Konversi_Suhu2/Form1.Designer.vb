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
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        lblFahrenheit = New Label()
        lblReamur = New Label()
        lblKelvin = New Label()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(139, 92)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(55, 20)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(217, 89)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(125, 27)
        txtCelcius.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(360, 89)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(471, 89)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(111, 235)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(77, 20)
        lblFahrenheit.TabIndex = 4
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(300, 235)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(60, 20)
        lblReamur.TabIndex = 5
        lblReamur.Text = "Reamur"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(504, 235)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(49, 20)
        lblKelvin.TabIndex = 6
        lblKelvin.Text = "Kelvin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblKelvin)
        Controls.Add(lblReamur)
        Controls.Add(lblFahrenheit)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblKelvin As Label

End Class
