using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : Singleton<RoundManager>
{
    public Round round;
    // Start is called before the first frame update
    void Start()
    {
        round= new Round();
        round.turn = 1;
        round.turnStage = 0;
        round.countryStage = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Statetransition() //阶段随时间变动
    {
        if (round.turnStage == TurnStage.ThrowCardStage && round.countryStage != CountryStage.American)
        {
            round.turnStage = 0;
            round.countryStage++;
        }
        else if (round.turnStage == TurnStage.ThrowCardStage && round.countryStage == CountryStage.American)
        {
            round.turnStage = 0;
            round.countryStage = 0;
        }
        else
        {
            round.turnStage++;
        }
    }

}
