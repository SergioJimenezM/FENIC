﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public enum TipoDocumentoEnum { }
    public class ExoneracionType
    {
        public TipoDocumentoEnum TipoDocumento { get; set; }

    }
}
