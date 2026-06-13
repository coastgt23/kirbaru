namespace Stella
{
    public static class AppConfig
    {
        public static void Init(IConfiguration configuration)
        {
            var mongoConnection = configuration["MongoDB:ConnectionString"]
                ?? throw new InvalidOperationException("MongoDB:ConnectionString is not configured.");
            var mongoDatabase = configuration["MongoDB:DatabaseName"] ?? "StellaDB";

            var jwtSecret = configuration["Jwt:Secret"]
                ?? throw new InvalidOperationException("Jwt:Secret is not configured.");

            MongoDB.Configure(mongoConnection, mongoDatabase);
            JsonWebToken.Configure(jwtSecret);
            OculusServer.Configure(configuration["Oculus:AppSecret"] ?? "");
            Logs.Configure(configuration["Discord:WebhookUrl"] ?? "");
        }
    }
}
