using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class BranchTypeRepository(DataContext context) : BaseRepository<BranchTypeEntity>(context), IBranchTypeRepository
{

}