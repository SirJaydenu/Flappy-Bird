using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;
    public static int ScoreNum;
    //private Movement num;
    // Start is called before the first frame update
    void Start()
    {
        //num = player.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreNum.ToString();
    }
}
