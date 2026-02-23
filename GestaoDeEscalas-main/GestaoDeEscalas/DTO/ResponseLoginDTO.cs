using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeEscalas.DTO
{
    public class ResponseLoginDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
