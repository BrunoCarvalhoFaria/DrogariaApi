﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogaria.Application.Interfaces
{
    public interface IUsuarioAutorizacaoService
    {
        string ObterUsuarioLogado();
        bool UsuarioLogadoAdministrador();
    }
}
