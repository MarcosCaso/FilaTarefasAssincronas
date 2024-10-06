using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Quantidade de tarefas a serem processadas
        int numTarefas = 10;

        // Array para armazenar as tarefas
        Task[] tarefas = new Task[numTarefas];

        Random random = new Random();

        // Criar as tarefas de forma assíncrona
        for (int i = 0; i < numTarefas; i++)
        {
            int taskId = i + 1; // ID da tarefa
            tarefas[i] = ProcessarTarefaAsync(taskId, random);
        }

        // Aguardar todas as tarefas serem concluídas
        await Task.WhenAll(tarefas);

        Console.WriteLine("Todas as tarefas foram processadas.");
    }

    // Método para simular o processamento da tarefa
    static async Task ProcessarTarefaAsync(int taskId, Random random)
    {
        // Gerar um tempo de espera aleatório entre 1 e 5 segundos
        int tempoEspera = random.Next(1000, 5001);

        // Simular a espera
        await Task.Delay(tempoEspera);

        // Imprimir no console o ID da tarefa e o tempo de execução
        Console.WriteLine($"Tarefa {taskId} foi processada em {tempoEspera / 1000.0} segundos.");
    }
}
