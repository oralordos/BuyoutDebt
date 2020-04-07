using Offworld.AppCore;
using Offworld.GameCore;

namespace BuyoutDebt
{
    public class ModEntryPoint : ModEntryPointAdapter
    {
        public override void Initialize() {
            Globals.SetFactory(new BuyoutFactory());
        }

        public override void Shutdown() {
            Globals.SetFactory(new GameFactory());
        }
    }
}