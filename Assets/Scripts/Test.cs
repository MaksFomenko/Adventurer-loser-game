using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public void NexTLevel(int _sceneNumber)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_sceneNumber);
    }
}
