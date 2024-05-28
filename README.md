# Veritabani-Yonetim-Sistemleri

Uygulamanın Tanıtımı:
Kitap satan bir mağazanın ürünlerini, siparişleri ve mağaza personellerinin bilgilerinin 
tutulduğu bir uygulama tasarımı.


İş Kuralları:
 Bir mağazada birden fazla personel vardır, bir personel yalnızca bir mağazada 
çalışabilir.
 Bir personel ya yönetici ya da işçi çalışan olarak çalışabilir.
 Bir personel yalnız bir ilde yaşayabilir, bir ilde birden fazla personel yaşayabilir.
 Bir personel yalnız bir ilçede yaşayabilir, bir ilçede birden fazla personel yaşayabilir.
 Bir ürünün yalnız bir kategorisi vardır, bir kategoride birden fazla ürün olabilir.
 Bir ürünün yalnız bir yazarı vardır, bir yazarın birden fazla ürünü olabilir.
 Bir ürünün yalnız bir çevirmeni vardır, bir çevirmenin birden fazla ürünü olabilir.
 Bir ürünün yalnız bir yayın evi vardır, bir yayın evinin birden fazla ürünü olabilir.
 Bir siparişi yalnız bir üyemüşteri verebilir, bir üyemüşteri birden çok sipariş verebilir.
 Bir siparişi bir kargo firması alır, bir kargo firması birden fazla sipariş alabilir.
 Bir siparişin yalnız bir adresi vardır, bir adrese birden çok sipariş olabilir.
 Bir mağazada birçok ürün vardır, bir ürü yalnız bir mağazada bulunabilir.
 Bir siparişte birden çok ürün olabilir, bir ürün yalnızca bir siparişte bulunur.

Varlık Bağıntı Diyagramı(Crow’s Foot)
16 tane tablodan oluşuyor.

İlişkisel Şema:
adres(adresid:integer,adresad:varchar(20),adresil:varchar(20),adresilce:varchar(20))
cevirmen(cevirmenid:integer,cevirmenad:varchar(20),cevirmensoyad:varchar(20))
il(ilid:integer,ilad:varchar(20))
ilce(ilceid:integer,ilcedi:varchar(20))
iscicalisan(personelid:integer,personeladi:varchar(20),personelsoyadi:varchar(20),personelci
ns:varchar(20),mesaisaati:integer,personelmagaza:integer,personelilid:integer,personelilceid
:integer)
kargofirmasi(kargofirmasiid:integer,kargofirmasiadi:varchar(20))
kategori(kategoriid:integer,kategoriadi:varchar(20))
magaza(magazaid:integer,magazaadi:varchar(20))
personel(personelid:integer,personeladi:varchar(20),personelsoyadi:varchar(20),personelcin
s:varchar(20) ,personelmagaza:integer,personelilid:integer,personelilceid:integer)
siparis(siparisid:integer,kargofirmasiid:integer,uyeid:integer,adresid:integer)
toplamuyemusteri(sayi:integer)
urun(urunid:integer,urunadi:varchar(20),basimyili:integer,sayfasayisi:integer,magazaid:integ
er,yazarid:integer,cevirmenid:integer,yayineviid:integer,siparisid:integer,kategoriid:integer)
uyemusteri(uyeid:integer, uyead:varchar(20),uyesoyad:varchar(20),uyetel:varchar(20))
yayinevi(yayineviid:integer,yayineviadi:varchar(20))
yazar(yazarid:integer,yazaradi:varchar(20),yazarsoyadi:varchar(20))
yonetici(personelid:integer,personeladi:varchar(20),personelsoyadi:varchar(20),personelcin
s:varchar(20) ,personelmagaza:integer,unvan:varchar(20),personelilid:integer,personelilceid:
integer)
