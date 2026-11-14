using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaVenda.model;

namespace SistemaVenda.Controller
{
    internal static class Sessao
    {
        // O ? significa que ou eu vou receber algo, ou não vou receber nada
        public static Funcionario? usuarioAutenticado;
        
    }
}
