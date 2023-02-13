using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager_1.Server.Data;
using TaskManager_1.Server.IRepository;
using TaskManager_1.Shared.Domain;

namespace TaskManager_1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTasksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserTasksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/UserTasks
        [HttpGet]
        public async Task<IActionResult> GetUserTasks()
        {
            var UserTasks = await _unitOfWork.UserTasks.GetAll();
            return Ok(UserTasks);
        }

        // GET: api/UserTasks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserTask(int id)
        {
            var UserTask = await _unitOfWork.UserTasks.Get(q => q.Id == id);

            if (UserTask == null)
            {
                return NotFound();
            }

            return Ok(UserTask);
        }

        // PUT: api/UserTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserTask(int id, UserTask userTask)
        {
            if (id != userTask.Id)
            {
                return BadRequest();
            }

            //_context.Entry(instrument).State = EntityState.Modified;
            _unitOfWork.UserTasks.Update(userTask);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserTaskExistsAsync(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserTask>> PostUserTask(UserTask userTask)
        {
            await _unitOfWork.UserTasks.Insert(userTask);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetUserTask", new { id = userTask.Id }, userTask);
        }

        // DELETE: api/UserTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserTask(int id)
        {
            var userTask = await _unitOfWork.UserTasks.Get(q => q.Id == id);
            if (userTask == null)
            {
                return NotFound();
            }

            await _unitOfWork.UserTasks.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> UserTaskExistsAsync(int id)
        {
            var UserTask = await _unitOfWork.UserTasks.Get(q => q.Id == id);
            return UserTask != null;
        }
    }
}
