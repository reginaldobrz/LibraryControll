import React, { useState } from 'react';
import { Link, useHistory } from 'react-router-dom';
import { FiArrowLeft } from 'react-icons/fi';
import api from '../../services/api';

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
            alert(`Seu Nome é o seu acesso : ` + name)
            history.push('/');
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