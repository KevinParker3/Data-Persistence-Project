using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public void BackButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
