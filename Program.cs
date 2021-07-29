using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes- Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia de tipos- Fundamentos", InferenciaDeTipos.Executar},
                {"Interpolacao- Fundamentos", Interpolacao.Executar},
                {"Lendo dados- Fundamentos", LendoDados.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}