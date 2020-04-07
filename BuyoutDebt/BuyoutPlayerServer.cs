using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Offworld.GameCore;

namespace BuyoutDebt
{
    class BuyoutPlayerServer : PlayerServer
    {
        public BuyoutPlayerServer(GameClient pGame) : base(pGame) {
        }

        public override void buyout(PlayerType ePlayer) {
            PlayerServer pPlayer = gameServer().playerServer(ePlayer);
            int debtPerShare = pPlayer.getDebt() / 10;

            base.buyout(ePlayer);

            for (PlayerType eLoopPlayer = 0; eLoopPlayer < gameServer().getNumPlayers(); eLoopPlayer++) {
                PlayerServer pLoopPlayer = gameServer().playerServer(eLoopPlayer);
                int sharesOwned = pLoopPlayer.getSharesOwned(ePlayer);
                if (sharesOwned > 0)
                    pLoopPlayer.changeDebt(debtPerShare * sharesOwned);
            }
        }
    }
}
