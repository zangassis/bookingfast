### Create a new solution

```dotnet new sln -n BookingFast```


### Create the UI layer

```dotnet new web -n BookingFast.UI```

Add the UI layer to solution

```dotnet sln BookingFast.sln add BookingFast.UI/BookingFast.UI.csproj```


### Create the Domain layer

```dotnet new classlib -n BookingFast.Domain```

Add the Domain layer to solution

```dotnet sln BookingFast.sln add BookingFast.Domain/BookingFast.Domain.csproj```


### Create the Infrastructure layer

```dotnet new classlib -n BookingFast.Infrastructure```

Add the Infrastructure layer to solution

```dotnet sln BookingFast.sln add BookingFast.Infrastructure/BookingFast.Infrastructure.csproj```

### Create the Application layer

```dotnet new classlib -n BookingFast.Application```

Add the Infrastructure layer to solution

```dotnet sln BookingFast.sln add BookingFast.Application/BookingFast.Application.csproj```