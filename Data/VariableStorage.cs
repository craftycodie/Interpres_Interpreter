using System.Collections.Generic;

namespace Interpreter.Data
{
    public class VariableStorage
    {
        public static VariableStorage singleton = new VariableStorage();
        
        private Dictionary<string, object> variables = new Dictionary<string, object>();

        public void WriteVariable(string name, object value)
        {
            variables[name] = value;
        }

        public object GetVariable(string name)
        {
            return variables[name];
        }

    }
}