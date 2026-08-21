# Project Plan

Working title: TBD (needs an original name — see Legal note below)

## Pitch
A pixel-art, d20-flavored co-op RPG. Explore, talk, fight — Baldur's Gate-lite
scope, Stardew Valley-ish art ambition. Solo-playable, with local (hot-seat)
co-op now and online co-op planned later.

## Why these choices
- **Turn-based combat (initiative order)**, not real-time-with-pause: far
  easier to network for co-op later, and it's the authentic D&D feel anyway.
- **Local co-op = hot-seat**, not split-screen: two players take turns
  controlling different party members on one screen. Much simpler to build,
  and it's a natural fit for turn-based play.
- **Online co-op is a later phase**, added once the single-player/local-coop
  core loop is solid — building gameplay and netcode at the same time is a
  rough first-game experience. We'll design turn/state systems to be
  network-friendly from the start so this isn't a rewrite later.
- **Engine: Unity**, 2D URP, Tilemap.

## Legal note
Can't use Wizards of the Coast's "Dungeons & Dragons" name, monsters, or
proprietary content on Steam — that's their trademark/IP. Plan is to build
d20-style mechanics either from the **SRD 5.1** (D&D content WotC released
under Creative Commons — safe to build on) or fully homebrewed, with our own
name and lore.

## Milestones

### Milestone 1 — single-player skeleton (current)
- Tiny pixel-art tilemap room, one character, top-down movement
- Walking into an enemy transitions into a turn-based combat screen
- One attack action: d20 roll vs. a target number, HP bar
- Touches: scenes, Tilemap, player controller, a simple explore↔combat state
  machine, first pass at a dice/stat system

### Milestone 2 — real combat loop (planned)
- Initiative order, multiple actions (attack/defend/item), enemy AI turn
- Basic character stats (class-ish archetypes, HP, a couple of abilities)
- Win/lose states

### Milestone 3 — local co-op (planned)
- Second party member controllable by a second player, hot-seat turn passing
- Shared-screen UI for whose turn it is

### Milestone 4 — content pass (planned)
- A few rooms/areas, simple quests/dialogue, more enemies

### Milestone 5 — online co-op (planned)
- Unity Netcode for GameObjects, sync the turn/state system built in
  Milestone 1-3 over network

### Later / stretch
- Steam page, build pipeline, Steamworks integration
- More content, polish, art pass

## How we're working
This is the user's first game project and a deliberate learning project.
Claude acts as a pairing partner (explains concepts, reviews code, suggests
structure) rather than writing full systems — the user drives the Unity
Editor and writes the implementation.
