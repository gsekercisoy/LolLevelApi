<div align="center">

[English](README.md) | **Türkçe**

# LolLevelApi

Riot Games API (TR bölgesi) üzerinden LoL oyuncu adından seviye sorgulayan
C# WinForms aracı.

</div>

## Özellikler

- Oyuncu adı girişi + tek tıkla seviye sorgulama
- Riot Summoner-v4 yanıtı Newtonsoft.Json ile ayrıştırma
- Seviye diyalogda gösterilir; bilinmeyen isimde anlaşılır hata

## Teknolojiler

- C# WinForms, .NET Framework 4.8
- `Newtonsoft.Json 13.0.1`, `HttpWebRequest`

## Çalıştırma (Windows)

1. [Riot Developer Portal](https://developer.riotgames.com/) adresinden ücretsiz API anahtarı al
2. `LolLevelApi.sln` dosyasını Visual Studio 2022 ile aç, NuGet paketlerini restore et
3. Anahtarı `Form1.cs` içindeki `apiKey` değişkenine yapıştır (kodda işaretli), derle ve çalıştır

> Not: Riot, summoner uç noktalarını zamanla değiştirdi; geçerli anahtarla
> sorgu başarısız olursa güncel [Summoner-V4 dokümanına](https://developer.riotgames.com/docs/lol) bak.

## Yapı

```
LolLevelApi/
  Form1.cs   # arayüz + API çağrısı + JSON ayrıştırma
  Program.cs # Application.Run(new Form1())
```
