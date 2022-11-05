using SudokuVerify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuVerify.Domain.Interfaces.Services
{
    public interface ISudokuCheckedService : IServiceBase<SudokuChecked>
    {
        bool IsSudokuOk(string[] sudoku, int positionRow, int positionCol, int value);
    }
}
