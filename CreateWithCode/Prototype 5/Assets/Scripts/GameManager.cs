using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button RestartButton;
    public GameObject titleScreen;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        spawnRate /= difficulty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        { yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]); 
        }
    }

    public void UpdateScore(int scoreToAdd)
    { score += scoreToAdd; scoreText.text = "Score: " + score; }

    public void GameOver()
    { gameOverText.gameObject.SetActive(true); 
        isGameActive = false; 
        RestartButton.gameObject.SetActive(true); 
    }

    public void restartGame() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
}
