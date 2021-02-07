using AutoMapper;
using EnsureThat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.BL.Services;
using UserManagement.Entities;
using UserManagement.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public UsersController(IUsersRepository usersRepository,
                ILogger<UsersController> logger,
                IMapper mapper)
        {
            Ensure.That(logger, nameof(logger)).IsNotNull();
            _logger = logger;

            Ensure.That(usersRepository, nameof(usersRepository)).IsNotNull();
            _usersRepository = usersRepository;

            Ensure.That(mapper, nameof(mapper)).IsNotNull();
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<User>> GetAsync()
        {
            return await _usersRepository.GetUsersAsync();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<bool> PostAsync([FromBody] UserRequest model)
        {
            var mappedUser = _mapper.Map<User>(model);
            _usersRepository.CreateUser(mappedUser);
            return await _usersRepository.SaveChangesAsync();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}