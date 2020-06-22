namespace ConsoleApp1
{
    public static class AzureDetails
    {
        public static string ClientID = "<Client ID or App ID>";
        public static string ClientSecret = "<Client Secret or Password>";
        public static string TenantID = "<Tenant ID>";
        public static string AccessToken { get; internal set; }
    }
}