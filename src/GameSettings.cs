﻿using System.Reflection;

namespace ChoppedEVA
{
    // ReSharper disable once InconsistentNaming
    public class ChoppedEVASettings : GameParameters.CustomParameterNode
    {
        #region Housekeeping

        public override string Title { get; } = "Chopped EVA settings";
        public override string Section { get; } = "Chopped EVA";
        public override string DisplaySection { get; } = "Chopped EVA";
        public override int SectionOrder { get; } = 3;
        public override GameParameters.GameMode GameMode { get; } = GameParameters.GameMode.ANY;
        public override bool HasPresets { get; } = false;

        #endregion

        #region Settings

        [GameParameters.CustomParameterUI("Enable EVA life support", autoPersistance = true, gameMode = GameParameters.GameMode.ANY)]
        public bool EnableLifeSupport = false;

        [GameParameters.CustomParameterUI("Respawn kerbals", toolTip = "Kerbals will be marked as missing, instead of dead", autoPersistance = true, gameMode = GameParameters.GameMode.ANY)]
        public bool Respawn = false;

        [GameParameters.CustomIntParameterUI("Electric charge", maxValue = 1000, minValue = 200, stepSize = 10, toolTip = "Amount of electricity", autoPersistance = true)]
        public int ElectricCharge = 700;

        [GameParameters.CustomFloatParameterUI("Discharge per second", toolTip = "Electric charge consumed per second", minValue = 0.4f, maxValue = 1.0f, asPercentage = false, displayFormat = "0.0")]
        public float DischargePerSec = 0.7f;

        #endregion

        public override bool Enabled(MemberInfo member, GameParameters parameters) => member.Name == nameof(EnableLifeSupport) || EnableLifeSupport;
    }
}