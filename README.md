<div align="center">

**English** | [Türkçe](README_tr.md)

# LolLevelApi

C# WinForms tool that looks up a League of Legends summoner's level by nickname
via the Riot Games API (TR region).

</div>

## Features

- Nickname input + one-click level lookup
- Riot Summoner-v4 response parsed with Newtonsoft.Json
- Level shown in a dialog; friendly error on unknown nickname

## Tech stack

- C# WinForms, .NET Framework 4.8
- `Newtonsoft.Json 13.0.1`, `HttpWebRequest`

## Getting started (Windows)

1. Get a free API key from the [Riot Developer Portal](https://developer.riotgames.com/)
2. Open `LolLevelApi.sln` in Visual Studio 2022, restore NuGet packages
3. Paste the key into the `apiKey` variable in `Form1.cs` (marked in code), build and run

> Note: Riot has changed its summoner endpoints over time; if the lookup fails
> with a valid key, check the current [Summoner-V4 docs](https://developer.riotgames.com/docs/lol).

## Structure

```
LolLevelApi/
  Form1.cs   # UI + API call + JSON parsing
  Program.cs # Application.Run(new Form1())
```
