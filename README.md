# BlazorDictionary
 
Ek�i s�zl�k , Blazor ve REST API bilgilerinin peki�tirilmesi, Onion Architecture ve CQRS yap�s�n�n ��renilmesi amac�yla geli�tirildi.


### Proje Yap�s�
- Proje **VS Code** ve **.NET6** s�r�m� ile geli�tirildi.
- Frontend
    - Blazor
    - Bootstrap 5
- Backend
    - REST API
    - **CQRS Pattern** dahil edilerek **Onion Architecture** dizayn kal�b� uyguland�
    - **Code First** yakla��m� ve **SQL Server** veritaban� kullan�ld�.

## Yap�land�rma
### 1.Dependencies
- [.NET8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) 6.0.16+
- [SQL Server](https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads)
- ~~[RabbitMQ](https://www.rabbitmq.com)~~
- [Node.js](https://nodejs.org/en) npm kayna��ndan javascript ve css paketlerini y�klemek i�in
##### Ba��ml� paketlerin y�klenmesi
- Blazor `.../src/Client/Blazor/wwwroot> npm i`
- API `.../src/Server/Api> dotnet restore`
- Common `.../src/Common> dotnet restore`

### 2.Connection String
- `Server/Api/appsettings.json`
- `Server/Infrastructure/Persistence/Context/BlazorDictionary.cs`

Dosyalar�n�n i�erisinde bulunan veritaban� ba�lant� adresleri g�ncellenmeli.

##### `Server/Api/appsettings.json`
```json
"ConnectionStrings": {
    "SQLServer": "Server=...;Initial Catalog=EksiSozlukDb;Integrated Security=True;"
}
```

##### `Server/Infrastructure/Persistence/Context/BlazorDictionaryContext.cs`
```c#
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    if (!optionsBuilder.IsConfigured)
        optionsBuilder.UseSqlServer("Server=...;Initial Catalog=EksiSozlukDb;Integrated Security=True;");
}
```
### 3.Fake Data
`Server/Infrastructure/Persistence/PersistenceRegistration.cs` i�erisinde bulunan
```c#
public static IServiceCollection AddPersistenceDependencies(this IServiceCollection service, IConfiguration configuration){

    new FakeData().GenerateAsync().GetAwaiter().GetResult();

}
```
methodu ile ba��ml�l�klar�n eklendi�i s�rada `new FakeData().GenerateAsync()` fonksiyonu ile varsay�lan olarak **25 kullan�c�** , **25 entry** , **500 entry yorumu** olu�turulup veritaban�na ekleme i�lemi ger�ekle�tirilir. 
- `GenerateAsync()` fonksiyonuna girilen parametre de�erleri ile bu say�lar de�i�tirilebilir
- Ekleme i�lemi yaln�zca veritaban�nda ilgili alanlarda kay�t yok ise yap�l�r


### 4.Database Update
`Server/Infrastructure/Persistence/Migrations` alt�nda bulunan migrations'lar�n uygulanmas�
```console
...\src\Server\Infrastructure\Persistence> dotnet ef database update
```
### 5.Projenin �al��t�r�lmas�
1. `...\src\Server\Api> dotnet run`
2. `...\src\Client\Blazor> dotnet run`
