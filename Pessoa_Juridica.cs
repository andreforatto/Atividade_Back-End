namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float v) // o 'override' acontece pq o método está sendo reescrito (está sendo usado o mesmo nome)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;            
        }
    }
}