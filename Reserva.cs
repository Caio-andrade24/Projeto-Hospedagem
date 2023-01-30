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
           
            if (hospedes . Count  <=  Suite . Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                 Console.WriteLine(( " A suíte selecionada não tem capacidade para volume de hóspedes " )); 
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            return Hospedes . Count ;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = 0;
            valor  =  DiasReservados  *  Suite . ValorDiaria ;
            int  desconto  =  0 ;

           
            if ( DiasReservados  >=  10 )
            {
                desconto  = ( int )( valor  *  10  /  100 );
                valor -=  desconto;
            }

            return valor;
        }
    }
}