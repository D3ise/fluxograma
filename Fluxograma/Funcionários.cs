namespace Fluxograma;

public class Funcionários : Pessoa 

{
string endereco;
string cargo;

 public string GetEndereco ()
 {
    return endereco;
 }

 public void SetEndereco (string endereco)
 {
    This.endereco = endereco;
 }

 public string GetCargo ()
 {
    return cargo;
 }

 public void SetCargo (string cargo)
 {
    This.cargo = cargo;
 }
    
}