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
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        balas = Player.GetComponent<WeaponController>().municion;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        UpdateMunicion();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }

    public void AddScore(int newScore){
        score += newScore;
    }

    public void UpdateScore(){
        ScoreText.text = "" + score;
    }

     public void UpdateMunicion(){
        balas = Player.GetComponent<WeaponController>().municion;
        BalasText.text = "" + balas;
    }

}
