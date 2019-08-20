using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services
{
    public class TempTarefaItemService : ITarefaItemService
    {
        public Task<IEnumerable<TarefaItemModel>> GetItemAsync()
        {
            IEnumerable<TarefaItemModel> items = new[]{

                new TarefaItemModel{
                    Name = "Learn ASP.NET Core 2.0",
                    Complete = false,
                    ConclusionDate = DateTime.Now.AddDays(30)

                },
                new TarefaItemModel{
                    Name = "Create Web Applications",
                    Complete = false,
                    ConclusionDate = DateTime.Now.AddDays(50)
                }
            };

            return Task.FromResult(items);
        }   
    }
}