using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
   public void EndGame(){
        if(GameEnded == false){
            GameEnded = true;
            Invoke("Restart",2f);
        }
    
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Credit()
    {
        SceneManager.LoadScene("Credits");

    }

}
