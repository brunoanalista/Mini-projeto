/*Atributos>cor,motor,poltrona
Metodos>mudar de cor,mostrar poltrona,ligar motor
*/
class avião{
  private string cor;
  public double poltrona;
  protected string motor;
  private piloto comandante;

  public void setCor(string novacor){
    cor=novacor;
  }
  public string getPoltrona(){
    return poltrona;
  }
  public string setMotor(string ligarmotor){
    motor=ligarmotor;
  }
  public avião(string cor,double poltrona,string motor){
    this.cor=cor;
    this.poltrona=poltrona;
    this.motor=motor;
  }
}