# Mitten’s Quest For The Lost Yarn (University of Arizona, GAME 351 Final Project)

## Game Overview

**Game Name:** Mitten’s Quest For The Lost Yarn  
**Description:**  
Mittens, a delightful white cat, has lost his beloved yarn and must venture through various terrains to retrieve it. Help Mittens traverse grassy islands, moving platforms, and snowy hills, and scale to the top of a snowy mountain to reclaim his precious yarn.

---

## Installation Notes

- Upon first installation, all scenes may need to be run to ensure renderings load properly.  
  *(This is due to the library folder being deleted to reduce project size. It is automatically recreated the first time you run the project.)*

---

## Known Bugs

1. **Lighting Issues:** Occasionally, lighting behaves strangely but can be fixed by reloading the scene or project.  
   - Similar issue: [Unity Discussions: Lights Get Darker When Loading Scene](https://discussions.unity.com/t/lights-get-darker-when-loading-scene/175994).
2. **Cat on Slopes:** Mittens may stop when climbing sloping terrain. Jumping can help mitigate this issue.  
   - Likely caused by collider setup; the sphere collider is used as we couldn't find a specific mass collider for the cat.

---

## Design Overview

### Terrains and Meshes
- **Cutscene Map:** Charis Pace  
- **Main Level:**  
  - Mountain Island & Platforms: Charis Pace  
  - Tutorial Island & Platforms: Sage Ashur Newton  
- **Additional Elements:**  
  - Ocean, Fog, and Lava Planes + Materials: Charis Pace  
  - Hidden Volcano Level + Platforms: Sage Ashur Newton  
- **Collectibles, Obstacles, and Save Point Placement:**  
  - Sage Ashur Newton, Charis Pace, Dongyoung Yang  

### Scripting and OOP
- **Scripts:**  
  - GameManager, HiddenManager, IngameUI, MenuButtons, Player, PlayerSystem, SawMoving, SoundManager, AfterCutScene: Dongyoung Yang  
  - AnimationController, AutoDestroy, Obstacle, PlayerSounds, Spin: Charis Pace  
- **Features:**  
  - OOP Implementation + Comments: Dongyoung Yang  
  - Scene Transitions + Game States: Dongyoung Yang  

### Animation and Motion
- **Animations for Cat Model:** Charis Pace  
- **Moving Platforms + Obstacles:** Dongyoung Yang  
- **Cutscenes (Start + End):** Sage Ashur Newton  

### Physics and Particles
- **Physics Implementation + Scripting + Colliders:** Dongyoung Yang  
- **Particle Systems:** Charis Pace  

### Audio and Game Mechanics
- **Audio:**  
  - All Implementations (except hidden level victory music and pause menu button clicks): Charis Pace  
  - Hidden Level Victory Music + Pause Menu Button Clicks: Dongyoung Yang  
- **Mechanics:**  
  - Player Movement + Cameras  
  - Damage Mechanics (Water, Obstacles, Death & Respawn)  
  - Save Point Mechanics (Cat Tower Collisions)  
  - Victory Mechanics (Scene Transition)  
  - Collectibles (Fish, 9 Lives System)  
  - Hidden Level Unlock (All Fish Collected)  

**All implemented by:** Dongyoung Yang  

### User Interface and HUD
- **UI and HUD Implementation + Scripting:** Dongyoung Yang  
- **Scenes:** Game Over, Victory, Main Menu, Hidden Level Victory: Dongyoung Yang  

---

## Controls

- **W:** Move Forward  
- **A:** Move Left  
- **S:** Move Backward  
- **D:** Move Right  
- **Space:** Jump  
- **M:** Meow (Cycles through 3 random meow sounds)  
- **Esc:** Pause / Skip Cutscenes  
- **Left Mouse Button:** Menu Button Click  

---

## Packages Used

- ProBuilder  
- Universal Rendering Pipeline  
- Shader Graph  
- Cinemachine  

---

## References

### Sounds
- [Pixabay](https://pixabay.com) (Various Sounds)  
- [ZapSplat](https://www.zapsplat.com) (Game Effects)  
- [Fesliyan Studios](https://www.fesliyanstudios.com) (Foliage Sounds)  

### Models and Animations
- [Unity Asset Store](https://assetstore.unity.com)  
- [Sketchfab](https://sketchfab.com)  

### Textures and Materials
- [Kenney.nl](https://www.kenney.nl/assets/platformer-kit)  
- [Unity Asset Store](https://assetstore.unity.com)  

### UI Images
- [HiClipart](https://www.hiclipart.com)  
- [PNGWing](https://www.pngwing.com)  
- Background images for victory, main menu, and game over scenes are AI-generated.

### Hidden Victory Music + Video
- [YouTube](https://youtu.be/2yJgwwDcgV8?si=mFPGcPDY1EftxrkU)

---

## Contributors

- **Dongyoung Yang:** Physics, Game Mechanics, Scripting, UI, HUD  
- **Charis Pace:** Scripting, Animation, Particle Systems, Maps  
- **Sage Ashur Newton:** Maps, Cutscenes  

---
