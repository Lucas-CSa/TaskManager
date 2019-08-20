using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tarefas.Services;
using Tarefas.Models;


namespace Tarefas.Controllers{
    public class TarefasController : Controller{
        //lista de Tarefas
        ITarefaItemService _tarefaService;
        public TarefasController(ITarefaItemService tarefaService){
            _tarefaService = tarefaService;
        }

        public async Task<IActionResult> Index(){
        //Get Data  
        var tarefas = await _tarefaService.GetItemAsync();

        var model = new TarefaViewModel();
        {
            model.TarefaItens = tarefas;
        }
         return View(model);

        }

    }
}