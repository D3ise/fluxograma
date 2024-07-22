namespace Fluxograma;

public class ClassePai
{
 string matériaprima;
 int quantidade;
 string fornecedor;
 int id;

 public string GetMatériaPrima ()
 {
    return matériaprima;
 }

 public void SetMatériaPrima (string matériaprima)
 {
    This.matériaprima = matériaprima;
 }

 public int GetQuantidade ()
 {
    return quantidade;
 }

 public void SetQuantidade (int quantidade)
 {
    This.quantidade = quantidade;
 }

public string GetFornecedor ()
 {
    return fornecedor;
 }

 public void SetFornecedor (string fornecedor)
 {
    This.fornecedor = fornecedor;
 }

public int GetId ()
 {
    return id;
 }

 public void SetId (int id)
 {
    This.id = id;
 }
}