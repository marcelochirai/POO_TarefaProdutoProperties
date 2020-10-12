using System;
using System.Collections.Generic;
using System.Text;

namespace POO_TarefaEncapsulamentoProperties
{
    class Produto
    {
        //Definição de variáveis
        private string _nome;
        public double _preco { get; private set; }
        public int _quantidade { get; private set; }

        //Construtores
        public Produto(string nome, double preco,int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Aplicação do Properties - envolvendo GET e SET
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value!=null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

    }
}
