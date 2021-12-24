using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Microsoft.AspNetCore.Cors;

namespace DotNet_Core_API.Controllers
{
    [Route("clientes")]
    [ApiController]
    [EnableCors("PermitirApiRequest")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        [Route("lista")]
        [Route("")]
        public List<Cliente> Index()
        {
            return Cliente.Todos();
        }

        [HttpPost]
        [Route("criar")]
        public Cliente Criar([FromBody] Cliente cliente)
        {
            return cliente.Salvar();
        }

        [HttpPut]
        [Route("{id}")]
        public Cliente Atualizar(int id, [FromBody] Cliente cliente)
        {
            cliente.Id = id;
            return cliente.Salvar();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Excluir(int id)
        {
         Cliente.Excluir(id);
        }
    }
}
