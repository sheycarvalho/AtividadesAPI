﻿using ChapterProject1.Models;
using ChapterProject1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterProject1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository LivroRep)
        {
            _livroRepository = LivroRep;
        }

        [HttpGet]

        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Livro livroBuscado = _livroRepository.BuscarPorId(id);

                if (livroBuscado == null)
                {
                    return NotFound();
                }

                return Ok(livroBuscado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }




        [HttpPost]
        public IActionResult Cadastrar(Livro l)
        {
            try
            {
                _livroRepository.Cadastrar(l);

                return StatusCode(201);
                //return Ok("Livro Cadastrado com sucesso");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return Ok("Livro removido com sucesso");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Livro l)
        {
            try
            {
                _livroRepository.Alterar(id, l);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}


