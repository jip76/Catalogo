﻿using Catalogo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.AccesoDatos.Repositorio.IRepositorio
{
    public interface IMarcaRepositorio:IRepositorio<Marca>
    {
        void Actualizar(Marca marca);
       
    }
}
