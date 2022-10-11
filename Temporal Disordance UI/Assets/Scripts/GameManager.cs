using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float sp1 = 0f;
    public float sp2 = 0f   ;
    public float p1health;
    public float p2health;
    public float p1max;
    public float p2max;
    public int rand;





    private void Start()  
    {
        p1health = PlayerPrefs.GetFloat("p1hp");
        p2health = PlayerPrefs.GetFloat("p2hp");
        p1max = PlayerPrefs.GetFloat("p1m");
        p2max = PlayerPrefs.GetFloat("p2m");
        sp1 = PlayerPrefs.GetFloat("csp1");
        sp2 = PlayerPrefs. GetFloat("csp2");
        healthcheck();
    }

    private void Update() 
    {
        PlayerPrefs.SetFloat("p1hn", p1health);
        PlayerPrefs.SetFloat("p2hn", p2health);
        PlayerPrefs.SetFloat("p1max", p1max);
        PlayerPrefs.SetFloat("p2max", p2max);
        PlayerPrefs.SetFloat("p1sp", sp1);
        PlayerPrefs.SetFloat("p2sp", sp2);

    }   

    public void healthcheck()
    {
        if (p1health < 1f)
        {
            SceneManager.LoadScene(25);
        }
        if (p2health < 1f)
        {
            SceneManager.LoadScene(24);
        }
    }

    

    public void p1lowpunch()
    {
        rand = Random.Range(0,100);
        if (rand <= 75) 
        {
        SceneManager.LoadScene(10);
        p2health -= 3f;
        }
        else
        {
        SceneManager.LoadScene(9);
        }
        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p1highpunch()
    {
        int rand = Random.Range(0,100);
        if (rand <= 55) 
        {
        SceneManager.LoadScene(6);
        p2health -= 8f;
        }
        else
        {
        SceneManager.LoadScene(5);
        }

        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p2lowpunch()
    {
        rand = Random.Range(0,100);
        if (rand <= 75) 
        {
        SceneManager.LoadScene(19);
        p1health -= 3f;
        }
        else
        {
        SceneManager.LoadScene(18);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p2highpunch()
    {
        int rand = Random.Range(0,100);
        if (rand <= 55) 
        {
        SceneManager.LoadScene(15);
        p1health -= 8f;
        }
        else
        {
        SceneManager.LoadScene(14);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p1lowKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 65) 
        {
        SceneManager.LoadScene(8);
        p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(7);
        }
        Debug.Log("Player 2 HP: "+ p2health);
    }

    public void p1highKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 45) 
        {
        SceneManager.LoadScene(4);
        p2health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(3);
        }
        Debug.Log("Player 2 HP: "+ p2health);

    }

    public void p2lowKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 65) 
        {
        SceneManager.LoadScene(17);
        p1health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(16);
        }
        Debug.Log("Player 1 HP: "+ p1health);
    }

    public void p2highKick()
    {
        int rand = Random.Range(0,100);
        if (rand <= 45) 
        {
        SceneManager.LoadScene(13);
        p1health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(12);
        }
        Debug.Log("Player 1 HP: "+ p1health);

    }

    public void p1specialattack()
    {
        if(sp1 <= 1f)
        {

        }
        else
        {
        if(p1health <= 30f)
        {

        }
        else
        {
        SceneManager.LoadScene(11);
        p2health -= 25f;
        sp1 += 1f;
        Debug.Log("Player 2 hp: "+ p2health);
        }
        }
    }
        

    public void p2specialattack()
    {   
        if(sp2 <= 1f)
        {

        }
        else
        {
        if(p2health <= 30f)
        {

        }
        else
        {
        SceneManager.LoadScene(20);
        p1health -= 25f;
        sp2 += 1f;
        Debug.Log("Player 1 hp: "+ p1health);
        }
        }
    }   
    
}

