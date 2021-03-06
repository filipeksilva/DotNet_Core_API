using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

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
        [Route("")]
        public Cliente Criar([FromBody] Cliente cliente)
        {
            return cliente.Salvar();
        }


        [HttpGet]
        [Route("{id}")]
        public Cliente Atualizar(int id)
        {

            return Cliente.BuscaPorId(id);
        }

        [HttpPut]
        [Route("{id}")]
        public Cliente Atualizar(int id, [FromBody] Cliente cliente)
        {
            cliente.Id = id;
            return cliente.Salvar_Com_SqlConnection();
        }        

        [HttpDelete]
        [Route("{id}")]
        public void Excluir(int id)
        {
            Cliente.Excluir(id);
        }
    }
}
