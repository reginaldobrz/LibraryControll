<h1 align="center">
    <img alt="Ecoleta" title="Ecoleta" src="https://github.com/reginaldobrz/LibraryControll/blob/master/frontend/src/assets/logo.png" width="220px" />
</h1>
<p align="center">
  <a href="#-technologies">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-introduction">Introdução</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-steps-to-run-this-project">Passos</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-license">License</a>
</p>

<p align="center">  
 <img src="https://img.shields.io/static/v1?label=PRs&message=welcome&color=7159c1&labelColor=000000" alt="PRs welcome!" />

<img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=7159c1&labelColor=000000">
  </p>

![Alt text](https://github.com/reginaldobrz/Ecoleta/blob/master/.github/ecoleta.png)

Biblioteca digital - É um projeto com intuito de registrar a opinião dos leitores a respeito dos exemplares, tanto em conteudo quanto o estado fisico do livro 🤓.

## 🚀 Technologies
Este projéto foi desenvolvido com as seguintes tecnologias:

- [.Net Core](https://dotnet.microsoft.com/)
- [React](https://reactjs.org)
- [SQL-Server](https://www.microsoft.com/pt-br/sql-server?rtc=1)

## 🗒 Introduction 
For this project we have three diferent projects, one of them is our Mobile project the other is our Server project and the last one is our Web project! 

* 🖥 Web Project : This project is a way to integrate our aplication into web like a diferent tool, let's me explain better. With this project you will have a portal to register new collect points. And see some informations about all the existed points!

* 📱 Mobile Project : This project is our mobile application, here you will find a form to register a new point and see all collect points around you just using your smartPhone wherever you want!

* 🛠 Server Project : This project is the brain of all, it is where you will find all business rules and the ecoleta engine! Fell free to study more about this project because we use a lot of thecnologies and features ! 

So let's go to the first step to run our project.


## 💻 Steps to run this project

First of all we need to install all dependencies to our project, run this comand line into each project(Web, Server and Mobile).

````
npm install
````
Easy hamm? 😎

Now you need to create a database, i am using for this project the Sqlite! So, just run the command to create tables into your Database!

```
npx knex migrate:latest --knexfile knexfile.ts migrate:latest
```

So now you have created tree tables (Points, Point_items, items), this table point_items give us the relation between points and items, this relation is N to N! 

After that all of the road to run this proect is done! Now we have to stand our server to put all of informations on. To do this just go inside the folder project server and run this command.

```
npm run dev 
```

If no message errors appears, your server is up! now our mobile project and web project have somewhere to connect and take some data!

And than, let's go to our front end, remember to see something don't stop your server, ok! now just go to web project folder and run this command line.

```
npm start 
```

Wait a moment and than your web browser will open with the application on ! 

To our mobile projet the process is a little diferent, Go to the mobile project  folder and than run this command line into your terminal.

```
expo start  
```

After that a web browser page will open with a QRCode inside, to run the app on your phone with this code just download the 'EXPO' app from your app store! 

When the instalation finished, open the camera and point to the code! A option to open the app will appear, click on that and wait to the magic!

If every things ok, in a feel moments the application will be runing on your phone!

That's all!


## :memo: License

This project use the MIT license. Look at this archive [LICENSE](LICENSE) to more details.


