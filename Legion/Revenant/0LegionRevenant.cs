//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Legion/CoreLegion.cs
//cs_include Scripts/Legion/Revenant/CoreLR.cs
//cs_include Scripts/Legion/InfiniteLegionDarkCaster.cs
using RBot;

public class LegionFealty4
{
    public CoreBots Core => CoreBots.Instance;
    public CoreLR LR = new CoreLR();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        LR.GetLR(true);

        Core.SetOptions(false);
    }
}

