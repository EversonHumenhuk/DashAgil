using DashAgil.Integrador.Commands.Input;
using DashAgil.Integrador.Commands.Output;
using DashAgil.Integrador.Entidades;
using DashAgil.Integrador.Infra.Comum;
using System.Threading.Tasks;

namespace DashAgil.Integrador.Handlers
{
    public class IntegradorHandler : ICommandHandler<SalvarEstoriaCommand>
    {
        public async Task<ICommandResult> Handle(SalvarEstoriaCommand command)
        {
            var estoria = new Estoria(command.Nome, command.Descricao);

            //salvar
            var result = true;

            await Task.CompletedTask;

            return new IntegradorCommandResult(true, "sucess", result);
        }
    }
}
