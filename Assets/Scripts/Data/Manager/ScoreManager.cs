using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����������
public class ScoreManager : Singleton<ScoreManager>
{
    // �����ҵķ���
    private Dictionary<string, int> scores = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        // ��ʼ�������ҷ���
        scores["Allies"] = 0;
        scores["Axis"] = 0;
        scores["American"] = 0;
        scores["UnitedKingdom"] = 0;
        scores["Soviet"] = 0;
        scores["Japan"] = 0;
        scores["Italy"] = 0;
        scores["Germany"] = 0;
    }

    // ���·������ӷֻ�۷֣�
    public void UpdateScore(string country, int scoreChange)
    {
        if (scores.ContainsKey(country))
        {
            scores[country] += scoreChange;
        }
        else
        {
            Debug.LogWarning($"Country '{country}' does not exist in the scores dictionary!");
        }
    }

    // ��ȡĳ�����ҵķ���
    public int GetScore(string country)
    {
        if (scores.ContainsKey(country))
        {
            return scores[country];
        }
        else
        {
            Debug.LogWarning($"Country '{country}' does not exist in the scores dictionary!");
            return 0;
        }
    }

    // ��ӡ���й��ҵķ��������ڵ��ԣ�
    public void PrintAllScores()
    {
        foreach (var score in scores)
        {
            Debug.Log($"{score.Key}: {score.Value}");
        }
    }
}