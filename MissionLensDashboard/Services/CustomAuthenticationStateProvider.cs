using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using MissionLensDashboard.Data;
using MissionLensDashboard.Services;

namespace MissionLensDashboard.Services;
public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private ClaimsPrincipal anonymous = new ClaimsPrincipal(new ClaimsIdentity());
    private readonly UserCacheService _userCache;

    public CustomAuthenticationStateProvider(UserCacheService userCache)
    {
        _userCache = userCache;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        // In a real application, retrieve a stored token or cookie here
        var identity = new ClaimsIdentity(); // start as unauthenticated
        var principal = new ClaimsPrincipal(identity);
        return await Task.FromResult(new AuthenticationState(principal));
    }

    public void AuthenticateUser(string username, UserModel userData)
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, username),
        }, "CustomAuth");
        var principal = new ClaimsPrincipal(identity);

        _userCache.SetUser(userData);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(principal)));
    }

    public void Logout()
    {
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymous)));
    }
}