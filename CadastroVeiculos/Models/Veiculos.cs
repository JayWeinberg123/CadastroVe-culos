using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CadastroVeiculos.Models

{

    public class Veiculos
    {
        public int VeiculosId { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

        public string Chassi { get; set; }

        public string Motor { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Combustivel { get; set; }

        public string Cor { get; set; }

        public string Ano { get; set; }

        public string Status { get; set; }




    }






}