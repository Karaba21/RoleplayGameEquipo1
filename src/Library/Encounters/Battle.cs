using System;
using System.Collections.Generic;

namespace Library
{
    public class Battle
    {
        public static void DoEncounter(List<Heroes> heroes, List<Enemies> enemies, out int rounds, out string victors)
        {
            rounds = 0;
            victors = "";

            // En hero.VP guardo los puntos de victoria de cada heroe antes de comenzar el encuentro
            // En hero.VPposEncounter voy aumentando segun cuantos enemigos mate el heroe
            foreach (Heroes hero in heroes)
            {
                hero.VPpreEncounter = hero.VP;
            }

            int heroCount = heroes.Count;
            int enemyCount = enemies.Count;
            while (enemyCount != 0 && heroCount != 0)
            {
                rounds ++;

                if (rounds % 2 != 0)
                {
                    // Atacan los villanos en las rondas impares (primero)
                    if (heroCount < enemyCount)
                    {
                        // Cuando hay menos heroes que enemigos, van a haber enemigos que le peguen al mismo heroe
                        int y = 0;
                        for (int x = 0; x < enemyCount; x++)
                        {
                            if (y == heroCount)
                            {
                                // Cuando y llega a la cantidad de heroes la volvemos a 0
                                // De esta forma, el enemigo heroCount + 1 ataca al primer heroe
                                y = y - heroCount;
                            }

                            enemies[x].UseAllStrength(heroes[y]);
                            y = y + 1;
                        }
                    }
                    else // (heroCount == enemyCount) || (heroCount > enemyCount)
                    {
                        // Como cada enemigo puede atacar unicamente a un heroe por ronda,
                        // el codigo es el mismo si la batalla es 1vs1 o si hay menos enemigos que heroes
                        for (int x = 0; x < enemyCount; x++)
                        {
                            enemies[x].UseAllStrength(heroes[x]);
                        }
                    }

                    // Reordeno la lista de heroes para que, en la siguiente ronda, los enemigos tengan nuevos oponentes
                    Heroes lastHero = heroes[heroCount - 1];
                    heroes.Remove(lastHero);
                    heroes.Insert(0, lastHero);
                }

                if (rounds % 2 == 0)
                {
                    // Atacan los heroes en las rondas pares
                    foreach (Heroes hero in heroes)
                    {
                        // Cada heroe ataca a todos los enemigos
                        foreach (Enemies enemy in enemies)
                        {
                            hero.UseAllStrength(enemy);
                        }
                    }
                }

                // En esta nueva lista voy a agregar los heroes sobrevivientes de cada ronda
                List<Heroes> newHeroes = new List<Heroes>();
                foreach (Heroes hero in heroes)
                {
                    if (hero.health > 0)
                    {
                        newHeroes.Add(hero);
                    }
                }
                // La lista de los sobrevivientes pasará a ser la nueva lista de competidores
                heroes = newHeroes;
                
                // En esta nueva lista voy a agregar los enemigos sobrevivientes de cada ronda
                List<Enemies> newEnemies = new List<Enemies>();
                foreach (Enemies enemy in enemies)
                {
                    // Saco de la lista de competidores a los enemigos que murieron
                    if (enemy.health > 0)
                    {
                        newEnemies.Add(enemy);
                    }
                }
                // La lista de los sobrevivientes pasará a ser la nueva lista de competidores
                enemies = newEnemies;

                // Vuelvo a settear estos valores, ya que las listas han sido modificadas
                heroCount = heroes.Count;
                enemyCount = enemies.Count;
            }


            // Mensaje que informa quienes han sido los vencedores del encuentro
            if (enemies.Count == 0)
            {
                victors = "The heroes have won!!";
            }
            if (heroes.Count == 0)
            {
                victors = "The heroes have lost :(";
            }

            // Una vez finalizado el encuentro, le restauro la vida a los heroes que obtuvieron 5 o mas VP
            foreach (Heroes hero in heroes)
            {
                if (hero.VP - hero.VPpreEncounter >= 5)
                {
                    hero.RestoreHealth();
                }
            }
        }
    }
}