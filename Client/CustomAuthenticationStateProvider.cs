using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorCustomAuth5.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly string _id = Guid.NewGuid().ToString();

        public CustomAuthenticationStateProvider()
        {
            Console.WriteLine($"Created AuthStateProvider: {_id}");
        }
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // we're not really testing authentication here
            return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
        }
    }
}
