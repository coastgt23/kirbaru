using Stella.Models;

namespace Stella.Routes.API
{
    public class GetCommunityBoard
    {
        [ServerAPI.GET("/api/communityboard/v1/current")]
        [ServerAPI.UseAuthorization]
        public dynamic ReturnGetCommunityBoard()
        {
            return new CommunityBoardDTO
            {
                CurrentAnnouncement = new CommunityBoardAnnouncementDTO
                {
                    Message = "Welcome To Lithium!",
                    MoreInfoUrl = ""
                },
                FeaturedPlayer = new CommunityBoardFeaturedPlayerData
                {
                    Id = 2,
                    TitleOverride = "Coast",
                    UrlOverride = ""
                },
                FeaturedRoomGroup = new FeaturedRoomGroupDTO
                {
                    FeaturedRooms = [],
                    Name = "stella"
                },
                InstagramImages = [],
                Videos = []
            };
        }
    }
}