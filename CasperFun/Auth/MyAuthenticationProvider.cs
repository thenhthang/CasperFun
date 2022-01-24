using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using CasperFun.Common;
using CasperFun.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Text.Json;
namespace CasperFun.Auth
{
    public class MyAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStogare;
        private readonly ClaimsIdentity anonymous = new ClaimsIdentity();
        public MyAuthenticationStateProvider(ISessionStorageService sessionStorage)
        {
            _sessionStogare = sessionStorage;
        }
        private async Task<ClaimsPrincipal> MakeClaimsPrincipal()
        {
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(anonymous);
            var item = await _sessionStogare.GetItemAsync<string>(Constants.KEY_USER);
            
            if (item != null)
            {
                var user = JsonSerializer.Deserialize<UserModel>(item);
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Account));
                claims.Add(new Claim(Constants.KEY_CLAIMTYPE_LOGTIME, user.LogTime));
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims: claims, Constants.KEY_AUTHENTYPE);
                claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            }

            //var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.NameIdentifier, "abc"));
            //claims.Add(new Claim(Constants.KEY_CLAIMTYPE_LOGTIME, "sdf"));
            //ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims: claims, Constants.KEY_AUTHENTYPE);
            //claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return claimsPrincipal;
        }
        public  async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                return await Task.FromResult(new AuthenticationState(await MakeClaimsPrincipal()));
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
            }
        }
        public async Task  MakeSignOut()
        {
            await _sessionStogare.RemoveItemAsync(Constants.KEY_USER);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous))));
        }
        public async Task MakeSignIn(UserModel user)
        {
            await _sessionStogare.SetItemAsync(Constants.KEY_USER,JsonSerializer.Serialize<UserModel>(user));
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(await MakeClaimsPrincipal())));
        }

    }
}
