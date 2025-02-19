namespace DesafioProjetoHospedagem.Models
{    
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *Implementado!!!*
            if (Suite.Capacidade >= 2)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *Implementado!!!*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *Implementado!!!*
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *Implementado!!!*
            decimal quantidadeDias = DiasReservados;
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valorFinal = Convert.ToDecimal(quantidadeDias) * valorDiaria;
            decimal valor = Convert.ToDecimal(valorFinal);

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *Implementado!!!*
            if (DiasReservados >= 5)
            {
                double desconto = 0.10 * Convert.ToDouble(valor);
                valor = valor - Convert.ToDecimal(desconto);
            }

            return valor;
        }
    }
}