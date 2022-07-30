//cs_include Scripts/CoreBots.cs
using Skua.Core.Interfaces;

public class FourDPyramidHouseShop
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        GetMergeItems();

        Core.SetOptions(false);
    }

    public void GetMergeItems()
    {
        Core.AddDrop("Anti-Matter Gem");

        while (!Bot.ShouldExit && !Core.CheckInventory("Anti-Matter Gem", 500))
        {
            //Reflections of Victory
            Core.EnsureAccept(5188);
            Core.HuntMonster("whitehole", "Dimensional Crystal", "Crystal Shards", 5);
            Core.EnsureComplete(5188);
        }
    }
}