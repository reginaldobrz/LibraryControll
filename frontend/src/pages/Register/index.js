import React, { useState } from 'react';
import { Link, useHistory } from 'react-router-dom';
import { FiArrowLeft } from 'react-icons/fi';
import api from '../../services/api';

import { confirmAlert } from 'react-confirm-alert'; // Import
import 'react-confirm-alert/src/react-confirm-alert.css'; // Import css

import './styles.css';
import logoImg from '../../assets/logo.png';

export default function Register(){
    const [name, setName] = useState('');
    
    
    const history = useHistory();

    async function handleRegister(e){
        e.preventDefault();
        const data ={
            name,
        };
        try{
            const response = await api.post('Usuario/CriarUsuarioBiblioteca?nome='+ data.name);


            console.log(response)


            if(response.data.data === "Usuario já cadastrado!"){
                confirmAlert({
                    title: data.name + ' você já é um usuário no Biblioteca Digital!',
                    message: 'Tente acessar com seu nome:' + data.name,
                    buttons: [
                      {
                        label: 'Ok',
                        onClick: () => history.push('/')
                      },                      
                    ]
                  });
            }else{
                confirmAlert({
                    title: 'Usuário cadastrado com sucesso! ',
                    message: 'Agora só precisa acessar o sistema para deixar sua avaliação!',
                    buttons: [
                      {
                        label: 'Ok',
                        onClick: () => history.push('/')
                      },                      
                    ]
                  });
            }





           // alert(`Seu Nome é o seu acesso : ` + name)
            //history.push('/');
        }catch{
            alert('Erro no cadastro tente novamente.');
        }
    }

    return (
        <div className="register-container">
            <div className="content">
                <section>
                    <img src={logoImg} alt="Be The Hero"/>

                    <h1>Cadastro</h1>
                    <p>Faça seu cadastro, entre na plataforma e nos dê sua opinião sobre os livros que leu.</p>

                    <Link className= "back-link" to="/">
                        <FiArrowLeft size={16} color= "#e02041"/>
                        Não tenho cadastro
                    </Link>   
                </section>
                <form onSubmit={handleRegister}>
                    <input 
                    placeholder ="Nome"
                    value={name}
                    onChange={e => setName(e.target.value)} />                    
                    <button className="button" type="submit">Cadastrar </button>
                </form>
            </div>
        </div>
    );
}