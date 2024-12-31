using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 分数管理器
public class ScoreManager : Singleton<ScoreManager>
{
    // 各国家的分数
    private Dictionary<string, int> scores = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        // 初始化各国家分数
        scores["Allies"] = 0;
        scores["Axis"] = 0;
        scores["American"] = 0;
        scores["UnitedKingdom"] = 0;
        scores["Soviet"] = 0;
        scores["Japan"] = 0;
        scores["Italy"] = 0;
        scores["Germany"] = 0;
    }

    // 更新分数（加分或扣分）
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

    // 获取某个国家的分数
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

    // 打印所有国家的分数（用于调试）
    public void PrintAllScores()
    {
        foreach (var score in scores)
        {
            Debug.Log($"{score.Key}: {score.Value}");
        }
    }
}