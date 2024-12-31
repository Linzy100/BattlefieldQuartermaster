using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Plate//地块情况
{
    public int plateId;//板块Id
    public string plateName;//板块名称
    public string plateType;//板块类型
    public string takeStatuByCountry1 = null;//被占领情况（国家）
    public string takeStatuByCountry2 = null;//被占领情况（国家）
    public string takeStatuByCountry3 = null;//被占领情况（国家）
    public string takeStatuByCampus = null;//被占领情况（阵营）
    public bool isAlliesSupply = false;//是否为同盟国补给点
    public bool isAxisSupply = false;//是否为轴心国补给点
    public bool isAlliesScore = false;//是否为同盟国得分点
    public bool isAxisScore = false;//是否为轴心国得分点
    public bool isInSupply = false;//是否处于补给状态

    
    
    

}
