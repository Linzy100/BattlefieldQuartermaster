using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ö��
public enum country
{
    none = -1,  // û��
    Germany = 0,
    UnitedKingdom = 1,
    Japan = 2,
    Soviet = 3,
    Italy = 4,
    American = 5
}

// ��λ����ö��
public enum unitType
{
    none = -1,  // û��
    Army = 0,   // ½��
    Navy = 1,   // ����
    AirForce = 2 // �վ�
}

// ��λ��
public class Unit
{
    public country unitOfCountry1; // ����1����������
    public unitType curunitType1;  // ����1������
    public country unitOfCountry2; // ����2����������
    public unitType curunitType2;  // ����2������
    public country unitOfCountry3; // ����3����������
    public unitType curunitType3;  // ����3������
    public country unitOfCountry4; // ����4����������
    public unitType curunitType4;  // ����4������
    public country unitOfCountry5; // ����5����������
    public unitType curunitType5;  // ����5������
    public country unitOfCountry6; // ����6����������
    public unitType curunitType6;  // ����6������
}

// ������
public class PlateUnitManager : Singleton<PlateUnitManager>
{
    GameManager gameManager;
    public List<Unit> unit = new List<Unit>(51); // һ����51������

    // ��ʼ�����е����ľ�������
    void Start()
    {
        // ��ʼ��unit�б�ȷ��ÿ�������ľ�����Ϣ������Ϊδ��ʼ��
        for (int i = 0; i < 51; i++)
        {
            if( i == 1)         //����������½��
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.American,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if( i == 6 )       //���е�Ⱥ����Ӣ��½��
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.UnitedKingdom,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if ( i == 15 )  //�ն����ŵ¹�½��
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Germany,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if( i == 16)   //������������½��
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Italy,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if (i == 21 )  //Ī˹�Ʒ�����½��
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Italy,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
            else if (i == 37)           //�ձ����ձ�½��
            {
                unit.Add(new Unit
                {
                    unitOfCountry1 = country.Italy,
                    curunitType1 = unitType.Army,
                    unitOfCountry2 = country.none,
                    curunitType2 = unitType.none,
                    unitOfCountry3 = country.none,
                    curunitType3 = unitType.none,
                    unitOfCountry4 = country.none,
                    curunitType4 = unitType.none,
                    unitOfCountry5 = country.none,
                    curunitType5 = unitType.none,
                    unitOfCountry6 = country.none,
                    curunitType6 = unitType.none
                });
            }
        }
    }

    // ���þ��ӷ���
    public void PlaceUnit(string plateName, int countryId, int unitTypeId)
    {
        // ��ȡ��ǰ��������Ϣ
        plateData p = gameManager.plateMananger.getCurPlateInfo(plateName);

        // ��鵱ǰ�����Ƿ��Ѿ��о���
        if (unit[p.plateId].unitOfCountry1 == country.none)
        {
            unit[p.plateId].unitOfCountry1 = (country)countryId;
            unit[p.plateId].curunitType1 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry2 == country.none)
        {
            unit[p.plateId].unitOfCountry2 = (country)countryId;
            unit[p.plateId].curunitType2 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry3 == country.none)
        {
            unit[p.plateId].unitOfCountry3 = (country)countryId;
            unit[p.plateId].curunitType3 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry4 == country.none)
        {
            unit[p.plateId].unitOfCountry4 = (country)countryId;
            unit[p.plateId].curunitType4 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry5 == country.none)
        {
            unit[p.plateId].unitOfCountry5 = (country)countryId;
            unit[p.plateId].curunitType5 = (unitType)unitTypeId;
        }
        else if (unit[p.plateId].unitOfCountry6 == country.none)
        {
            unit[p.plateId].unitOfCountry6 = (country)countryId;
            unit[p.plateId].curunitType6 = (unitType)unitTypeId;
        }
        else
        {
            Debug.LogError("�õ��������������޷��������ã�");
        }
    }

    public void RemoveUnit(string plateName, int unitIndex)
    {
        plateData p = gameManager.plateMananger.getCurPlateInfo(plateName);
        if (p.plateId < 0 || p.plateId >= unit.Count)
        {
            Debug.LogError($"PlateId {p.plateId} ������Χ��");
            return;
        }

        Unit currentUnit = unit[p.plateId];

        switch (unitIndex)
        {
            case 1:
                currentUnit.unitOfCountry1 = country.none;
                currentUnit.curunitType1 = unitType.none;
                Debug.Log($"���Ƴ����� {plateName} �ľ���1");
                break;
            case 2:
                currentUnit.unitOfCountry2 = country.none;
                currentUnit.curunitType2 = unitType.none;
                Debug.Log($"���Ƴ����� {plateName} �ľ���2");
                break;
            case 3:
                currentUnit.unitOfCountry3 = country.none;
                currentUnit.curunitType3 = unitType.none;
                Debug.Log($"���Ƴ����� {plateName} �ľ���3");
                break;
            case 4:
                currentUnit.unitOfCountry4 = country.none;
                currentUnit.curunitType4 = unitType.none;
                Debug.Log($"���Ƴ����� {plateName} �ľ���4");
                break;
            case 5:
                currentUnit.unitOfCountry5 = country.none;
                currentUnit.curunitType5 = unitType.none;
                Debug.Log($"���Ƴ����� {plateName} �ľ���5");
                break;
            case 6:
                currentUnit.unitOfCountry6 = country.none;
                currentUnit.curunitType6 = unitType.none;
                Debug.Log($"���Ƴ����� {plateName} �ľ���6");
                break;
            default:
                Debug.LogError($"��Ч�ľ��ӱ�� {unitIndex}��ӦΪ1��6��");
                break;
        }
    }
}
