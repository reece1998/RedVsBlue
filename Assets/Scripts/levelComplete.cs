using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
public void loadnextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

}
}
