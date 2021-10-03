# Telefon Rehberi Uygulaması

Uygulamada olan özellikler aşağıdaki gibidir.

- Telefon Numarası Kaydet
- Telefon Numarası Sil
- Telefon Numarası Güncelle
- Rehber Listeleme 
- Rehberde Arama

## Açıklama:

Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekledim.

Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.

```
  Lütfen yapmak istediğiniz işlemi seçiniz 
  *******************************************
  (1) Yeni Numara Kaydetmek
  (2) Varolan Numarayı Silmek
  (3) Varolan Numarayı Güncelleme
  (4) Rehberi Listelemek
  (5) Rehberde Arama Yapmak
```
### (1) Yeni Numara Kaydetmek
```
  Lütfen isim giriniz             : 
  Lütfen soyisim giriniz          :
  Lütfen telefon numarası giriniz : 
```
### (2) Varolan Numarayı Silmek
İsim ve soyisime göre arama yapılır.
```
  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:
```
Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:
```
  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
  * Silmeyi sonlandırmak için : (1)
  * Yeniden denemek için      : (2)
```
Rehberde uygun veri bulunursa:
```
  {} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)
```
**Not**: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinir.
### (3) Varolan Numarayı Güncelleme
````
  Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:
````
Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:
````
  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
  * Güncellemeyi sonlandırmak için    : (1)
  * Yeniden denemek için              : (2)
`````
Rehberde uygun veri bulunursa:

````
  Lütfen {0} {1} isimli kişinin yeni numarasını giriniz:
`````
Kullanıcıdan alınan girdi doğrultusunda güncelleme işlemi gerçekleştirilir.
### (4) Rehberi Listelemek
Tüm rehber aşağıdaki formatta console'a listelenir.
````
  Telefon Rehberi
  **********************************************
  isim: {}
  Soyisim: {}
  Telefon Numarası: {}
  - 
  isim: {}
  Soyisim: {}
  Telefon Numarası: {}
  .
  .
  ````
  ### (5) Rehberde Arama Yapmak
  ````
  Arama yapmak istediğiniz tipi seçiniz.
  **********************************************
        
  İsim veya soyisime göre arama yapmak için: (1)
  Telefon numarasına göre arama yapmak için: (2)
  ````
  Arama sonucuna göre bulunan veriler aşağıdaki formatta gösterilir.
  ````
  Arama Sonuçlarınız:
  **********************************************
  isim: {}
  Soyisim: {}
  Telefon Numarası: {}
  - 
  isim: {}
  Soyisim: {}
  Telefon Numarası: {}
  .
  .
````
