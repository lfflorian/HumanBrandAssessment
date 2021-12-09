using AutoMapper;
using Database_client.Entities;
using Database_client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService Service;
        private readonly IMapper _mapper;

        public ClientController(IClientService service, IMapper mapper)
        {
            this.Service = service;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);

            try
            {
                client.CreateDate = DateTime.Now;
                await this.Service.Add(client).ConfigureAwait(false);
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);
            }

            return Ok(client);
        }
    }
}
