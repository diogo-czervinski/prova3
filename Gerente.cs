public class Gerente : Funcionario
{
    private double salarioBase;
    private int horasExtras;
    
    public Gerente(double salarioBase, int horasExtras)
    {
        this.salarioBase = salarioBase;
        this.horasExtras = horasExtras;
    }
    
    public override double CalcularSalario()
    {
        
        return salarioBase + (horasExtras * 50); 
    }
    
    public override void RegistrarPonto()
    {
        
        Console.WriteLine("Ponto registrado para o gerente.");
    }
}
