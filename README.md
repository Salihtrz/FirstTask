<div>
  <h2>Proje Kurulum Aşamaları</h2>
  <ul>
    <li>Visual Studio Kurulumu</li>
    <li>MSSQL Kurulumu</li>
    <li>Projede Bazı Ayarlamalar</li>
  </ul>
  <h3>Visual Studio Kurulumu</h3>
  <div>Öncelikle resimdeki kısımdan projeyi zip olarak masaüstümüze indiriyoruz. Daha sonra zip'ten çıkartıyoruz. 
    <div align="center"><img src="/Installation Images/Github_Project_Install.png" width="650" ></div>  
    Şimdi Visual Studio kurulumuna geçebiliriz.
    <a href="https://visualstudio.microsoft.com/tr/">buraya tıklayarak</a> Microsoft'un resmi sitesinden Visual Studio'yu indirmeye koyuyoruz. Visual Studio Installer indikten sonra resimdeki seçimi yaparak
    indirme işlemini başlatıyoruz. 
    <div align="center"><img src="/Installation Images/Visual_Studio_Web_Service.png" width="650" ></div>  
    İndirme işlemi tamamlandıktan sonra zip içerisinden çıkartmış olduğumuz dosyayı açıp .sln uzantılı programa tıklıyoruz ve Visual Studio ile birlikte açıyoruz.
    Karşımıza çıkan sertifika onaylarını kabul ediyoruz. Sıradaki kuruluma geçebiliriz.
  </div>
  <h3>MSSQL Kurulumu</h3>
  <p>
    Visual Studio'yu başarılı bir şekilde kurduktan sonra <a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads">buraya tıklayarak</a> Microsoft'un resmi sayfasına geliyoruz. Bu sayfada
    resimde gösterilen Sql sürümünü indiriyoruz.
    <div align="center"><img src="/Installation Images/Sql_Server_2022_Express.png" width="650" ></div>  
    İndirme işlemi tamamlandıktan sonra inen programa tıklıyoruz. Açılan sekmede Basic kurulum seçiyoruz ve devam ediyoruz. Microsoft Lisans Sözleşmesini kabul ediyoruz.
    Daha sonra kurulacak dosya yolunu veriyoruz ve kurulumu başlatıyoruz. Kurulum tamamlandıktan sonra <a href="https://learn.microsoft.com/tr-tr/ssms/release-notes-20">buraya tıklıyoruz.</a> Açılan sayfada
    aşağılara doğru iniyoruz ve <strong >19.3</strong> sürümünü indiriyoruz.İndirme işlemi tamamlandıktan sonra tıklıyoruz ve açılan sekmede dosya yolunu belirtip Install diyoruz.
    İndirme işlemi tamamlandıktan sonra başlata Sql yazıp gelen uygulamayı açıyoruz. Karşınıza resimdeki gibi kısım geldiyse kurulum başarılı olmuş demektir.
    <div align="center"><img src="/Installation Images/SSMS_Window.png" width="650" ></div>  
    Şimdi projedeki ayarlamalara geçebiliriz.
  </p>
  <h3>Projede Bazı Ayarlamalar</h3>
  <p>
    Şimdi Visual Studio ile beraber açmış olduğumuz projeye geri dönelim. Öncelikle DataAccessLayer/Concrete/context.cs sınıfını açıyoruz. Daha sonra bu sınıftaki <strong>Server=SALIH\\SQLEXPRESS</strong> 
    bu kod parçasını resimde bulunan sizin kendi bilgisayar adınız ile değiştiriyoruz.
    <div align="center"><img src="/Installation Images/SSMS_Window_User_Name.png" width="650" ></div>
    Ardından Üst sekmeden View/Other Windows/Package Manager Console kısmını bulup açıyoruz. Açılan terminalde
    Default Project yazan yerde DataAccessLayer'ı seçiyoruz. Seçimi yaptıktan sonra terminale update-database yazıyoruz ve işlemin tamamlanmasını bekliyoruz. İşlem tamamlandıktan sonra MSSQL içerisinde
    database yolu altında veritabanımızı görmeliyiz. Ardından FirstTaskApi ve FirstTaskUI projeleri içerisindeki properties klasörü altındaki launhsettings.json kodunu açıyoruz. Burada programın
    başlatılacağı url ve port numaraları bulunuyor. Eğer bu port numaraları sizin bilgisayarınızda başka bir program tarafından kullanılıyorsa bu proje başlatılamayacaktır. Bunları kendinize göre
    değiştirmeniz gerekiyor. (Uyarı eğer port numaralarında değişiklik yaparsanız FirstTaskUI/ProductController içerisindeki url yollarınıda bu port numaralarına göre tekrar değiştirmelisiniz. Aksi taktirde
    Api ile bağlantı kuramazsınız.) Bu ayarı yaptıktan sonra yukarıdan All seçimini yapıp Start tuşuna tıklıyoruz. Normal şartlarda şuan da çalışmalı ancak null hatası veya başka bir hata alır iseniz
    launchsettings.json sınıfları içerisindeki https ayarlarını silip tekrar deneyin. Gene hata alırsanız yukarıdan (Start tuşunun yanı) FirstTaskApi'yi seçin ve <strong>CTRL+F5</strong> veya <strong>CTRL+Fn+F5</strong> yapın.
    Açılan sekmede Url'nin devamına /swagger/index.html yazısını ekleyin ve API'ye erişin. Daha sonra Product/Index View'ına gidin ve burada <strong>CTRL+Shift+W</strong> tuşlarına tıklayın.
    Web sayfası şimdi açılacaktır.
  </p>
</div>
