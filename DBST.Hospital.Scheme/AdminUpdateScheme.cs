﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class AdminUpdateScheme : WorkerScheme
    {
        public string Password { get; set; }
        public string Titulacion { get; set; }
        public int IdDireccion { get; set; }
    }
}
