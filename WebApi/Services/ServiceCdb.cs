﻿using WebApi.Dto;
using WebApi.Extensions;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ServiceCdb : IServiceCdb
    {
        public ServiceCdb() { }

        public SimulacaoResponseDto SimularCdb(SimulacaoRequestDto request)
        {
            Cdb novaAplicacao = request.DtoToModel();

            novaAplicacao.CalcularRendimento();
            novaAplicacao.Arrendondar();

            return novaAplicacao.ModelToDto();
        }

    }
}
