using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
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
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
        Destroy(scenetimer.gameObject);
    }
}
