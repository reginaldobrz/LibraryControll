import React, { useState, useEffect } from 'react';

import { Link, useHistory } from 'react-router-dom';
import { FiArrowLeft } from 'react-icons/fi';
import logoImg from '../../assets/logo.png';

import { confirmAlert } from 'react-confirm-alert'; // Import
import 'react-confirm-alert/src/react-confirm-alert.css'; // Import css

import { makeStyles } from '@material-ui/core/styles';
import TextField from '@material-ui/core/TextField';
import MenuItem from '@material-ui/core/MenuItem';

import './styles.css';
import '../../services/api';
import api from '../../services/api';

export default function NewIncident(){
    const [biblioteca, setBiblioteca] = useState();
    const [book, setBook] = useState('');
    const [description, setDescription] = useState('');
    const [nota, setNota] = useState();
    const [conservacao, setConservacao] = useState('');

    const history = useHistory();
    const ongId = localStorage.getItem('ongId');
    const nomeAluno = localStorage.getItem('nome');
   
    useEffect(()=>{
        api.get('Livros/LivrosBiblioteca').then(response=>{
             setBiblioteca(response.data.data);
        })
    },[]);  

    console.log(biblioteca)

    const estado = [
        {conservacao:'Ótimo'}, {conservacao:'Bom'}, {conservacao:'Ruim'}
    ];

    const avaliacao = [
        {
            nota:'0'
        },
        {
            nota:'1'
        },
        {
            nota:'2'
        },
        {
            nota:'3'
        },
        {
            nota:'4'
        },
        {
            nota:'5'
        },
        {
            nota:'6'
        },
        {
            nota:'7'
        },
        {
            nota:'8'
        },
        {
            nota:'9'
        },
        {
            nota:'10'
        },        
    ];

    console.log(avaliacao)
    
    
    async function handleNewIncident(e){
        e.preventDefault();

        console.log(book,description,nota,conservacao)

        const data ={
            book,
            description,            
            nota,
            conservacao,
        };
        try{
            await api.post('Avaliacao/AvaliacaoLivroBiblioteca?nome='+book+'&estado='+conservacao+
            '&nota='+nota+'&observacao='+description+'&nomeUsuario='+nomeAluno);
            
            //history.push('/incidents/new');

            confirmAlert({
                title: 'Avaliação cadastrada com sucesso',
                message: 'Gostaria de cadastrar uma nova avaliação?',
                buttons: [
                  {
                    label: 'Yes',
                    onClick: () => history.push('/incidents/new')
                  },
                  {
                    label: 'No',
                    onClick: () => history.push('/profile')
                  }
                ]
              });
        }catch(err){
            alert('Erro ao cadastrar avaliação, tente novamente.')
        }
    } 

    return (
        
        <div className="new-incident-container">
            
            <div className="content">
                <section>
                    <img src={logoImg} alt="Be The Hero"/>

                    <h1>Cadastrar avaliação</h1>
                    <p>Preencha o formulário com as observações do livro que leu</p>

                    <Link className= "back-link" to="/profile">
                        <FiArrowLeft size={16} color= "#e02041"/>
                        Voltar para home
                    </Link>   
                </section>
                <form onSubmit={handleNewIncident}>

                    <textarea 
                        placeholder="Descrição" 
                        value={description}
                        onChange={e => setDescription(e.target.value)}
                    />
                  
                    <TextField
                        id="outlined-select-currency"
                        select
                        label="Livros"
                        value={book}
                        onChange={e => setBook(e.target.value)}
                        helperText="Selecione o livro que deseja avaliar"
                        variant="outlined"
                    >
                        {biblioteca?.map((option) => (                            
                            <MenuItem key={option.nome} value={option.nome}>
                            {option.nome}
                            </MenuItem>
                        ))}
                    </TextField>

                    <TextField
                        id="outlined-select-currency"
                        select
                        label="Estado do Livro"
                        value={estado.data}
                        onChange={e => setConservacao(e.target.value)}
                        helperText="Selecione o livro para avaliar"
                        variant="outlined"
                        
                    >
                        {estado.map((option) => (
                            <MenuItem key={option.conservacao} value={option.conservacao}>
                            {option.conservacao}
                            </MenuItem>
                        ))}
                    </TextField>

                    <TextField
                        id="outlined-select-currency"
                        select
                        label="Nota do Livro"
                        value={nota}
                        onChange={e => setNota(e.target.value)}
                        helperText="De uma nota para o livro"
                        variant="outlined"
                    >
                        {avaliacao.map((option) => (
                            <MenuItem key={option.nota} value={option.nota}>
                            {option.nota}
                            </MenuItem>
                        ))}
                    </TextField>                   
                    <button className="button" type="submit">Cadastrar </button>
                </form>
                
            </div>
            
        </div>
    );
}