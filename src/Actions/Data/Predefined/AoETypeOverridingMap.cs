﻿using ActionEffectRange.Actions.Data.Template;
using ActionEffectRange.Actions.Enums;
using System.Collections.Generic;
using System.Collections.Immutable;

using static ActionEffectRange.Actions.Enums.ActionAoEType;
using static ActionEffectRange.Actions.Enums.ActionHarmfulness;

namespace ActionEffectRange.Actions.Data.Predefined
{
    public static class AoETypeOverridingMap
    {
        public static readonly ImmutableDictionary<uint, AoETypeDataItem> PredefinedSpecial
            = new KeyValuePair<uint, AoETypeDataItem>[]
            {
                GeneratePair(2270, Circle, Harmful),     // Doton (NIN)
                GeneratePair(3639, Circle, Harmful),     // salted earth (DRK)

                GeneratePair(7385, Cone, Beneficial),  // Passage of Arms (PLD)
                GeneratePair(7418, Cone, Harmful),   // Flamethrower (MCH)

                GeneratePair(16553, Circle, Beneficial),   // celestial opposition (AST)
            }.ToImmutableDictionary();

        private static KeyValuePair<uint, AoETypeDataItem> GeneratePair(
            uint actionId, ActionAoEType aoeType, ActionHarmfulness harmfulness)
            => new(actionId, new(actionId, (byte)aoeType, harmfulness));
    }
}
