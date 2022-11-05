using SudokuVerify.Domain.Entities;
using SudokuVerify.Domain.Interface.Repository;

namespace SudokuVerify.Infra
{
    public class SudokuCheckedRepository : BaseRepository<SudokuChecked>, ISudokuCheckedRepository
    {
        public SudokuCheckedRepository(BaseContext context) : base(context) { }

    }
}
