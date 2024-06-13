namespace FluentCalculatorAndSomeBool;

public class FluentCalculator
{
    public Value zero = new(0);
    public Value one = new(1);
    public Value two = new(2);
    public Value three = new(3);
    public Value four = new(4);
    public Value five = new(5);
    public Value six = new(6);
    public Value seven = new(7);
    public Value eight = new(8);
    public Value nine = new(9);
    public Value ten = new(10);

    public class Value
    {
        private readonly int _value;
        private Func<int, int> _operation;

        public Value(int value)
        {
            _value = value;
            _operation = x => x;
        }

        public Value(Func<int, int> operation)
        {
            _value = 0;
            _operation = operation;
        }

        public static implicit operator int(Value value)
        {
            return value._operation(value._value);
        }

        public override string ToString()
        {
            return _operation(_value).ToString();
        }

        public Operation plus => new(x => _operation(_value) + x);
        public Operation minus => new(x => _operation(_value) - x);
        public Operation times => new(x => _operation(_value) * x);
        public DividedByOperation dividedBy => new(x => _operation(_value) / x);
    }

    public class Operation
    {
        protected readonly Func<int, int> _operation;

        public Operation(Func<int, int> operation)
        {
            _operation = operation;
        }

        public Value zero => new(_ => _operation(0));
        public Value one => new (_ => _operation(1));
        public Value two => new (_ => _operation(2));
        public Value three => new (_ => _operation(3));
        public Value four => new (_ => _operation(4));
        public Value five => new (_ => _operation(5));
        public Value six => new (_ => _operation(6));
        public Value seven => new (_ => _operation(7));
        public Value eight => new (_ => _operation(8));
        public Value nine => new (_ => _operation(9));
        public Value ten => new (_ => _operation(10));
    }

    public class DividedByOperation
    {
        protected readonly Func<int, int> _operation;
        public DividedByOperation(Func<int, int> operation) 
        {
            _operation = operation;
        }

        public Value one => new(_ => _operation(1));
        public Value two => new(_ => _operation(2));
        public Value three => new(_ => _operation(3));
        public Value four => new(_ => _operation(4));
        public Value five => new(_ => _operation(5));
        public Value six => new(_ => _operation(6));
        public Value seven => new(_ => _operation(7));
        public Value eight => new(_ => _operation(8));
        public Value nine => new(_ => _operation(9));
        public Value ten => new(_ => _operation(10));
    }
}