using Offworld.GameCore;

namespace BuyoutDebt
{
    class BuyoutFactory : GameFactory
    {
        public override PlayerServer createPlayerServer(GameClient pGame) {
            return new BuyoutPlayerServer(pGame);
        }
    }
}
