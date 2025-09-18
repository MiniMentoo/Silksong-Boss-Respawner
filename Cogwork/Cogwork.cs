using BepInEx;
using BepInEx.Configuration;
using UnityEngine;



[BepInPlugin("com.minimentwo.CogworkDancerRespawn", "Cogwork Dancer Respawner", "1.0.0")]
public class CogworkDancerRespawn : BaseUnityPlugin
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
        Logger.LogInfo("Loaded Cogwork Dancer Respawner and initialised.");
    }

    private void Update()
    {
        if (Input.GetKey(modifierKey.Value) && Input.GetKeyDown(actionKey.Value))
        {
            Logger.LogInfo($"{modifierKey.Value}+{actionKey.Value} pressed! Respawning Cogwork Dancers...");
            RespawnCogwork();
        }
    }


    private void RespawnCogwork()
    {
        PlayerData.instance.defeatedCogworkDancers = false;
    }
}