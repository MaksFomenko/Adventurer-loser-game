using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public void NexTLevel(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
