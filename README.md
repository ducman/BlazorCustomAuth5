# ASP.NET Core Blazor dependency injection test

Refering to: https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/dependency-injection?view=aspnetcore-5.0&pivots=webassembly

It is stated that the Blazor Wasm doesn't have a concept of a `Scoped` lifetime and that if register as scoped, it behave like a `Singleton`. 

This repo test that anything `Scoped` injected into a `DelegatingHandler` is actually transient (in a sense). It is definitely DOES NOT behave like a `Singleton`.
