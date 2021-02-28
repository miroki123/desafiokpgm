# desafiokpgm
Desafio KPGM

Para esta demo foi utilizado o template básico de Web API do .NET
O único framework externo utilizado foi o Swagger do Swashbuckle, para facilitar o teste das requisições
Os dois endpoints foram implementados no controller único chamado GameController
No texto do desafio fala sobre uma "persistência periódica" dos dados, mas não especifica como (isso pode ser feito de N maneiras), portanto criei apenas um DatabaseBase que é a classe abstrata que implementa a classe de conexão com o banco de dados

Para testar a aplicação basta baixar o projeto e rodar a solution, o swagger vai abrir automaticamente mostrando os dois endpoints e com uma interface para enviar requisições
