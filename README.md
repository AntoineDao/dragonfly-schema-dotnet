
# DragonflySchema - the C# library for the Dragonfly Model Schema

This is the documentation for Dragonfly model schema.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.5.1
- SDK version: 1.5.1
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/dragonfly-core](https://github.com/ladybug-tools/dragonfly-core)

## Frameworks supported


- .NET 4.5 or later

## Dependencies


- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
```


## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using DragonflySchema;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out DragonflySchema.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DragonflySchema;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


## Documentation for Models

 - [Model.Adiabatic](docs/Adiabatic.md)
 - [Model.ApertureSetAbridged](docs/ApertureSetAbridged.md)
 - [Model.Autocalculate](docs/Autocalculate.md)
 - [Model.Autosize](docs/Autosize.md)
 - [Model.Building](docs/Building.md)
 - [Model.BuildingEnergyPropertiesAbridged](docs/BuildingEnergyPropertiesAbridged.md)
 - [Model.BuildingPropertiesAbridged](docs/BuildingPropertiesAbridged.md)
 - [Model.ConstructionSetAbridged](docs/ConstructionSetAbridged.md)
 - [Model.ContextShade](docs/ContextShade.md)
 - [Model.ContextShadeEnergyPropertiesAbridged](docs/ContextShadeEnergyPropertiesAbridged.md)
 - [Model.ContextShadePropertiesAbridged](docs/ContextShadePropertiesAbridged.md)
 - [Model.DetailedWindows](docs/DetailedWindows.md)
 - [Model.DoorSetAbridged](docs/DoorSetAbridged.md)
 - [Model.ElectricEquipmentAbridged](docs/ElectricEquipmentAbridged.md)
 - [Model.EnergyMaterial](docs/EnergyMaterial.md)
 - [Model.EnergyMaterialNoMass](docs/EnergyMaterialNoMass.md)
 - [Model.EnergyWindowMaterialBlind](docs/EnergyWindowMaterialBlind.md)
 - [Model.EnergyWindowMaterialGas](docs/EnergyWindowMaterialGas.md)
 - [Model.EnergyWindowMaterialGasCustom](docs/EnergyWindowMaterialGasCustom.md)
 - [Model.EnergyWindowMaterialGasMixture](docs/EnergyWindowMaterialGasMixture.md)
 - [Model.EnergyWindowMaterialGlazing](docs/EnergyWindowMaterialGlazing.md)
 - [Model.EnergyWindowMaterialShade](docs/EnergyWindowMaterialShade.md)
 - [Model.EnergyWindowMaterialSimpleGlazSys](docs/EnergyWindowMaterialSimpleGlazSys.md)
 - [Model.ExtrudedBorder](docs/ExtrudedBorder.md)
 - [Model.Face3D](docs/Face3D.md)
 - [Model.FloorSetAbridged](docs/FloorSetAbridged.md)
 - [Model.GasEquipmentAbridged](docs/GasEquipmentAbridged.md)
 - [Model.Ground](docs/Ground.md)
 - [Model.IdealAirSystemAbridged](docs/IdealAirSystemAbridged.md)
 - [Model.InfiltrationAbridged](docs/InfiltrationAbridged.md)
 - [Model.LightingAbridged](docs/LightingAbridged.md)
 - [Model.LouversByCount](docs/LouversByCount.md)
 - [Model.LouversByDistance](docs/LouversByDistance.md)
 - [Model.Model](docs/Model.md)
 - [Model.ModelEnergyProperties](docs/ModelEnergyProperties.md)
 - [Model.ModelProperties](docs/ModelProperties.md)
 - [Model.NoLimit](docs/NoLimit.md)
 - [Model.OpaqueConstructionAbridged](docs/OpaqueConstructionAbridged.md)
 - [Model.Outdoors](docs/Outdoors.md)
 - [Model.Overhang](docs/Overhang.md)
 - [Model.PeopleAbridged](docs/PeopleAbridged.md)
 - [Model.Plane](docs/Plane.md)
 - [Model.ProgramTypeAbridged](docs/ProgramTypeAbridged.md)
 - [Model.RectangularWindows](docs/RectangularWindows.md)
 - [Model.RepeatingWindowRatio](docs/RepeatingWindowRatio.md)
 - [Model.RoofCeilingSetAbridged](docs/RoofCeilingSetAbridged.md)
 - [Model.Room2D](docs/Room2D.md)
 - [Model.Room2DEnergyPropertiesAbridged](docs/Room2DEnergyPropertiesAbridged.md)
 - [Model.Room2DPropertiesAbridged](docs/Room2DPropertiesAbridged.md)
 - [Model.ScheduleDay](docs/ScheduleDay.md)
 - [Model.ScheduleFixedIntervalAbridged](docs/ScheduleFixedIntervalAbridged.md)
 - [Model.ScheduleRuleAbridged](docs/ScheduleRuleAbridged.md)
 - [Model.ScheduleRulesetAbridged](docs/ScheduleRulesetAbridged.md)
 - [Model.ScheduleTypeLimit](docs/ScheduleTypeLimit.md)
 - [Model.SetpointAbridged](docs/SetpointAbridged.md)
 - [Model.ShadeConstruction](docs/ShadeConstruction.md)
 - [Model.SimpleWindowRatio](docs/SimpleWindowRatio.md)
 - [Model.SingleWindow](docs/SingleWindow.md)
 - [Model.Story](docs/Story.md)
 - [Model.StoryEnergyPropertiesAbridged](docs/StoryEnergyPropertiesAbridged.md)
 - [Model.StoryPropertiesAbridged](docs/StoryPropertiesAbridged.md)
 - [Model.Surface](docs/Surface.md)
 - [Model.VentilationAbridged](docs/VentilationAbridged.md)
 - [Model.WallSetAbridged](docs/WallSetAbridged.md)
 - [Model.WindowConstructionAbridged](docs/WindowConstructionAbridged.md)


## Documentation for Authorization

All endpoints do not require authorization.
