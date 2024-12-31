using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    Round round;
    // Start is called before the first frame update
    void Start()
    {
        round.turn = 1;
        round.turnStage = 0;
        round.countryStage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Statetransition() //�׶���ʱ��䶯,��������׶δ�����Ŀǰ��
    {
        if( round.turnStage == TurnStage.ThrowCardStage && round.countryStage != CountryStage.American )
        {
            round.turnStage = 0;
            round.countryStage++;
        }
        else if (round.turnStage == TurnStage.ThrowCardStage && round.countryStage == CountryStage.American )
        {
            round.turnStage = 0;
            round.countryStage = 0;
        }
        else
        {
            round.turnStage++;
        }
    }

    public string returnCurCountryName()    //���ص�ǰ�ж��Ĺ�������
    {
        return round.countryStage.ToString();
    }

    public string returnCurCampName()    //���ص�ǰ�ж�����Ӫ����
    {
        if ( round.countryStage == (CountryStage)0 || round.countryStage == (CountryStage)2 || round.countryStage == (CountryStage)4 )
        {
            return "Axis";
        }
        else
        {
            return "Allies";
        }
    }

}
