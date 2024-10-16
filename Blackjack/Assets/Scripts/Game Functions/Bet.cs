using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{

    double currentMoney;
    double betAmount;
    public PlayerData data;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void makeBet()
    {
        currentMoney = data.getMoney();
        if (betAmount > currentMoney)
        {
            Debug.Log("Too high of bet");
            return;
        }
        currentMoney = currentMoney - betAmount;
        Debug.Log("Bet is " + betAmount);
        Debug.Log("Player money is " + currentMoney);
        return;
    }

    public void ReadStringInput(string s)
    {
        betAmount = double.Parse(s);
        Debug.Log("New betAmount is " + betAmount);
    }

}