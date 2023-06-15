<h1 align="center">
    🛡️<br>War Round Simulation with Monte Carlo
</h1>


## Table of Contents
  * [Description](#description)
  * [Used Languages](#used-languages)
  * [Rules](#rules)
  * [Comands](#comands)

<br>

<a name="description"></a>
## 📚 Description
>  Project using CSharp that simulate an War Round and uses Monte Carlo to calculate the probability  of victory.

<br>

<a name="used-languages"></a>
## Used Languages
<p align="center">
    <img src="https://img.shields.io/badge/CSharp-43853D?style=for-the-badge&logo=csharp&logoColor=white" />
</p>

<br>

<a name="rules"></a>
## 📜 Rules
1. The war consists of several battles of up to 3 against 3. Armies always send the
as many as possible, however, the attacker cannot send all his soldiers,
having to stay with at least 1 in your territory. Thus, with less than 4 soldiers, the
attackers attack with less. Defenders also send as much as possible to
defense, however, they are fighting in your house and don't need to leave a soldier around.
less back.

2. For each soldier in the battle, a die is played and ordered, like this, for example, the
attackers will have 3 dice and defenders will have 3 dice as well, unless they have
less than 3 soldiers in the battle.

3. Comparing the dice ordered 1 to 1, the highest in defense against the highest in attack and
so on, a winner is determined which is the one with the highest value on the dice.

4. Defense wins all ties.
5. For each defeat, a team loses a soldier, and can lose from 0 to 3 at once.
6. The war ends when either the defense is completely decimated, or only one attacker remains.

<br>

<a name="comands"></a>
## 💻 Comands

* To run the application type the followind code in the terminal: 
```
dotnet run
```
