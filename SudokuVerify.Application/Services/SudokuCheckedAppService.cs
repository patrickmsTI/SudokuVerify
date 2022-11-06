using SudokuVerify.Application.Interfaces;
using SudokuVerify.Domain.Entities;
using SudokuVerify.Domain.Interfaces.Services;

namespace SudokuVerify.Application.Services
{
    public class SudokuCheckedAppService : AppServiceBase<SudokuChecked>, ISudokuCheckedAppService
    {
        private readonly ISudokuCheckedService _service;

        public SudokuCheckedAppService(ISudokuCheckedService sudokuCheckedService) : base(sudokuCheckedService)
        {
            _service = sudokuCheckedService;
        }

        public bool IsSudokuOk(string[] sudoku, int positionRow, int positionCol, int value)
        {
            return _service.IsSudokuOk(sudoku, positionRow, positionCol, value);
        }
    }
}
