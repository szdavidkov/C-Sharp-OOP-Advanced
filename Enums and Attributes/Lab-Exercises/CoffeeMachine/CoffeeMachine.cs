﻿using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private List<CoffeeType> coffeeSold = new List<CoffeeType>();
    private int coins;

    public IEnumerable<CoffeeType> CoffeesSold => this.coffeeSold;

    public void InsertCoin(string coin)
    {
        Coin rem = (Coin) Enum.Parse(typeof(Coin), coin);
        this.coins += (int) rem;
    }

    public void BuyCoffee(string price, string type)
    {
        CoffeeType coffeeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice coffeePrice = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), price);

        if (this.coins >= (int)coffeePrice)
        {
            this.coffeeSold.Add(coffeeType);
            this.coins = 0;
        }
    }
}

