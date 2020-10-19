﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.lexer.tokens.bitwise
{
    class LeftShiftOperator : AbstractOperator
    {
        public override string ToString()
        {
            return "<<";
        }

        public override ValueToken Operate(params ValueToken[] values)
        {
            if (!values[0].IsNumeric() || values[0].IsFloat())
                throw new ArgumentException($"Can't perform ${ToString()} operation on a {values[0].Value.GetType()}");

            if (!values[1].IsNumeric() || values[1].IsFloat())
                throw new ArgumentException($"Can't perform ${ToString()} operation by a {values[1].Value.GetType()}");


            dynamic l = values[0].Value;
            dynamic r = values[1].Value;

            return new ValueToken(l << r);

        }
    }
}
