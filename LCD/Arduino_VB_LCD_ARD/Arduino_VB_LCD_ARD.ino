#include <LiquidCrystal.h> //LCD Kütüphanesi

const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2; // LCD pinleri ve arduino bağlantıları
LiquidCrystal lcd(rs, en, d4, d5, d6, d7); // LCD Pinleri
String str1 = ""; // VB'den gelen karakterlerin yazılacağı 1.satır dizini
String str2 = ""; //VB'den gelen karakterlerin yazılacağı 2.satır dizini
boolean harfdizisi = false; //harfdizisi veri tipini oluştur ve false yap
int sayici = 0;//Gelen karakter sayısını kaydetmek için sayici değişkeni



void setup() {

  lcd.begin(16, 2);//LCD ekranı başlat
  Serial.begin(9600);//Seri haberleşmeyi başlat
}

void loop() {
	SeriOkuma(); // Seri okuma loopunu çalıştır
	if (harfdizisi==true) // Eğer harf dizisi true ise
	{
		lcd.clear();//LCD'yi temizle
		lcd.print(str1);//1.satır verilerini yaz
		lcd.setCursor(0, 1); //2.satıra geç
		lcd.print(str2);//2.satır verilerini yaz
		harfdizisi = false; //harf dizisini tekrar false yap
		str1 = "";//1.satırı boşalt
		str2 = "";//2.satırı boşalt
		sayici = 0;//sayiciyi 0 yap
	}
	delay(50); //verilerin düzenli işlenmesi için 50 ms gecikme
}

void SeriOkuma()//Seri okuma loopu
{
  while (Serial.available()) //Geçerli bir seri haberleşme varsa
  {
    char karakter = (char)Serial.read(); //Seri porttan char olarak oku karakter dizinine yaz
    sayici++;//sayiciyi karakter sayısına göre artır
    if (karakter == '\n') //Eğer karakter dizini boş ise
      harfdizisi = true;// harf dizisini true yap
    if (karakter == '*')//Eğer VB'den * geliyorsa
    {
      lcd.clear();//LCD'yi temizle
      str1 = "";//1.satırı boşalt
      str2 = "";//2.satırı boşalt
      harfdizisi = true;//harfdizisini true yap
    }
    if (harfdizisi == false && sayici <= 16) //Eğer harf dizisi false ve sayıcı 16'dan küçük eşitse
      str1 += karakter;//VB'den gelen karakterleri 1.satıra yaz

    if (harfdizisi == false && sayici > 16 && sayici <= 32)//Eğer harf dizisi false sayıcı 16'dan büyük ve 32'den küçük eşitse
      str2 += karakter;//VB'den gelen karakterleri 2.satıra yaz
  }
}