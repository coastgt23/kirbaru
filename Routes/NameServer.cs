using Stella.Models;

namespace Stella.Routes
{
    public class NS
    {
        [ServerAPI.GET("/")]
        public NameServerResponse NameServer()
        {
            return new NameServerResponse
            {
                Accounts = "https://lithiumservers.fly.dev",
                API = "https://lithiumservers.fly.dev", // dont add /api because every call to this service to this already does
                Auth = "https://lithiumservers.fly.dev/auth",
                CDN = "https://lithiumservers.fly.dev/cdn",
                Chat = "https://lithiumservers.fly.dev/chat",
                Clubs = "https://lithiumservers.fly.dev/clubs",
                Commerce = "https://lithiumservers.fly.dev/commerce",
                DataCollection = "https://lithiumservers.fly.dev/datacollection",
                Images = "https://lithiumservers.fly.dev/img",
                Leaderboard = "https://lithiumservers.fly.dev",
                Link = "https://lithiumservers.fly.dev/link",
                Matchmaking = "https://lithiumservers.fly.dev/match",
                Moderation = "https://lithiumservers.fly.dev/moderation",
                Notifications = "https://lithiumservers.fly.dev/notify",
                PlatformNotifications = "https://lithiumservers.fly.dev/platformnotifications",
                RoomComments = "https://lithiumservers.fly.dev/roomcomments",
                Rooms = "https://lithiumservers.fly.dev/rooms",
                Storage = "https://lithiumservers.fly.dev/storage",
                WWW = "http://stellaonline.org"
            };
        }
    }
}