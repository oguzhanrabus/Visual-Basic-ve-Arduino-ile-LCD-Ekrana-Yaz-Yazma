Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent() 'Programı ekranın ortasında aç.
        BtnBağlantıAç.Enabled = False 'Bağlantı aç butonunu pasif yap.
        BtnBağlantıAç.BringToFront() 'Butonu öne getir.

        BtnBağlantıKes.Enabled = False 'Bağlantı Kes butonunu pasif yap.
        BtnBağlantıKes.SendToBack() 'Butonu arkaya gönder.
        VeriHızı.SelectedItem = "9600" 'Veri Hızı 9600 seçili olarak programı aç.

        Timer1.Start() 'Haberleşme durumunu kontrol etmek için Timer 1'i çalıştır.

    End Sub

    Private Sub BtnComPort_Click(sender As Object, e As EventArgs) Handles BtnComPort.Click 'port ara butonu
        ComPort.Items.Clear() 'ComPort isimli ComboBox'ı temizle.
        Dim port As Array 'port isimli bir dizi oluştur.
        Dim i As Integer 'i isimli bir değişken oluştur.
        port = IO.Ports.SerialPort.GetPortNames ' Bilgisayardaki Seri portları oku ve port dizisine yaz.
        ComPort.Items.AddRange(port) 'Port verilerini comport'a yaz.
        i = ComPort.Items.Count 'Comport öğelerinini i değişkenine yaz.
        i = i - i 'Bilgisayardaki aktif portları i değiişkenine yaz.

        Try
            ComPort.SelectedIndex = i 'seçili dizini comporta yaz.
            'Eğer seçili dizinde port bulunamazsa alt satıra geçecek.
        Catch ex As Exception
            Dim sonuç As DialogResult 'Sonuç isimli değişken oluştur.
            sonuç = MessageBox.Show("Comport Bulunamadı", "Dikkat !!!!", MessageBoxButtons.OK) 'Haberleşme Portu bulunamazsa uyarı mesajı ver
            ComPort.Text = "" 'ComboBoxı Boş göster.
            ComPort.Items.Clear() 'ComboBox içeriğini temizle.
            Call Form1_Load(Me, e) 'Sayfayı ilk haline getir.
        End Try
        'Eğer seçili dizinde port bulunursa alt satıra geçecek.
        BtnBağlantıAç.Enabled = True 'Bağlantı butonunu aktif yap
        BtnComPort.BringToFront() 'port ara butonun öne getir.
        ComPort.DroppedDown = True 'Portları listele
    End Sub

    Private Sub BtnBağlantıAç_Click(sender As Object, e As EventArgs) Handles BtnBağlantıAç.Click
        BtnBağlantıAç.Enabled = False 'Bağlantı aç butonunu pasif yap.
        BtnBağlantıAç.SendToBack() 'Arkaya gönder
        SerialPort1.BaudRate = VeriHızı.SelectedItem ' Seçilen haberleşme hızını Seri portun baud rate içine yaz.
        SerialPort1.PortName = ComPort.SelectedItem ' Seçilen port ismini Seri portun port name içine yaz.
        SerialPort1.Open() 'Seri portu çalıştır.
        BtnBağlantıKes.Enabled = True 'Bağlantı kes butonun aktif yap 
        BtnBağlantıKes.BringToFront() 'Bağlantı kes butonunu öne getir.

    End Sub

    Private Sub BtnBağlantıKes_Click(sender As Object, e As EventArgs) Handles BtnBağlantıKes.Click
        BtnBağlantıKes.Enabled = False 'Bağlantı Kes Butonunu pasif yap.
        BtnBağlantıKes.SendToBack() 'Butonu arkaya gönder.

        SerialPort1.Close() 'seri portu kapat.
        BtnBağlantıAç.Enabled = True 'Bağlantı aç butonunu aktif yap.
        BtnBağlantıAç.BringToFront() 'Butonu öne getir.
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.IsOpen Then 'seri port açık ise
            Me.BackColor = Color.Green 'sayfanını arka plan rengini yeşil yap
            BtnYaz.Enabled = True 'Gönder butonunu aktif yap
            BtnSil.Enabled = True 'Sil butonunu aktif yap
            TextBox1.Enabled = True 'TextBox aktif yap
            ComPort.Enabled = False 'ComPort pasif yap 
            VeriHızı.Enabled = False 'VeriHızı pasif yap
        Else 'seri port kapalı ise 
            Me.BackColor = Color.Red 'sayfanını arka plan rengini kırmızı yap
            BtnYaz.Enabled = False 'Gönder butonunu pasif yap
            BtnSil.Enabled = False 'Sil butonunu pasif yap
            TextBox1.Enabled = False 'TextBox pasif yap
            ComPort.Enabled = True 'ComPort aktif yap
            VeriHızı.Enabled = True 'VeriHızı aktif yap
        End If
    End Sub
    Dim lcd As String 'lcd isimli bir dizi oluştur
    Private Sub BtnGndr_Click(sender As Object, e As EventArgs) Handles BtnYaz.Click, BtnYaz.Enter
        lcd = TextBox1.Text 'text box içindeki karakterleri lcd dizisine yaz.
        SerialPort1.WriteLine(lcd) 'lcd içindeki karakterleri seri portla arduinoya gönder. 
    End Sub

    Private Sub BtnSl_Click(sender As Object, e As EventArgs) Handles BtnSil.Click
        SerialPort1.WriteLine("*") 'arduinoya yıldız karakteri gönder
        TextBox1.Clear() 'textBox içini temizle
    End Sub
    Dim satır As Integer 'satır isimli değişken oluştur.
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        satır = TextBox1.Text.Length + 1 'text uzunluğunu satır değişkenine yaz.
        If (satır <= 17) Then 'girilen karakter sayısı 17'den küçük eşitse label2'de 1.satırdasısınız uyarısını ver.
            Label2.Text = satır & Chr(13) & "1.satırdasınız"
        ElseIf (satır > 17) Then 'eğer girilen karakter sayısı 17'den büyükse label2'de 2.satırdasısınız uyarısını ver.
            Label2.Text = satır & Chr(13) & "2.satırdasınız"
        End If
        If (satır = 33) Then 'Eğer girilen karakter 33'den büyükse hata mesajı ver.
            BtnYaz.Enabled = False
            MessageBox.Show("Son Karakteri Yazdınız", "Maksimum", MessageBoxButtons.OK)
        End If
    End Sub
End Class
