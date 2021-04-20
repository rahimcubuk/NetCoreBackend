# NetCoreBackend

Yeni projeye başlangıç için 6 katmanlı bir hazır altyapı sağlayıcısı. 
 Proje katmanları;
 * [Business](https://github.com/rahimcubuk/ProjectInitial/tree/master/Business),
 * [DataAccess](https://github.com/rahimcubuk/ProjectInitial/tree/master/DataAccess),
 * [Entities](https://github.com/rahimcubuk/ProjectInitial/tree/master/Entities),
 * [WebAPI](https://github.com/rahimcubuk/ProjectInitial/tree/master/WebAPI),
 * [Core](https://github.com/rahimcubuk/NetCoreBackend/tree/master/Core),
 * UserInterface.

Arayüz katmanı proje bazlı değişiklik göstereceğinden initial yapısına eklenmemiştir. 

* Veri tabanı CRUD işlemleri "Entity Framework - microsoft.entityframeworkcore.sqlserver v.3.1.11" ile gerçekleştirilmektedir.
* Validasyon "FluentValidation v9.5.1" kütüphanesi ile gerçekleştirilmektedir.
* Dependency injektor için "Autofac v6.1.0" kütüphanesi kullanılmıştır.
* AOP mimarisi için "Autofac.Extras.DynamicProxy v6.0.0" kullanılmıştır.

### Geliştirme Ortam Bilgileri
* Geliştirme aşamasında "Microsoft Blend for Visual Studio Community 2019 Version 16.8.5" kullanılmıştır.
* Veritabanı olarak MsSQL kullanılmış ve veritabanı ile iletişim "Microsoft.EntityFrameworkCore.SqlServer v3.1.11" ile sağlanmıştır.
* Veritabanı "Microsoft SQL Server Management Studio 11.0.3000.0" ile tasarlanıştır.

Yardım, destek, öneri için rahimcubuk@gmail.com adresine mail atabilirsiniz.
