using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigerPanelPlayer : MonoBehaviour
{
    //[SerializeField] private GameObject[] losePanel = new GameObject[2];
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject losePanel2;
    //[SerializeField] private List<GameObject> losePanel = new List<GameObject>();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "obstacle2")
        {
            losePanel2.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ButtonClick()
    {
        if (Time.timeScale == 0)
        {
            losePanel.SetActive(false);
            losePanel2.SetActive(false);
            Time.timeScale = 1;
        } 
    }
}
