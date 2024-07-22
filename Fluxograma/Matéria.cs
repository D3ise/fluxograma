namespace Fluxograma;

public class Matéria
{
 string nome;
 int valor;
 string matériaprima;

 public string GetNome ()
 {
    return nome;
 }

 public void SetNome (string nome)
 {
   This.nome = nome;
 }

 public int GetValor ()
 {
    return valor;
 }

 public void SetValor (int valor)
 {
    This.valor = valor;
 }

 public string GetMatériaPrima ()
 {
    return matériaprima;
 }

 public void SetMatériaPrima (string matériaprima)
 {
   This.matériaprima = matériaprima;
 }
}