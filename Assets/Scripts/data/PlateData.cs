using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class PlateData : ScriptableObject
{
    [SerializeField]
    public List<plateData> plateDatas;
}

[Serializable]
public class plateData
{
    [field: SerializeField]
    public int plateId { get; private set; }

    [field: SerializeField]
    public string plateName { get; private set; }

    [field: SerializeField]
    public string plateType { get; private set; }

    [field: SerializeField]
    public string takeStatuByCountry1 { get; set; }

    [field: SerializeField]
    public string takeStatuByCountry2 { get; set; }

    [field: SerializeField]
    public string takeStatuByCountry3 { get; set; }

    [field: SerializeField]
    public string takeStatuByCampus { get; set; }

    [field: SerializeField]
    public bool isAlliesSupply { get; set; }

    [field: SerializeField]
    public bool isAxisSupply { get; set; }

    [field: SerializeField]
    public bool isAlliesScore { get; set; }

    [field: SerializeField]
    public bool isAxisScore { get; set; }

    [field: SerializeField]
    public bool isInSupply { get; set; }

}
