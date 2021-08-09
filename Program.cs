using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
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
                {"Conversões- Fundamentos", Conversoes.Executar},
                {"Formatando números- Fundamentos", FormatandoNumero.Executar},
                {"Operadores aritmeticos- Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos- Fundamentos", OperadoresLogicos.Executar},
                {"Operadores unários- Fundamentos", OperadoresUnarios.Executar},
                {"Operador ternário - Fundamentos", OperadorTernario.Executar},

            // Classes e Métodos
                {"Params - Fundamentos", Params.Executar},
            });




            central.SelecionarEExecutar();
        }
    }
}