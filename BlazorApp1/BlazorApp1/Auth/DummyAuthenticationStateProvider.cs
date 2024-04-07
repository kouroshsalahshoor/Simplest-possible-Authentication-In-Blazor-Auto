using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorApp1.Auth
{
    public class DummyAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //await Task.Delay(3000);

            var authorized = new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, "User Name"),
                new Claim(ClaimTypes.Email, "user@x.x"),
                new Claim(ClaimTypes.NameIdentifier, "User Id"),
                new Claim(ClaimTypes.Role, "User"),
                new Claim("key1", "value1"),
            }, "xxx");
            //var authorized = new ClaimsIdentity("xxx");

            var anonymous = new ClaimsIdentity();
            
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(authorized)));
            //return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        }
    }
}
