﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeSeguridad.Datos
{
    interface IUsuarioDAO
    {
        List<Modelo.Usuario> Listar();
        void Insertar(Modelo.Usuario t);
        Modelo.Usuario Consultar(int id);
        void Modificar(Modelo.Usuario t);
        void Eliminar(int id);
        List<Modelo.Vista> ListarVistasDisponibles(int id);
        List<Modelo.Accion> ListarAccionesDisponibles(int idUser, int idVista);
    }
}
