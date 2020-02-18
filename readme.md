![PdfGenerator.Net](https://raw.githubusercontent.com/Zettersten/PdfGenerator.Net/master/PdfGenerator.Net/PdfGenerator.png "PdfGenerator.Net")
# PdfGenerator.Net

![Build history](https://buildstats.info/azurepipelines/chart/nenvy/PdfGenerator.Net/9)

An HTTP Client and PDF builder that interfaces with EMoney PDF Cloud API. 

[![Build Status](https://dev.azure.com/nenvy/PdfGenerator.Net/_apis/build/status/Zettersten.PdfGenerator.Net?branchName=master)](https://dev.azure.com/nenvy/PdfGenerator.Net/_build/latest?definitionId=9&branchName=master)


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
configuration[$"PdfGenerator:{nameof(PdfGeneratorOptions.AccessToken)}"]
configuration[$"PdfGenerator:{nameof(PdfGeneratorOptions.ApplicationId)}"]
configuration[$"PdfGenerator:{nameof(PdfGeneratorOptions.Domain)}"]
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
