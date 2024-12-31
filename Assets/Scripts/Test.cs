using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private CardData cardDatas;
    private void Start()
    {
        read();
    }
    public void read()
    {
        cardDatas = Resources.Load<CardData>("New Card Data");

        Card card = GetCard(5102);
        Debug.Log(card.cardName);
        //cardDatas.PrintInfo();
    }

    public Card GetCard(int id)
    {
        for (int i = 0; i < cardDatas.cards.Count; i++)
        {
            if (cardDatas.cards[i].id == id)
            {
                return  cardDatas.cards[i];
            }

        }
        return null;

    }
}
