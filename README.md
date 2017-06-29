# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (UberAPITests.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the UberAPITests library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

### 3. Add reference of the library project

In order to use the UberAPITests library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` UberAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```UberAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Uber%20API-CSharp&workspaceName=UberAPITests&projectName=UberAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

API client can be initialized as following.

```csharp

UberAPITestsClient client = new UberAPITestsClient();
```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [UserController](#user_controller)
* [EstimatesController](#estimates_controller)
* [ProductsController](#products_controller)

## <a name="user_controller"></a>![Class: ](https://apidocs.io/img/class.png "ACME.CORP.API.Controllers.UserController") UserController

### Get singleton instance

The singleton instance of the ``` UserController ``` class can be accessed from the API Client.

```csharp
UserController user = client.User;
```

### <a name="get_me"></a>![Method: ](https://apidocs.io/img/method.png "ACME.CORP.API.Controllers.UserController.GetMe") GetMe

> *Tags:*  ``` Skips Authentication ``` 

> User Profile


```csharp
Task<ProfileModel> GetMe()
```

#### Example Usage

```csharp

ProfileModel result = await user.GetMe();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


### <a name="get_history"></a>![Method: ](https://apidocs.io/img/method.png "ACME.CORP.API.Controllers.UserController.GetHistory") GetHistory

> *Tags:*  ``` Skips Authentication ``` 

> User Activity


```csharp
Task<ActivitiesModel> GetHistory(int? offset = null, int? limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | Offset the list of returned results by this amount. Default is zero. |
| limit |  ``` Optional ```  | Number of items to retrieve. Default is 5, maximum is 100. |


#### Example Usage

```csharp
int? offset = 209;
int? limit = 209;

ActivitiesModel result = await user.GetHistory(offset, limit);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)

## <a name="estimates_controller"></a>![Class: ](https://apidocs.io/img/class.png "ACME.CORP.API.Controllers.EstimatesController") EstimatesController

### Get singleton instance

The singleton instance of the ``` EstimatesController ``` class can be accessed from the API Client.

```csharp
EstimatesController estimates = client.Estimates;
```

### <a name="get_estimates_time"></a>![Method: ](https://apidocs.io/img/method.png "ACME.CORP.API.Controllers.EstimatesController.GetEstimatesTime") GetEstimatesTime

> *Tags:*  ``` Skips Authentication ``` 

> Time Estimates


```csharp
Task<List<ProductModel>> GetEstimatesTime(
        double startLatitude,
        double startLongitude,
        Guid? customerUuid = null,
        string productId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| startLatitude |  ``` Required ```  | Latitude component of start location. |
| startLongitude |  ``` Required ```  | Longitude component of start location. |
| customerUuid |  ``` Optional ```  | Unique customer identifier to be used for experience customization. |
| productId |  ``` Optional ```  | Unique identifier representing a specific product for a given latitude & longitude. |


#### Example Usage

```csharp
double startLatitude = 209.205291336032;
double startLongitude = 209.205291336032;
Guid? customerUuid = Guid.NewGuid();
string productId = "product_id";

List<ProductModel> result = await estimates.GetEstimatesTime(startLatitude, startLongitude, customerUuid, productId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


### <a name="get_estimates_price"></a>![Method: ](https://apidocs.io/img/method.png "ACME.CORP.API.Controllers.EstimatesController.GetEstimatesPrice") GetEstimatesPrice

> *Tags:*  ``` Skips Authentication ``` 

> Price Estimates


```csharp
Task<List<PriceEstimateModel>> GetEstimatesPrice(
        double startLatitude,
        double startLongitude,
        double endLatitude,
        double endLongitude)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| startLatitude |  ``` Required ```  | Latitude component of start location. |
| startLongitude |  ``` Required ```  | Longitude component of start location. |
| endLatitude |  ``` Required ```  | Latitude component of end location. |
| endLongitude |  ``` Required ```  | Longitude component of end location. |


#### Example Usage

```csharp
double startLatitude = 209.205291336032;
double startLongitude = 209.205291336032;
double endLatitude = 209.205291336032;
double endLongitude = 209.205291336032;

List<PriceEstimateModel> result = await estimates.GetEstimatesPrice(startLatitude, startLongitude, endLatitude, endLongitude);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)

## <a name="products_controller"></a>![Class: ](https://apidocs.io/img/class.png "ACME.CORP.API.Controllers.ProductsController") ProductsController

### Get singleton instance

The singleton instance of the ``` ProductsController ``` class can be accessed from the API Client.

```csharp
ProductsController products = client.Products;
```

### <a name="get_products"></a>![Method: ](https://apidocs.io/img/method.png "ACME.CORP.API.Controllers.ProductsController.GetProducts") GetProducts

> *Tags:*  ``` Skips Authentication ``` 

> Product Types


```csharp
Task<List<ProductModel>> GetProducts(double latitude, double longitude)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | Latitude component of location. |
| longitude |  ``` Required ```  | Longitude component of location. |


#### Example Usage

```csharp
double latitude = 123;
double longitude = 123;

List<ProductModel> result = await products.GetProducts(latitude, longitude);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)



