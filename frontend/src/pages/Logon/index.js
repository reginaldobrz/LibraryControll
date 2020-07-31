import React, {useState} from 'react';
import {Link, useHistory} from 'react-router-dom';
import {FiLogIn} from 'react-icons/fi'
import api from '../../services/api';
import './styles.css';
import heroesImg from '../../assets/heroes.png';
import logoImg from '../../assets/logo.png';

export default function Logon(){
    const [name, setName] = useState('');
    const history = useHistory();

    async function handleLogin(e){
        e.preventDefault();

        try{
            const response = await api.post('Usuario/UsuarioBiblioteca?nome='+ name);
            localStorage.setItem('nome', name);
            history.push('/incidents/new');
        }catch(err){
            alert('Falha no login, tente novamente.');
        }
    }
    return(
        <div className="logon-container">
            <section className="form">
                <img src={logoImg} alt="Biblioteca"/>
                <form onSubmit={handleLogin}>
                    <h1>Faça seu logon</h1>
                    <input 
                    placeholder="Seu Nome"
                    value = { name }
                    onChange = {e => setName(e.target.value)}
                    />
                    <button className="button" type="submit">Entrar</button>
                    <Link className= "back-link" to="/register">
                        <FiLogIn size={16} color= "#e02041"/>
                        Não tenho cadastro
                    </Link>
                </form>
            </section>
            <img src={heroesImg} alt="Heroes"/>
        </div>
    );
}