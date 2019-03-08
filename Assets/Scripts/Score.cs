using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        scoreText.text = "000";
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = player.position.z.ToString("0");
	}
}
