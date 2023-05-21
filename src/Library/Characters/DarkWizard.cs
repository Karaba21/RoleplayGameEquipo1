using System;
using System.Collections.Generic;

namespace Library
{
public class DarkWizard : Enemies
{
    public override Daggers item1{get;}
    public  override FireBalls item2 {get;}
    public override  Scythe item3 {get;}
    public DarkWizard (string name)
    {
        Daggers daggers= new Daggers();
        FireBalls fireball= new FireBalls();
        Scythe scythe=new Scythe();
        this.name = name;
        this.health = 1000;
        this.item1 = daggers;
        this.item2 = fireball;
        this.item3 = scythe;
        this.VP = 4;
        this.items.Add(this.item1);
        this.items.Add(this.item2);
        this.items.Add(this.item3);
        
    }
    public void UseDaggers(Enemies enemy) // item1
        {
            if (enemy.totaldefense < this.item1.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item1.damage;
            }
        }
    public void UseFireBalls(Enemies enemy) // item2
        {
            if (enemy.totaldefense < this.item2.damage)
            {
                enemy.health = enemy.health + enemy.totaldefense - this.item2.damage;
            }
        }
    public void UseScythe(Enemies enemy) // item3
    {
        if (enemy.totaldefense < this.item3.damage)
        {
            enemy.health = enemy.health + enemy.totaldefense - this.item3.damage;
        }
    }
}
}