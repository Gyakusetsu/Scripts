﻿//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
using Skua.Core.Interfaces;
public class GlaceraREP
{
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        //Farm.UseBoost(ChangeToBoostID, RBot.Items.BoostType.Reputation, false);

        Farm.GlaceraREP();

        Core.SetOptions(false);
    }
}