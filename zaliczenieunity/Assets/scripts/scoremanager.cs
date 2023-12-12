using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;
    public Text Scoretext;

    int score = 0;
    //automatyczne uruchomienie skryptu
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Scoretext.text = score.ToString() + " Points";
    }
    public void AddPoint(int points)
    {
        score += points;
        Scoretext.text = score.ToString() + " Points";
    }
}
