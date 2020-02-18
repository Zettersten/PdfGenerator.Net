![PdfGenerator.Net](https://raw.githubusercontent.com/Zettersten/FeedlySharp/master/PdfGenerator.Net/PdfGenerator.png "PdfGenerator.Net")
# PdfGenerator.Net

![Build history](https://buildstats.info/azurepipelines/chart/nenvy/PdfGenerator.Net/8)

An HTTP Client that interfaces with Feedly Cloud API. Millions of users depend on their feedly for inspiration, information, and to feed their passions. But one size does not fit all. Individuals have different workflows, different habits, and different devices. In our efforts to evolve feedly from a product to a platform, we have therefore decided to open up the feedly API. Developers are welcome to deliver new applications, experiences, and innovations via the feedly cloud. We feel strongly that this will help to accelerate innovation and better serve our users.

[![Build Status](https://dev.azure.com/nenvy/FeedlySharp/_apis/build/status/Zettersten.FeedlySharp?branchName=master)](https://dev.azure.com/nenvy/PdfGenerator.Net/_build/latest?definitionId=8&branchName=master) [![NuGet Badge](https://buildstats.info/nuget/PdfGenerator.Net)](https://www.nuget.org/packages/PdfGenerator.Net/)


## Installation

```bash
dotnet add package PdfGenerator.Net
```

or from the VS Package Manager

```powershell
Install-Package PdfGenerator.Net
```

## Adding PdfGenerator.Net to your project

### Instatiate client by providing `PdfGeneratorOptions`

```csharp
var pdfGenerator = new PdfGeneratorHttpClient(PdfGeneratorOptions); 
```

### Instatiate client by using the `IServiceCollection` (default ASP.NET Core DI)

```csharp
services.AddPdfGenerator();
```

*Note: By default, PdfGenerator.Net will look at `IConfiguration` for `PdfGeneratorOptions`*

```
configuration[$"Feedly:{nameof(PdfGeneratorOptions.AccessToken)}"]
configuration[$"Feedly:{nameof(PdfGeneratorOptions.ApplicationId)}"]
configuration[$"Feedly:{nameof(PdfGeneratorOptions.Domain)}"]
```

#### PdfGeneratorOptions

```csharp
public class PdfGeneratorOptions
{
    public string AccessToken { get; set; }

    public string ApplicationId { get; set; }

    public string Domain { get; set; } = "https://pdf.emoney.com/";
}
```

*Note: You can also provide `IOptions<PdfGeneratorOptions>`*
