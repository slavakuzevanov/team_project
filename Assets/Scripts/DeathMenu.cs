﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathMenu : MonoBehaviour {
    public Text scoreText;
    public Text coinsText;
    public Image backgroundImage;
    private bool isShowed = false;
    private float transition = 0.0f;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (!isShowed)
            return;
        transition += Time.deltaTime;
        backgroundImage.color = Color.Lerp(new Color(0,0,0,0),Color.black,transition);
        
	}
    public void ToggleEndMenu(float score)
    {
        gameObject.SetActive(true);
        scoreText.text = ((int)score).ToString();
        coinsText.text = "Coins: " + ((int)PlayerPrefs.GetFloat("Coins"));
        isShowed = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
