## 🕹️ Unity Pool Projects

This repository contains **Unity Pool Projects**.  
It is designed to help you learn the fundamentals of the Unity game engine through practical and interactive mini projects.  
Perfect for beginners who want to understand core Unity concepts and develop small-scale examples.

---

### 🚀 Unity Fundamentals

#### 🎨 1. What is Unity?
Unity is a powerful **2D and 3D game engine** used to create games, simulations, and interactive applications.  
It supports multiple platforms such as mobile (iOS, Android), desktop (Windows, Mac), and web.

---

#### 🧩 2. Core Concepts
| Concept | Description |
|----------|-------------|
| **Scene** | The environment or level where the game takes place. All objects exist within a scene. |
| **GameObject** | The basic building block of Unity. Everything in your game (camera, lights, characters, etc.) is a GameObject. |
| **Component** | Adds specific behaviors or properties to a GameObject (e.g., Rigidbody, Collider, Script). |
| **Transform** | Stores position, rotation, and scale information of an object. |
| **Prefab** | A pre-configured, reusable GameObject template. |
| **Script** | C# scripts define object behaviors and interactions. |

---

#### ⚙️ 3. Unity Interface
- **Hierarchy:** Lists all objects in the current scene  
- **Scene View:** The editor view where you design the scene (2D/3D)  
- **Game View:** Shows how the game will look during play mode  
- **Inspector:** Displays and edits the selected object’s components  
- **Project Window:** Contains all your project assets (scripts, scenes, textures, etc.)

---

#### 💡 4. Basic Script Example
```csharp
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(moveX, moveY, 0);
    }
}
```
This simple script allows a character to move using the arrow keys.

---

### 🏗️ Project List  

Below is the list of Unity projects included in this repository.  
Use the checkboxes to track your progress — mark completed ones with a ✅.  

| Status | Project Name |
|:------:|---------------|
| ⬜ | **Unity - 0 - The Basics & Unity Tools** |
| ⬜ | **Unity - 1 - 3D Physics, Tags, Layers and Scene** |
| ⬜ | **Unity - 2 - 2D Environment, Tiles and Sprites** |
| ⬜ | **Unity - 3 - Advanced Inputs and 2D GUI** |
| ⬜ | **Unity - 4 - Animations and Sound** |
| ⬜ | **Unity - 5 - Singleton, PlayerPrefs and Coroutines** |
| ⬜ | **Unity - 6 - NavMesh, Light, Sound and Camera** |

> To mark a project as completed, replace `⬜` with `✅`  
> Example:  
> `| ✅ | Unity - 0 - The Basics & Unity Tools |`

---

### 🧠 Learning Resources
- 🎓 [Unity Learn](https://learn.unity.com/)  
- 📖 [Unity Documentation](https://docs.unity3d.com/)  
- ▶️ YouTube Channels: [Brackeys](https://www.youtube.com/user/Brackeys), [Code Monkey](https://www.youtube.com/@CodeMonkeyUnity), [Game Dev Guide](https://www.youtube.com/@GameDevGuide)

---

### 🧾 License
These projects are for educational and practice purposes.  
The code can be freely used, but giving credit to the source is appreciated.  
