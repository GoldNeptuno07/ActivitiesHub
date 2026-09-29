using EventsHub.Domain;
using EventsHub.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace EventsHub.Api.Controllers;

public class EventsController(AppDbContext context) : EventsHubBaseController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetEventsAsync()
    {
        return context.Activities.ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetEventDetailAsync(string id)
    {
        var activity = await context.Activities.FindAsync(id);
        if (activity == null)
        {
            return NotFound("The activity was not found.");
        }
        return Ok(activity);
    }
}