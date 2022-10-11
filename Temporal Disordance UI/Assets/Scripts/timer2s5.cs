using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer2s5 : MonoBehaviour
{
    public GameObject scenetimer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(changescenetime());
    }

    IEnumerator changescenetime()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(2);
        Destroy(scenetimer.gameObject);
    }
}
