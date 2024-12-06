#nullable disable

using BaseBackend.Entities;
using BaseBackend.Enums;

namespace GameShop.Dtos
{
    public class AddGame : Game
    {
        public string GameName { get; set; }
        public int GameYear { get; set; }
        public string Company { get; set; }
        public OnlineOffline OnlineOffline { get; set; }
        public MultiSingle MultiSingle { get; set; }
    }
}
