namespace Fluxograma;

public class Cliente : Pessoa 

{
string cnpj;

 public string GetCnpj ()
 {
    return cnpj;
 }

 public void SetCnpj (string cnpj)
 {
    This.cnpj = cnpj;
 }
    
}