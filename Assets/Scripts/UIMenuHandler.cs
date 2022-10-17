using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMenuHandler : MonoBehaviour
{
    public Text highScoreText;

    private void Awake()
    {
        highScoreText.text = "Best Score : " + GameManager.Instance.highScorePlayerName + " " + GameManager.Instance.currentHighScore;
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButtonClicked()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void PlayerNameChanged(string value)
    {
        GameManager.Instance.playerName = value;
    }
}