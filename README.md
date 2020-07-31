<h1 align="center">
    <img alt="Ecoleta" title="Ecoleta" src=".github/ecoleta.svg" width="220px" />
</h1>
<p align="center">
  <a href="#-technologies">Technologies</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-introduction">Introduction</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-steps-to-run-this-project">Steps</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-there-is-how-its-mobile-work">Sample</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#%EF%B8%8F--where-i-found-this">Inspirations</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-license">License</a>
</p>

<p align="center">  
 <img src="https://img.shields.io/static/v1?label=PRs&message=welcome&color=7159c1&labelColor=000000" alt="PRs welcome!" />

<img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=7159c1&labelColor=000000">
  </p>

![Alt text](https://github.com/reginaldobrz/Ecoleta/blob/master/.github/ecoleta.png)

Ecoleta - A project to controll the collection points for recycling.This project was developed basicaly to study and anderstand some tecnologies. But you can use to implement some feature and fly to production, fell free! I am doind this 🤓.

## 🚀 Technologies
This project was developed with this following tecnologies:

- [Node.js](https://nodejs.org/en/)
- [React](https://reactjs.org)
- [React Native](https://facebook.github.io/react-native/)
- [Expo](https://expo.io/)

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

## 📲 There is how its mobile work
![Farmers Market Finder Demo](https://github.com/reginaldobrz/Ecoleta/blob/master/.github/ecoleta.gif)


## 🧙🏻‍♀️  Where i found this

This is a 'Next Level Week' project from 'Rocketseat'developed by me ! 
<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
<table>
  <tr>
    <td align="center"><a href="https://github.com/Rocketseat"><img itemprop="image" class="TableObject-item avatar flex-shrink-0" src="https://avatars0.githubusercontent.com/u/28929274?s=200&amp;v=4" width="200" height="200" alt="@Rocketseat"><br /><sub><b>Rocketseat</b></sub></a><br />💻</a></td>
  </tr>
</table>

<!-- ALL-CONTRIBUTORS-LIST:END -->

## :memo: License

This project use the MIT license. Look at this archive [LICENSE](LICENSE) to more details.


