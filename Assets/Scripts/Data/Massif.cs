using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Massif//地块情况
{
    public string MassifType;//板块类型
    public string takeStatuByCountry = null;//被占领情况（国家）
    public bool IfAlliesSupply = false;//是否为同盟国补给点
    public bool IfAxisSupply = false;//是否为轴心国补给点
    public bool IfAlliesScore = false;//是否为同盟国得分点
    public bool IfAxisScore = false;//是否为轴心国得分点
    public bool IfInSupply = false;//是否处于补给状态
    
}
