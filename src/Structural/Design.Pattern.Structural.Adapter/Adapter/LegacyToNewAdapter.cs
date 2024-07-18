using Design.Pattern.Structural.Adapter.Entities;
using Design.Pattern.Structural.Adapter.Interfaces;

namespace Design.Pattern.Structural.Adapter.Adapter
{
    public class LegacyToNewAdapter : INewSystem
    {
        private readonly LegacySystem _legacySystem;

        public LegacyToNewAdapter(LegacySystem legacySystem)
        {
            _legacySystem = legacySystem;
        }

        public string GetData()
        {
            // Adaptando a chamada do método da classe legada para a nova interface
            return _legacySystem.GetLegacyData();
        }
    }
}
