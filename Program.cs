using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAuthorizationToken();
            Console.WriteLine(AzureDetails.AccessToken);
        }

        public static void GetAuthorizationToken()
        {
            ClientCredential cc = new ClientCredential(AzureDetails.ClientID, AzureDetails.ClientSecret);
            var context = new AuthenticationContext("https://login.microsoftonline.com/" + AzureDetails.TenantID);
            var result = context.AcquireTokenAsync("https://management.azure.com/", cc);
            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the Access token");
            }
            AzureDetails.AccessToken = result.Result.AccessToken;
        }
    }
}
