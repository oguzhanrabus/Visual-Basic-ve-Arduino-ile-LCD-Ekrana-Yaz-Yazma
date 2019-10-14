<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSil = New System.Windows.Forms.Button()
        Me.BtnYaz = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnBağlantıKes = New System.Windows.Forms.Button()
        Me.BtnBağlantıAç = New System.Windows.Forms.Button()
        Me.VeriHızı = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComPort = New System.Windows.Forms.ComboBox()
        Me.BtnComPort = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Label2"
        '
        'BtnSil
        '
        Me.BtnSil.Location = New System.Drawing.Point(93, 166)
        Me.BtnSil.Name = "BtnSil"
        Me.BtnSil.Size = New System.Drawing.Size(121, 23)
        Me.BtnSil.TabIndex = 39
        Me.BtnSil.Text = "Sil"
        Me.BtnSil.UseVisualStyleBackColor = True
        '
        'BtnYaz
        '
        Me.BtnYaz.AccessibleDescription = ""
        Me.BtnYaz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnYaz.Location = New System.Drawing.Point(93, 137)
        Me.BtnYaz.Name = "BtnYaz"
        Me.BtnYaz.Size = New System.Drawing.Size(121, 23)
        Me.BtnYaz.TabIndex = 2
        Me.BtnYaz.Text = "Gönder"
        Me.BtnYaz.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 93)
        Me.TextBox1.MaxLength = 32
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 20)
        Me.TextBox1.TabIndex = 37
        '
        'BtnBağlantıKes
        '
        Me.BtnBağlantıKes.Location = New System.Drawing.Point(220, 13)
        Me.BtnBağlantıKes.Name = "BtnBağlantıKes"
        Me.BtnBağlantıKes.Size = New System.Drawing.Size(75, 58)
        Me.BtnBağlantıKes.TabIndex = 36
        Me.BtnBağlantıKes.Text = "Bağlantıyı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kes"
        Me.BtnBağlantıKes.UseVisualStyleBackColor = True
        '
        'BtnBağlantıAç
        '
        Me.BtnBağlantıAç.Location = New System.Drawing.Point(220, 12)
        Me.BtnBağlantıAç.Name = "BtnBağlantıAç"
        Me.BtnBağlantıAç.Size = New System.Drawing.Size(75, 60)
        Me.BtnBağlantıAç.TabIndex = 35
        Me.BtnBağlantıAç.Text = "Bağlantıyı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aç"
        Me.BtnBağlantıAç.UseVisualStyleBackColor = True
        '
        'VeriHızı
        '
        Me.VeriHızı.FormattingEnabled = True
        Me.VeriHızı.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.VeriHızı.Location = New System.Drawing.Point(93, 51)
        Me.VeriHızı.Name = "VeriHızı"
        Me.VeriHızı.Size = New System.Drawing.Size(121, 21)
        Me.VeriHızı.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Veri Hızı : "
        '
        'ComPort
        '
        Me.ComPort.FormattingEnabled = True
        Me.ComPort.Location = New System.Drawing.Point(93, 14)
        Me.ComPort.Name = "ComPort"
        Me.ComPort.Size = New System.Drawing.Size(121, 21)
        Me.ComPort.TabIndex = 32
        '
        'BtnComPort
        '
        Me.BtnComPort.Location = New System.Drawing.Point(12, 12)
        Me.BtnComPort.Name = "BtnComPort"
        Me.BtnComPort.Size = New System.Drawing.Size(75, 23)
        Me.BtnComPort.TabIndex = 31
        Me.BtnComPort.Text = "Port Ara"
        Me.BtnComPort.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnYaz
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 237)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSil)
        Me.Controls.Add(Me.BtnYaz)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnBağlantıKes)
        Me.Controls.Add(Me.BtnBağlantıAç)
        Me.Controls.Add(Me.VeriHızı)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComPort)
        Me.Controls.Add(Me.BtnComPort)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSil As Button
    Friend WithEvents BtnYaz As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnBağlantıKes As Button
    Friend WithEvents BtnBağlantıAç As Button
    Friend WithEvents VeriHızı As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComPort As ComboBox
    Friend WithEvents BtnComPort As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
End Class
