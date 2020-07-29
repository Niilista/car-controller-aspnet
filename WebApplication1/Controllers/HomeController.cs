using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteValidacaoSoftware.Models;
using TesteValidacaoSoftware.DAL;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis;

namespace TesteValidacaoSoftware.Controllers
{
    public class HomeController : Controller
    {
        private readonly Contexto db;

        public HomeController(Contexto context) {
            db = context;
        }

        public IActionResult Index() {
            return View();
        }
        public IActionResult Register() {
            return View();
        }


        public IActionResult RegisterCar() {
            return View();
        }
        public IActionResult ShowRegisters() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult CadastrarPessoa(string cpf, string nome) {

            if (db.Pessoas.Where(x => x.CPF == cpf).ToList().Count() > 0) {
                return Json("CPF já cadastrado");
            }
            else {
                var pessoa = new Pessoa {
                    CPF = cpf,
                    Name = nome
                };
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return Json("ok");
            }
        }

        public IActionResult CadastrarCarro(string placa, string modelo, string marca, string cpf) {

            if (db.Pessoas.Where(x => x.CPF == cpf).ToList().Count() > 0) {

                var carro = new Carro {
                    Placa = placa,
                    Modelo = modelo,
                    Marca = marca,
                    Proprietario = cpf
                };

                db.Carros.Add(carro);
                db.SaveChanges();

                return Json("ok");
            }
            else {
                return Json("Erorororororoor");
            }
        }

        public IActionResult GetDocumentos() {
            var result = new List<RegistroViewModel>();
            var data = db.Carros.ToList();
            foreach (var reg in data) {
                var documento = new RegistroViewModel {
                    CPF = reg.Proprietario,
                    Nome = db.Pessoas.Where(x => x.CPF == reg.Proprietario).Select(x => x.Name).FirstOrDefault().ToString(),
                    Placa = reg.Placa,
                    Modelo = reg.Modelo,
                    Marca = reg.Marca
                };
                result.Add(documento);
            }
            return Json(result);
        }









    }
}
