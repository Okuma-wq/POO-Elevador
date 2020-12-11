using System;

namespace POO_Elevador.Classes
{
    public class Elevador
    {
        private int maxCapacidade;
        public int MaxCapacidade
        {
            get{return maxCapacidade;}
            set{maxCapacidade = value;}
        }
        private int totalDeAndares;
        public int TotalDeAndares
        {
            get{return totalDeAndares;}
            set{totalDeAndares = value;}
        }

        private int andarAtual = 0;
        public int AndarAtual
        {
            get{return andarAtual;}
            set{andarAtual = value;}
        }
        private int capAtual = 0;
        public int CapAtual
        {
            get{return capAtual;}
            set{capAtual = value;}
        }

        public void Inicializar()
        {
            Console.Clear();
            Console.WriteLine("Inicializando...");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Digite os seguintes parâmetros:");
            Console.Write("Capacidade máxima (apenas quantidade de pessoas): ");
            maxCapacidade = int.Parse(Console.ReadLine());
            Console.Write("Total de andares do prédio: ");
            totalDeAndares = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public int Entrar()
        {
            return capAtual++;
        }

        public int Sair()
        {
            return capAtual--;
        }

        public int Subir()
        {
            return andarAtual++;
        }

        public int Descer()
        {
            return andarAtual--;
        }

        public string InfoAtual()
        {
            if(andarAtual > 0)
            {
                return $"Andar atual: {andarAtual} andar \nNúmero de pessoas dentro do elevador: {capAtual}";
            }else
            {
                return $"Andar atual: {andarAtual} térreo \nNúmero de pessoas dentro do elevador: {capAtual}";
            }
        }
    }
}