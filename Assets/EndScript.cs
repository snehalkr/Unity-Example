using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManagerScript>().LevelComplete();
    }
}
