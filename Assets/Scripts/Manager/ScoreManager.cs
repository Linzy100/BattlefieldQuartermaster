using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public int Score_Allies;
    public int Score_Axis;

    // Start is called before the first frame update
    void Start()
    {
        Score_Allies = 1;
        Score_Axis = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
