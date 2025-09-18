using BepInEx;
using BepInEx.Configuration;
using UnityEngine;


[BepInPlugin("com.minimentwo.WidowBossRespawn", "Widow Respawner", "1.0.0")]
public class WidowRespawn : BaseUnityPlugin
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
        Logger.LogInfo("Loaded Widow Respawner and initialised.");
    }

    private void Update()
    {
        if (Input.GetKey(modifierKey.Value) && Input.GetKeyDown(actionKey.Value))
        {
            Logger.LogInfo($"{modifierKey.Value}+{actionKey.Value} pressed! Respawning Widow...");
            RespawnWidow();
        }
    }


    private void RespawnWidow()
    {
        PlayerData __instance = PlayerData.instance;
        __instance.spinnerDefeated = false; //spinner = Widow rehaunts Bellhart every time they respawn 
        __instance.bellShrineBellhart = false;
        SceneData.instance.PersistentInts.SetValue(new PersistentItemData<int> //disables bench in Widow fight while boss is active
        {
            SceneName = "Belltown_Shrine",
            ID = "Bellshrine Sequence Bellhart",
            Value = 0,
            Mutator = 0
        });
    }
}