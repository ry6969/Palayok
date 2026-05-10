<h1 align="center">ੈ✩‧₊˚Palayok - Your Filipino Cooking Companion‧₊˚✩ ੈ</h1>
<p align="center">
  <img src="AReadMe/PalayokRM.gif">
</p>

> *"Tara, luto!"* — Come, let's cook!

---

## 🍲 What is Palayok?

**Palayok** (Filipino for *clay pot*) is a mobile cooking guide app designed to bring the warmth and soul of Filipino home cooking to your fingertips. Guided by **Sandok** — your friendly in-app kitchen companion — Palayok walks you through authentic Filipino dishes with clarity, care, and a little bit of *kuya/ate* energy.

Whether you're a first-timer curious about adobo or a home cook looking to nail your lola's nilaga, Palayok has you covered.

---
## 👨‍🍳 Meet Sandok

**Sandok** (Filipino for *ladle*) is your in-app guide — warm, encouraging, and always ready with the next instruction. He greets you on loading, walks you through prep, and cheers you on through every step.

> *"Onions chopped, now move to our next step."*
> *"Garlic ready, now move to our next step."*
> *"Nice one! Now let's wait for the chicken to be golden brown."*
---
## ✨ Features

### 🥘 Dish Library
Browse a curated collection of classic Filipino recipes, each with:
- Cooking time and serving size
- Difficulty level (Easy / Medium / Average)
- Full ingredients list
- Step-by-step instructions

**Current Menu:**
| Dish | Image | Time | Difficulty | Serves |
|---|---|---|---|---|
| Adobo | <img src="AReadMe/adobo.png" width="80"> | 45 mins | Easy | 4 |
| Tinola | <img src="AReadMe/tinola.png" width="80"> | 45 mins | Medium | 4 |
| Tortang Talong | <img src="AReadMe/tortang_talong.png" width="80"> | 25 mins | Easy | 3 |
| Paksiw na Bangus | <img src="AReadMe/paksiw_na_bangus.png" width="80"> | 45 mins | Medium | 4 |
| Pork Monggo | <img src="AReadMe/pork_monggo.png" width="80"> | 90 mins | Average | 4 |
| Nilagang Baka | <img src="AReadMe/nilagang_baka.png" width="80"> | 103 mins | Easy | 4 |

---

### 🎛️ Two Cooking Modes

#### 📖 Read-Only Mode
A clean, distraction-free view of the full recipe — ingredients and numbered steps all in one place. Perfect for experienced cooks who just need a quick reference.

#### ⏱️ Real-Time Cooking Mode *(Recommended for first-timers!)*
An interactive, step-by-step guided experience that takes you through the cooking process one action at a time:
- **Prep phase** — guided ingredient chopping and preparation
- **Cooking phase** — action-by-action instructions with built-in timers
- **Contextual prompts** — Sandok narrates each step in a friendly, conversational tone
- **Timer support** — start timers right from the screen so nothing gets overcooked

---

## 🧑‍💻 Object-Oriented Design Principles

Palayok's system is built with the four pillars of **Object-Oriented Programming (OOP)** in mind:

### 1. 🔒 Encapsulation
Each recipe is modeled as a self-contained object — it holds its own data (ingredients, steps, duration, difficulty) and exposes only what the UI needs. Internal cooking logic is hidden away, keeping the interface clean and the data safe from unintended modification.

> *Like a palayok itself — the heat, steam, and simmering all happen inside. You just lift the lid when it's ready.*

---

### 2. 🧬 Inheritance
A base `Recipe` class defines the shared structure — title, serving size, cooking time, ingredient list, and instructions. Specific dishes like `Adobo`, `Tinola`, or `Nilagang Baka` inherit from this base, extending it with their unique properties without duplicating code.

> *Every Filipino dish starts from the same foundation: heat, seasoning, and patience. What makes each unique is what it adds on top.*

---

### 3. 🎭 Polymorphism
The `CookingMode` interface can be implemented as either `ReadOnlyMode` or `RealTimeMode`. The app calls the same `startCooking()` method regardless of which mode is active — each mode just handles it differently under the hood.

> *Same pan, different technique. You can boil, fry, or simmer — the stove doesn't care. It just provides the heat.*

---

### 4. 🫙 Abstraction
Users interact with simple screens: pick a dish, choose a mode, follow the steps. The complexity behind managing timers, tracking progress, and transitioning between prep and cooking phases is completely abstracted away.

> *You don't need to know how the clay pot was fired to cook in it. You just need to know what goes inside.*

---

## 🗂️ App Structure (UI Flow)

## 🗂️ Folder Structure
---

## 🌿 Philosophy

Palayok isn't just a recipe app — it's a love letter to Filipino home cooking. Every dish in the library carries stories: the garlic sautéed until golden, the vinegar that never gets stirred right away, the malunggay leaves added last so they stay bright and fresh.

The goal is simple: make Filipino cooking accessible, approachable, and joyful — for anyone, anywhere.

---

*Made with rice and a lot of puso (heart).*
