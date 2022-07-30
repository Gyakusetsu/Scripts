//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/QueenofMonsters/BookofMonstersTheDestroyer(Extriki)/CoreExtriki.cs
using Skua.Core.Interfaces;

public class CompleteExtrikiMap
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();
    public CoreExtriki Extriki => new CoreExtriki();
    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        Extriki.Extriki();

        Core.SetOptions(false);
    }
}