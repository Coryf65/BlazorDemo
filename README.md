# BlazorDemo
 Playing with Blazor

 - [Razor Docs](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-7.0)
 - [Blazor Docs](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0)

 ## What is Blazor?

 Blazor is a framework designed to use C# to write the front end to the back end.

 It has a similar concepts design akin to React. It has reuseable components to build and reuse in the web app.

 ## What is it for ?

 ## Benefits
 
- Write code in C# instead of JavaScript.
- Leverage the existing .NET ecosystem of .NET libraries.
- Share app logic across server and client.
- Benefit from .NET's performance, reliability, and security.
- Stay productive on Windows, Linux, or macOS with a development environment, such as Visual Studio or Visual Studio Code.
- Build on a common set of languages, frameworks, and tools that are stable, feature-rich, and easy to use.

 > These are coming from the [Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-7.0)

 ## Types of Blazor apps

 as of right now we have two main choices. Though there is more in the works currently.

 1. Blazor Server

    Blazor Server provides support for hosting Razor components on the server in an ASP.NET Core app. UI updates are handled over a SignalR connection.

 2. Blazor WASM

    Blazor WebAssembly is a single-page app (SPA) framework for building interactive client-side web apps with .NET.

 ## What does it look like

 ```Razor
@page "/"

<h1>Hello, world!</h1>

<p>
    Welcome to your new app.
</p>

<Dialog Title="Learn More">
    Do you want to <i>learn more</i> about Blazor?
</Dialog>

 ```


 ### Notes about Blazor

- Components are built and called using the route `@page"/name"` or placed in the page using `<name Parameter="something"/>`
- Components can have multiple routes so either `/counter` or `/count` would work.

example:
```Razor
@page "/counter"
@page "/count"

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    [Parameter]
    public int IncrementBy { get; set; } = 1;
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount += IncrementBy;
    }
}
```

### Icons

The icons used are from [open-iconic](https://icon-sets.iconify.design/oi/page-1.html)

you can search available icons on that site to find ones to use.

### Parameters

Pass using the routes

```Razor
@page "/Message/{value}"
```




### Binding Data

