using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKullanimi
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region const kullanımı
            const double pi = 3.14;
            //sabit değerleri tanımlamak için kullanırız
            //yapısı static'tir
            //sonradan değiştirilemez
            //tanımlama aşamasında değerleri atanmalıdır

            #endregion

            #region global değişken oluşturmak
            //eğer oluşturulan değişkekn global olsun istiyorsak sınıfın içinde tanımlamalıyız
            //eğer tanımlanan değişken bir sınıfın içindeki bir metodun içinde tanımlanıyorsa o local değişken olarak adlandırılır.
            #endregion

            #region aynı anda değişken tanımlamak
            //int a = 5, b = 11 ;
            //int c = a+b ;

            #endregion

            #region deep copy ile eldeki verinin çoğaltılması
            //int a = 5;
            //int x = 5;
            //int y = a;
            //burada yaptığımız işlem sayesinde belleğin stack bölgesinde b=5 değerine sahip bir alan oluşturuldu.
            //bu yalnızca değer türlü değişenlerde (int double decimal byte) geçerlidir
            #endregion

            #region shallow copy 
            //referans türlü değişkenlerin referanslarının diğer değişkenler tarafından işaretlenmesi durumudur. burda referansı alan değişkenlerden birinde yapılan değişiklik, o referansa sahip tüm değişkenleri  de değiştirir.
            //değer türlü değişkenleri shallow copy yapabilmek için "ref" keyword ünü kullanacağız.
            #endregion

            #region object nedir?
            //değerler uygun türlere belirlenmelidir
            // string = 5 yazamayız burada metinsel bir ifade almalıdır
            //object : tüm türleri karşılayabilen bir kapsayıcı türdür. 
            //tüm türler object ten türerler. Bu sebeple tüm türlerin atası denebilir.
            object yas = 5;
            object ad = "mehmet";
            object basHard = 'C';
            //object referans türlü bir değişken olmasına rağmen değer türlü değişkenleri de karşılayabilir.


            #endregion

            #region Boxing
            //bir veriyi object içerisinde tutmaya boxing denir. yani kutulama. dışına bakınca object olarak görünür ama içinde string olduğunu biliriz.
            int yasim = 25;
            object _yasim = 25; //boxing
            //_yasim değişkeni artık object türde 28 değerini getirir. bu sebeple _yasim ile gelen değer ile matematiksel işlem yapamam. bunu yapabilmem için onu kendi öz değerinde belirtmem lazım buna da unboxing diyeceğiz.
            #endregion

            #region Cast Operatörü
            //object 'e atanmış bir veriyi kendi türünde elde etmemizi sağlayan bir operatördür.
            //tür dönüşümlerinde kullanacağız
            //kalıtımsal durumlarda da karşımıza çıkacak
            // ()  ile çalışır
            int ka = 5;
            object ba = ka;
            int ka2 = (int)ba; //object olan bu türü int e cast ettik deriz.

            #endregion

            #region Unboxing
            //object içindeki veriyi kendi türüne dönüştürmeye unboxing denir. yani en dış kutu olan object görüntüsünden onu kurtarıp özüne ait olan türe atıyoruz.bunu neden yapıyoruz ? çünkü object türündeki bir değişkenle dört işlem yapamayız veya string olarak onu birleştirip/parçalayamayız.

            #endregion

            #region getType ile tür öğrenimi
            //int a1 = 242;
            //string a2 = "dasda";
            //Console.WriteLine(a1.GetType());
            //Console.WriteLine(a2.GetType());


            #endregion

            #region var keyword ü
            bool medeniHal = true;
            //tutulacak değerin türüne uygun bir değişken tanımlayabilmek için kullanılan keyword'dür.
            //var keyword'ü kendisine atanan değerin türüne otomatik bürünür.
            var medeniHal2 = true;
            //medeniHal2 değişkeni compiler tarafından bool olarak algılanır.
            var sayi1 = 5;
            var sayi2 = 15;
            var sayi3 = sayi1 + sayi2;
            //var değişkeni ile belirtmeden işlemler de yapılabilir. bunu object ile yapamayız, önce cast etmemiz gerekirdi.
            #endregion

            #region dynamic keyword'ü
            //var aa = 5;
            //bu aşamadan sonra aa değişkeni int davranışı sergiler.
            //var compiler süresinde/development aşamasında değerin türüne bürünür
            //dynamic ab= 5;
            //dynamic ise runtime da ab değerinin int olduğunu anlar ve o türe bürünür.
            //UZAKTAN BİR VERİ GELECEĞİ ZAMAN EĞER GELECEK OLAN VERİNİN TÜRÜ BİLİNMİYORSA BUNU DYNAMIC İLE KARŞILARIZ.

            // KÖTÜ YANI : string olarak belirlediğimiz değişkeni runtime sırasında türünü değiştirebilmemize imkan veriyor. var gibi kararlı bir yapı değil.
            //dynamic isim = "mmmm";
            //Console.WriteLine(isim.GetType());
            //isim = 244;
            //Console.WriteLine(isim.GetType());

            //Console.ReadLine();



            #endregion

            #region PARSE ILE STRING VERIYI HEDEF TÜRE DÖNÜŞTÜRME
            //SADECE STRING VERILERİ DÖNÜŞTÜRÜRKEN KULLANIRIZ
            //string aaaa = "123";
            //int bbbb = int.Parse(aaaa);
            ////Console.WriteLine(aaaa + 5); //bu kod çalışmaz çünkü aaaa değişkeni string
            //Console.WriteLine(bbbb + 5); //bu kod çalışır çünkü bbbb int değer oldu
            //Console.WriteLine(int.Parse(aaaa) *4); //bu kod da çalışır
            //short cccc = short.Parse(aaaa);

            //  !!! burda önemli olan "1325" verisi int short olur ama byte olmaz
            //  !!! "a" verisi char olur ama int olmaz byte olmaz
            // !!! dönüşüm yaparken uygun veriyi döönüştürmeyi dene
            #endregion

            #region CONVERT Fonksiyonu
            //string asd = "25";
            //int asd2 = Convert.ToInt32(asd);

            //string sayi11 = "3,14";
            //double sayi22=Convert.ToDouble(sayi11);
            //Console.WriteLine(sayi22*5);
            //Console.ReadLine();
            #endregion

            #region ToString metodu ile her veriyi string yapmak
            //float f = 23.4f;
            //string fstring = f.ToString();
            //Console.WriteLine(fstring);
            //Console.ReadLine() ;
            #endregion

            #region sayısal verilerin kendi aralarında tür dönüşümü
            // dönüşüm yaparken, dönüştürdüğüm türün kümesi daha kapsayıcı ise veri kaybı yaşanmaz ama bir int a = 500225 değerini byte a çevirmeye kalkarsanız veri kaybı olur
            // bilinçsiz tür dönüşümü veri kaybının olmadığı alt kümeden üst kümeye dönüşme durumudur
            // bilinçli tür dönüşümü üst kümeden alt kümeye dönüşürken veri kaybı olabileceği için geliştirme ortamı bizi uyarır ve biz bu dönüşümü bilincimizle kabul edeceğimiz için buna bilinçli tür dönüşümü deriz.
            #endregion

            #region bilinçsiz tür dönüşümü

            //int sayiint = 5;
            //float sayifloat = sayiint;
            ////float int 'i kapsadığı için bu dönüşümü otomatik yaptı.
            #endregion

            #region bilinçli tür dönüşümü CAST OPERATÖRÜ
            // cast edilmek istenen değişkenin başına parantez içinde hangi türe dönüştürülmek isteniyorsa o tür yazılır.

            //int ax = 60000;
            //byte aba = (byte)ax; //burada veri kaybı olur ax değişkeni aba değişkenine cast edildi denir.
            //Console.WriteLine(aba.ToString());
            //Console.ReadLine();

            #endregion

            #region BİLİNÇİ TÜR DÖNÜŞÜMÜNDE CHECKED VE UNCHECKED KOMUTLARI
            // bilinçi türk dönüşümündeki veri kaybı olup olmadığını runtime da tespit etmemize yarayan komutlardır

            //int asd1 = 125;
            //byte asd2 = (byte)asd1; //burada veri kaybı olmaz 
            //checked
            //{
            //    int asd3 = 125444;
            //    byte asd4 = (byte)asd3; //burada veri kaybı olur ve bizi runtime da uyarır

            //}
            //eğer checked kullanılmasaydı veri kaybı olsa da bizi uyarmazdı

            #endregion

            #region unchecked komutu

            unchecked
            {
                int buyukSayi = 213213;
                byte deneme = (byte)buyukSayi; //veri kaybı olur ve bunu hata olarak vermez
            }

            // normal bir kod bloğu default olarak unchecked 'dir. hata vermez.
            #endregion

            #region bool türünün sayısal veriye dönüşmesi

            //bool boolT = true;
            //bool boolF = false;
            //byte byteT= Convert.ToByte(boolT);
            //byte byteF= Convert.ToByte(boolF);
            //Console.WriteLine("True olan dönüşüm sonucu " + byteT);
            //Console.WriteLine("False olan dönüşüm sonucu " + byteF);
            //Console.ReadLine() ;

            #endregion

            #region sayısal türlerin boolean türe dönüştürülmesi
            //int abcd = 1;
            //int k = 321;
            //int n = 0;
            //bool t = Convert.ToBoolean(abcd); //true olur
            //bool p = Convert.ToBoolean(k);  //true olur
            //bool l = Convert.ToBoolean(n); // false olur yalnızca sıfırda false olur
            #endregion

            #region tuple değişken atama
            // !!! burda ilerde int string yerine sınıf türleri de vereceğiz
            //(int a, int b, string c, string d) nesnem = (5, 123, "ahmet", "kem");
            //Console.WriteLine(nesnem.a.ToString());
            //Console.WriteLine(nesnem.b.ToString());
            //Console.WriteLine(nesnem.c);
            //Console.WriteLine(nesnem.d);
            //Console.ReadLine();
            #endregion

            #region char türünü sayısal türe dönüştürmek ASCII
            //char a111 = 'a';
            //int asciikod = (int)a111; //cast operatörü unboxing yani bilinçli dönüşümdü
            //Console.WriteLine(asciikod);
            //Console.ReadKey();
            #endregion

            #region sayısal türlerin char türüne dönüştürülmesi ASCII
            //byte s = 111;

            //Console.WriteLine((char)s); //verilen değeri chara cast ettik
            //Console.ReadKey();

            #endregion

            #region operatörlerin okur yazarlığı
            // operatörler genellikle iki değer arasında mantıksal ya da işlemsel bir görev yapar.
            // operatörleri kullanırken geriye dönüş değerlerine dikkat edilmesi gerekir


            #endregion

            #region aritmatik operatörleri inceliyoruz

            ////aritmatik operatörler iki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem neticesinde "uygun türde" sonuç dönerler
            //int sonuc1 = 3 + 5; // + operatörünün üstüne gelirsek sol ve sağ int alırsa int döner

            //int sonuc2 = 3 * 5;

            //double sonuc3 = 3.3 - 5.5;

            //double sonuc4 = 5 + 3.4; //kapsayıcı olan türde dönüş olur çünkü arkaplanda int olan değer bilinçsiz olarak double a dönüştürülür ve sonra toplama gerçekleşir

            //short sonuc5 = 22 + 3300; //byte + short sonucu short verir

            //// ISTISNA DURUM byte ve byte
            //byte deger1 = 19;
            //byte deger2 = 20;
            //byte sonuc6 = deger2 - deger1; // görüldüğü üzere sonuç her daim int dönüyor 


            #endregion

            #region karşılaştırma operatörleri
            //< küçük müdür?
            //> büyük müdür?
            //==  eşit midir?

            // !!! karşılaştırma operatörleri geriye true ya da false döner !!!
            #endregion

            #region mantıksal operatörler
            // mantıksal karşılaştırmalar sonucunda geriye boolean sonuç döndürür
            // ve &&    ---tüm şartların yerine getirilmiş olmasını ister
            // veya ||    ---en az birinin gerçekleşmesini ister
            // ya da ^    ---yalnız birinin olmasını ister
            #endregion

            #region arttırma azaltma operatörleri
            //elimizdeki sayıyı ya 1 arttırır ya da 1 azaltır
            #region örnek 1
            //int i = 10;
            //Console.WriteLine(i++);
            //Console.WriteLine(++i);
            #endregion
            #region örnek 2
            //int i1 = 5, i2 = 2;
            //i2 = i1++;  //burada i2=5 olurken daha sonra ++ ile i1'e değer atama gerçekleşeceği için i1=6 olacaktır.
            //Console.WriteLine(i1);
            //Console.WriteLine(i2);


            #endregion


            // !!DIKKAT!! ++i olursa önce ++'dan dolayı değer 1 artar ardından i değeri okunur
            // !!DIKKAT!! i++ olursa önce i değeri okunur sonra değer 1 artar

            #endregion

            #region metinsel ifadelerde operatörler
            //string ad1 = "ali ", ad2 = "mehmet";
            //Console.WriteLine(ad1+ad2);

            //// tür dönüşümlerinde herhangi bir değeri string yapmak için ToString() yapıyoruz ayrıyetten string dışı bir ifadeyi + operatörü ile toplarsak o türü object olarak düşünecek

            //int yas14 = 44;
            //Console.WriteLine(yas14+" "+ad2);

            //ad1 += ad2; //ad1 = ad1 + ad2; manası çıkar
            //Console.WriteLine(ad1);

            //// == operatörü ile boolean değer döndürebiliriz
            //Console.WriteLine("aaa"=="aab");
            #endregion

            #region ! operatörü
            //Console.WriteLine(!false);
            #endregion

            #region Ternary Operatörü
            //Şarta bağlı değer döndüren operatördür
            //bir değişkene/metoda/property 'e değer atarken şart kontrolünü yaparak duruma göre değer döndürmemize yarayan kalıpsal operatördür.
            //bool medeniHal3=true;
            //string mesaj = medeniHal3 == true? "Evlilere kampanya...": "Bekarlara kampanya...";
            ////burada mesaj değişkeni medeniHal3 'ün aldığı değere göre bir değer alacak.
            //Console.WriteLine(mesaj);
            #endregion

            #region Ternary ile çoklu şartlanma
            //int yas1 = 25;
            ////yasi 25 en küçükse A , 25 ise B, 25'ten büyükse C değerini döndüren ternary
            //string sonuc = yas1 < 25 ? "A" : (yas1 == 25 ? "B" : "C");
            //Console.WriteLine(sonuc);
            #endregion

            #region sizeof operatörü
            //verilen türün bellekte kaç byte yer kapladığını gösterir
            //Console.WriteLine("int :"+sizeof(int));
            //Console.WriteLine("byte :" + sizeof(byte));
            //Console.WriteLine("long :" + sizeof(long));
            //Console.WriteLine("ulong :" + sizeof(ulong));

            #endregion

            #region typeof operatörü
            //verilen türün/değerin type'ını/türünü getirir
            //o tür ile ilgili bilgileri edinmek için kullanılr
            //ileride reflection konusunda göreceğiz
            //Type t = typeof(int);
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.FullName);
            //Console.WriteLine(t.IsValueType);
            //Console.WriteLine(t.ReflectedType);
            //Console.WriteLine(t.DeclaringType);
            //Console.WriteLine(t.IsClass);
            #endregion

            #region default operatörü
            //her tür için belirli bir default(varsayılan) değer vardır
            //sayısal = 0
            //mantıksal = false
            //metinsel =null
            //char = \0
            //referans = null olarak tanımlılardır
            //Console.WriteLine(default(decimal));
            //Console.WriteLine(default(string));
            //Console.WriteLine(default(Program)); 
            //Console.WriteLine(default(short));
            //Console.WriteLine(default(char));


            //int deger = default; //deger  = 0 olur
            //Console.WriteLine(deger);





            #endregion

            #region is operatörü
            //boxing yapılmış bir değerin özdeğerini kontrol edebilmek için kullanılan bir  operatördür
            //object x4 = true; //boxing yaptık
            //Console.WriteLine(x4 is int);
            //Console.WriteLine(x4 is bool);
            //Console.WriteLine(x4 is Program);

            //ileride if yapılanmasında çok tercih edilen bir operatör olacak. gelecek olan verinin ne olduğunu sorguladıktan sonra ona bağlı olarak işlemler yaptıracağız
            // OOP yapılanmasında polimorfizm ile kalıtsal durumlardaki nesnelerin türlerini öğrenirken kullanacağız

            #endregion

            #region is null & is not null operatörleri
            //bir değişkenin değerinin null olup olmamasını kontrol eden operatördür
            // !!! dikkat !!! 
            // bu operatör sadece null olabilen türlerde kullanılır
            // value tpye 'lar not nullable türlerdir o yüzden bu operatör kullanılmaz
            //referans türlü değişkenler nullable olabildikleri için bu operatörü kullanabilir
            //string a5 = "adas";
            //Console.WriteLine(a5 is null);  //false döner
            //Console.WriteLine(a5 is not null); //true döner

            #endregion

            #region as operatörü  ***
            //cast operatörüne alternatif olarak çıkmıştır
            //unboxing sürecinde kullanılır
            //referans type'larda kullanırız  kalıp -> Type y = x as Type ;
            //value type atama yapamayız örn : int donusum1 = sayi as int;   olmaz !!

            //object abc = "neden";
            //string abcd = (string)abc; //cast ile unboxing

            //object sayi = 123;
            //string donusum1 = sayi as string; //as operatörü ile cast arasındaki fark burada anlaşılıyor ki: as ile unboxing yaparken değer dönüşmüyorsa null değerini atar.

            //Console.WriteLine(donusum1+"    boşluk görüyorsunuz");
            #endregion

            #region ? (nullable) operatörü  ***
            //bir değer türlü değişkenin null değerini almasını sağlar.

            //int o = null; //görüldüğü gibi null olamıyor
            //int? o = null; //şu an null değeri alabildi.

            // !!! ARTIK 'IS NULL' 'IS NOT NULL' ETIKETLERİ KULLANILABİLİR
            //Console.WriteLine(o is null); //true döner

            // ****  AS örneklendirme ****
            //daha önce value type'lar as ile kullanılamaz demiştik ama artık value type'ın nullable özelliğini verirsek dönüşüm gerçekleşmezse null dönebileceği için as operatörünü kullanabiliyoruz
            //object x6 = 123;
            //int? y6 = x6 as int?;
            //string z6 = x6 as string;
            //Console.WriteLine(y6.ToString());
            //Console.WriteLine( z6.GetType());
            #endregion

            #region ?? (Null-Coalescing)/null birleştirme Operatörü ***
            //elimizdeki değişkenin değeri null ise farklı bir değeri gönderme operatörüdür
            // sametype ?? sametype  bu operatörün sağ ve solundaki değişkenler aynı tür olmalıdır.
            //string d1 = null;
            //Console.WriteLine(d1 ?? "Merhaba");
            //int? d2 = null;
            //Console.WriteLine( d2 ?? 12);
            #endregion

            #region ??= (Null-Coalescing Assingment) operatörü
            //eğer k1 değişkeni null ise "Sebep" Yazdır ve "Sebep" değerini k1'e ata.
            //string k1 = null;
            //Console.WriteLine(  x ??= "Sebep");
            #endregion

            #region akış kontrol mekanizmaları.1) switch case yapısı

            //int bin = 1000;
            //int bin1 = 50;
            //int bin2 = 30;
            //switch (bin)
            //{
            //    case 1000 when (bin1>bin2):
            //        Console.WriteLine("oluyor");
            //        break;
            //    case 1000 when (bin1 < bin2):
            //        Console.WriteLine("olmuyor");
            //        break;
            //    default:
            //        Console.WriteLine("burası default yeri");
            //        break;
            //}
            #endregion

            #region goto komutu

            //farklı eşitliklerde aynı komutu çalıştıracaksak eğer kod tekrarına girmemek için goto komutu ile şu case 'i çalıştır diyebiliyoruz
            //int a = 7;
            //switch (a)
            //{
            //    case 5:
            //        Console.WriteLine(a * 5);
            //        break;
            //    case 15:
            //        Console.WriteLine(a * 15);
            //        break;
            //    case 7:
            //    case 10:
            //        goto case 5;
            //    default:
            //        break;
            //}
            #endregion

            #region switch expressions 
            //string isim = "";
            //int i = 10;
            //int k = 11;
            //switch (i)
            //{
            //    case 5:
            //        isim = "Hilmi";
            //        break;
            //    case 7:
            //        isim = "Halil";
            //        break;
            //    case 10:
            //        isim = "Ahmet";
            //        break;
            //    default:
            //        break;
            //}

            //***************  ÜST SWITCH AYRI ALT SWITH'LER AYRI ÇALIŞTIR *********

            //string isim1 = i switch
            //{
            //    5 => "Hilmi",
            //    10 => "Halil",
            //    11 => "Faruk"

            //};
            //Console.WriteLine(isim1);
            //string isim2 = k switch
            //{
            //    5 => "Hilmi",
            //    10 => "Halil",
            //    11 => "Faruk"

            //};
            //Console.WriteLine(isim2);
            
            #endregion






            Console.ReadKey();
        }

    }

}
