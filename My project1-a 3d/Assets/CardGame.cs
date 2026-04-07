using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;


public class CardGame : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    private Card firstCard = null;
    private Card secondCard = null;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartGame();
        //List<int> pairNumbers = GeneratePairNumber(cards.Count);
        //
        //
        //for (int i = 0; i < pairNumbers.Count; i++)
        //{
        //    cards[i].SetCardnumber(pairNumbers[i]);
        //}

        //for (int i = 0; i < cards.Count; i++)
        //{
        //   cards[i].isFront = false;
        //}
    }


    void StartGame()
    {
        List<int> pairNumbers = GeneratePairNumber(cards.Count);

        for (int i = 0; i < pairNumbers.Count; i++)
        {
            cards[i].SetCardnumber(pairNumbers[i]);
        }
        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].isFront = false;
        }

    }
    

    void CheckCard()
    {
        if(firstCard.number == secondCard.number)
        {
            //페어 성공
            firstCard.ChangeColor(Color.red);
            secondCard.ChangeColor(Color.red);

            firstCard.isMatched = true;
            secondCard.isMatched = true;
            
            firstCard = null; secondCard = null;
        }           
        else
        {
            //페어 실패
            Invoke("HideCard", 1.0f);

        }
    }

    public void OnClickCard(Card card)
    {
        if (firstCard == null)
        {
            firstCard = card;
        }
        else
        {
            secondCard = card;
        }
        
        if (firstCard != null && secondCard != null)
        {
            CheckCard();
        }
    }

    void HideCard()
    {
        firstCard.isFront = false;
        secondCard.isFront = false;

        firstCard = null;
        secondCard = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //페어 넘버의 알고리즘
    List<int> GeneratePairNumber(int cardCount)
    {
        //8
        int pairCount = cardCount / 2;

        List<int> newCardNumbers = new List<int>();

        for(int i = 0; i < pairCount; i++)
        {
            newCardNumbers.Add(i);
            newCardNumbers.Add(i);
        }
        //[0][0][1][1][2][2][3][3]

        //셔플
        for (int i = newCardNumbers.Count -1; i > 0; i--)
        {
            int rnd = Random.Range(0, i + 1);
            int temp = newCardNumbers[i];
            newCardNumbers[i] = newCardNumbers[rnd];
            newCardNumbers[rnd] = temp;
        }
        return newCardNumbers;
        //for(int i = 0; i < cardCount; i++)
        //{
        //    int temp = newCardNumbers[i];
        //
        //    int randomindex = Random.Range(0, cardCount - 1);
        //    newCardNumbers[i] = newCardNumbers[randomindex];
        //    newCardNumbers[randomindex] = randomindex;
        //
        //}




    }
}
