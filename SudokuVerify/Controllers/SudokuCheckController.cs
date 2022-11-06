using Microsoft.AspNetCore.Mvc;
using SudokuVerify.Application.Interfaces;

namespace SudokuVerify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SudokuCheckController : ControllerBase
    {
        private readonly ISudokuCheckedAppService _sudokuCheckedApp;

        public SudokuCheckController(ISudokuCheckedAppService sudokuCheckedApp)
        {
            _sudokuCheckedApp = sudokuCheckedApp;
        }

        [HttpPost]
        public virtual IActionResult IsSudokuOk(string[] sudoku, int positionRow, int positionCol, int value)
        {
            try
            {
                if (_sudokuCheckedApp.IsSudokuOk(sudoku, positionRow, positionCol, value))
                    return Ok();
                else
                    return StatusCode(403);
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
