using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void DelayLoadScene()
    {
        Invoke("LoadScene", 1.5f);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Ãö¥d1");
    }

    public void DalayQuitGame()
    {
        Invoke("QuitGame", 1.5f);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
