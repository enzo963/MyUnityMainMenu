#  Unity Main Menu System

![Unity](https://img.shields.io/badge/Unity-2022%2B-black?logo=unity)
![C#](https://img.shields.io/badge/C%23-Game%20Development-blue?logo=csharp)
![Status](https://img.shields.io/badge/Status-Completed-success)

A fully modular and production-ready **Main Menu System** built in Unity, featuring complete UI navigation, settings management, and persistent data saving.

---

##  Demo & Previews

|  Main Menu Animation |  Settings System Preview |
| :---: | :---: |
| ![Main Menu GIF](assets/main-menu.gif) | ![Settings GIF](assets/settings-menu.gif) |

---

##  Screenshots

|  Main Menu |  Audio Settings |
| :---: | :---: |
| ![Main Menu](assets/main-menu.png) | ![Audio Settings](assets/audio-settings.png) |

|  Graphics Settings |
| :---: |
| ![Graphics Settings](assets/graphics-settings.png) |

---

##  Key Features

*   **Full Main Menu Workflow:** Ready-to-use New Game, Load Game, and Exit functionalities.
*   **Smooth Navigation:** UI flow designed for seamless transitions between screens.
*   **Advanced Audio System:** Real-time volume control linked with Audio Mixers + local saving.
*   **Graphics & Display Management:**
    *   Dynamic resolution detection & automatic dropdown population.
    *   Runtime resolution switching & Fullscreen toggles.
    *   Quality presets control & Brightness adjustment.
*   **Data Persistence:** Automatic saving and loading using `PlayerPrefs`.
*   **Smart Defaults:** Quick "Reset to Default" options for all systems.
*   **Clean Architecture:** Highly decoupled, modular, and extremely easy to scale.

---

##  System Breakdown

###  Architecture & Core Logic
*   **Modular Controller:** Separated logic blocks per settings category (Audio, Graphics, Gameplay).
*   **Decoupled UI:** UI presentation layers are fully separated from core game logic for easier maintenance.

###  Audio & Gameplay
*   Sliders dynamically mapped to `AudioMixer` groups.
*   Toggle and slider systems built for flexible gameplay customization.

###  Graphics Setup
*   Grabs native hardware capabilities to populate configurations at runtime.
*   Includes an efficient **Apply / Save** pipeline to prevent accidental changes.

---

##  Tech Stack

*   **Engine:** Unity Engine (2022+)
*   **Language:** C#
*   **UI System:** Unity UI (UGUI)
*   **Storage:** PlayerPrefs

---

##  Project Structure (Assets)

```text
assets/
├── main-menu.gif
├── settings-menu.gif
├── main-menu.png
├── audio-settings.png
└── graphics-settings.png

# How to Run

Clone the repository to your local machine.
Open the project using Unity 2022 or newer.
Navigate to the scenes folder and open the MainMenu scene.
Press Play  and enjoy!


# Future Improvements
[ ] Add smooth UI Tweening animations (e.g., LeanTween / DOTween).
[ ] Integrate full Localization support (Multi-language system).
[ ] Implement a custom Input Remapping system.
[ ] Add Cloud Save support.

 Note: This system was built with flexibility in mind. It is fully reusable and can be integrated into any indie or commercial pipeline with ease.

















