﻿using System;
using TMPro;
using UnityEngine;

/**
 * This component tracks the score of the player.
 * The score increases when the player picks a coin.
 */
public class ScoreCounter: MonoBehaviour {
    CharacterController characterController;

    [SerializeField] int scorePerCoin = 1;

    private TextMeshPro scoreText;
    private int score = 0;

    void Start() {
        var scoreChild = transform.Find("Score");
        if (!scoreChild) throw new Exception("No child with name Score!");
        scoreText = scoreChild.GetComponent<TextMeshPro>();
        SetScore(0);
    }
    
    private void SetScore(int s) {
        score = s;
        scoreText.text = score.ToString();
    }

    public void CollectCoin() {
        SetScore(score + scorePerCoin);
    }
}