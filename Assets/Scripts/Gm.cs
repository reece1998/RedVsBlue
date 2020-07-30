using UnityEngine;
using UnityEngine.SceneManagement;
public class Gm : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delay = 1f;
    public GameObject completelevelUI;

    public void levelComplete ()
    {
            completelevelUI.SetActive(true);
    }


    public void EndGame ()
    {
        if(gameHasEnded == false){
        Debug.Log("GAME OVER");
        gameHasEnded = true;
        Invoke("Restart", delay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
