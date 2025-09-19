using BepInEx;
using BepInEx.Configuration;
using UnityEngine;


[BepInPlugin("com.minimentwo.SinnerBossRespawn", "Sinner Respawner", "1.0.0")]
public class SinnerRespawn : BaseUnityPlugin
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
        Logger.LogInfo("Loaded First Sinner Respawner and initialised.");
    }

    private void Update()
    {
        if (Input.GetKey(modifierKey.Value) && Input.GetKeyDown(actionKey.Value))
        {
            Logger.LogInfo($"{modifierKey.Value}+{actionKey.Value} pressed! Respawning First Sinner...");
            RespawnSinner();
        }
    }


    private void RespawnSinner()
    {
        PlayerData __instance = PlayerData.instance;
        __instance.defeatedFirstWeaver = false;
        PlayerData.instance.hasSilkBomb = false; //Removing Rune Rage from player
        //When loading the First Sinner Boss room, the game checks what room layout to load, either
        //The one with the statue intact where you can interact to start the fight, or the ruined one
        //The room will load with the ruined one if the Rune Rage skill has been acquired, the only boss that does this afaik
    }
}