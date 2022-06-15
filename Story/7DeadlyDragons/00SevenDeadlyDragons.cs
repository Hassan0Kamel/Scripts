//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/7DeadlyDragons/01Gluttony.cs
//cs_include Scripts/Story/7DeadlyDragons/02Pride.cs
//cs_include Scripts/Story/7DeadlyDragons/03Greed.cs
//cs_include Scripts/Story/7DeadlyDragons/04Sloth.cs
//cs_include Scripts/Story/7DeadlyDragons/05Lust.cs
//cs_include Scripts/Story/7DeadlyDragons/06Envy.cs
//cs_include Scripts/Story/7DeadlyDragons/07Wrath.cs
using RBot;

public class Complete7DeadlyDragons
{
    public ScriptInterface Bot => ScriptInterface.Instance;

    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public Gluttony s01 = new Gluttony();
    public Pride s02 = new Pride();
    public Greed s03 = new Greed();
    public Sloth s04 = new Sloth();
    public Lust s05 = new Lust();
    public Envy s06 = new Envy();
    public Wrath s07 = new Wrath();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        CompleteToD();

        Core.SetOptions(false);
    }

    public void CompleteToD()
    {
        s01.GluttonySaga();
        Core.Logger("Finished Gluttony");
        s02.PrideSaga();
        Core.Logger("Finished Pride");
        s03.GreedSaga();
        Core.Logger("Finished Greed");
        s04.SlothSaga();
        Core.Logger("Finished Sloth");
        s05.LustSaga();
        Core.Logger("Finished Lust");
        s06.EnvySaga();
        Core.Logger("Finished Envy");
        s07.WrathSaga();
        Core.Logger("Finished Wrath");
    }
}
