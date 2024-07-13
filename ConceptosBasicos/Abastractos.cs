namespace ConceptosBasicos
{
    public class Abastractos
    {
        public abstract class Expression
        {
            public abstract double Evaluate(Dictionary<string, object> vars);
        }

        public class Constant : Expression
        {
            double _value;

            public Constant(double value)
            {
                _value = value;
            }

            public override double Evaluate(Dictionary<string, object> vars)
            {
                return _value;
            }
        }

        public class VariableReference : Expression
        {
            string _name;

            public VariableReference(string name)
            {
                _name = name;
            }

            public override double Evaluate(Dictionary<string, object> vars)
            {
                object value = vars[_name] ?? throw new Exception($"Unknown variable: {_name}");
                return Convert.ToDouble(value);
            }
        }

        public class Operation : Expression
        {
            Expression _left;
            char _op;
            Expression _right;

            public Operation(Expression left, char op, Expression right)
            {
                _left = left;
                _op = op;
                _right = right;
            }

            public override double Evaluate(Dictionary<string, object> vars)
            {
                double x = _left.Evaluate(vars);
                double y = _right.Evaluate(vars);
                switch (_op)
                {
                    case '+': return x + y;
                    case '-': return x - y;
                    case '*': return x * y;
                    case '/': return x / y;

                    default: throw new Exception("Unknown operator");
                }
            }

            /* Expression e = new Operation(
             new VariableReference("x"),
             '+',
             new Constant(3));*/

            Expression e = new Operation(
                new VariableReference("x"),
                '*',
                new Operation(
                new VariableReference("y"),
                '+',
                new Constant(2)));

            //Ejemplos de usos 

            /*Dictionary<string, object> vars = new();
            vars["x"] = 3;
            vars["y"] = 5;
            Console.WriteLine(e.Evaluate(vars)); // "21"
            vars["x"] = 1.5;
            vars["y"] = 9;
            Console.WriteLine(e.Evaluate(vars)); // "16.5"*/
        }
    }
}
