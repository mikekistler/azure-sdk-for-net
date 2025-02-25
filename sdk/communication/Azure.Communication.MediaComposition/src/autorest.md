# Azure.Communication.MediaComposition

Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
title: Media Composition
tag: package-2022-07-16-preview
model-namespace: false
generation1-convenience-client: true
payload-flattening-threshold: 10
require:
    - https://raw.githubusercontent.com/Azure/azure-rest-api-specs/d0065fc88b192e819305eacac33e151f055e097e/specification/communication/data-plane/MediaComposition/readme.md
```

``` yaml
directive:
- from: swagger-document
  where: $.definitions.*
  transform: >
    $["x-csharp-usage"] = "model,input,output";
    $["x-csharp-formats"] = "json";
```
