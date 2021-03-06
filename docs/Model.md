
# DragonflySchema.Model.Model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. | 
**Buildings** | [**List&lt;Building&gt;**](Building.md) | A list of Buildings in the model. | 
**Properties** | [**ModelProperties**](ModelProperties.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**DisplayName** | **string** | Display name of the object with no restrictions. | [optional] 
**Type** | **string** |  | [optional] [default to "Model"]
**ContextShades** | [**List&lt;ContextShade&gt;**](ContextShade.md) | A list of ContextShades in the model. | [optional] 
**NorthAngle** | **double** | The clockwise north direction in degrees. | [optional] [default to 0M]
**Units** | **string** | Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters. | [optional] [default to UnitsEnum.Meters]
**Tolerance** | **double** | The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations that can be performed on geometry, such as solving adjacency between Room2Ds. A value of 0 will result in no checks and an inability to perform certain operations. Typical tolerances for builing geometry range from 0.1 to 0.0001 depending on the units of the geometry. | [optional] [default to 0M]
**AngleTolerance** | **double** | The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations. Typical tolerances for builing geometry are often around 1 degree. | [optional] [default to 0M]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

