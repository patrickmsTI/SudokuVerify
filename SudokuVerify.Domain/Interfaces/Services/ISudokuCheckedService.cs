using SudokuVerify.Domain.Entities;

namespace SudokuVerify.Domain.Interfaces.Services
{
    public interface ISudokuCheckedService : IServiceBase<SudokuChecked>
    {
        bool IsSudokuOk(string[] sudoku, int positionRow, int positionCol, int value);
    }
}
