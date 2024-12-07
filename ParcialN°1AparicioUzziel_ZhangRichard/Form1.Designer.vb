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
        components = New ComponentModel.Container()
        LABEL = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextNombre = New TextBox()
        rbtnHombre = New RadioButton()
        rbtnMujer = New RadioButton()
        MonthCalendar1 = New MonthCalendar()
        Button1 = New Button()
        lblResultado = New Label()
        btnExit = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LABEL
        ' 
        LABEL.AutoSize = True
        LABEL.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        LABEL.BorderStyle = BorderStyle.Fixed3D
        LABEL.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LABEL.ForeColor = SystemColors.ButtonFace
        LABEL.Location = New Point(211, 35)
        LABEL.Name = "LABEL"
        LABEL.Size = New Size(217, 32)
        LABEL.TabIndex = 0
        LABEL.Text = "TU FUTURO ES HOY "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 17)
        Label1.TabIndex = 1
        Label1.Text = "Ingrese su nombre y apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(114, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 17)
        Label2.TabIndex = 2
        Label2.Text = "Ingrese su sexo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(64, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 17)
        Label3.TabIndex = 3
        Label3.Text = "Ingrese su fecha de nacimiento "
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(104, 108)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(123, 23)
        TextNombre.TabIndex = 4
        ' 
        ' rbtnHombre
        ' 
        rbtnHombre.AutoSize = True
        rbtnHombre.Location = New Point(82, 168)
        rbtnHombre.Name = "rbtnHombre"
        rbtnHombre.Size = New Size(80, 19)
        rbtnHombre.TabIndex = 5
        rbtnHombre.TabStop = True
        rbtnHombre.Text = "Masculino"
        rbtnHombre.UseVisualStyleBackColor = True
        ' 
        ' rbtnMujer
        ' 
        rbtnMujer.AutoSize = True
        rbtnMujer.Location = New Point(168, 168)
        rbtnMujer.Name = "rbtnMujer"
        rbtnMujer.Size = New Size(78, 19)
        rbtnMujer.TabIndex = 6
        rbtnMujer.TabStop = True
        rbtnMujer.Text = "Femenino"
        rbtnMujer.UseVisualStyleBackColor = True
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(45, 226)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(130, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 31)
        Button1.TabIndex = 8
        Button1.Text = "Predicción"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.BorderStyle = BorderStyle.Fixed3D
        lblResultado.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResultado.ForeColor = SystemColors.ControlText
        lblResultado.Location = New Point(346, 168)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(93, 19)
        lblResultado.TabIndex = 9
        lblResultado.Text = "Su predicción"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = SystemColors.Control
        btnExit.Location = New Point(12, 413)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(61, 27)
        btnExit.TabIndex = 10
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Khaki
        ClientSize = New Size(648, 452)
        Controls.Add(btnExit)
        Controls.Add(lblResultado)
        Controls.Add(Button1)
        Controls.Add(MonthCalendar1)
        Controls.Add(rbtnMujer)
        Controls.Add(rbtnHombre)
        Controls.Add(TextNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LABEL)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LABEL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents rbtnHombre As RadioButton
    Friend WithEvents rbtnMujer As RadioButton
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider

End Class
