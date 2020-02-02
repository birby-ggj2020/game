using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CreaturePartType
{
    HEAD,
    LEGS,
    BACK,
    TAIL,
    SKIN
}

public class CreaturePart
{
    public string name;
    public CreaturePartType type;
    public Sprite sprite;

    public CreaturePart(string name,
                        CreaturePartType type,
                        Sprite sprite)
    {
        this.name = name;
        this.type = type;
        this.sprite = sprite;
    }
}

public static class CREATURE_PARTS
{
    public static CreaturePart TAIL_FEATHERS = new CreaturePart(
        "feathers",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-2.png")
    );
    public static CreaturePart TAIL_DINO = new CreaturePart(
        "dino",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-4.png")
    );
    public static CreaturePart TAIL_SCORPION = new CreaturePart(
        "scorpion",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-6.png")
    );
    public static CreaturePart TAIL_PROPELLER = new CreaturePart(
        "propeller",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-8.png")
    );
    public static CreaturePart TAIL_THAGOMIZER = new CreaturePart(
        "thagomizer",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-10.png")
    );
    public static CreaturePart TAIL_SNAKE = new CreaturePart(
        "snake",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-12.png")
    );
    public static CreaturePart TAIL_HORSE = new CreaturePart(
        "horse",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-14.png")
    );
    public static CreaturePart TAIL_WHALE = new CreaturePart(
        "whale",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-16.png")
    );
    public static CreaturePart TAIL_RATTLE = new CreaturePart(
        "rattle",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-18.png")
    );
    public static CreaturePart TAIL_DECOY = new CreaturePart(
        "decoy",
        CreaturePartType.TAIL,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-20.png")
    );
    public static CreaturePart BACK_TANK = new CreaturePart(
        "tank",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-23.png")
    );
    public static CreaturePart BACK_TORTOISE = new CreaturePart(
        "tortoise",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-24.png")
    );
    public static CreaturePart BACK_CAMEL = new CreaturePart(
        "camel",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-25.png")
    );
    public static CreaturePart BACK_BATWINGS = new CreaturePart(
        "batwings",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-26.png")
    );
    public static CreaturePart BACK_TOWER = new CreaturePart(
        "tower",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-28.png")
    );
    public static CreaturePart BACK_BIRDWINGS = new CreaturePart(
        "birdwings",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-29.png")
    );
    public static CreaturePart BACK_SPIKES = new CreaturePart(
        "spikes",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-31.png")
    );
    public static CreaturePart BACK_SNAIL = new CreaturePart(
        "snail",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-32.png")
    );
    public static CreaturePart BACK_SADDLE = new CreaturePart(
        "saddle",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-33.png")
    );
    public static CreaturePart BACK_SAILFIN = new CreaturePart(
        "sailfin",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-34.png")
    );
    public static CreaturePart BACK_FURRY = new CreaturePart(
        "furry",
        CreaturePartType.BACK,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-36.png")
    );
    public static CreaturePart LEGS_ELEPHANT = new CreaturePart(
        "elephant",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-38.png")
    );
    public static CreaturePart LEGS_BIRD = new CreaturePart(
        "bird",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-40.png")
    );
    public static CreaturePart LEGS_FLIPPERS = new CreaturePart(
        "flippers",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-42.png")
    );
    public static CreaturePart LEGS_WHEELS = new CreaturePart(
        "wheels",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-44.png")
    );
    public static CreaturePart LEGS_FROG = new CreaturePart(
        "frog",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-46.png")
    );
    public static CreaturePart LEGS_HORSE = new CreaturePart(
        "horse",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-48.png")
    );
    public static CreaturePart LEGS_TENTACLES = new CreaturePart(
        "tentacles",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-50.png")
    );
    public static CreaturePart LEGS_BUG = new CreaturePart(
        "bug",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-52.png")
    );
    public static CreaturePart LEGS_MAN = new CreaturePart(
        "man",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-54.png")
    );
    public static CreaturePart LEGS_FURRY = new CreaturePart(
        "furry",
        CreaturePartType.LEGS,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-56.png")
    );
    public static CreaturePart HEAD_FISH = new CreaturePart(
        "fish",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-58.png")
    );
    public static CreaturePart HEAD_DUCK = new CreaturePart(
        "duck",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-60.png")
    );
    public static CreaturePart HEAD_BRONTOSAURUS = new CreaturePart(
        "brontosaurus",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-62.png")
    );
    public static CreaturePart HEAD_RHINO = new CreaturePart(
        "rhino",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-64.png")
    );
    public static CreaturePart HEAD_FRIEND = new CreaturePart(
        "friend",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-66.png")
    );
    public static CreaturePart HEAD_CENTAUR = new CreaturePart(
        "centaur",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-68.png")
    );
    public static CreaturePart HEAD_HORSE = new CreaturePart(
        "horse",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-70.png")
    );
    public static CreaturePart HEAD_UNICORN = new CreaturePart(
        "unicorn",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-72.png")
    );
    public static CreaturePart HEAD_DOOTDOOT = new CreaturePart(
        "dootdoot",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-74.png")
    );
    public static CreaturePart HEAD_WASHINGTON = new CreaturePart(
        "washington",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-76.png")
    );
    public static CreaturePart HEAD_WHALE = new CreaturePart(
        "whale",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-78.png")
    );
    public static CreaturePart HEAD_BULL = new CreaturePart(
        "bull",
        CreaturePartType.HEAD,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-80.png")
    );
    public static CreaturePart SKIN_SPECKLE = new CreaturePart(
        "speckle",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-81.png")
    );
    public static CreaturePart SKIN_RED = new CreaturePart(
        "red",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-82.png")
    );
    public static CreaturePart SKIN_GOLD = new CreaturePart(
        "gold",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-83.png")
    );
    public static CreaturePart SKIN_METAL = new CreaturePart(
        "metal",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-84.png")
    );
    public static CreaturePart SKIN_LIZARD = new CreaturePart(
        "lizard",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-85.png")
    );
    public static CreaturePart SKIN_PAPER = new CreaturePart(
        "paper",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-86.png")
    );
    public static CreaturePart SKIN_GREENSTRIPE = new CreaturePart(
        "greenstripe",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-87.png")
    );
    public static CreaturePart SKIN_POLKADOT = new CreaturePart(
        "polkadot",
        CreaturePartType.SKIN,
        GameUtils.load_sprite("Assets/Graphics/creature_parts/Exquisite_animated_1k-88.png")
    );

    public static List<CreaturePart> ALL = new List<CreaturePart>{
        TAIL_FEATHERS,
        TAIL_DINO,
        TAIL_SCORPION,
        TAIL_PROPELLER,
        TAIL_THAGOMIZER,
        TAIL_SNAKE,
        TAIL_HORSE,
        TAIL_WHALE,
        TAIL_RATTLE,
        TAIL_DECOY,

        BACK_TANK,
        BACK_TORTOISE,
        BACK_CAMEL,
        BACK_BATWINGS,
        BACK_TOWER,
        BACK_BIRDWINGS,
        BACK_SPIKES,
        BACK_SNAIL,
        BACK_SADDLE,
        BACK_SAILFIN,
        BACK_FURRY,

        LEGS_ELEPHANT,
        LEGS_BIRD,
        LEGS_FLIPPERS,
        LEGS_WHEELS,
        LEGS_FROG,
        LEGS_HORSE,
        LEGS_TENTACLES,
        LEGS_BUG,
        LEGS_MAN,
        LEGS_FURRY,

        HEAD_FISH,
        HEAD_DUCK,
        HEAD_BRONTOSAURUS,
        HEAD_RHINO,
        HEAD_FRIEND,
        HEAD_CENTAUR,
        HEAD_HORSE,
        HEAD_UNICORN,
        HEAD_DOOTDOOT,
        HEAD_WASHINGTON,
        HEAD_WHALE,
        HEAD_BULL,

        SKIN_SPECKLE,
        SKIN_RED,
        SKIN_GOLD,
        SKIN_METAL,
        SKIN_LIZARD,
        SKIN_PAPER,
        SKIN_GREENSTRIPE,
        SKIN_POLKADOT
    };
}