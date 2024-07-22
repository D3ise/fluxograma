namespace Fluxograma;

public class Produtos
{
 string nome;
 int unidade;

 public string GetNome ()
 {
    return nome;
 }

 public void SetNome (string nome)
 {
   This.nome = nome;
 }

 public int GetUnidade ()
 {
    return unidade;
 }

 public void SetUnidade (int unidade)
 {
    This.unidade = unidade;
 }
}