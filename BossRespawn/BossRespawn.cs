using BepInEx;
using BepInEx.Configuration;
using UnityEngine;


[BepInPlugin("com.minimentwo.BossRespawn", "Boss Respawner", "1.1.0")]
public class BossRespawn : BaseUnityPlugin
{
    private ConfigEntry<KeyCode> modifierKey;
    private ConfigEntry<KeyCode> actionKey;
    private void Awake()
    {
        modifierKey = Config.Bind(
            "Keybinds",               
            "Modifier",                
            KeyCode.LeftAlt,           
            "The modifier key to hold (e.g. Alt)"
        );

        actionKey = Config.Bind(
            "Keybinds",
            "ActionKey",
            KeyCode.Alpha1,
            "The key to press together with the modifier"
        );
        Logger.LogInfo("Loaded Boss Respawner mod and initialised.");
    }

    private void Update()
    {
        if (Input.GetKey(modifierKey.Value) && Input.GetKeyDown(actionKey.Value))
        {
            Logger.LogInfo($"{modifierKey.Value}+{actionKey.Value} pressed! Respawning bosses...");
            RespawnBosses();
        }
    }

 
    private void RespawnBosses()
    {
        PlayerData __instance = PlayerData.instance;

        //Reviving Moss Mother, she requires changes to the scene data aswell, literally the only boss I know of that requires this
        __instance.defeatedMossMother = false;
        SceneData.instance.PersistentBools.SetValue(new PersistentItemData<bool>
        {
            SceneName = "Tut_03",
            ID = "Battle Scene",
            Value = false
        });

        __instance.defeatedBellBeast = false; //can't use BB to travel into the marrow or get glitched out
        __instance.defeatedSongGolem = false; //SongGolem = fourth chorus
        __instance.defeatedVampireGnatBoss = false; //VampireGnatBoss = mosswing
        __instance.defeatedTrobbio = false;
        __instance.defeatedLace1 = false; //This will respawn Lace1 but not if the game has progressed too far (not sure on the exact timing)
        __instance.laceLeftDocks = false;
        __instance.defeatedLaceTower = false; //This is respawning Lace2
        __instance.defeatedPhantom = false; //Retriggers mist aswell
        __instance.hang04Battle = false; //The high halls ten wave battle
        __instance.defeatedDockForemen = false; //Foreman brothers
        __instance.wardBossDefeated = false;

        //Act 3 Bosses
        __instance.defeatedAntQueen = false;
        __instance.defeatedCloverDancers = false; //Reunlocks Verdania too
        __instance.defeatedWhiteCloverstag = false; //The White Cloverstag in Verdania
        __instance.defeatedCoralKing = false;
        __instance.defeatedFlowerQueen = false;
        __instance.defeatedSeth = false;
        __instance.defeatedCrowCourt = false;
        __instance.defeatedAntTrapper = false;
        //The Act 3 bosses locked behind wishes require some more shenanigans to unlock
    }
}