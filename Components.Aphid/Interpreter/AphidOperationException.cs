﻿using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidOperationException : AphidRuntimeException
    {
        public AphidOperationException(
            AphidExpression currentStatement,
            AphidExpression currentExpression, 
            string op)
            : base(currentStatement, currentExpression, "Cannot perform {0} operation on null.", op)
        {
        }
    }
}
