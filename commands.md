Create a new minimal api project

```dotnet new web -n BookingFast.UI```

Create a new solution

```dotnet new sln -n BookingFast```

Add the UI classlib to solution

```dotnet sln BookingFast.sln add BookingFast.UI/BookingFast.UI.csproj```

Create the Domain classlib

```dotnet new classlib -n BookingFast.Domain```

Add the Domain class lib to solution

```dotnet sln BookingFast.sln add BookingFast.Domain/BookingFast.Domain.csproj```

