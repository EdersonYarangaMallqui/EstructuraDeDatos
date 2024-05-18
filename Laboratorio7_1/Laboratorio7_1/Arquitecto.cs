
namespace Laboratorio7_1
{
    public class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public string Especialidad { get; set; }
        public string TipoActividad { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal SueldoBase { get; set; }
        private static decimal porc_Afp = (decimal)0.15;
        private static decimal porc_Snp = (decimal)0.08;
        private static decimal porc_Essalud = (decimal)0.03;
        private static int contador = 0;
    
        public Arquitecto(string codigo, string nombre, string condicion, string especialidad,
            string tipoActividad, string tipoAfiliacion)
        {
            contador++;
            Codigo = codigo;
            Nombre = nombre;
            Condicion = condicion;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;
        }
        
        public decimal CalcularSueldoBase(){
            if(Condicion=="Estable"&&TipoActividad=="Supervisión de Obras")
            {
                SueldoBase = 4000;
                return SueldoBase;
            }else if(Condicion=="Estable"&&TipoActividad=="Supervisión de Vías")
            {
                SueldoBase = 6000;
                return SueldoBase;
            }
            else if (Condicion == "Contratado" && TipoActividad == "Supervisión de Obras")
            {
                SueldoBase = 2000;
                return SueldoBase;
            }
            else if (Condicion == "Contratado" && TipoActividad == "Supervisión de Vías")
            {
                SueldoBase = 4500;
                return SueldoBase;
            }
            else
            {
                return SueldoBase;
            }
        }

        public decimal CalcularBonificacion()
        {
            decimal bonificación = 0;
            if (Especialidad == "Estructuras")
            {
                bonificación = (decimal)0.16;
                return bonificación*CalcularSueldoBase();
            }else if(Especialidad=="Recursos Hídricos")
            {
                bonificación = (decimal)0.18;
                return bonificación* CalcularSueldoBase();
            }
            else
            {
                return bonificación;
            }
        }
        public decimal CalcularMontoSeguro()
        {
            if (TipoAfiliacion == "AFP")
                return porc_Afp*CalcularSueldoBase();
            if (TipoAfiliacion == "SNP")
                return porc_Snp* CalcularSueldoBase();

            return 0;
        }
        public decimal CalcularMontoEssalud()
        {
            return SueldoBase * porc_Essalud;
        }
        public decimal CalcularDescuento()
        {
            return CalcularMontoSeguro() + CalcularMontoEssalud();
        }
        public decimal SueldoBruto()
        {
            return SueldoBase + CalcularBonificacion();
        }
        public decimal SueldoNeto()
        {
            return SueldoBruto() - CalcularDescuento();
        }
        public static int GetContador()
        {
            return contador;
        }
    }

}
