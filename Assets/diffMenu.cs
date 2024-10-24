using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diffMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject difficultyMenu;
    private void LaunchGame()
    {
        SceneManager.LoadScene("MainMap");
    }

    // Update is called once per frame
    public void Training()
    {
        LaunchGame();
    }
}
