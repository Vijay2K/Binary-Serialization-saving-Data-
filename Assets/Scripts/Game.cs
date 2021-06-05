using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    [SerializeField] private Text levelText = null;

    public int score = 0;
    public int level = 0;

    private void Update() {
        scoreText.text = score.ToString();
        levelText.text = level.ToString();
    }

    #region Game
    public void AddScore() {
        score++;
    }

    public void SubtractScore() {
        score--;
    }

    public void AddLevel() {
        level++;
    }

    public void SubstractLevel() {
        level--;
    }
    #endregion

    public void SaveGame() {
        SavingSystem.Save(this);
    }

    public void LoadGame() {
        GameData data = SavingSystem.Load();
        score = data.score;
        level = data.level;

    }
}
