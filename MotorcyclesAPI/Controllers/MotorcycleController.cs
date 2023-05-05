namespace MotorcyclesAPI.Controllers;

using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

[Route("api/[controller]")]
[ApiController]
public class MotorcycleController : ControllerBase
{
    private readonly MotorcycleContext _dbContext;

    public MotorcycleController(MotorcycleContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Motorcycle>>> GetAllMotorcyclesTask()
    {
        return Ok(await _dbContext.Motorcycles.ToListAsync());
    }

    [HttpPost]
    public async Task<ActionResult<List<Motorcycle>>> AddMotorcycleTask(Motorcycle motorcycle)
    {
        _dbContext.Motorcycles.Add(motorcycle);
        await _dbContext.SaveChangesAsync();

        return Ok(await _dbContext.Motorcycles.ToListAsync());
    }

    [HttpPut]
    public async Task<ActionResult<List<Motorcycle>>> UpdateMotorcycleTask(Motorcycle motorcycle)
    {
        // We can actually update only the price
        var motorcycleToUpdate = await _dbContext.Motorcycles.FindAsync(motorcycle.Id);

        if (motorcycleToUpdate is null)
        {
            return BadRequest($"Motorcycle with id: {motorcycle.Id} was not found.");
        }

        motorcycleToUpdate.Price = motorcycle.Price;

        await _dbContext.SaveChangesAsync();

        return Ok(await _dbContext.Motorcycles.ToListAsync());
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Motorcycle>>> DeleteMotorcycleTask(int id)
    {
        var motorcycleToDelete = await _dbContext.Motorcycles.FindAsync(id);

        if (motorcycleToDelete is null)
        {
            return BadRequest($"Motorcycle with id: {id} was not found.");
        }

        _dbContext.Remove(motorcycleToDelete);

        await _dbContext.SaveChangesAsync();

        return Ok(await _dbContext.Motorcycles.ToListAsync());
    }
}