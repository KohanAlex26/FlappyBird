using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHighScore : MonoBehaviour
{
    //public static int hs = 0;
    // Start is called before the first frame update
    //public static int GetHighScore()
    //{
    //    return PlayerPrefs.GetInt("highscore");
    //}
    //public void Start()
    //{
    //    PlayerPrefs.SetInt("highscore", 0);
    //    PlayerPrefs.Save();
    //    Debug.Log(PlayerPrefs.GetInt("highscore"));
    //}
    private void Update()
    {
        if (Score.score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", Score.score);
            PlayerPrefs.Save();
        }
        GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("highscore").ToString();
    }
    

    // Update is called once per frame
    //void Update()
    //{
    //    if (Score.score > hs)
    //        hs = Score.score;
    //    GetComponent<TMPro.TextMeshProUGUI>().text = hs.ToString();
    //}
}
