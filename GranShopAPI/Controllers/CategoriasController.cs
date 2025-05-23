
using GranShopAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace GranShopAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController(AppDbContext db) : ControllerBase
{
    private readonly AppDbContext _db = db;
            
}
