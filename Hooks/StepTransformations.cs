using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Hooks
{
    [Binding]
    public class StepTransformations
    {
        [StepArgumentTransformation]
        [StepArgumentTransformation]
        public KeyValuePair<string, string> TransformTableToKeyValuePair(Table table)
        {
            var field = table.Rows[0]["Field"];
            var value = table.Rows[0]["Value"];
            return new KeyValuePair<string, string>(field, value);
        }
    }
}
