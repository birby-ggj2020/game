# [WIP] Game Pitch

## Story
TODO: something something *REPAIR*ing the ecosystem.

## Scenario
there are several Habitats that each need to be populated with a Creature.
each Habitat has a different requirement for a Creature to survive in it (eg: be
able to eat fruit from tall trees).
Player must mix Traits to create Creatures that can survive in each Habitat.
in each Habitat, some Traits will help, some will hurt, and some will make no difference.

Trait usage:
- v0: each Habitat has a specific set of "must-have" Traits and a set of
  "must-not-have" Traits.
- v1: Traits confer abilities (eg: fly, swim) and stats (eg: height, weight).
  Creature must reach certain thresholds (ie: must be a certain height) to
  achieve goals.

Creature interaction:
- v0: Creatures move on their own, according to Traits.
- v1: Player can directly control Creatures to act out goal achievement (eg:
  walk up to tree to eat tall fruit, or fly to get tall fruit).

## Scenes
- startup/loading/welcome
    + just a welcome screen w/ title, credits
    + click to go to habitat selection scene
- habitat selection
    + a 3x2 grid of crt screens (ie: 6 Habitats)
    + click a screen to view Habitat (ie: go to creature editor scene)
    + "quit" button to exit
- creature editor
    + bottom 1/3: available Traits palette
    + left 1/3: selected Traits soup
    + top-right 2/3: Habitat
        * Habitat background
        * active Creature
        * props for Creature to interact with (eg: a tall tree with fruit)
    + "back" button to go back to habitat selection

maybes:
- "win" screen
- "load/new game" screen
    + needs a "save" button in the habitat selection scene

## Traits
- head
    + long neck
    + short neck
    + gills (can only breath in water)
- limbs
    + types: arms, legs (walk or swim slow), fins (swim fast, cant walk)
    + sizes: small, medium, large
- body
    + types?
    + sizes: small, medium, large
- accessories
    + horn
    + spikes
    + shell
    + wings (can fly)
- skin?
    + scales
    + hair
    + feathers
    + smooth

## Habitats/Levels
### Grasslands
- Goal: eat grass
- v0 Solution: neck length >= leg langth
    + Must not: ???

### Sparse Trees
- Goal: eat fruit from tall trees
- v0 Solution: long legs and long neck
    + Must not: have horn (skewers fruit, stuck out of reach)

### Tree tops
- Goal: don't fall
- v0 Solution: wings or long arms
    + Must not: large body, shell (too heavy)

### Desert
- Goal: get over quicksand
- v0 Solution: [small body and short legs] or wings
    + Must not: ???

### Water
- Goal: don't drown
- v0 Solution: fins, gills
    + Must not: feathers (sink because too heavy)

...?
