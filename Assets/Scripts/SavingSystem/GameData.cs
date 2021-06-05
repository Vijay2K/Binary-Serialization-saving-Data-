using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int score;
    public int level;

    public GameData(Game game) {
        this.score = game.score;
        this.level = game.level;
    }
}
