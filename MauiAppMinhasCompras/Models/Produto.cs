﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        double _quantidade, _preco;


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            }
        }
        public double Quantidade
        {
            get => _quantidade;
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Por favor, informe quantidade maior que 0");
                }

                _quantidade = value;
            }
        }
        public double Preco 
        { 
            get => _preco;
            set
            { 
                if(value <= 0) 
                {
                    throw new Exception("Por favor, informe valor maior que R$0.00");
                }
                _preco = value;
            } 
        }

        public double Total { get => Quantidade * Preco; }
    }
}
