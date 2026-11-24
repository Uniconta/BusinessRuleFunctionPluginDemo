using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniconta.ClientTools.BusinessRules;

namespace Plugin.Uniconta.BusinessRuleDemo
{
    public class HelloWorld : BusinessRuleFunctionBase
    {
        public override object Evaluate(object[] operands)
        {
            const string message = "Hello, world!";
            ShowMessage(message);
            return message;
        }

        public override Type GetResultType(Type[] operands)
            => typeof(string);

        protected override FunctionDocumentation GetDocumentation()
            => new FunctionDocumentation(nameof(HelloWorld))
            {
                FunctionDescription = "Logs and returns Hello, world!",
                Example = "HelloWorld()"
            };
    }
}
