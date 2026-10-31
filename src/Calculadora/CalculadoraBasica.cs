namespace Calculadora
{
    public class CalculadoraBasica
    {
        public decimal Calcular(Operacao op, decimal n1, decimal n2)
        {
            switch (op)
            {
                case (Operacao.Somar):
                    return Somar(n1, n2);
                case (Operacao.Dividir):
                    return Dividir(n1, n2);
                case (Operacao.Multiplicar):
                    return Multiplicar(n1, n2);
                case (Operacao.Subtrair):
                    return Subtrair(n1, n2);
                default:
                        throw new ArgumentOutOfRangeException(nameof(op),"A operação inserida não é reconhecida");
            }
        }

        public decimal Somar (decimal n1,decimal n2)
        {
            return n1 + n2;
        }

        public decimal Dividir(decimal n1, decimal n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException("O denominador não pode ser zero!!!");
            
            return n1 / n2;
        }

        public decimal Multiplicar(decimal n1,decimal n2)
        {
            return n1 * n2;
        }

        public decimal Subtrair(decimal n1,decimal n2)
        {
            return n1 - n2;
        }
    }
}
