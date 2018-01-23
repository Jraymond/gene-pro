using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Systems_Tester
{
    /// <summary>
    /// Spawning logic for life forms
    /// can be used to spawn all types
    /// </summary>
    class Spawner
    {

        life_form Spawn()
        {
            #region Variables
            life_form new_life = new life_form();
            Random rnd = new Random();
            char[] alliels = new char[4];
            #endregion

            #region Gene list creation
            for (int i = 0; i < 4; i++)
            {
              switch(rnd.Next(0, 3))
              {
                  case 0: alliels[i] = 'a';
                      break;
                  case 1: alliels[i] = 't';
                      break;
                  case 2: alliels[i] = 'c';
                      break;
                  case 3: alliels[i] = 'g';
                      break;
                  default: Console.WriteLine("inital Spawn switch error");
                      break;
              }
            }
            #endregion

            #region Life form init
            new_life.age = 0;
            new_life.is_female = (new Random().Next(0, 1) == 1) ? true : false; // true/false based on random number. % chance to be male can be determined by Max range
            new_life.is_pregnant = false;
            new_life.genes_list.Add(alliels);
            #endregion

           return new_life;
        }

        life_form Spawn(life_form mother, life_form father)
        {
            #region Variables
            life_form new_life = new life_form();
            Random rnd = new Random();

            char[] alliels = new char[4];
            int number_of_alliels = 0;
            char[] mother_alliels;
            char[] father_alliels;
            #endregion


            #region Fetch parent genetics
            foreach (char[] alliel in mother.genes_list)
            {
                number_of_alliels++;
            }

            mother_alliels = mother.genes_list[(rnd.Next(0, number_of_alliels))];
            number_of_alliels = 0;

            foreach(char[] alliel in father.genes_list)
            {
                number_of_alliels++;
            }

            father_alliels = father.genes_list[(rnd.Next(0, number_of_alliels))];
            #endregion

            #region Gene list creation  
            //used to randomize the childs genetics. 
            //the percent chance to get each of the parents alliels can be changed with rnd.Next(0,X) X + 1 being the denominator i.e 1/X+1.
            //so 2 would be 1/3
            for (int i = 0; i < 4; i++)
            {
                if (rnd.Next(0, 1) == 1)
                    alliels[i] = father_alliels[i];
                else
                    alliels[i] = mother_alliels[i];
            }
            #endregion

            #region Life form init
            new_life.age = 0;
            new_life.is_female = (new Random().Next(0, 1) == 1) ? true : false; // true/false based on random number. % chance to be male can be determined by Max range
            new_life.is_pregnant = false;
            new_life.genes_list.Add(alliels);
            #endregion

            return new_life;
        }




    }
}
