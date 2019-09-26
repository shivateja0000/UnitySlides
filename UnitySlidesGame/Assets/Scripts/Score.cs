using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ((int)Player.position.z).ToString();
        
        
    }
}
