using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    // Importa a função nativa do Windows para bloquear a estação
    [DllImport("user32.dll")]
    public static extern bool LockWorkStation();

    static void Main()
    {
        int tempoRestante = 60; // 60 segundos

        Console.Title = "Gerenciador de Logon - Aguardando Bloqueio";

        while (tempoRestante > 0)
        {
            Console.Clear(); // Limpa o console para atualizar o número
            Console.WriteLine("==========================================");
            Console.WriteLine("   SISTEMA INICIADO - AUTO-BLOQUEIO   ");
            Console.WriteLine("==========================================");
            Console.WriteLine($"\nvoltará para tela de bloqueio em: {tempoRestante} segundos...");
            Console.WriteLine("\n [ Mantenha esta janela aberta ]");

            Thread.Sleep(1000); // Espera 1 segundo
            tempoRestante--;
        }

        Console.WriteLine("\nBloqueando agora...");
        LockWorkStation();
    }
}