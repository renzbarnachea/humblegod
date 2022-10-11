using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer2 : MonoBehaviour
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
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(2);
        Destroy(scenetimer.gameObject);
    }
}
