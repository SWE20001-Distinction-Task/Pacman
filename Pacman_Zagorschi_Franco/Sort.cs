using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Zagorschi_Franco
{
    public class Sort
    {
        //CCL
        //sort the ranking of player score
        public string[,] sortscore(string[,] scores)
        {
            for (int i = 0; i < scores.GetLength(0) - 1; i++)
            {
                for (int j = i; j < scores.GetLength(0); j++)
                {
                    if (int.Parse(scores[i, 1]) < int.Parse(scores[j, 1])) // sort by descending by first index of each row
                    {
                        for (int k = 0; k < scores.GetLength(1); k++)
                        {
                            var temp = scores[i, k];
                            scores[i, k] = scores[j, k];
                            scores[j, k] = temp;
                        }
                    }
                }
            }
            return scores;
        }
    }
}
