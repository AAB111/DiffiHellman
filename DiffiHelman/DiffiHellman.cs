using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DiffiHelman
{
    internal class DiffiHellman
    {
        EllipCurves curves;
        uint privateKey;
        (BigInteger, BigInteger) P;
        public DiffiHellman(EllipCurves curves, uint privateKey, (BigInteger, BigInteger) P) 
        {
            this.curves = curves;
            this.privateKey = privateKey;
            this.P = P;
        }
        public (BigInteger,BigInteger) GetPartKey()
        {
            return curves.Multi(P, privateKey);
        }
        public (BigInteger,BigInteger) GetFullKey((BigInteger,BigInteger) Q)
        {
            return curves.Multi(Q,privateKey);
        }
    }
}
