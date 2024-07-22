namespace Fluxograma;

public class Pessoa
{
 string nome;
 string telefone;
 string cpf;
 string email;
 int id;

 public string GetNome ()
 {
    return nome;
 }

 public void SetNome (string nome)
 {
    This.nome = nome;
 }

 public string GetTelefone ()
 {
    return telefone;
 }

 public void SetTelefone (string telefone)
 {
    This.telefone = telefone;
 }

public string GetCpf ()
 {
    return cpf;
 }

 public void SetCpf (string cpf)
 {
    This.cpf = cpf;
 }

 public string GetEmail ()
 {
    return email;
 }

 public void SetEmail (string email)
 {
    This.email = email;
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