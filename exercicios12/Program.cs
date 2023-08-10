﻿using exercicios12;

Console.WriteLine(" ### Respontas equivalentes ao exercicio 9 de Classes e Metodo ### ");

Console.WriteLine("-----Lista de Cores -----");
Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("Defina a Cor escolhida");
var cor = Convert.ToInt32(Console.ReadLine());

Carros chevrolet = new("Sedan","Chevrolet","Onix",2016,110, cor);
Console.WriteLine("------------Chevrolet----------------");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: chevrolet.Ano, cor: chevrolet.Cor);

/*
Console.WriteLine($"Modelo = {chevrolet.Modelo}, Montadora = {chevrolet.Montadora}");
Carros ford = new("SUV","Ford", "EcoSport",2018,120);
Console.WriteLine("---------------Ford--------------");
Console.WriteLine($"Modelo = {ford.Modelo}, Montadora = {ford.Montadora}, Ano = {ford.Ano}, Potencia = {ford.Potencia}, Marca = {ford.Marca}");
Console.WriteLine("---------------Acelerando Ford--------------");
ford.Acelerar(ford.Marca);
Console.WriteLine($"Velocidade Maxima = {ford.VelocidadeMaxima(ford.Potencia)}");
Console.WriteLine("------Aumentando potencia Ford com argumento por valor --------------");
Console.WriteLine("Aumentando potencia do Ford em 3");
var novaPotencia = ford.AumentarPotencia(ford.Potencia);
Console.WriteLine($"Nova potencia aumentada em 3: {ford.Potencia}");
Console.WriteLine("------Aumentando potencia Ford com argumento por ref --------------");
ford.AumentarPotencia(ref ford.Potencia);
Console.WriteLine($"Nova potencia aumentada em 5: {ford.Potencia}");
Console.WriteLine("------Aumentando potencia Ford com argumento por out --------------");
var newPotential = chevrolet.AumentarPotenciaVelocidade(ford.Potencia, out double velocidade);
Console.WriteLine($"Nova potencia: {newPotential}");
Console.WriteLine($"Velocidade: {velocidade}");
Console.WriteLine("------------Chevrolet com propriedade opcional ----------------");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia);
Console.WriteLine("------------Chevrolet com propriedade obrigatoria ----------------");
chevrolet.ExibirInfo(modelo: chevrolet.Modelo, montadora: chevrolet.Montadora, marca: chevrolet.Marca, potencia: chevrolet.Potencia, ano: chevrolet.Ano);
Console.WriteLine("------------Chevrolet IPVA ----------------");
Carros.ObterValor();
Console.WriteLine($"IPVA = {Carros.ValorIpva} %");
*/

