using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSafeScene : MonoBehaviour
{
    public Transform _TransformsSafe;
    void Start()
    {
        if (PlayerPrefs.HasKey("X"))
            _TransformsSafe.position = new Vector3(
                PlayerPrefs.GetFloat("X"),
                _TransformsSafe.position.y,
                _TransformsSafe.position.z);
        if (PlayerPrefs.HasKey("Y"))
            _TransformsSafe.position = new Vector3(
                _TransformsSafe.position.x,
                PlayerPrefs.GetFloat("Y"),
                _TransformsSafe.position.z);
        if (PlayerPrefs.HasKey("Z"))
            _TransformsSafe.position = new Vector3(
                 _TransformsSafe.position.x,
                _TransformsSafe.position.z,
                PlayerPrefs.GetFloat("Z"));
        
        print("Transform: " + _TransformsSafe.position );

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SafeTrnsformPoint();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DeleteSafeTrnsformPoint();
        }
    }

    public void SafeTrnsformPoint()
    {
            PlayerPrefs.SetFloat("X", _TransformsSafe.position.x);
            PlayerPrefs.SetFloat("Y", _TransformsSafe.position.y);
            PlayerPrefs.SetFloat("Z", _TransformsSafe.position.z);
            
            //PlayerPrefs.SetFloat("Safe", _TransformsSafe.position = new Vector3(PlayerPrefs.GetFloat("X"),PlayerPrefs.GetFloat("Y"),PlayerPrefs.GetFloat("Z"));
            
            PlayerPrefs.Save();
            print("===Safe===");
    }
    
    public void DeleteSafeTrnsformPoint()
    {
        PlayerPrefs.DeleteAll();

        print("___Delete___");
    }
}
