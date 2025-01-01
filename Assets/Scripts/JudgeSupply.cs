using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeSupply : Singleton<JudgeSupply>
{
    private int[,] adjacencyMatrix = new int[51, 51];
    public List<plateData> platelist = new List<plateData>();

    private void Start()
    {
        adjacencyMatrix = AdjacencyMatrix.Instance.GetAdjacencyMatrix();
        platelist = PlateManager.Instance.returnAllPlateInfo();
    }


    public List<plateData> SearchSupply()
    {
        List<int> array = new List<int>();
        List<int> start = new List<int>();
        List<int> isLegal = new List<int>();
        List<plateData> returnList = new List<plateData>();

        foreach (plateData plate in platelist)
        {
            if (plate.takeStatuByCountry1.Equals(RoundManager.Instance.returnCurCountryName()) || plate.takeStatuByCountry2.Equals(RoundManager.Instance.returnCurCountryName()) || plate.takeStatuByCountry3.Equals(RoundManager.Instance.returnCurCountryName()))
            {
                array.Add(plate.plateId);
                if (plate.isAxisSupply == true || plate.isAlliesSupply == true)
                {
                    start.Add(plate.plateId);
                }
            }
        }
        foreach (int find in start)
        {
            SearchAround(find, array, isLegal);
        }

        foreach (int returnIndex in isLegal)
        {
            foreach (plateData plate in platelist)
            {
                if (plate.plateId == returnIndex)
                {
                    returnList.Add(plate);
                    break;
                }

            }
        }

        return returnList;
    }

    public bool isSeaPlate(int id)
    {
        if (platelist[id].plateType == "Sea")
            return true;
        else
            return false;
    }

    public bool canInput(int find, int j)
    {//mark
        /*for (int k = 0; k < N; k++)
        {
            //еп╤о
            if (adjacencyMatrix[find, k] > 0 && adjacencyMatrix[j, k] > 0 && platelist[k].plateType.Equals("Land") && platelist[k].takeStatuByCampus.Equals(RoundManager.Instance.returnCurCampName()))
            {
                return true;
            }
        }*/

        return false;
    }

    public void SearchAround(int find, List<int> array, List<int> isLegal)
    {
        List<int> temp = new List<int>();
        bool isOver = false;

        if (isOver == true)
            return;

        for (int j = 0; j < 51; j++)
        {
            if (adjacencyMatrix[find, j] > 0)
            {
                if (isSeaPlate(find) && isSeaPlate(j))
                {
                    if (canInput(find, j))
                        temp.Add(j);
                }
                else
                    temp.Add(j);
            }
        }

        foreach (int v in temp)
        {
            isOver = true;
            if (array.Contains(v) && !isLegal.Contains(v))
            {
                isOver = false;
                isLegal.Add(v);
                array.Remove(v);
                SearchAround(v, array, isLegal);
            }
        }
    }
}
