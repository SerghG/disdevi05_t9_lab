using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text BalasText;
    public int score = 0;
    public int balas;
    public GameObject Player;
    private int winScore = 80;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        balas = Player.GetComponent<WeaponController>().municion;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }

    public void AddScore(int newScore){
        score += newScore;
        UpdateMunicion();
    }

    public void UpdateScore(){
        ScoreText.text = "" + score;
    }

     public void UpdateMunicion(){
        balas = Player.GetComponent<WeaponController>().municion;
        BalasText.text = "" + balas;
        if(balas == 0){
            if(score >= 60){
                ScoreText.text = "WIN";
            } else {
                ScoreText.text = "LOSE";
            }
        }
    }

}
