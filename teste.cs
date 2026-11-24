using System;

// FUNÇÃO LOCAL: recebe ataque e defesa e devolve o dano.
int CalcularDano(int ataque, int defesa)
{
    return ataque - defesa;
}

// FUNÇÃO LOCAL: recebe um texto e escreve o título.
void MostrarTitulo(string titulo)
{
    Console.WriteLine("==============================");
    Console.WriteLine(titulo);
    Console.WriteLine("==============================");
}

// Chama a função e passa o nome do jogo como argumento.
MostrarTitulo("A batalha pelo cristal");

// Cria o objeto do herói.
Personagem heroi = new Personagem();

// Preenche os campos desse objeto.
heroi.nome = "Luna";
heroi.vida = 100;
heroi.ataque = 30;
heroi.defesa = 10;

// Cria outro objeto, com seus próprios valores.
Personagem monstro = new Personagem();

monstro.nome = "Guardião do Cristal";
monstro.vida = 80;
monstro.ataque = 25;
monstro.defesa = 8;

// Chama o método de cada objeto.
Console.WriteLine();
Console.WriteLine("PERSONAGENS NO INÍCIO:");

heroi.MostrarStatus();
monstro.MostrarStatus();

// A função devolve um número, que guardamos na variável.
int danoDoHeroi = CalcularDano(heroi.ataque, monstro.defesa);

// O método altera a vida do monstro.
monstro.ReceberDano(danoDoHeroi);

Console.WriteLine();
Console.WriteLine(
    heroi.nome + " causou " + danoDoHeroi + " de dano!"
);

// Calcula e aplica o ataque do monstro.
int danoDoMonstro = CalcularDano(monstro.ataque, heroi.defesa);

heroi.ReceberDano(danoDoMonstro);

Console.WriteLine(
    monstro.nome + " causou " + danoDoMonstro + " de dano!"
);

// Chama o método de cura do herói.
heroi.Curar(10);

Console.WriteLine(heroi.nome + " usou uma poção e recuperou 10 de vida!");

// Exibe os valores depois das alterações.
Console.WriteLine();
Console.WriteLine("PERSONAGENS NO FINAL:");

heroi.MostrarStatus();
monstro.MostrarStatus();

// A declaração da classe fica depois dos comandos soltos.
public class Personagem
{
    public string nome = "";
    public int vida;
    public int ataque;
    public int defesa;

    // MÉTODO: mostra os dados do objeto que recebeu a chamada.
    public void MostrarStatus()
    {
        Console.WriteLine(
            nome
            + " | Vida: " + vida
            + " | Ataque: " + ataque
            + " | Defesa: " + defesa
        );
    }

    // MÉTODO: altera a vida do objeto que recebeu a chamada.
    public void ReceberDano(int dano)
    {
        vida = vida - dano;
    }

    // MÉTODO: aumenta a vida do objeto que recebeu a chamada.
    public void Curar(int quantidade)
    {
        vida = vida + quantidade;
    }
}