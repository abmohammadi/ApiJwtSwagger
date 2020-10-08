using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiJwtSwagger.Setting
{
    public class JwtTokenInfo
    {
        public string Key = "Your insert your key here Your insert your key here";
        public string Issuer = "http://dpSirang.ir";
        public string Audience = "http://dpSirang.ir";
        public int ExpireDays = 5;
    }
}
