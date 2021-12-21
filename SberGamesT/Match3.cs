using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SberGamesT
{
    public class Match3
    {
//Так как посыл был не гуглить стандартные подходы к решению этой задачи, то вот что получилось:
//краткий алгоритм: идем по элементам и проверяем последовательность.
//Если последовательность состоит из одного типа элементов и это не 0, то ход возможен
//Если в последовательности только два типа элементов и один из них в единственном экземпляре,
// то проверяем можем ли это элемент поменять на тот тип, которого больше. Если да, то ход возможен.
//так же накидал юнит тестов
        public bool IsMovePosible(int?[,] matrixInput)
        {
            int[,] matrix = TransformMatrix(matrixInput);//change null на int 0
            int COUNT_OF_ELEMENTS = 3;
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            for ( int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //Vertical check
                    if ( i + COUNT_OF_ELEMENTS <= rows)
                    {
                        if (CanMatchSequence(matrix, i, j, Axis.Vertical, COUNT_OF_ELEMENTS, rows, columns))
                        {
                            return true;
                        }                       
                    }
                    //Horizontal check
                    if ( j + COUNT_OF_ELEMENTS <= columns)
                    {
                        if (CanMatchSequence(matrix, i, j, Axis.Horizontal, COUNT_OF_ELEMENTS, rows, columns))
                        {
                            return true;
                        }
                    }                   
                }
            }
            return false;
        }

        private bool IsChangeableValue(int[,] matrix, int requiredValue, Axis axis, int startIndexX, int startIndexY, int rowsCount, int columnsCount)
        {
            switch (axis)
            {
                case Axis.Horizontal:
                    if(columnsCount  > startIndexX + 1)
                    {
                        if(requiredValue == matrix[startIndexX + 1, startIndexY])
                        {
                            return true;
                        }
                    }
                    if(0 <= startIndexX - 1)
                    {
                        if(requiredValue == matrix[startIndexX - 1, startIndexY])
                        {
                            return true;
                        }
                    }                    
                    break;

                case Axis.Vertical:
                    if (rowsCount > startIndexY + 1)
                    {
                        if (requiredValue == matrix[startIndexX, startIndexY + 1])
                        {
                            return true;
                        }
                    }
                    if (0 <= startIndexY - 1)
                    {
                        if (requiredValue == matrix[startIndexX, startIndexY - 1])
                        {
                            return true;
                        }
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }

        private bool CanMatchSequence(int [,] matrix, int startIndexX, int startIndexY, Axis axis, int COUNT_OF_ELEMENTS, int rows, int columns)
        {
            int value1 = matrix[startIndexX, startIndexY];
            int value2 = -1;
            int value1Count = 0;
            int value2Count = 0;
            int mutableValue;
            int requiredValue;
            int stepX = 0;
            int stepY = 0;
            switch (axis)
            {
                case Axis.Horizontal:
                    stepY = 1;
                    break;
                case Axis.Vertical:
                    stepX = 1;
                    break;
                default:
                    return false;
            }
            //check count of variables in  Sequence                   
            for (int l = 0; l < COUNT_OF_ELEMENTS; l++)
            {
                if (value1 == matrix[startIndexX + l*stepX, startIndexY + l * stepY])
                {
                    value1Count++;
                }
                else if (value2 == -1)
                {
                    value2 = matrix[startIndexX + l * stepX, startIndexY + l * stepY];
                    value2Count++;
                }
                else if(value2 == matrix[startIndexX + l * stepX, startIndexY + l * stepY])
                {
                    value2Count++;
                }
                else
                {
                    return false; //if in Sequence more than 2 elements
                }
            }
            ////
            ///
            if (value1Count == COUNT_OF_ELEMENTS && value1 != 0)
            {
                return true;
            }
            else if(value1Count == 1)
            {
                mutableValue = value1;
                requiredValue = value2;
            }
            else if (value2Count == 1)
            {
                mutableValue = value2;
                requiredValue = value1;
            }
            else
            {
                return false;
            }
            if(requiredValue == 0)
            {
                return false;
            }
            for (int l = 0; l < COUNT_OF_ELEMENTS; l++)
            {
                if(mutableValue == matrix[startIndexX + l * stepX, startIndexY + l * stepY])
                {
                    return IsChangeableValue(matrix, requiredValue, axis, startIndexX + l * stepX, startIndexY + l * stepY, rows, columns);
                }
            }
            return false;    
        }

        private int[,] TransformMatrix(int?[,] matrixInput)
        {
            int rows = matrixInput.GetUpperBound(0) + 1;
            int columns = matrixInput.GetUpperBound(1) + 1;
            int[,] matrixOutput = new int[rows, columns]; 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixOutput[i, j] = matrixInput[i, j].GetValueOrDefault(0);
                }
            }
            return matrixOutput;
        }

        private enum Axis
        {
            Vertical,
            Horizontal
        }
    }
}
