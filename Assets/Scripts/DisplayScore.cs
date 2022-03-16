using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    public static int s;
    void Update()
    {
        s = Score.score;
        GetComponent<TMPro.TextMeshProUGUI>().text = s.ToString();
    }

}
