using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class sethealth : MonoBehaviour
{

    public GameObject sethealthbutt;
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public void setHP100()
    {
        PlayerPrefs.SetFloat("p1hp", 100f);
        PlayerPrefs.SetFloat("p2hp", 100f);
        PlayerPrefs.SetFloat("p1m", 100f);
        PlayerPrefs.SetFloat("p2m", 100f);
        Debug.Log("Players set Health to 100");
    }

    public void setHP50()
    {
        PlayerPrefs.SetFloat("p1hp", 50f);
        PlayerPrefs.SetFloat("p2hp", 50f);
        PlayerPrefs.SetFloat("p1m", 50f);
        PlayerPrefs.SetFloat("p2m", 50f);
        Debug.Log("Players set Health to 50");
    }

    public void saveButtonName()
    {
    PlayerPrefs.SetString("p1sn", inputField1.text);
    PlayerPrefs.SetString("p2sn", inputField2.text);
    }



}
