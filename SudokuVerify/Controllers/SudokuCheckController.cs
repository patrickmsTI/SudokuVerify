using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SudokuVerify.Domain.Interfaces.Services;
using System.Net;

namespace SudokuVerify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SudokuCheckController : ControllerBase
    {
        private readonly ISudokuCheckedService _sudokuCheckedService;

        public SudokuCheckController(ISudokuCheckedService sudokuCheckedService)
        {
            _sudokuCheckedService = sudokuCheckedService;
        }

        [HttpPost]
        public virtual IActionResult IsSudokuOk(string[] sudoku, int positionRow, int positionCol, int value)
        {
            try
            {
                if (_sudokuCheckedService.IsSudokuOk(sudoku, positionRow, positionCol, value))
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
