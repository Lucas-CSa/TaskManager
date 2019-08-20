
namespace Tarefas.Models{

    public class TarefaItemModel{
        public System.Guid Id { get; set; }

        public bool Complete { get; set; }

        public string Name { get; set; }

        public System.DateTimeOffset? ConclusionDate { get; set; }
    }
}   