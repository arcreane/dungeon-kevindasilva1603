
public class Protection {
    public bool CheckEfficiency(Monster monsterInRoom) {

        return true;
    }
}


public class Hero : Protection {
    public Protection[] Protections { get; set; }
    public Arsenal HeroArsenal { get; set; }
    public int Health { get; set; }
    public Weapon ActiveWeapon { get; set; }

    public void SelectProtection() {

    }

    public void AutoSelectCorrectProtection(Monster roomMonster) {

    }
}


public class Arsenal {
    public Weapon[] Weapons { get; set; }
}


public class Weapon {

}


public class Claw : Weapon {

}

public class Fire : Weapon {

}

public class Spike : Weapon {

}


public class Item {

}


public class Arrows : Item {

}

public class IceArrow : Arrows {

}


public class Room {
    public Monster OpenDoor() {

        return new Monster();
    }
}


public class Monster {

}

// Définition de la classe Game
public class Game {
    public Hero HeroPlayer { get; set; }
    public Dungeon GameDungeon { get; set; }

    public void Initialise() {

    }
}


public class Dungeon {

}


public class GameManager {
    public Game MyGame { get; set; }
}


public class Shield : Protection {

}

public class Cape : Protection {

}

public class Pendant : Protection {

}

// Classes dérivées de Weapon
public class Dagger : Weapon {

}

public class Sword : Weapon {

}

public class WaterFlask : Weapon {

}

public class Lightning : Weapon {

}
