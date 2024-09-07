public class Operador : Funcionario
{
    private double salarioBase;
    private int horasTrabalhadas;
    
    public Operador(double salarioBase, int horasTrabalhadas)
    {
        this.salarioBase = salarioBase;
        this.horasTrabalhadas = horasTrabalhadas;
    }
    
    public override double CalcularSalario()
    {
        
        return salarioBase + (horasTrabalhadas * 20); 
    }
    
    public override void RegistrarPonto()
    {
        
        Console.WriteLine("Ponto registrado para o operador.");
    }
}
