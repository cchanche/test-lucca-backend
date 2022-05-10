## Test Lucca backend

Simple .NET service, handling user payments. Project was built for learning purposes as an exercise. Context and guidelines were provided externally and can be found [here](https://gist.github.com/maxmg/1f76d42f873989718a61dc65594fc7eb).

## Data structure

![Data structure](/lucca-uml.png?raw=true "Data structure title")

## How to run

- Install [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download)
- Install EF Core for SQLite dependency

```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

- (Optional) Install dotnet-format (used with defaults)

```bash
dotnet tool install -g dotnet-format
```
