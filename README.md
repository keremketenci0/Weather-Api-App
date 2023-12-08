# Weather-Api-App
Bu uygulama, farklı şehirlerin hava durumu bilgilerini çekerek gösteren bir C# uygulamasıdır. Visual Studio 2022 kullanılarak geliştirilmiştir.

## Dosya Yapısı
- Program.cs: Uygulamanın ana giriş noktasını içerir. Şehirlerin hava durumu bilgilerini çeker ve WeatherService sınıfı üzerinden işler.

- Services/WeatherService.cs: Hava durumu servisini içerir. HttpClient kullanarak dış API'den veri çeker ve Weather modeline dönüştürür.

- Models/Weather.cs: Hava durumu verilerini temsil eden modelleri içerir. Ana hava durumu bilgilerini ve günlük tahminleri içeren yapıları barındırır.

## Kullanım
Uygulama, farklı şehirlerin hava durumu bilgilerini almak için kullanılır. Şehir isimlerini değiştirerek istediğiniz şehirlerin hava durumu bilgilerini çekebilirsiniz.

## Servisler
- WeatherService: Hava durumu verilerini çekmek için HttpClient'i kullanan bir servistir. İstenen şehirdeki hava durumu bilgilerini çeker ve ekrana yansıtır.

## Bağımlılıklar
Bu uygulama, .NET Core'un bir parçası olan HttpClient'i kullanır.
Newtonsoft.Json kütüphanesini JSON verilerini işlemek için kullanır.

## Kurulum
Visual Studio 2022'de projeyi açın.
Gerekli bağımlılıkları yükleyin.
Program.cs dosyasında bulunan şehir isimlerini istediğiniz şehirlerle değiştirerek uygulamayı çalıştırın.

## Ekran Görüntüleri

![WeatherApp](https://github.com/keremketenci0/Weather-Api-App/assets/128905838/479cb566-06a1-45bc-9e1a-65a3cb8ef66d)
