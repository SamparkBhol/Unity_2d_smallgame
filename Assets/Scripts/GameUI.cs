using UnityEngine;

public class GameUI : MonoBehaviour
{
    public void StartGame()
    {
        LevelManager.instance.LoadLevel("Level1");
    }

    public void ExitGame()
    {
        LevelManager.instance.QuitGame();
    }
}