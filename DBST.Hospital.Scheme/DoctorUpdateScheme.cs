﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBST.Hospital.Scheme
{
    public class DoctorUpdateScheme : WorkerScheme
    {
        public int IdConsultorio { get; set; }
        public string CedulaProfesional { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public int IdDireccion { get; set; }
    }
}
