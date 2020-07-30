import React, { useState, useEffect } from 'react';
import { Link, useHistory } from 'react-router-dom';
import { FiPower, FiTrash2 } from 'react-icons/fi';
import api from '../../services/api';

import logoImg from '../../assets/logo.png';
import './styles.css';

export default function Profile(){
    const [incidents, setIncidents] = useState([]);
    const history = useHistory();

    const ongName = localStorage.getItem('ongName');
    const ongId = localStorage.getItem('ongId');
    const nomeAluno = localStorage.getItem('nome');    

    useEffect(() => {
        api.get('Avaliacao/AvaliacoesPorUsuarioBiblioteca?nomeUsuario='+ nomeAluno
        ).then(response => {
            setIncidents(response.data);
        })
    },[nomeAluno]);

    console.log(incidents.data);

    async function handleDeleteIncident(id){
        try{
            await api.delete(`incidents/${id}`,{
                headers: {
                    Authorization: ongId,
                }
            });
            setIncidents(incidents.filter(incident => incident.id !== id));
        }catch(err){
            alert('Erro ao deletar caso, tente novamente.')
        }        
    }

    function handleLogout(){
        localStorage.clear();
        history.push('/');
    }

    return (
        <div className="profile-container">
            <header>
                <img src={logoImg} alt="Biblioteca"/>
                <span>Bem Vindo(a), {nomeAluno}</span>

                <Link className="button" to="/incidents/new">Cadastrar avaliação</Link>
                <button onClick={handleLogout} type = "button">
                    <FiPower size={18} color="#e02041"/>
                </button>
            </header>
            <h1>Avaliações Cadastradas</h1>
            <ul>
                {incidents.map(incident => (
                    <li key={incident.id}>
                    <strong>Caso:</strong>
                    <p>{incident.title}</p>

                    <strong>DESCRIÇÃO:</strong>
                    <p>{incident.description}</p>

                    <strong>VALOR:</strong>
                    <p>{Intl.NumberFormat('pt-BR',{style: 'currency', currency: 'BRL'}).format(incident.value)}</p>

                    <button onClick={() => handleDeleteIncident(incident.id)} type="button">
                        <FiTrash2 size={20} color="#a8a8b3"/>
                    </button>
                </li>  
                ))}              
            </ul>
        </div>
    );
}
