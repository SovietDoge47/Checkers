using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cell
{
	public int RowNumber { get; set; }
    public int ColumnNumber { get; set; }
    public bool OccupiedByWhite { get; set; }
    public bool LegalNextMove { get; set; }
    public bool notOccupied { get; set; }
    public Cell forwardLeft { get; set; }
    public Cell forwardRight { get; set; }
    public Cell backLeft { get; set; }
    public Cell backRight { get; set; }

    public Cell(int column, int row)
    {
        RowNumber = row;
        ColumnNumber = column;
        OccupiedByWhite = false;
        LegalNextMove = false;
        notOccupied = true;
    }

}
