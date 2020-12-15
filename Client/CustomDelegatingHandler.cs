using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;

namespace BlazorCustomAuth5.Client
{
    public class CustomDelegatingHandler : DelegatingHandler
    {
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly AnotherThingToInject _anotherThing;

        public CustomDelegatingHandler(AuthenticationStateProvider authStateProvider, AnotherThingToInject anotherThing)
        {
            // refer to console.log
            // BAD: we're getting a different auth state provider instance here ... why????
            _authStateProvider = authStateProvider;
            _anotherThing = anotherThing;
        }
    }
}
