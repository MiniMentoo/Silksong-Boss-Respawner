# BossRespawner mod

This is a simple (UI'less) mod that respawns the bosses of silksong for practice purposes. The intention is to use this mod for Speedrun and Steel Soul practice, allowing you to easily respawn bosses while still in game, so you don't need to roll back your save or edit save files.

PLEASE BACK UP YOUR SAVES BEFORE USING THIS MOD, IT EDITS SAVE FILES DIRECTLY

## Installation/Setup

Drag the BossRespawn.dll along with any other Dlls of the bosses you want to respawn into your BepInEx plugins folder. BossRespawn.dll contains most of the bosses this mod supports, while other more problematic bosses have their own files. Each dll can be used seperately without the others.

To Respawn the bosses press ```alt+1``` (the left alt key and the 1 key above your Q key), this default can be changed by going into the com.minimentwo.BossRespawn.cfg file in your BepInEx config folder 

```
Hollow Knight Silksong\BepInEx\config\com.minimentwo.BossRespawn.cfg
```
if you're changing the widow dll then change the com.minimentwo.WidowRespawner.cfg and so on

## Usage

Press ```alt +1``` and all (supported bosses will respawn), there won't be any visual queue, but enter the boss scene and the boss should be there like normal. 

If you press ```alt+1``` while in a boss scene leave and reenter and the boss will appear, this can cause bugs so it's recommended to just use the keybind while not in any scene with a boss room in it.

If bosses/rooms are behaving weirdly, you're probably in act 3.

## Supported Bosses and Notes (Please read before use!)
Currently Only supporting the bosses fought in the Any% speed-run. Bosses marked Problematic are seperated into their own DLL files, so you can just not drag those into your plugins folder if you don't want to deal with them.

- Bell Beast - Fast traveling into Marrow station will bug you out until you save and quit, will lock you into a cut-scene after where you'll gain a duplicate silk heart. Silk Hearts aren't capped so you can theoretically have 10, fun, but maybe not good for practice.

- Cogwork Dancers - PROBLEMATIC BOSS, enable it separately. Will seal south exits of the room and lift, making traversal through cogwork core difficult. Can soft lock if benched south of the boss room. Must save and Quit after the second dancer dies to reset room state.

- Fourth Chorus - Works as intended, although the platforms on west side of the boss disappear if the boss is active making it hard to reach without grappling hook.

- High Halls gauntlet room - The 10 wave enemy fight in High Halls, not a Boss but I wanted to practice it for steel soul. Works as intended.

- Lace1 - Theoretically works, but the game won't load Lace in deep docks if you've progressed too far in the game, I'm not sure what this point is yet.

- Lace2 - Works as intended, the right exit is still open which can cause Lace to have slightly weird movement, but it's hardly noticeable. After beating Lace exit through the right to avoid long cut-scene and duplicate silk heart.

- Moorwing - Works as intended, although will likely respawn next to Greymoor station.

- Moss Mother - works as intended.

- Phantom - Works as intended, re spawns the mist with her which is good practice.

- Trobbio - Iconic boss, also works as intended.

- Widow - PROBLEMATIC BOSS, enable it separately. Will re-haunt Bellhart if she's respawned, this might cause issues with NPCs.

## License

Do whatever, I don't care