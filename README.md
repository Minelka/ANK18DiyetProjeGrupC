# ANK18 Diyet Proje Grup C

**ANK18 Diyet Proje Grup C**, kullanıcıların diyet listelerini yönetmelerine yardımcı olmak amacıyla geliştirilmiş bir web API uygulamasıdır. Sistem, kullanıcıların diyet programlarını oluşturmasına, güncellemesine ve takip etmesine olanak tanır.

## Özellikler

- **Kullanıcı Yönetimi**: Kullanıcı kayıt ve giriş işlemleri.
- **Diyet Listesi Yönetimi**: Diyet listesi ekleme, güncelleme ve silme işlemleri.
- **Yemek Kategorileri**: Öğün bazında yemeklerin kategorilere ayrılması.
- **Kalori Hesaplama**: Diyet listelerindeki yemeklerin toplam kalori hesaplaması.
- **JWT Kimlik Doğrulama**: Kullanıcıların güvenli bir şekilde oturum açmasını sağlar.

## Teknolojiler

- **.NET 7.0**
- **Entity Framework Core**
- **SQL Server**
- **JWT Authentication**
- **Swagger**

## Kurulum

### Gereksinimler

- .NET 7.0 SDK
- SQL Server
- Visual Studio veya Visual Studio Code

### Adımlar

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/Minelka/ANK18DiyetProjeGrupC.git
   ```

2. Proje dizinine gidin:

   ```bash
   cd ANK18DiyetProjeGrupC
   ```

3. Bağımlılıkları yükleyin:

   ```bash
   dotnet restore
   ```

4. **appsettings.json** dosyasında veritabanı bağlantı dizesini güncelleyin:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=DiyetProjeDB;Trusted_Connection=True;"
   }
   ```

5. Veritabanı migrasyonlarını çalıştırın:

   ```bash
   dotnet ef database update
   ```

6. Uygulamayı başlatın:

   ```bash
   dotnet run
   ```

Uygulama varsayılan olarak `https://localhost:5001` adresinde çalışacaktır.

## API Endpoints

### Kimlik Doğrulama

- **POST** `/api/auth/register` – Kullanıcı kaydı oluşturur.
- **POST** `/api/auth/login` – Kullanıcı girişi yapar.

### Diyet Listeleri

- **GET** `/api/diets` – Kullanıcıya ait diyet listelerini getirir.
- **POST** `/api/diets` – Yeni diyet listesi ekler.
- **PUT** `/api/diets/{id}` – Diyet listesini günceller.
- **DELETE** `/api/diets/{id}` – Diyet listesini siler.

## Proje Yapısı

```
ANK18DiyetProjeGrupC
├─ Controllers     # API Kontrolleri
├─ Services       # İş servisleri
├─ Models        # Veri modelleri
├─ Data          # Veritabanı işlemleri
├─ DTOs          # Veri transfer nesneleri
└─ Configurations # JWT ve diğer yapılandırmalar
```

## Lisans

Bu proje açık kaynak değildir ve yalnızca izinli kullanıcılar tarafından kullanılabilir.
