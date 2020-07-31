<h1 align="center">
    <img alt="Ecoleta" title="Ecoleta" src="https://github.com/reginaldobrz/LibraryControll/blob/master/frontend/src/assets/logo.png" width="220px" />
</h1>
<p align="center">
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-introdução">Introdução</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-passos-para-rodar-o-projeto">Passos</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-license">License</a>
</p>

<p align="center">  
 <img src="https://img.shields.io/static/v1?label=PRs&message=welcome&color=7159c1&labelColor=000000" alt="PRs welcome!" />

<img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=7159c1&labelColor=000000">
  </p>



Biblioteca digital - É um projeto com intuito de registrar a opinião dos leitores a respeito dos exemplares, tanto em conteudo quanto o estado fisico do livro 🤓.

## 🚀 Tecnologias
Este projéto foi desenvolvido com as seguintes tecnologias:

- [.Net Core](https://dotnet.microsoft.com/)
- [React](https://reactjs.org)
- [SQL-Server](https://www.microsoft.com/pt-br/sql-server?rtc=1)
- [JavaScript](https://www.javascript.com/)

## 🗒 Introdução 
Para esta aplicação temos tres projetos destintos, um é o nosso frontend feito em react o outro é o nosso backend feito em .NetCore e temos o schema do nosso banco de dados feito no SQL-Server.

* 🖥 BackEnd : Aqui implementei toda nossa regra de négocio em API Rest, logo temos um total de tres endPoints para a avaliação dada pelos usuários, um end point para os livros cadastrados e dois endpoints para o usuário:
    * Avaliação-
        - Registro de uma nova avaliação.
        - Avaliações por usuário.
        - Delete de avaliação.
    * Livros-
        - Listagem dos exemplares registrados no sistema.
    * Usuário-
        - Criação de um novo usuário.
        - Listar usuário cadastrado.

* 🛠 FrontEnd: Já para o front end temos todos estes recursos sendo adaptados para a visão criada, logo temos uma página de logon, formulario e cadastr de usuário

Então chega de enrrolação e vamos para o passo a passo e ver esse projeto rodando!


## 💻 Passos para rodar o projeto

* Antes de tudo clone o repositorio para uma pasta do seu computador!

* Vamos rodar nosso schema de criação do banco de dados que esta na pasta onde você clonou o projeto acima chamado de "SchemaBiblioteca.sql",
para o projeto foi usada a ferramenta "Microsoft Sql Server Management Studio 18" e o "SQL server 2019":
    * Para isso sigo os seguintes passos-
        - Baixe e instale o SQL Server 2019(https://go.microsoft.com/fwlink/?linkid=866662) e Microsoft Sql Server Management Studio 18(https://aka.ms/ssmsfullsetup).
        - Ao baixar o SQL Server, lebre-se de anotar suas credenciais de acesso a sua base local(vamos precisar dela mais tarde), Podem ser encontradas no momento do login:
        
<p align="center"><img src="https://github.com/reginaldobrz/LibraryControll/blob/master/img/sQLSERVER.png" alt="PRs welcome!" />
    
        - Baixe o schema citado acima.
        - Abra o Microsoft Sql Server Management Studio 18, importe e execute com "F5" o schema baixado.
* Agora que já temos nossa base de dados criada vamos rodar nosso backend que contem todas as nossas API's e regras de negócio, para isso eu utilizei como ferramenta o visual studio 2019:
    * Para isso siga os seguintes passos-
        - Baixe e instale o visual studio 2019(https://visualstudio.microsoft.com/pt-br/vs/).
        - Agora dentro da pasta que do projeto abra a pasta "BackEnd" e dentro dela vai encontrar um arquivo chamado "Biblioteca.sln", basta abrir este arquivo com o visual studio 2019 !
        - Com o projeto aberto vá atravez do "Explorador de arquivos" pelo caminho "01-Host > Biblioteca.Host > appsettings.json > " e abra o seguinte arquivo appsettings.Development.json, nele você vai encontrar uma propriedade chamada "BibliotecaoContext", nela você vai informar as credenciais de acesso da sua base de dados que pedi para que anotasse anteriormente!
    
<p align="center"><img src="https://github.com/reginaldobrz/LibraryControll/blob/master/img/StringCone.png" alt="PRs welcome!" />
    
        - Neste momento nossa aplicação server está de pé em um servidor localhost e pronta para ser consumida, então deixe-a rodando e vamos para o próximo passo.
    
* Agora com nossa aplicação servidor rodando vamos iniciar nosso frontend e ver a mágica acontecer, lembrando que para isso eu utilizei as seguinte ferramenta, visual studio code:
    * Para isso siga os seguintes passos-
        - Baize e instale o visual studio code e a ferramenta yarn(https://classic.yarnpkg.com/en/docs/install#windows-stable).
        - Abra o visual studio code e clique em arquivo(file)-abrir aquivo(open folder)-navegue ate a pasta clonada e abra a pasta "frontend"
        - Agora com o o projeto aberto, abra o terminal do visual code( CTRL + " ' ") e execute os seguintes comandos:
````
yarn 
````
Aguarde finalizar e execute o seguinte comando:
````
yarn start 
````

Pronto, se você executou os passas todos certos agora temos toda nossa aplicação pronta para ser usada e testada localmente!

Easy hamm? 😎

That's all!


## :memo: License

This project use the MIT license. Look at this archive [LICENSE](LICENSE) to more details.


