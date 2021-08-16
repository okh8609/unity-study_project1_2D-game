using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour
{
    // public Text input;
    public int n_bomb;
    public int total;
    public Text score;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        win.gameObject.SetActive(false);
        score.text = "Score: " + n_bomb.ToString() + " / " + total.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int s)
    {
        n_bomb += s;

        score.text = "Score: " + n_bomb.ToString() + " / " + total.ToString();

        if (n_bomb == total)
            win.gameObject.SetActive(true);
    }

    public void AddBomb()
    {
        ++total;

        score.text = "Score: " + n_bomb.ToString() + " / " + total.ToString();
    }
}
