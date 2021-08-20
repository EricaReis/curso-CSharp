using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.HashGame;

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
                {"Params - Classes e Métodos", Params.Executar},
                {"Params nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Propriedades - Classes e Métodos", Props.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Atributos readonly - Classes e Métodos", Readonly.Executar},
                {"GetSet - Classes e Métodos", GetSet.Executar},
                {"Métodos estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Membros - Classes e Métodos", Membros.Executar},

            // Métodos e Funções
                {"Exemplo lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Usando delegates - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegates com funções anônimas - Métodos e Funções", DelegateFunAnonima.Executar},

            // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

            //HashGame
                {"Jogo da Velha", Hash.Executar},
            });




            central.SelecionarEExecutar();
        }
    }
}