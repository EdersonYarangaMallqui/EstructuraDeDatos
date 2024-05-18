namespace Laboratorio7_2
{
    public class Jefe
    {
        public string Nombres { get; set; }
        public string Dni { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public int Antiguedad { get; set; }
        public decimal SueldoBase { get; set; }
       
        private static int contador = 0;

        public Jefe(string nombres, string dni, string cargo, string area,
            int antiguedad)
        {
            contador++;
            Nombres = nombres;
            Dni = dni;
            Cargo = cargo;
            Area = area;
            Antiguedad = antiguedad;
        }
        public decimal CalcularSueldoBase()
        {
            if (Cargo == "Gerente" && Area == "Contabilidad")   {
                SueldoBase = 6000;
                return SueldoBase;
            }
            else if (Cargo == "Gerente" && Area == "Planificación") {
                SueldoBase = 7000;
                return SueldoBase;
            }
            else if (Cargo == "Subgerente" && Area == "Contabilidad")  {
                SueldoBase = 5000;
                return SueldoBase;
            }
            else if (Cargo == "Subgerente" && Area == "Planificación")  {
                SueldoBase = 6000;
                return SueldoBase;
            }
            else     {
                return SueldoBase;
            }
        }
        public decimal CalcularBonificacion()
        {
            decimal bonificación = 0;
            if (Antiguedad <= 7)
            {
                bonificación = (decimal)0.05;
                return bonificación * CalcularSueldoBase();
            }
            else if (Antiguedad >= 8)
            {
                bonificación = (decimal)0.04;
                return bonificación * CalcularSueldoBase();
            }
            else
            {
                return bonificación;
            }
        }
        public decimal Movilidad()   {
            if (Cargo == "Gerente")
                return 700;
            else if (Cargo == "Subgerente")
                return 400;
            else return 0;
        }
        public decimal SueldoFinal()     {
            return CalcularSueldoBase() + CalcularBonificacion()+Movilidad();
        }
        public static int GetContador()    {
            return contador;
        }
    }
}
