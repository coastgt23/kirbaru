using Stella.Models;
using System.Text.Json;

namespace Stella.Routes.API
{
    public class PlayerReporting
    {
        [ServerAPI.POST("/api/PlayerReporting/v1/hile")]
        [ServerAPI.UseAuthorization]
        public IResult ModerationBlockDetails(HttpContext ctx)
        {
            Console.WriteLine(JsonSerializer.Serialize(ctx.Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString())));
            return Results.Ok();
        }
        
        [ServerAPI.GET("/api/PlayerReporting/v1/moderationBlockDetails")]
        [ServerAPI.UseAuthorization]
        public ModerationBlockDetailDTO ReturnModerationBlockDetails()
        {
            return new ModerationBlockDetailDTO
            {
                ReportCategory = ReportCategory.Unknown,
                Duration = 0,
                GameSessionId = 0,
                IsHostKick = false,
                Message = "",
                PlayerIdReporter = null,
                IsBan = false
            };
        }
    }
}