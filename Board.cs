using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Board
{
    public int Size { get; set; }
    public Cell[,] theGrid { get; }

    public Board(int s)
    {
        Size = s; // set size of 2d array
        theGrid = new Cell[Size, Size];

        //Initialize cells (coordinates) and place them in theGrid, which is a 2d array
        for(int column = 0; column < Size; column++)
        {
            for(int row = 0; row < Size; row++)
            {
                var cell = new Cell(column, row);
                theGrid[column, row] = cell;
            }
        }

        //Defining where a piece can move
        for (int column = 0; column < Size; column++)
        {
            for(int row = 0; row < Size; row++)
            {
                var cell = theGrid[column, row];

                //Top row
                if(row == 0)
                {
                    if(column == s - 1) //Top right
                    {
                        cell.backLeft = theGrid[column - 1, row + 1];
                    }
                    else
                    {
                        cell.backLeft = theGrid[column - 1, row + 1];
                        cell.backRight = theGrid[column + 1, row + 1];
                    }
                }
                //Bottom row
                else if(row == s - 1)
                {
                    if(column == 0)
                    {
                        cell.frontRight = theGrid[column + 1, row - 1];
                    }
                    else
                    {
                        cell.frontleft = theGrid[column - 1, row - 1];
                        cell.frontRight = theGrid[column + 1, row - 1];
                    }
                }
                //Left column

                //Right column

                //Every other piece
            }
        }
    }
}
